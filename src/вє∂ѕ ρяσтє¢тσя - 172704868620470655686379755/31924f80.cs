using System;

// Token: 0x02000044 RID: 68
internal class 31924f80 : b8ce7618
{
	// Token: 0x06000189 RID: 393 RVA: 0x00002410 File Offset: 0x00000610
	public byte 68b53414()
	{
		return 867a1c12.54722a6a;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0001B78C File Offset: 0x0001998C
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num - 1U);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		num -= 2U;
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		float num2 = 1581069d.44fe9b32() - 1581069d2.44fe9b32();
		byte b = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.8ad076d9 | 867a1c12.f3907264;
		byte b2 = A_1.cd97a091[(int)867a1c12.3097c3ce].83c9551e() & ~b;
		bool flag = num2 == 0f;
		if (flag)
		{
			b2 |= 867a1c12.541c9a73;
		}
		else
		{
			bool flag2 = num2 < 0f;
			if (flag2)
			{
				b2 |= 867a1c12.fca79d36;
			}
		}
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b2);
		A_2 = (e321097e)0;
	}
}
