// subject.c
// Generated by decompiling subject.exe
// using Reko decompiler version 0.8.0.2.

#include "subject.h"

// 00010958: void _start(Register (ptr32 Eq_2) g1, Register word32 o2, Register word32 o3, Register word32 o4, Register word32 o5, Register (ptr32 Eq_7) o7, Register ui32 fsr, Stack ui32 dwArg40)
void _start(void (* g1)(), word32 o2, word32 o3, word32 o4, word32 o5, struct Eq_7 * o7, ui32 fsr, ui32 dwArg40)
{
	globals->ptr20E60 = fp + 0x44;
	globals->ptr20E3C = fp + 0x44 + ((dwArg40 << 0x02) + 0x04);
	if (0x00 != 0x00)
	{
		globals->dw20E58 = fsr;
		globals->dw20E58 &= 0x303FFFFF;
		if (false)
			globals->dw20E5C = 0x01;
	}
	if (g1 == null)
	{
		atexit(&globals->t10CB8);
		_init(0x00010CB8, 0x00020C00, o2, o3, o4, o5, o7);
	}
	else
		atexit(g1);
}

// 00010A5C: void func1()
void func1()
{
}

// 00010A74: void func2()
void func2()
{
}

// 00010A8C: void func3()
void func3()
{
}

// 00010AA4: void func4()
void func4()
{
}

// 00010ABC: void func5()
void func5()
{
}

// 00010AD4: void func6()
void func6()
{
}

// 00010AEC: void func7()
void func7()
{
}

// 00010B04: void func8()
void func8()
{
}

// 00010B0C: void main(Register int32 o0)
void main(int32 o0)
{
	word32 o0_20 = 0x01;
	if (o0 <= 0x01)
		o0_20 = 0x00;
	word32 o0_31;
	if (o0_20 != 0x00)
		o0_31 = 68188;
	else
		o0_31 = 68212;
	word32 o3_37;
	if (o0_20 != 0x00)
		o3_37 = 68236;
	else
		o3_37 = 0x00010AA4;
	word32 o2_43;
	if (o0_20 != 0x00)
		o2_43 = 68284;
	else
		o2_43 = 68308;
	word32 o1_49;
	if (o0_20 != 0x00)
		o1_49 = 68332;
	else
		o1_49 = 0x00010B04;
	word32 i1_114;
	Eq_86 Z_122;
	if (o0_20 != 0x00)
	{
		if (o0_31 != 68188 || (o3_37 != 68236 || (o2_43 != 68284 || o1_49 != 68332)))
		{
			i1_114 = 0x00;
			Z_122.u0 = SLICE(cond(0x00), bool, 2);
			goto l00010C44;
		}
		i1_114 = 0x01;
	}
	else if (o0_31 == 68212 && (o3_37 == 0x00010AA4 && (o2_43 == 68308 && o1_49 == 0x00010B04)))
		i1_114 = 0x01;
	else
		i1_114 = 0x00;
	Z_122.u0 = SLICE(cond(i1_114), bool, 2);
l00010C44:
	if (!Z_122)
		printf("Pass\n");
	else
		printf("Failed!\n");
}

// 00010C80: void _init(Register word32 o0, Register word32 o1, Register word32 o2, Register word32 o3, Register word32 o4, Register word32 o5, Register (ptr32 Eq_7) o7)
void _init(word32 o0, word32 o1, word32 o2, word32 o3, word32 o4, word32 o5, struct Eq_7 * o7)
{
	fn00010C90(o1, o2, o3, o4, o5, o7, o0, o1, o2, o3, o4, o5, fp, o7);
}

// 00010C90: void fn00010C90(Register word32 o1, Register word32 o2, Register word32 o3, Register word32 o4, Register word32 o5, Register (ptr32 Eq_7) o7, Register word32 i0, Register word32 i1, Register word32 i2, Register word32 i3, Register word32 i4, Register word32 i5, Register ptr32 i6, Register (ptr32 Eq_7) i7)
void fn00010C90(word32 o1, word32 o2, word32 o3, word32 o4, word32 o5, struct Eq_7 * o7, word32 i0, word32 i1, word32 i2, word32 i3, word32 i4, word32 i5, ptr32 i6, struct Eq_7 * i7)
{
	struct Eq_143 * o0_6 = o7 + o7->dw0008 / 0x0C;
	word32 l0_7 = o0_6->dwFFFFFFF8;
	if (l0_7 == 0x00)
		return;
	fn81C7E008();
}

// 00010CB8: void _fini(Register word32 o0, Register word32 o1, Register word32 o2, Register word32 o3, Register word32 o4, Register word32 o5, Register (ptr32 Eq_162) o7)
void _fini(word32 o0, word32 o1, word32 o2, word32 o3, word32 o4, word32 o5, struct Eq_162 * o7)
{
	fn00010CC8(o1, o2, o3, o4, o5, o7, o0, o1, o2, o3, o4, o5, fp, o7);
}

// 00010CC8: void fn00010CC8(Register word32 o1, Register word32 o2, Register word32 o3, Register word32 o4, Register word32 o5, Register (ptr32 Eq_162) o7, Register word32 i0, Register word32 i1, Register word32 i2, Register word32 i3, Register word32 i4, Register word32 i5, Register ptr32 i6, Register (ptr32 Eq_162) i7)
void fn00010CC8(word32 o1, word32 o2, word32 o3, word32 o4, word32 o5, struct Eq_162 * o7, word32 i0, word32 i1, word32 i2, word32 i3, word32 i4, word32 i5, ptr32 i6, struct Eq_162 * i7)
{
	struct Eq_181 * o0_6 = o7 + o7->dw0008 / 0x0C;
	<anonymous> * l0_7 = o0_6->ptrFFFFFFFC;
	if (l0_7 == null)
		return;
	l0_7();
}

// 00020D40: void atexit()
void atexit()
{
}

// 00020D4C: void exit()
void exit()
{
}

// 00020D58: void _exit()
void _exit()
{
}

// 00020D64: void printf()
void printf()
{
}

