// subject.h
// Generated by decompiling subject.exe
// using Reko decompiler version 0.9.1.0.

/*
// Equivalence classes ////////////
Eq_1: (struct "Globals" (10CB8 Eq_2 t10CB8) (10CF8 (str char) str10CF8) (10D00 (str char) str10D00) (20E3C ptr32 ptr20E3C) (20E58 ui32 dw20E58) (20E5C word32 dw20E5C) (20E60 ptr32 ptr20E60))
	globals_t (in globals : (ptr32 (struct "Globals")))
Eq_2: (fn void ())
	T_2 (in g1 : (ptr32 Eq_2))
	T_26 (in 0<32> : word32)
	T_42 (in func : (ptr32 (fn void ())))
	T_43 (in 0x10CB8<32> : word32)
Eq_7: (struct "Eq_7" (8 int32 dw0008))
	T_7 (in o7 : (ptr32 Eq_7))
	T_53 (in o7 : (ptr32 Eq_7))
	T_127 (in o7 : (ptr32 Eq_7))
	T_135 (in i7 : (ptr32 Eq_7))
Eq_40: (fn void ((ptr32 Eq_2)))
	T_40 (in atexit : ptr32)
	T_41 (in signature of atexit : void)
	T_57 (in atexit : ptr32)
Eq_45: (fn void (word32, word32, word32, word32, word32, word32, (ptr32 Eq_7)))
	T_45 (in _init : ptr32)
	T_46 (in signature of _init : void)
Eq_114: (fn int32 ((ptr32 char)))
	T_114 (in printf : ptr32)
	T_115 (in signature of printf : void)
Eq_119: (fn int32 ((ptr32 char)))
	T_119 (in printf : ptr32)
	T_120 (in signature of printf : void)
Eq_125: (fn void ((ptr32 Eq_7), word32, word32, word32, word32, word32, word32, ptr32, (ptr32 Eq_7)))
	T_125 (in fn00010C90 : ptr32)
	T_126 (in signature of fn00010C90 : void)
Eq_141: (struct "Eq_141" (FFFFFFF8 word32 dwFFFFFFF8))
	T_141 (in o7 + Mem0[o7 + 8<i32>:word32] : word32)
Eq_155: (struct "Eq_155" (8 int32 dw0008))
	T_155 (in o7 : (ptr32 Eq_155))
	T_158 (in o7 : (ptr32 Eq_155))
	T_166 (in i7 : (ptr32 Eq_155))
Eq_156: (fn void ((ptr32 Eq_155), word32, word32, word32, word32, word32, word32, ptr32, (ptr32 Eq_155)))
	T_156 (in fn00010CC8 : ptr32)
	T_157 (in signature of fn00010CC8 : void)
Eq_173: (struct "Eq_173" (FFFFFFFC (ptr32 code) ptrFFFFFFFC))
	T_173 (in o7 + Mem0[o7 + 8<i32>:word32] : word32)
// Type Variables ////////////
globals_t: (in globals : (ptr32 (struct "Globals")))
  Class: Eq_1
  DataType: (ptr32 Eq_1)
  OrigDataType: (ptr32 (struct "Globals"))
T_2: (in g1 : (ptr32 Eq_2))
  Class: Eq_2
  DataType: (ptr32 Eq_2)
  OrigDataType: (ptr32 (fn void ()))
T_3: (in o2 : word32)
  Class: Eq_3
  DataType: word32
  OrigDataType: word32
T_4: (in o3 : word32)
  Class: Eq_4
  DataType: word32
  OrigDataType: word32
T_5: (in o4 : word32)
  Class: Eq_5
  DataType: word32
  OrigDataType: word32
T_6: (in o5 : word32)
  Class: Eq_6
  DataType: word32
  OrigDataType: word32
T_7: (in o7 : (ptr32 Eq_7))
  Class: Eq_7
  DataType: (ptr32 Eq_7)
  OrigDataType: word32
T_8: (in fsr : ui32)
  Class: Eq_8
  DataType: ui32
  OrigDataType: word32
T_9: (in dwArg40 : ui32)
  Class: Eq_9
  DataType: ui32
  OrigDataType: ui32
T_10: (in fp : ptr32)
  Class: Eq_10
  DataType: ptr32
  OrigDataType: ptr32
T_11: (in 0x44<32> : word32)
  Class: Eq_11
  DataType: int32
  OrigDataType: int32
T_12: (in fp + 0x44<32> : word32)
  Class: Eq_12
  DataType: ptr32
  OrigDataType: ptr32
T_13: (in 0x20E60<32> : word32)
  Class: Eq_13
  DataType: (ptr32 ptr32)
  OrigDataType: (ptr32 (struct (0 T_14 t0000)))
T_14: (in Mem8[0x20E60<32>:word32] : word32)
  Class: Eq_12
  DataType: ptr32
  OrigDataType: word32
T_15: (in fp + 0x44<32> : word32)
  Class: Eq_15
  DataType: ptr32
  OrigDataType: ptr32
T_16: (in 2<32> : word32)
  Class: Eq_16
  DataType: word32
  OrigDataType: word32
T_17: (in dwArg40 << 2<32> : word32)
  Class: Eq_17
  DataType: ui32
  OrigDataType: ui32
T_18: (in 4<32> : word32)
  Class: Eq_18
  DataType: word32
  OrigDataType: word32
T_19: (in (dwArg40 << 2<32>) + 4<32> : word32)
  Class: Eq_19
  DataType: int32
  OrigDataType: int32
T_20: (in fp + 0x44<32> + ((dwArg40 << 2<32>) + 4<32>) : word32)
  Class: Eq_20
  DataType: ptr32
  OrigDataType: ptr32
T_21: (in 0x20E3C<32> : word32)
  Class: Eq_21
  DataType: (ptr32 ptr32)
  OrigDataType: (ptr32 (struct (0 T_22 t0000)))
T_22: (in Mem13[0x20E3C<32>:word32] : word32)
  Class: Eq_20
  DataType: ptr32
  OrigDataType: word32
T_23: (in 0<32> : word32)
  Class: Eq_23
  DataType: word32
  OrigDataType: word32
T_24: (in 0<32> : word32)
  Class: Eq_23
  DataType: word32
  OrigDataType: word32
T_25: (in 0<32> == 0<32> : bool)
  Class: Eq_25
  DataType: bool
  OrigDataType: bool
T_26: (in 0<32> : word32)
  Class: Eq_2
  DataType: (ptr32 Eq_2)
  OrigDataType: word32
T_27: (in g1 == null : bool)
  Class: Eq_27
  DataType: bool
  OrigDataType: bool
T_28: (in 0x20E58<32> : word32)
  Class: Eq_28
  DataType: (ptr32 ui32)
  OrigDataType: (ptr32 (struct (0 T_29 t0000)))
T_29: (in Mem27[0x20E58<32>:word32] : word32)
  Class: Eq_8
  DataType: ui32
  OrigDataType: word32
T_30: (in 0x20E58<32> : word32)
  Class: Eq_30
  DataType: (ptr32 ui32)
  OrigDataType: (ptr32 (struct (0 T_31 t0000)))
T_31: (in Mem27[0x20E58<32>:word32] : word32)
  Class: Eq_8
  DataType: ui32
  OrigDataType: ui32
T_32: (in 0x303FFFFF<32> : word32)
  Class: Eq_32
  DataType: ui32
  OrigDataType: ui32
T_33: (in globals->dw20E58 & 0x303FFFFF<32> : word32)
  Class: Eq_8
  DataType: ui32
  OrigDataType: ui32
T_34: (in 0x20E58<32> : word32)
  Class: Eq_34
  DataType: (ptr32 ui32)
  OrigDataType: (ptr32 (struct (0 T_35 t0000)))
T_35: (in Mem33[0x20E58<32>:word32] : word32)
  Class: Eq_8
  DataType: ui32
  OrigDataType: word32
T_36: (in true : bool)
  Class: Eq_36
  DataType: bool
  OrigDataType: bool
T_37: (in 1<32> : word32)
  Class: Eq_37
  DataType: word32
  OrigDataType: word32
T_38: (in 0x20E5C<32> : word32)
  Class: Eq_38
  DataType: (ptr32 word32)
  OrigDataType: (ptr32 (struct (0 T_39 t0000)))
T_39: (in Mem44[0x20E5C<32>:word32] : word32)
  Class: Eq_37
  DataType: word32
  OrigDataType: word32
T_40: (in atexit : ptr32)
  Class: Eq_40
  DataType: (ptr32 Eq_40)
  OrigDataType: (ptr32 (fn T_44 (T_43)))
T_41: (in signature of atexit : void)
  Class: Eq_40
  DataType: (ptr32 Eq_40)
  OrigDataType: 
T_42: (in func : (ptr32 (fn void ())))
  Class: Eq_2
  DataType: (ptr32 Eq_2)
  OrigDataType: 
T_43: (in 0x10CB8<32> : word32)
  Class: Eq_2
  DataType: (ptr32 Eq_2)
  OrigDataType: (ptr32 (fn void ()))
T_44: (in atexit(&g_t10CB8) : void)
  Class: Eq_44
  DataType: void
  OrigDataType: void
T_45: (in _init : ptr32)
  Class: Eq_45
  DataType: (ptr32 Eq_45)
  OrigDataType: (ptr32 (fn T_56 (T_54, T_55, T_3, T_4, T_5, T_6, T_7)))
T_46: (in signature of _init : void)
  Class: Eq_45
  DataType: (ptr32 Eq_45)
  OrigDataType: 
T_47: (in o0 : word32)
  Class: Eq_47
  DataType: word32
  OrigDataType: word32
T_48: (in o1 : word32)
  Class: Eq_48
  DataType: word32
  OrigDataType: word32
T_49: (in o2 : word32)
  Class: Eq_3
  DataType: word32
  OrigDataType: word32
T_50: (in o3 : word32)
  Class: Eq_4
  DataType: word32
  OrigDataType: word32
T_51: (in o4 : word32)
  Class: Eq_5
  DataType: word32
  OrigDataType: word32
T_52: (in o5 : word32)
  Class: Eq_6
  DataType: word32
  OrigDataType: word32
T_53: (in o7 : (ptr32 Eq_7))
  Class: Eq_7
  DataType: (ptr32 Eq_7)
  OrigDataType: word32
T_54: (in 0x10CB8<32> : word32)
  Class: Eq_47
  DataType: word32
  OrigDataType: word32
T_55: (in 0x20C00<32> : word32)
  Class: Eq_48
  DataType: word32
  OrigDataType: word32
T_56: (in _init(0x10CB8<32>, 0x20C00<32>, o2, o3, o4, o5, o7) : void)
  Class: Eq_56
  DataType: void
  OrigDataType: void
T_57: (in atexit : ptr32)
  Class: Eq_40
  DataType: (ptr32 Eq_40)
  OrigDataType: (ptr32 (fn T_58 (T_2)))
T_58: (in atexit(g1) : void)
  Class: Eq_44
  DataType: void
  OrigDataType: void
T_59: (in o0 : int32)
  Class: Eq_59
  DataType: int32
  OrigDataType: int32
T_60: (in o0_20 : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_61: (in 1<32> : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_62: (in 1<32> : word32)
  Class: Eq_59
  DataType: int32
  OrigDataType: int32
T_63: (in o0 <= 1<32> : bool)
  Class: Eq_63
  DataType: bool
  OrigDataType: bool
T_64: (in o0_31 : word32)
  Class: Eq_64
  DataType: word32
  OrigDataType: word32
T_65: (in 0<32> : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_66: (in o0_20 == 0<32> : bool)
  Class: Eq_66
  DataType: bool
  OrigDataType: bool
T_67: (in 0<32> : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_68: (in 0x10A74<32> : word32)
  Class: Eq_64
  DataType: word32
  OrigDataType: word32
T_69: (in 0x10A5C<32> : word32)
  Class: Eq_64
  DataType: word32
  OrigDataType: word32
T_70: (in o3_37 : word32)
  Class: Eq_70
  DataType: word32
  OrigDataType: word32
T_71: (in 0<32> : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_72: (in o0_20 == 0<32> : bool)
  Class: Eq_72
  DataType: bool
  OrigDataType: bool
T_73: (in 0x10AA4<32> : word32)
  Class: Eq_70
  DataType: word32
  OrigDataType: word32
T_74: (in 0x10A8C<32> : word32)
  Class: Eq_70
  DataType: word32
  OrigDataType: word32
T_75: (in o2_43 : word32)
  Class: Eq_75
  DataType: word32
  OrigDataType: word32
T_76: (in 0<32> : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_77: (in o0_20 == 0<32> : bool)
  Class: Eq_77
  DataType: bool
  OrigDataType: bool
T_78: (in 0x10AD4<32> : word32)
  Class: Eq_75
  DataType: word32
  OrigDataType: word32
T_79: (in 0x10ABC<32> : word32)
  Class: Eq_75
  DataType: word32
  OrigDataType: word32
T_80: (in o1_49 : word32)
  Class: Eq_80
  DataType: word32
  OrigDataType: word32
T_81: (in 0<32> : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_82: (in o0_20 == 0<32> : bool)
  Class: Eq_82
  DataType: bool
  OrigDataType: bool
T_83: (in 0x10B04<32> : word32)
  Class: Eq_80
  DataType: word32
  OrigDataType: word32
T_84: (in 0x10AEC<32> : word32)
  Class: Eq_80
  DataType: word32
  OrigDataType: word32
T_85: (in i1_114 : word32)
  Class: Eq_85
  DataType: word32
  OrigDataType: word32
T_86: (in Z_122 : bool)
  Class: Eq_86
  DataType: bool
  OrigDataType: bool
T_87: (in 0<32> : word32)
  Class: Eq_60
  DataType: word32
  OrigDataType: word32
T_88: (in o0_20 == 0<32> : bool)
  Class: Eq_88
  DataType: bool
  OrigDataType: bool
T_89: (in 0x10A74<32> : word32)
  Class: Eq_64
  DataType: word32
  OrigDataType: word32
T_90: (in o0_31 != 0x10A74<32> : bool)
  Class: Eq_90
  DataType: bool
  OrigDataType: bool
T_91: (in 0x10A5C<32> : word32)
  Class: Eq_64
  DataType: word32
  OrigDataType: word32
T_92: (in o0_31 != 0x10A5C<32> : bool)
  Class: Eq_92
  DataType: bool
  OrigDataType: bool
T_93: (in 0x10A8C<32> : word32)
  Class: Eq_70
  DataType: word32
  OrigDataType: word32
T_94: (in o3_37 != 0x10A8C<32> : bool)
  Class: Eq_94
  DataType: bool
  OrigDataType: bool
T_95: (in 0<32> : word32)
  Class: Eq_85
  DataType: word32
  OrigDataType: word32
T_96: (in 0<32> : word32)
  Class: Eq_96
  DataType: word32
  OrigDataType: word32
T_97: (in cond(0<32>) : byte)
  Class: Eq_97
  DataType: byte
  OrigDataType: byte
T_98: (in SLICE(cond(0<32>), bool, 2) : bool)
  Class: Eq_86
  DataType: bool
  OrigDataType: bool
T_99: (in 0x10ABC<32> : word32)
  Class: Eq_75
  DataType: word32
  OrigDataType: word32
T_100: (in o2_43 != 0x10ABC<32> : bool)
  Class: Eq_100
  DataType: bool
  OrigDataType: bool
T_101: (in 0x10AEC<32> : word32)
  Class: Eq_80
  DataType: word32
  OrigDataType: word32
T_102: (in o1_49 != 0x10AEC<32> : bool)
  Class: Eq_102
  DataType: bool
  OrigDataType: bool
T_103: (in 1<32> : word32)
  Class: Eq_85
  DataType: word32
  OrigDataType: word32
T_104: (in cond(i1_114) : byte)
  Class: Eq_104
  DataType: byte
  OrigDataType: byte
T_105: (in SLICE(cond(i1_114), bool, 2) : bool)
  Class: Eq_86
  DataType: bool
  OrigDataType: bool
T_106: (in 0<32> : word32)
  Class: Eq_85
  DataType: word32
  OrigDataType: word32
T_107: (in 0x10AA4<32> : word32)
  Class: Eq_70
  DataType: word32
  OrigDataType: word32
T_108: (in o3_37 != 0x10AA4<32> : bool)
  Class: Eq_108
  DataType: bool
  OrigDataType: bool
T_109: (in 0x10AD4<32> : word32)
  Class: Eq_75
  DataType: word32
  OrigDataType: word32
T_110: (in o2_43 != 0x10AD4<32> : bool)
  Class: Eq_110
  DataType: bool
  OrigDataType: bool
T_111: (in 0x10B04<32> : word32)
  Class: Eq_80
  DataType: word32
  OrigDataType: word32
T_112: (in o1_49 != 0x10B04<32> : bool)
  Class: Eq_112
  DataType: bool
  OrigDataType: bool
T_113: (in 1<32> : word32)
  Class: Eq_85
  DataType: word32
  OrigDataType: word32
T_114: (in printf : ptr32)
  Class: Eq_114
  DataType: (ptr32 Eq_114)
  OrigDataType: (ptr32 (fn T_118 (T_117)))
T_115: (in signature of printf : void)
  Class: Eq_114
  DataType: (ptr32 Eq_114)
  OrigDataType: 
T_116: (in format : (ptr32 char))
  Class: Eq_116
  DataType: (ptr32 char)
  OrigDataType: 
T_117: (in 0x10D00<32> : word32)
  Class: Eq_116
  DataType: (ptr32 char)
  OrigDataType: (ptr32 char)
T_118: (in printf("Failed!\n") : int32)
  Class: Eq_118
  DataType: int32
  OrigDataType: int32
T_119: (in printf : ptr32)
  Class: Eq_119
  DataType: (ptr32 Eq_119)
  OrigDataType: (ptr32 (fn T_122 (T_121)))
T_120: (in signature of printf : void)
  Class: Eq_119
  DataType: (ptr32 Eq_119)
  OrigDataType: 
T_121: (in 0x10CF8<32> : word32)
  Class: Eq_116
  DataType: (ptr32 char)
  OrigDataType: (ptr32 char)
T_122: (in printf("Pass\n") : int32)
  Class: Eq_122
  DataType: int32
  OrigDataType: int32
T_123: (in 0<32> : word32)
  Class: Eq_85
  DataType: word32
  OrigDataType: word32
T_124: (in i1_114 == 0<32> : bool)
  Class: Eq_124
  DataType: bool
  OrigDataType: bool
T_125: (in fn00010C90 : ptr32)
  Class: Eq_125
  DataType: (ptr32 Eq_125)
  OrigDataType: (ptr32 (fn T_137 (T_53, T_47, T_48, T_49, T_50, T_51, T_52, T_136, T_53)))
T_126: (in signature of fn00010C90 : void)
  Class: Eq_125
  DataType: (ptr32 Eq_125)
  OrigDataType: 
T_127: (in o7 : (ptr32 Eq_7))
  Class: Eq_7
  DataType: (ptr32 Eq_7)
  OrigDataType: (ptr32 (struct (8 T_140 t0008)))
T_128: (in i0 : word32)
  Class: Eq_47
  DataType: word32
  OrigDataType: word32
T_129: (in i1 : word32)
  Class: Eq_48
  DataType: word32
  OrigDataType: word32
T_130: (in i2 : word32)
  Class: Eq_3
  DataType: word32
  OrigDataType: word32
T_131: (in i3 : word32)
  Class: Eq_4
  DataType: word32
  OrigDataType: word32
T_132: (in i4 : word32)
  Class: Eq_5
  DataType: word32
  OrigDataType: word32
T_133: (in i5 : word32)
  Class: Eq_6
  DataType: word32
  OrigDataType: word32
T_134: (in i6 : ptr32)
  Class: Eq_134
  DataType: ptr32
  OrigDataType: word32
T_135: (in i7 : (ptr32 Eq_7))
  Class: Eq_7
  DataType: (ptr32 Eq_7)
  OrigDataType: word32
T_136: (in fp : ptr32)
  Class: Eq_134
  DataType: ptr32
  OrigDataType: ptr32
T_137: (in fn00010C90(o7, o0, o1, o2, o3, o4, o5, fp, o7) : void)
  Class: Eq_137
  DataType: void
  OrigDataType: void
T_138: (in 8<i32> : int32)
  Class: Eq_138
  DataType: int32
  OrigDataType: int32
T_139: (in o7 + 8<i32> : word32)
  Class: Eq_139
  DataType: word32
  OrigDataType: word32
T_140: (in Mem0[o7 + 8<i32>:word32] : word32)
  Class: Eq_140
  DataType: int32
  OrigDataType: int32
T_141: (in o7 + Mem0[o7 + 8<i32>:word32] : word32)
  Class: Eq_141
  DataType: (ptr32 Eq_141)
  OrigDataType: (ptr32 (struct (FFFFFFF8 T_144 tFFFFFFF8)))
T_142: (in -8<i32> : int32)
  Class: Eq_142
  DataType: int32
  OrigDataType: int32
T_143: (in o7 + Mem0[o7 + 8<i32>:word32] + -8<i32> : word32)
  Class: Eq_143
  DataType: word32
  OrigDataType: word32
T_144: (in Mem0[o7 + Mem0[o7 + 8<i32>:word32] + -8<i32>:word32] : word32)
  Class: Eq_144
  DataType: word32
  OrigDataType: word32
T_145: (in 0<32> : word32)
  Class: Eq_144
  DataType: word32
  OrigDataType: word32
T_146: (in *((char *) (o7 + o7->dw0008 / 12<i32>) - 8<i32>) == 0<32> : bool)
  Class: Eq_146
  DataType: bool
  OrigDataType: bool
T_147: (in fn81C7E008 : ptr32)
  Class: Eq_147
  DataType: (ptr32 code)
  OrigDataType: (ptr32 code)
T_148: (in signature of fn81C7E008 : void)
  Class: Eq_148
  DataType: Eq_148
  OrigDataType: 
T_149: (in o0 : word32)
  Class: Eq_149
  DataType: word32
  OrigDataType: word32
T_150: (in o1 : word32)
  Class: Eq_150
  DataType: word32
  OrigDataType: word32
T_151: (in o2 : word32)
  Class: Eq_151
  DataType: word32
  OrigDataType: word32
T_152: (in o3 : word32)
  Class: Eq_152
  DataType: word32
  OrigDataType: word32
T_153: (in o4 : word32)
  Class: Eq_153
  DataType: word32
  OrigDataType: word32
T_154: (in o5 : word32)
  Class: Eq_154
  DataType: word32
  OrigDataType: word32
T_155: (in o7 : (ptr32 Eq_155))
  Class: Eq_155
  DataType: (ptr32 Eq_155)
  OrigDataType: word32
T_156: (in fn00010CC8 : ptr32)
  Class: Eq_156
  DataType: (ptr32 Eq_156)
  OrigDataType: (ptr32 (fn T_168 (T_155, T_149, T_150, T_151, T_152, T_153, T_154, T_167, T_155)))
T_157: (in signature of fn00010CC8 : void)
  Class: Eq_156
  DataType: (ptr32 Eq_156)
  OrigDataType: 
T_158: (in o7 : (ptr32 Eq_155))
  Class: Eq_155
  DataType: (ptr32 Eq_155)
  OrigDataType: (ptr32 (struct (8 T_172 t0008)))
T_159: (in i0 : word32)
  Class: Eq_149
  DataType: word32
  OrigDataType: word32
T_160: (in i1 : word32)
  Class: Eq_150
  DataType: word32
  OrigDataType: word32
T_161: (in i2 : word32)
  Class: Eq_151
  DataType: word32
  OrigDataType: word32
T_162: (in i3 : word32)
  Class: Eq_152
  DataType: word32
  OrigDataType: word32
T_163: (in i4 : word32)
  Class: Eq_153
  DataType: word32
  OrigDataType: word32
T_164: (in i5 : word32)
  Class: Eq_154
  DataType: word32
  OrigDataType: word32
T_165: (in i6 : ptr32)
  Class: Eq_165
  DataType: ptr32
  OrigDataType: word32
T_166: (in i7 : (ptr32 Eq_155))
  Class: Eq_155
  DataType: (ptr32 Eq_155)
  OrigDataType: word32
T_167: (in fp : ptr32)
  Class: Eq_165
  DataType: ptr32
  OrigDataType: ptr32
T_168: (in fn00010CC8(o7, o0, o1, o2, o3, o4, o5, fp, o7) : void)
  Class: Eq_168
  DataType: void
  OrigDataType: void
T_169: (in l0_7 : (ptr32 code))
  Class: Eq_169
  DataType: (ptr32 code)
  OrigDataType: (ptr32 code)
T_170: (in 8<i32> : int32)
  Class: Eq_170
  DataType: int32
  OrigDataType: int32
T_171: (in o7 + 8<i32> : word32)
  Class: Eq_171
  DataType: word32
  OrigDataType: word32
T_172: (in Mem0[o7 + 8<i32>:word32] : word32)
  Class: Eq_172
  DataType: int32
  OrigDataType: int32
T_173: (in o7 + Mem0[o7 + 8<i32>:word32] : word32)
  Class: Eq_173
  DataType: (ptr32 Eq_173)
  OrigDataType: (ptr32 (struct (FFFFFFFC T_176 tFFFFFFFC)))
T_174: (in -4<i32> : int32)
  Class: Eq_174
  DataType: int32
  OrigDataType: int32
T_175: (in o7 + Mem0[o7 + 8<i32>:word32] + -4<i32> : word32)
  Class: Eq_175
  DataType: word32
  OrigDataType: word32
T_176: (in Mem0[o7 + Mem0[o7 + 8<i32>:word32] + -4<i32>:word32] : word32)
  Class: Eq_169
  DataType: (ptr32 code)
  OrigDataType: word32
T_177: (in 0<32> : word32)
  Class: Eq_169
  DataType: (ptr32 code)
  OrigDataType: word32
T_178: (in l0_7 == null : bool)
  Class: Eq_178
  DataType: bool
  OrigDataType: bool
*/
typedef struct Globals {
	Eq_2 t10CB8;	// 10CB8
	char str10CF8[];	// 10CF8
	char str10D00[];	// 10D00
	ptr32 ptr20E3C;	// 20E3C
	ui32 dw20E58;	// 20E58
	word32 dw20E5C;	// 20E5C
	ptr32 ptr20E60;	// 20E60
} Eq_1;

typedef void (Eq_2)();

typedef struct Eq_7 {
	int32 dw0008;	// 8
} Eq_7;

typedef void (Eq_40)( *);

typedef void (Eq_45)(word32, word32, word32, word32, word32, word32, Eq_7 *);

typedef int32 (Eq_114)(char *);

typedef int32 (Eq_119)(char *);

typedef void (Eq_125)(Eq_7 *, word32, word32, word32, word32, word32, word32, ptr32, Eq_7 *);

typedef struct Eq_141 {
	word32 dwFFFFFFF8;	// FFFFFFF8
} Eq_141;

typedef struct Eq_155 {
	int32 dw0008;	// 8
} Eq_155;

typedef void (Eq_156)(Eq_155 *, word32, word32, word32, word32, word32, word32, ptr32, Eq_155 *);

typedef struct Eq_173 {
	<anonymous> * ptrFFFFFFFC;	// FFFFFFFC
} Eq_173;

