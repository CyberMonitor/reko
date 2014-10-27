﻿#region License
/* 
 * Copyright (C) 1999-2014 John Källén.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 */
#endregion

using Decompiler.Analysis;
using Decompiler.Core;
using Decompiler.Core.Expressions;
using Decompiler.Core.Types;
using Decompiler.Typing;
using Decompiler.UnitTests.Mocks;
using NUnit.Framework;
using Rhino.Mocks;
using System;

namespace Decompiler.UnitTests.Typing
{
    [TestFixture]
    public class ConstantPointerTraversalTests
    {
        private MockRepository mr;
        private LoadedImage image;
        private Expression globals;
        private TypeVariable globals_t;
        private StructureType globalStruct;
        private EquivalenceClass eqLink;
        private IProcessorArchitecture arch;

        [SetUp]
        public void Setup()
        {
            mr = new MockRepository();
            arch = mr.Stub<IProcessorArchitecture>();
            arch.Stub(a => a.CreateImageReader(null, 0u)).IgnoreArguments().Do(new Func<LoadedImage, uint, ImageReader>((i, o) => i.CreateLeReader(o)));
            arch.Replay();
            globalStruct = new StructureType
            {
            };
            globals_t = new TypeVariable("globals_t", 1) { DataType = globalStruct };
            globals = new Identifier("globals", -1, PrimitiveType.Pointer32, null);

            eqLink = new EquivalenceClass(new TypeVariable(2));
            StructureType str = new StructureType
            {
                Fields = {
                    { 0, new Pointer(eqLink, 4)},
                    { 4, PrimitiveType.Int32 }
                }
            };
            eqLink.DataType = str;
        }

        private ImageWriter Memory(uint address)
        {
            image = new LoadedImage(new Address(address), new byte[1024]);
            var mem = new LeImageWriter(image.Bytes);
            return mem;
        }

        private void Root(uint address, DataType dt)
        {
            globalStruct.Fields.Add((int) address, dt);
        }

        [Test]
        public void CptPointerChain()
        {
            Memory(0x10000000)
                .WriteLeUInt32(0x10000008)
                .WriteLeUInt32(0x00000001)
                .WriteLeUInt32(0x10000010)
                .WriteLeUInt32(0x00000002)
                .WriteLeUInt32(0);

            Root(0x10000000, eqLink);

            var cpt = new ConstantPointerTraversal(arch, globalStruct, image);
            cpt.Traverse();
            Assert.AreEqual(1, cpt.Discoveries.Count);
            Assert.AreEqual("10000008: t10000008: Eq_2", cpt.Discoveries[0].ToString());
        }

        [Test]
        public void CptArrayOfPointers()
        {
            Memory(0x10000)
                .WriteLeUInt32(0x01010)
                .WriteLeUInt32(0x01014)
                .WriteLeUInt32(0x01018)
                .WriteLeUInt32(0x0101C)
                .WriteLeUInt32('a')
                .WriteLeUInt32('b')
                .WriteLeUInt32('c')
                .WriteLeUInt32('d');
            Root(0x010000, new ArrayType(new Pointer(PrimitiveType.Char, 4), 4));
            var cpt = new ConstantPointerTraversal(arch, globalStruct, image);
            cpt.Traverse();

            Assert.AreEqual(4, cpt.Discoveries.Count);
            Assert.AreEqual("1010: b1010: char", cpt.Discoveries[0].ToString());
            Assert.AreEqual("1014: b1014: char", cpt.Discoveries[1].ToString());
            Assert.AreEqual("1018: b1018: char", cpt.Discoveries[2].ToString());
            Assert.AreEqual("101C: b101C: char", cpt.Discoveries[3].ToString());

        }

        [Test]
        public void CptCycle()
        {
            Memory(0x1000)
                .WriteLeUInt32(0x1000)
                .WriteLeUInt32(42);
            Root(0x1000, eqLink);
            var cpt = new ConstantPointerTraversal(arch, globalStruct, image);
            cpt.Traverse();

            Assert.AreEqual(0, cpt.Discoveries.Count);
        }

        [Test]
        public void CptPfn()
        {
        }
    }
}
