using System;

// Token: 0x02000046 RID: 70
internal class 7978a4b2 : b8ce7618
{
	// Token: 0x0600018F RID: 399 RVA: 0x00002430 File Offset: 0x00000630
	public byte 68b53414()
	{
		return 867a1c12.fba9763d;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0001B994 File Offset: 0x00019B94
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num - 1U);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		num -= 2U;
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		bool flag = 1581069d.c41a9534() == 1581069d2.c41a9534();
		int num2;
		if (flag)
		{
			num2 = 0;
		}
		else
		{
			num2 = -1;
		}
		byte b = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.8ad076d9 | 867a1c12.f3907264;
		byte b2 = A_1.cd97a091[(int)867a1c12.3097c3ce].83c9551e() & ~b;
		bool flag2 = num2 == 0;
		if (flag2)
		{
			b2 |= 867a1c12.541c9a73;
		}
		else
		{
			bool flag3 = num2 < 0;
			if (flag3)
			{
				b2 |= 867a1c12.fca79d36;
			}
		}
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b2);
		A_2 = (e321097e)0;
	}
}
