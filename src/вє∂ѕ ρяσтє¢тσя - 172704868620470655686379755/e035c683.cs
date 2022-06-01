using System;

// Token: 0x02000049 RID: 73
internal class e035c683 : b8ce7618
{
	// Token: 0x06000198 RID: 408 RVA: 0x00002460 File Offset: 0x00000660
	public byte 68b53414()
	{
		return 867a1c12.8f2a8be1;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0001BBA4 File Offset: 0x00019DA4
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num);
		double num2 = 1581069d.f2602200();
		1581069d.6535f2d7((ulong)((long)num2));
		byte b = A_1.cd97a091[(int)867a1c12.3097c3ce].83c9551e() & ~867a1c12.8ad076d9;
		bool flag = (b & 867a1c12.33db731d) > 0;
		if (flag)
		{
			bool flag2 = num2 <= -1.0 || num2 >= 1.8446744073709552E+19;
			if (flag2)
			{
				b |= 867a1c12.8ad076d9;
			}
			bool flag3 = num2 >= 9.2233720368547758E+18;
			if (flag3)
			{
				1581069d.6535f2d7((ulong)((double)((long)num2) - 9.2233720368547758E+18) + 9223372036854775808UL);
			}
		}
		else
		{
			bool flag4 = num2 <= -9.2233720368547779E+18 || num2 >= 9.2233720368547758E+18;
			if (flag4)
			{
				b |= 867a1c12.8ad076d9;
			}
		}
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b & ~867a1c12.33db731d);
		A_1.c544e0bc.af836684(num, 1581069d);
		A_2 = (e321097e)0;
	}
}
