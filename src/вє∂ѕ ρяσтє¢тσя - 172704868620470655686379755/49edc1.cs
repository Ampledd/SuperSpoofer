using System;

// Token: 0x0200005E RID: 94
internal class 49edc1 : b8ce7618
{
	// Token: 0x060001D8 RID: 472 RVA: 0x000025B6 File Offset: 0x000007B6
	public byte 68b53414()
	{
		return 867a1c12.5f2c74c8;
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0001CE80 File Offset: 0x0001B080
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num - 1U);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		num -= 1U;
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		1581069d 1581069d3 = default(1581069d);
		1581069d3.5714c0e9(1581069d2.44fe9b32() * 1581069d.44fe9b32());
		A_1.c544e0bc.af836684(num, 1581069d3);
		byte b = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.33db731d;
		byte b2 = A_1.cd97a091[(int)867a1c12.3097c3ce].83c9551e() & ~b;
		bool flag = 1581069d3.44fe9b32() == 0f;
		if (flag)
		{
			b2 |= 867a1c12.541c9a73;
		}
		else
		{
			bool flag2 = 1581069d3.44fe9b32() < 0f;
			if (flag2)
			{
				b2 |= 867a1c12.fca79d36;
			}
		}
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b2);
		A_2 = (e321097e)0;
	}
}
