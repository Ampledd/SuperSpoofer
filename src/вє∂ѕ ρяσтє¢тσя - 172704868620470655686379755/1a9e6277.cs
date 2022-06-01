using System;

// Token: 0x0200005D RID: 93
internal class 1a9e6277 : b8ce7618
{
	// Token: 0x060001D4 RID: 468 RVA: 0x000025A6 File Offset: 0x000007A6
	public byte 68b53414()
	{
		return 867a1c12.4a30adcd;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0001CC94 File Offset: 0x0001AE94
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
		ulong num2 = 1581069d.61f3d758() * 1581069d2.61f3d758();
		1581069d3.6535f2d7(num2);
		A_1.c544e0bc.af836684(num, 1581069d3);
		byte b2 = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.33db731d;
		byte b3 = 867a1c12.f3907264 | 867a1c12.8ad076d9;
		byte b4 = 0;
		bool flag = (b & 867a1c12.33db731d) > 0;
		if (flag)
		{
			bool flag2 = 1a9e6277.4f545d6a(1581069d.61f3d758(), 1581069d2.61f3d758()) > 0UL;
			if (flag2)
			{
				b4 = b3;
			}
		}
		else
		{
			bool flag3 = num2 >> 63 != (1581069d.61f3d758() ^ 1581069d2.61f3d758()) >> 63;
			if (flag3)
			{
				b4 = b3;
			}
		}
		b = ((b & ~b3) | b4);
		b0e33cb9.6e2f8896((ulong)1581069d.95ecf24a(), 1581069d2.61f3d758(), 1581069d3.61f3d758(), 1581069d3.61f3d758(), ref b, b2);
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b);
		A_2 = (e321097e)0;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0001CE14 File Offset: 0x0001B014
	private static ulong 4f545d6a(ulong A_0, ulong A_1)
	{
		ulong num = A_0 & (ulong)-1;
		ulong num2 = A_0 >> 32;
		ulong num3 = A_1 & (ulong)-1;
		ulong num4 = A_1 >> 32;
		ulong num5 = num * num3;
		ulong num6 = num5 & (ulong)-1;
		num5 = num2 * num3 + (num5 >> 32);
		ulong num7 = num5 & (ulong)-1;
		ulong num8 = num5 >> 32;
		num5 = num7 + num * num4;
		num7 = (num5 & (ulong)-1);
		return num8 + num2 * num4 + (num5 >> 32);
	}
}
