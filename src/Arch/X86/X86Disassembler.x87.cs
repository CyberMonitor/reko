﻿#region License
/* 
 * Copyright (C) 1999-2016 John Källén.
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Reko.Arch.X86
{
    public partial class X86Disassembler
    {
        private bool IsEmulated8087Vector(byte vectorNumber)
        {
            return false;
        }

        private X86Instruction RewriteEmulated8087Instruction()
        {
            return new X86Instruction(Opcode.nop, null, null);
        }

        private static OpRec[] CreateFpuOprecs()
        {
            return new SingleByteOpRec[]  
			{
				// D8 /////////////////////////

				new SingleByteOpRec(Opcode.fadd, "Mf"),
				new SingleByteOpRec(Opcode.fmul, "Mf"),
				new SingleByteOpRec(Opcode.fcom, "Mf"),
				new SingleByteOpRec(Opcode.fcomp, "Mf"),
				new SingleByteOpRec(Opcode.fsub,  "Mf"),
				new SingleByteOpRec(Opcode.fsubr, "Mf"),
				new SingleByteOpRec(Opcode.fdiv,  "Mf"),
				new SingleByteOpRec(Opcode.fdivr, "Mf"),
				// D8 C0
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),

				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				// D8 D0		
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
						
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				// D8 E0
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
						
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				// D8 F0
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
						
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				
				// D9 ////////////////////////////////
				
				new SingleByteOpRec(Opcode.fld, "Mf"),
				new SingleByteOpRec(Opcode.illegal, ""),
				new SingleByteOpRec(Opcode.fst, "Mf"),
				new SingleByteOpRec(Opcode.fstp, "Mf"),
				new SingleByteOpRec(Opcode.fldenv, "Mw"),
				new SingleByteOpRec(Opcode.fldcw, "Mw"),
				new SingleByteOpRec(Opcode.fstenv, "Mw"),
				new SingleByteOpRec(Opcode.fstcw, "Mw"),
						
				// D9 C0
				new SingleByteOpRec(Opcode.fld, "F"),
				new SingleByteOpRec(Opcode.fld, "F"),
				new SingleByteOpRec(Opcode.fld, "F"),
				new SingleByteOpRec(Opcode.fld, "F"),
				new SingleByteOpRec(Opcode.fld, "F"),
				new SingleByteOpRec(Opcode.fld, "F"),
				new SingleByteOpRec(Opcode.fld, "F"),
				new SingleByteOpRec(Opcode.fld, "F"),
						
				new SingleByteOpRec(Opcode.fxch, "f,F"),
				new SingleByteOpRec(Opcode.fxch, "f,F"),
				new SingleByteOpRec(Opcode.fxch, "f,F"),
				new SingleByteOpRec(Opcode.fxch, "f,F"),
				new SingleByteOpRec(Opcode.fxch, "f,F"),
				new SingleByteOpRec(Opcode.fxch, "f,F"),
				new SingleByteOpRec(Opcode.fxch, "f,F"),
				new SingleByteOpRec(Opcode.fxch, "f,F"),
						
				// D9 D0
				new SingleByteOpRec(Opcode.fnop, ""),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				// E0
				new SingleByteOpRec(Opcode.fchs),
				new SingleByteOpRec(Opcode.fabs, ""),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.ftst),
				new SingleByteOpRec(Opcode.fxam),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.fld1),
				new SingleByteOpRec(Opcode.fldl2t, ""),
				new SingleByteOpRec(Opcode.fldl2e, ""),
				new SingleByteOpRec(Opcode.fldpi),
				new SingleByteOpRec(Opcode.fldlg2, ""),
				new SingleByteOpRec(Opcode.fldln2),
				new SingleByteOpRec(Opcode.fldz),
				new SingleByteOpRec(Opcode.illegal),
						
				// D9 F0
				new SingleByteOpRec(Opcode.f2xm1, "F,f"),
				new SingleByteOpRec(Opcode.fyl2x, "F,f"),
				new SingleByteOpRec(Opcode.fptan, "F,f"),
				new SingleByteOpRec(Opcode.fpatan, "F,f"),
				new SingleByteOpRec(Opcode.fxtract, "F,f"),
				new SingleByteOpRec(Opcode.fprem1, "F,f"),
				new SingleByteOpRec(Opcode.fdecstp, "F,f"),
				new SingleByteOpRec(Opcode.fincstp, "F,f"),
						
				new SingleByteOpRec(Opcode.fprem, "F,f"),
				new SingleByteOpRec(Opcode.fyl2xp1, "F,f"),
				new SingleByteOpRec(Opcode.fsqrt),
				new SingleByteOpRec(Opcode.fsincos),
				new SingleByteOpRec(Opcode.frndint),
				new SingleByteOpRec(Opcode.fscale, "F,f"),
				new SingleByteOpRec(Opcode.fsin),
				new SingleByteOpRec(Opcode.fcos),
				
				// DA //////////////
				
				new SingleByteOpRec(Opcode.fiadd, "Md"),
				new SingleByteOpRec(Opcode.fimul, "Md"),
				new SingleByteOpRec(Opcode.ficom, "Md"),
				new SingleByteOpRec(Opcode.ficomp, "Md"),
				new SingleByteOpRec(Opcode.fisub, "Md"),
				new SingleByteOpRec(Opcode.fisubr, "Md"),
				new SingleByteOpRec(Opcode.fidiv, "Md"),
				new SingleByteOpRec(Opcode.fidivr, "Md"),
				
				// DA C0 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.fucompp), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				// DB ///////////////////////////
				
				new SingleByteOpRec(Opcode.fild, "Md"),
				new SingleByteOpRec(Opcode.illegal, ""),
				new SingleByteOpRec(Opcode.fist, "Md"),
				new SingleByteOpRec(Opcode.fistp, "Md"),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.fld, "Mh"),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.fstp, "Mh"),
						
				// DB C0, Conditional moves.

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.fclex), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 

				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
				new SingleByteOpRec(Opcode.illegal), 
					
				// DC ////////////////////

				new SingleByteOpRec(Opcode.fadd, "Mg"),
				new SingleByteOpRec(Opcode.fmul, "Mg"),
				new SingleByteOpRec(Opcode.fcom, "Mg"),
				new SingleByteOpRec(Opcode.fcomp, "Mg"),
				new SingleByteOpRec(Opcode.fsub, "Mg"),
				new SingleByteOpRec(Opcode.fsubr, "Mg"),
				new SingleByteOpRec(Opcode.fdiv, "Mg"),
				new SingleByteOpRec(Opcode.fdivr, "Mg"),

                // DC C0
						
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
				new SingleByteOpRec(Opcode.fadd, "f,F"),
						
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
				new SingleByteOpRec(Opcode.fmul, "f,F"),
						
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
				new SingleByteOpRec(Opcode.fcom, "f,F"),
						
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
				new SingleByteOpRec(Opcode.fcomp, "f,F"),
						
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
				new SingleByteOpRec(Opcode.fsub, "f,F"),
						
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
				new SingleByteOpRec(Opcode.fsubr, "f,F"),
						
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
				new SingleByteOpRec(Opcode.fdiv, "f,F"),
						
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),
				new SingleByteOpRec(Opcode.fdivr, "f,F"),

				// DD ////////////////

				new SingleByteOpRec(Opcode.fld, "Mg"),
				new SingleByteOpRec(Opcode.illegal, ""),
				new SingleByteOpRec(Opcode.fst, "Mg"),
				new SingleByteOpRec(Opcode.fstp, "Mg"),
				new SingleByteOpRec(Opcode.frstor, "Mw"),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.fsave, "Mw"),
				new SingleByteOpRec(Opcode.fstsw, "Mw"),
						
				// DD C0

				new SingleByteOpRec(Opcode.ffree, "F"),
				new SingleByteOpRec(Opcode.ffree, "F"),
				new SingleByteOpRec(Opcode.ffree, "F"),
				new SingleByteOpRec(Opcode.ffree, "F"),
				new SingleByteOpRec(Opcode.ffree, "F"),
				new SingleByteOpRec(Opcode.ffree, "F"),
				new SingleByteOpRec(Opcode.ffree, "F"),
				new SingleByteOpRec(Opcode.ffree, "F"),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				// DD D0
				new SingleByteOpRec(Opcode.fst, "F"),
				new SingleByteOpRec(Opcode.fst, "F"),
				new SingleByteOpRec(Opcode.fst, "F"),
				new SingleByteOpRec(Opcode.fst, "F"),
				new SingleByteOpRec(Opcode.fst, "F"),
				new SingleByteOpRec(Opcode.fst, "F"),
				new SingleByteOpRec(Opcode.fst, "F"),
				new SingleByteOpRec(Opcode.fst, "F"),
						
				new SingleByteOpRec(Opcode.fstp, "F"),
				new SingleByteOpRec(Opcode.fstp, "F"),
				new SingleByteOpRec(Opcode.fstp, "F"),
				new SingleByteOpRec(Opcode.fstp, "F"),
				new SingleByteOpRec(Opcode.fstp, "F"),
				new SingleByteOpRec(Opcode.fstp, "F"),
				new SingleByteOpRec(Opcode.fstp, "F"),
				new SingleByteOpRec(Opcode.fstp, "F"),
						
				// E0
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				// F0
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				// DE //////////////////////////

				new SingleByteOpRec(Opcode.fiadd, "Mw"),
				new SingleByteOpRec(Opcode.fimul, "Mw"),
				new SingleByteOpRec(Opcode.ficom, "Mw"),
				new SingleByteOpRec(Opcode.ficomp, "Mw"),
				new SingleByteOpRec(Opcode.fisub, "Mw"),
				new SingleByteOpRec(Opcode.fisubr, "Mw"),
				new SingleByteOpRec(Opcode.fidiv, "Mw"),
				new SingleByteOpRec(Opcode.fidivr, "Mw"),
				
                // DE C0
				
                new SingleByteOpRec(Opcode.faddp, "F,f"),
				new SingleByteOpRec(Opcode.faddp, "F,f"),
				new SingleByteOpRec(Opcode.faddp, "F,f"),
				new SingleByteOpRec(Opcode.faddp, "F,f"),
				new SingleByteOpRec(Opcode.faddp, "F,f"),
				new SingleByteOpRec(Opcode.faddp, "F,f"),
				new SingleByteOpRec(Opcode.faddp, "F,f"),
				new SingleByteOpRec(Opcode.faddp, "F,f"),
						
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
				new SingleByteOpRec(Opcode.fmulp, "F,f"),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.fcompp),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				// DE E0	
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
				new SingleByteOpRec(Opcode.fsubrp, "F,f"),
						
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				new SingleByteOpRec(Opcode.fsubp, "F,f"),
				// DE F0
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
				new SingleByteOpRec(Opcode.fdivrp, "F,f"),
						
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				new SingleByteOpRec(Opcode.fdivp, "F,f"),
				
				// DF //////////////////////

				new SingleByteOpRec(Opcode.fild, "Mw"),
				new SingleByteOpRec(Opcode.illegal, ""),
				new SingleByteOpRec(Opcode.fist, "Mw"),
				new SingleByteOpRec(Opcode.fistp, "Mw"),
				new SingleByteOpRec(Opcode.fbld, "MB"),
				new SingleByteOpRec(Opcode.fild, "Mq"),
				new SingleByteOpRec(Opcode.fbstp, "MB"),
				new SingleByteOpRec(Opcode.fistp, "Mq"),

				// C0
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				// D0
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				// E0
				new SingleByteOpRec(Opcode.fstsw, "aw"),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				// F0
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
						
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
				new SingleByteOpRec(Opcode.illegal),
			};
        }
    }
}
