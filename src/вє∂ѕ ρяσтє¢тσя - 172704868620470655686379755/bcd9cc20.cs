using System;

// Token: 0x02000063 RID: 99
internal class bcd9cc20 : b8ce7618
{
	// Token: 0x060001E7 RID: 487 RVA: 0x00002606 File Offset: 0x00000806
	public byte 68b53414()
	{
		return 867a1c12.ee627b0e;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0001D388 File Offset: 0x0001B588
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
		bool flag = (b & 867a1c12.33db731d) > 0;
		if (flag)
		{
			1581069d3.eb3abd21(1581069d.95ecf24a() % 1581069d2.95ecf24a());
		}
		else
		{
			1581069d3.eb3abd21(1581069d.95ecf24a() % 1581069d2.95ecf24a());
		}
		A_1.c544e0bc.af836684(num, 1581069d3);
		byte b2 = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.33db731d;
		b0e33cb9.6e2f8896(1581069d.95ecf24a(), 1581069d2.95ecf24a(), 1581069d3.95ecf24a(), 1581069d3.95ecf24a(), ref b, b2);
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b);
		A_2 = (e321097e)0;
	}
}
