using System;

// Token: 0x02000065 RID: 101
internal class bf736a52 : b8ce7618
{
	// Token: 0x060001ED RID: 493 RVA: 0x00002626 File Offset: 0x00000826
	public byte 68b53414()
	{
		return 867a1c12.379c6d70;
	}

	// Token: 0x060001EE RID: 494 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num - 1U);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		num -= 1U;
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		1581069d 1581069d3 = default(1581069d);
		1581069d3.5714c0e9(1581069d2.44fe9b32() % 1581069d.44fe9b32());
		A_1.c544e0bc.af836684(num, 1581069d3);
		byte b = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.8ad076d9 | 867a1c12.f3907264;
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
