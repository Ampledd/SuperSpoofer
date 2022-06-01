using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200008B RID: 139
internal class 2554693f : dc32a2c5
{
	// Token: 0x0600025F RID: 607 RVA: 0x000028AA File Offset: 0x00000AAA
	public 2554693f(uint A_1)
	{
		this.f0a447c9(A_1);
	}

	// Token: 0x06000260 RID: 608 RVA: 0x000028BC File Offset: 0x00000ABC
	public uint ace6592()
	{
		return this.ec01ae94;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x000028C4 File Offset: 0x00000AC4
	public void f0a447c9(uint A_1)
	{
		this.ec01ae94 = A_1;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
	public 1581069d 4109351f(33cd5b0d A_1, 7d18b560 A_2)
	{
		1581069d result = A_1.c544e0bc.cb15379(this.ace6592());
		bool flag = A_2 == (7d18b560)0;
		if (flag)
		{
			result.6535f2d7((ulong)result.83c9551e());
		}
		else
		{
			bool flag2 = A_2 == (7d18b560)1;
			if (flag2)
			{
				result.6535f2d7((ulong)result.dfeb40c());
			}
			else
			{
				bool flag3 = A_2 == (7d18b560)2;
				if (flag3)
				{
					result.6535f2d7((ulong)result.95ecf24a());
				}
				else
				{
					bool flag4 = result.c41a9534() is 48621248;
					if (flag4)
					{
						result.5b4f3f03(((48621248)result.c41a9534()).c6601aba());
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0001ED4C File Offset: 0x0001CF4C
	public void 6517fff2(33cd5b0d A_1, 1581069d A_2, 7d18b560 A_3)
	{
		bool flag = A_3 == (7d18b560)0;
		if (flag)
		{
			A_2.6535f2d7((ulong)A_2.83c9551e());
		}
		else
		{
			bool flag2 = A_3 == (7d18b560)1;
			if (flag2)
			{
				A_2.6535f2d7((ulong)A_2.dfeb40c());
			}
			else
			{
				bool flag3 = A_3 == (7d18b560)2;
				if (flag3)
				{
					A_2.6535f2d7((ulong)A_2.95ecf24a());
				}
			}
		}
		A_1.c544e0bc.af836684(this.ace6592(), A_2);
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0001EDBC File Offset: 0x0001CFBC
	public dc32a2c5 ed435ea9(uint A_1)
	{
		return new 2554693f(this.ace6592() + A_1);
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0001EDDC File Offset: 0x0001CFDC
	public dc32a2c5 ed435ea9(ulong A_1)
	{
		return new 2554693f(this.ace6592() + (uint)A_1);
	}

	// Token: 0x06000266 RID: 614 RVA: 0x000028CD File Offset: 0x00000ACD
	public void 5f1317f4(33cd5b0d A_1, f087c8e3 A_2, Type A_3)
	{
		A_1.c544e0bc.5f1317f4(this.ace6592(), A_2, A_3);
	}

	// Token: 0x0400014E RID: 334
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private uint ec01ae94;
}
