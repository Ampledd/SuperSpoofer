using System;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x0200008F RID: 143
[StructLayout(LayoutKind.Explicit)]
internal struct 1581069d
{
	// Token: 0x06000275 RID: 629 RVA: 0x0001F970 File Offset: 0x0001DB70
	public ulong 61f3d758()
	{
		return this.4a6d611a;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0000292F File Offset: 0x00000B2F
	public void 6535f2d7(ulong A_1)
	{
		this.4a6d611a = A_1;
		this.72b75650 = null;
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0001F988 File Offset: 0x0001DB88
	public uint 95ecf24a()
	{
		return this.4c1a9b5c;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002940 File Offset: 0x00000B40
	public void eb3abd21(uint A_1)
	{
		this.4c1a9b5c = A_1;
		this.72b75650 = null;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
	public ushort dfeb40c()
	{
		return this.54d5c8ee;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00002951 File Offset: 0x00000B51
	public void 346dffb(ushort A_1)
	{
		this.54d5c8ee = A_1;
		this.72b75650 = null;
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
	public byte 83c9551e()
	{
		return this.5896fb75;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002962 File Offset: 0x00000B62
	public void 758039e5(byte A_1)
	{
		this.5896fb75 = A_1;
		this.72b75650 = null;
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0001F9D0 File Offset: 0x0001DBD0
	public double f2602200()
	{
		return this.14373db1;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002973 File Offset: 0x00000B73
	public void 2adcad5f(double A_1)
	{
		this.14373db1 = A_1;
		this.72b75650 = null;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
	public float 44fe9b32()
	{
		return this.dfab7f0b;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002984 File Offset: 0x00000B84
	public void 5714c0e9(float A_1)
	{
		this.dfab7f0b = A_1;
		this.72b75650 = null;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0001FA00 File Offset: 0x0001DC00
	public object c41a9534()
	{
		return this.72b75650;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002995 File Offset: 0x00000B95
	public void 5b4f3f03(object A_1)
	{
		this.72b75650 = A_1;
		this.4a6d611a = 0UL;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x0001FA18 File Offset: 0x0001DC18
	public static 1581069d 99db5886(object A_0, Type A_1)
	{
		bool isEnum = A_1.IsEnum;
		1581069d result;
		if (isEnum)
		{
			Type underlyingType = Enum.GetUnderlyingType(A_1);
			result = 1581069d.99db5886(Convert.ChangeType(A_0, underlyingType), underlyingType);
		}
		else
		{
			switch (Type.GetTypeCode(A_1))
			{
			case TypeCode.Boolean:
			{
				1581069d 1581069d = new 1581069d
				{
					5896fb75 = (((bool)A_0) ? 1 : 0)
				};
				result = 1581069d;
				break;
			}
			case TypeCode.Char:
			{
				1581069d 1581069d = new 1581069d
				{
					54d5c8ee = (ushort)((char)A_0)
				};
				result = 1581069d;
				break;
			}
			case TypeCode.SByte:
			{
				1581069d 1581069d = new 1581069d
				{
					5896fb75 = (byte)((sbyte)A_0)
				};
				result = 1581069d;
				break;
			}
			case TypeCode.Byte:
			{
				1581069d 1581069d = new 1581069d
				{
					5896fb75 = (byte)A_0
				};
				result = 1581069d;
				break;
			}
			case TypeCode.Int16:
			{
				1581069d 1581069d = new 1581069d
				{
					54d5c8ee = (ushort)((short)A_0)
				};
				result = 1581069d;
				break;
			}
			case TypeCode.UInt16:
			{
				1581069d 1581069d = new 1581069d
				{
					54d5c8ee = (ushort)A_0
				};
				result = 1581069d;
				break;
			}
			case TypeCode.Int32:
			{
				1581069d 1581069d = new 1581069d
				{
					4c1a9b5c = (uint)((int)A_0)
				};
				result = 1581069d;
				break;
			}
			case TypeCode.UInt32:
			{
				1581069d 1581069d = new 1581069d
				{
					4c1a9b5c = (uint)A_0
				};
				result = 1581069d;
				break;
			}
			case TypeCode.Int64:
			{
				1581069d 1581069d = new 1581069d
				{
					4a6d611a = (ulong)((long)A_0)
				};
				result = 1581069d;
				break;
			}
			case TypeCode.UInt64:
			{
				1581069d 1581069d = new 1581069d
				{
					4a6d611a = (ulong)A_0
				};
				result = 1581069d;
				break;
			}
			case TypeCode.Single:
			{
				1581069d 1581069d = new 1581069d
				{
					dfab7f0b = (float)A_0
				};
				result = 1581069d;
				break;
			}
			case TypeCode.Double:
			{
				1581069d 1581069d = new 1581069d
				{
					14373db1 = (double)A_0
				};
				result = 1581069d;
				break;
			}
			default:
			{
				bool flag = A_0 is Pointer;
				if (flag)
				{
					1581069d 1581069d = new 1581069d
					{
						4a6d611a = Pointer.Unbox(A_0)
					};
					result = 1581069d;
				}
				else
				{
					bool flag2 = A_0 is IntPtr;
					if (flag2)
					{
						1581069d 1581069d = new 1581069d
						{
							4a6d611a = (ulong)((long)((IntPtr)A_0))
						};
						result = 1581069d;
					}
					else
					{
						bool flag3 = A_0 is UIntPtr;
						if (flag3)
						{
							1581069d 1581069d = new 1581069d
							{
								4a6d611a = (ulong)((UIntPtr)A_0)
							};
							result = 1581069d;
						}
						else
						{
							bool isValueType = A_1.IsValueType;
							if (isValueType)
							{
								1581069d 1581069d = new 1581069d
								{
									72b75650 = cdd1c92b.6cae0349(A_0, A_1)
								};
								result = 1581069d;
							}
							else
							{
								1581069d 1581069d = new 1581069d
								{
									72b75650 = A_0
								};
								result = 1581069d;
							}
						}
					}
				}
				break;
			}
			}
		}
		return result;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x000029A7 File Offset: 0x00000BA7
	public unsafe void 16edd62d(f087c8e3 A_1)
	{
		*(TypedReference*)f087c8e3.2b8998e6(A_1) = __makeref(this.4c1a9b5c);
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0001FCBC File Offset: 0x0001DEBC
	public unsafe void 143dc1a8(f087c8e3 A_1, Type A_2)
	{
		bool flag = this.72b75650 is ValueType && A_2.IsValueType;
		if (flag)
		{
			de06eb40.26446329(this.72b75650, A_1);
		}
		else
		{
			*(TypedReference*)f087c8e3.2b8998e6(A_1) = __makeref(this.72b75650);
		}
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0001FD0C File Offset: 0x0001DF0C
	public object c822b8e7(Type A_1)
	{
		bool isEnum = A_1.IsEnum;
		object result;
		if (isEnum)
		{
			result = Enum.ToObject(A_1, this.c822b8e7(Enum.GetUnderlyingType(A_1)));
		}
		else
		{
			switch (Type.GetTypeCode(A_1))
			{
			case TypeCode.Boolean:
				result = (this.5896fb75 > 0);
				break;
			case TypeCode.Char:
				result = (char)this.54d5c8ee;
				break;
			case TypeCode.SByte:
				result = (sbyte)this.5896fb75;
				break;
			case TypeCode.Byte:
				result = this.5896fb75;
				break;
			case TypeCode.Int16:
				result = (short)this.54d5c8ee;
				break;
			case TypeCode.UInt16:
				result = this.54d5c8ee;
				break;
			case TypeCode.Int32:
				result = (int)this.4c1a9b5c;
				break;
			case TypeCode.UInt32:
				result = this.4c1a9b5c;
				break;
			case TypeCode.Int64:
				result = (long)this.4a6d611a;
				break;
			case TypeCode.UInt64:
				result = this.4a6d611a;
				break;
			case TypeCode.Single:
				result = this.dfab7f0b;
				break;
			case TypeCode.Double:
				result = this.14373db1;
				break;
			default:
			{
				bool isPointer = A_1.IsPointer;
				if (isPointer)
				{
					result = Pointer.Box(this.4a6d611a, A_1);
				}
				else
				{
					bool flag = A_1 == typeof(IntPtr);
					if (flag)
					{
						result = (461c8a90.b3275caf ? new IntPtr((long)this.4a6d611a) : new IntPtr((int)this.4c1a9b5c));
					}
					else
					{
						bool flag2 = A_1 == typeof(UIntPtr);
						if (flag2)
						{
							result = (461c8a90.b3275caf ? new UIntPtr(this.4a6d611a) : new UIntPtr(this.4c1a9b5c));
						}
						else
						{
							result = cdd1c92b.8a9bd8cf(this.72b75650);
						}
					}
				}
				break;
			}
			}
		}
		return result;
	}

	// Token: 0x04000156 RID: 342
	[FieldOffset(0)]
	private ulong 4a6d611a;

	// Token: 0x04000157 RID: 343
	[FieldOffset(0)]
	private double 14373db1;

	// Token: 0x04000158 RID: 344
	[FieldOffset(0)]
	private uint 4c1a9b5c;

	// Token: 0x04000159 RID: 345
	[FieldOffset(0)]
	private float dfab7f0b;

	// Token: 0x0400015A RID: 346
	[FieldOffset(0)]
	private ushort 54d5c8ee;

	// Token: 0x0400015B RID: 347
	[FieldOffset(0)]
	private byte 5896fb75;

	// Token: 0x0400015C RID: 348
	[FieldOffset(8)]
	private object 72b75650;

	// Token: 0x0400015D RID: 349
	public static readonly 1581069d 89f2356f;
}
