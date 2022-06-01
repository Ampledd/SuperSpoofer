using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200008E RID: 142
internal static class a4d544eb
{
	// Token: 0x0600026B RID: 619 RVA: 0x0001EEAC File Offset: 0x0001D0AC
	public static e321097e 9a70f6ec(33cd5b0d A_0)
	{
		e321097e e321097e = (e321097e)0;
		bool flag = true;
		do
		{
			try
			{
				e321097e = a4d544eb.4fac154e(A_0);
				e321097e e321097e2 = e321097e;
				if (e321097e2 != (e321097e)2)
				{
					if (e321097e2 == (e321097e)3)
					{
						uint num = A_0.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
						1581069d 1581069d = A_0.c544e0bc.cb15379(num--);
						A_0.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
						a4d544eb.62a241b0(A_0, 1581069d.c41a9534());
						return e321097e;
					}
				}
				else
				{
					uint num2 = A_0.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
					1581069d 1581069d2 = A_0.c544e0bc.cb15379(num2--);
					A_0.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num2);
					a4d544eb.e288c662(A_0, 1581069d2.c41a9534());
				}
				flag = false;
			}
			catch (object ex)
			{
				a4d544eb.ed471c55(A_0, ex);
				flag = false;
			}
			finally
			{
				bool flag2 = flag;
				if (flag2)
				{
					a4d544eb.2e5657e4(A_0);
					e321097e = (e321097e)1;
				}
				else
				{
					bool flag3 = A_0.d796777a.Count > 0;
					if (flag3)
					{
						do
						{
							a4d544eb.9bfe1259(A_0, ref e321097e);
						}
						while (e321097e == (e321097e)3);
					}
				}
			}
		}
		while (e321097e != (e321097e)1);
		return e321097e;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0001F010 File Offset: 0x0001D210
	private static e321097e 4fac154e(33cd5b0d A_0)
	{
		e321097e e321097e;
		bool flag2;
		do
		{
			byte b = A_0.9468c108();
			byte b2 = A_0.9468c108();
			944ddc58.e02f5101(b).9a70f6ec(A_0, out e321097e);
			bool flag = A_0.cd97a091[(int)867a1c12.6e2e8d6b].61f3d758() == 1UL;
			if (flag)
			{
				e321097e = (e321097e)1;
			}
			flag2 = (e321097e > (e321097e)0);
		}
		while (!flag2);
		return e321097e;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0001F074 File Offset: 0x0001D274
	private static void ed471c55(33cd5b0d A_0, object A_1)
	{
		bool flag = A_0.d796777a.Count != 0;
		2b68c716 2b68c;
		if (flag)
		{
			2b68c = A_0.d796777a[A_0.d796777a.Count - 1];
			bool flag2 = 2b68c.a139d37d != null;
			if (flag2)
			{
				bool flag3 = 2b68c.1dd77eb8 == (2b68c716.9bc5addb)0;
				if (flag3)
				{
					A_0.cd97a091[(int)867a1c12.b1f32914].758039e5(0);
				}
				else
				{
					bool flag4 = 2b68c.1dd77eb8 == (2b68c716.9bc5addb)1;
					if (flag4)
					{
						2b68c.fcd5b2b7 = A_1;
					}
				}
				return;
			}
		}
		2b68c = new 2b68c716
		{
			85a4e801 = A_0.cd97a091[(int)867a1c12.98ef7511],
			6258216c = A_0.cd97a091[(int)867a1c12.d7e5ab3c],
			fcd5b2b7 = A_1,
			1dd77eb8 = (2b68c716.9bc5addb)0,
			a139d37d = null,
			ac5cf0aa = null
		};
		A_0.d796777a.Add(2b68c);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0001F164 File Offset: 0x0001D364
	private static void 62a241b0(33cd5b0d A_0, object A_1)
	{
		bool flag = A_0.d796777a.Count > 0;
		if (flag)
		{
			a4d544eb.ed471c55(A_0, A_1);
		}
		else
		{
			a4d544eb.e288c662(A_0, A_1);
		}
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0001F198 File Offset: 0x0001D398
	private static string 4f08694f(33cd5b0d A_0)
	{
		uint num = A_0.cd97a091[(int)867a1c12.6e2e8d6b].61f3d758() - A_0.4b935237.74973c38().aa571bc5();
		uint num2 = A_0.cd97a091[(int)867a1c12.98ef7511].95ecf24a();
		StringBuilder stringBuilder = new StringBuilder();
		do
		{
			a4d544eb.9bc61eb6 = a4d544eb.9bc61eb6 * 1664525U + 1013904223U;
			ulong num3 = (ulong)(a4d544eb.9bc61eb6 | 1U);
			stringBuilder.AppendFormat("|{0:x16}", (ulong)num * num3 << 32 | (num3 & 18446744073709551614UL));
			bool flag = num2 > 1U;
			if (!flag)
			{
				break;
			}
			num = A_0.c544e0bc.cb15379(num2 - 1U).61f3d758() - A_0.4b935237.74973c38().aa571bc5();
			2554693f 2554693f = A_0.c544e0bc.cb15379(num2).c41a9534() as 2554693f;
			bool flag2 = 2554693f == null;
			if (flag2)
			{
				break;
			}
			num2 = 2554693f.ace6592();
		}
		while (num2 > 0U);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0001F2BC File Offset: 0x0001D4BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e288c662(33cd5b0d A_0, object A_1)
	{
		bool flag = A_1 is Exception;
		if (flag)
		{
			9aa017f.5405cbd4((Exception)A_1, null);
		}
		throw A_1;
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
	private static void 9bfe1259(33cd5b0d A_0, ref e321097e A_1)
	{
		2b68c716 2b68c = A_0.d796777a[A_0.d796777a.Count - 1];
		2b68c716.9bc5addb 1dd77eb = 2b68c.1dd77eb8;
		int? a139d37d;
		if (1dd77eb == (2b68c716.9bc5addb)0)
		{
			bool flag = 2b68c.a139d37d != null;
			if (flag)
			{
				bool flag2 = A_0.cd97a091[(int)867a1c12.b1f32914].83c9551e() > 0;
				bool flag3 = flag2;
				if (flag3)
				{
					2b68c.1dd77eb8 = (2b68c716.9bc5addb)1;
					2b68c.ac5cf0aa = 2b68c.a139d37d;
					2b68c.a139d37d = new int?(A_0.5c71f0c7.Count);
					A_1 = (e321097e)0;
					goto IL_31F;
				}
				2b68c.a139d37d--;
			}
			else
			{
				2b68c.a139d37d = new int?(A_0.5c71f0c7.Count - 1);
			}
			Type type = 2b68c.fcd5b2b7.GetType();
			int num;
			a0c9cd35 a0c9cd;
			for (;;)
			{
				a139d37d = 2b68c.a139d37d;
				num = 0;
				if (!(a139d37d.GetValueOrDefault() >= num & a139d37d != null) || 2b68c.ac5cf0aa != null)
				{
					goto IL_29D;
				}
				a0c9cd = A_0.5c71f0c7[2b68c.a139d37d.Value];
				bool flag4 = a0c9cd.d89e7d10 == 867a1c12.f332c7d;
				if (flag4)
				{
					break;
				}
				bool flag5 = a0c9cd.d89e7d10 == 867a1c12.62e24416;
				if (flag5)
				{
					bool flag6 = a0c9cd.b07e6139.IsAssignableFrom(type);
					if (flag6)
					{
						goto Block_8;
					}
				}
				2b68c.a139d37d--;
			}
			uint num2 = 2b68c.6258216c.95ecf24a();
			A_0.c544e0bc.83d7c013(num2 += 1U);
			f6dce402 c544e0bc = A_0.c544e0bc;
			uint num3 = num2;
			1581069d 1581069d = default(1581069d);
			1581069d.5b4f3f03(2b68c.fcd5b2b7);
			c544e0bc.af836684(num3, 1581069d);
			A_0.cd97a091[(int)867a1c12.4b45f8d5].758039e5(0);
			A_0.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num2);
			A_0.cd97a091[(int)867a1c12.98ef7511] = a0c9cd.c279944;
			A_0.cd97a091[(int)867a1c12.6e2e8d6b].6535f2d7(a0c9cd.98dfad2f);
			goto IL_29D;
			Block_8:
			2b68c.1dd77eb8 = (2b68c716.9bc5addb)1;
			2b68c.ac5cf0aa = 2b68c.a139d37d;
			2b68c.a139d37d = new int?(A_0.5c71f0c7.Count);
			goto IL_31F;
			IL_29D:
			a139d37d = 2b68c.a139d37d;
			num = -1;
			bool flag7 = (a139d37d.GetValueOrDefault() == num & a139d37d != null) && 2b68c.ac5cf0aa == null;
			if (flag7)
			{
				A_0.d796777a.RemoveAt(A_0.d796777a.Count - 1);
				A_1 = (e321097e)3;
				bool flag8 = A_0.d796777a.Count == 0;
				if (flag8)
				{
					a4d544eb.62a241b0(A_0, 2b68c.fcd5b2b7);
				}
			}
			else
			{
				A_1 = (e321097e)0;
			}
			return;
		}
		if (1dd77eb != (2b68c716.9bc5addb)1)
		{
			throw new ExecutionEngineException();
		}
		IL_31F:
		2b68c.a139d37d--;
		int i;
		for (i = 2b68c.a139d37d.Value; i > 2b68c.ac5cf0aa.Value; i--)
		{
			a0c9cd35 a0c9cd2 = A_0.5c71f0c7[i];
			A_0.5c71f0c7.RemoveAt(i);
			bool flag9 = a0c9cd2.d89e7d10 == 867a1c12.bdf703b8 || a0c9cd2.d89e7d10 == 867a1c12.aa6d73b7;
			if (flag9)
			{
				a4d544eb.931a41f3(A_0, a0c9cd2);
				break;
			}
		}
		2b68c.a139d37d = new int?(i);
		a139d37d = 2b68c.a139d37d;
		int? ac5cf0aa = 2b68c.ac5cf0aa;
		bool flag10 = a139d37d.GetValueOrDefault() == ac5cf0aa.GetValueOrDefault() & a139d37d != null == (ac5cf0aa != null);
		if (flag10)
		{
			a0c9cd35 a0c9cd3 = A_0.5c71f0c7[2b68c.ac5cf0aa.Value];
			A_0.5c71f0c7.RemoveAt(2b68c.ac5cf0aa.Value);
			uint num4 = a0c9cd3.9926d3d3.95ecf24a();
			a0c9cd3.9926d3d3.eb3abd21(num4 + 1U);
			A_0.c544e0bc.83d7c013(a0c9cd3.9926d3d3.95ecf24a());
			f6dce402 c544e0bc2 = A_0.c544e0bc;
			uint num5 = a0c9cd3.9926d3d3.95ecf24a();
			1581069d 1581069d = default(1581069d);
			1581069d.5b4f3f03(2b68c.fcd5b2b7);
			c544e0bc2.af836684(num5, 1581069d);
			A_0.cd97a091[(int)867a1c12.4b45f8d5].758039e5(0);
			A_0.cd97a091[(int)867a1c12.d7e5ab3c] = a0c9cd3.9926d3d3;
			A_0.cd97a091[(int)867a1c12.98ef7511] = a0c9cd3.c279944;
			A_0.cd97a091[(int)867a1c12.6e2e8d6b].6535f2d7(a0c9cd3.86278c2);
			A_0.d796777a.RemoveAt(A_0.d796777a.Count - 1);
		}
		A_1 = (e321097e)0;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0001F820 File Offset: 0x0001DA20
	private static void 2e5657e4(33cd5b0d A_0)
	{
		1581069d 1581069d = A_0.cd97a091[(int)867a1c12.98ef7511];
		1581069d 1581069d2 = A_0.cd97a091[(int)867a1c12.d7e5ab3c];
		for (int i = A_0.5c71f0c7.Count - 1; i >= 0; i--)
		{
			a0c9cd35 a0c9cd = A_0.5c71f0c7[i];
			bool flag = a0c9cd.d89e7d10 == 867a1c12.bdf703b8 || a0c9cd.d89e7d10 == 867a1c12.aa6d73b7;
			if (flag)
			{
				a4d544eb.931a41f3(A_0, a0c9cd);
				a4d544eb.9a70f6ec(A_0);
			}
		}
		A_0.5c71f0c7.Clear();
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
	private static void 931a41f3(33cd5b0d A_0, a0c9cd35 A_1)
	{
		uint num = A_1.9926d3d3.95ecf24a();
		A_1.9926d3d3.eb3abd21(num + 1U);
		A_0.cd97a091[(int)867a1c12.4b45f8d5].758039e5(0);
		A_0.cd97a091[(int)867a1c12.d7e5ab3c] = A_1.9926d3d3;
		A_0.cd97a091[(int)867a1c12.98ef7511] = A_1.c279944;
		A_0.cd97a091[(int)867a1c12.6e2e8d6b].6535f2d7(A_1.86278c2);
		f6dce402 c544e0bc = A_0.c544e0bc;
		uint num2 = A_1.9926d3d3.95ecf24a();
		1581069d 1581069d = default(1581069d);
		1581069d.6535f2d7(1UL);
		c544e0bc.af836684(num2, 1581069d);
	}

	// Token: 0x04000155 RID: 341
	private static uint 9bc61eb6 = (uint)Environment.TickCount;
}
