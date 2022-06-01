using System;

// Token: 0x0200005C RID: 92
internal class 4db0bd78 : b8ce7618
{
	// Token: 0x060001D1 RID: 465 RVA: 0x00002596 File Offset: 0x00000796
	public byte 68b53414()
	{
		return 867a1c12.726a46a6;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0001CB18 File Offset: 0x0001AD18
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num - 1U);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		num -= 1U;
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		byte b = A_1.cd97a091[(int)867a1c12.3097c3ce].83c9551e();
		1581069d 1581069d3 = default(1581069d);
		ulong num2 = (ulong)(1581069d.95ecf24a() * 1581069d2.95ecf24a());
		1581069d3.eb3abd21((uint)num2);
		A_1.c544e0bc.af836684(num, 1581069d3);
		byte b2 = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.33db731d;
		byte b3 = 867a1c12.f3907264 | 867a1c12.8ad076d9;
		byte b4 = 0;
		bool flag = (b & 867a1c12.33db731d) > 0;
		if (flag)
		{
			bool flag2 = (num2 & (ulong)-1) > 0UL;
			if (flag2)
			{
				b4 = b3;
			}
		}
		else
		{
			num2 = (ulong)((long)(1581069d.95ecf24a() * 1581069d2.95ecf24a()));
			bool flag3 = num2 >> 63 != (ulong)(1581069d3.95ecf24a() >> 31);
			if (flag3)
			{
				b4 = b3;
			}
		}
		b = ((b & ~b3) | b4);
		b0e33cb9.6e2f8896(1581069d.95ecf24a(), 1581069d2.95ecf24a(), 1581069d3.95ecf24a(), 1581069d3.95ecf24a(), ref b, b2);
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b);
		A_2 = (e321097e)0;
	}
}
