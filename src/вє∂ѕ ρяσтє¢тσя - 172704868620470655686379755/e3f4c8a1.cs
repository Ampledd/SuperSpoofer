using System;

// Token: 0x0200003F RID: 63
internal class e3f4c8a1 : b8ce7618
{
	// Token: 0x0600017A RID: 378 RVA: 0x000023C0 File Offset: 0x000005C0
	public byte 68b53414()
	{
		return 867a1c12.2e31f1ff;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0001B1FC File Offset: 0x000193FC
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num - 1U);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		num -= 1U;
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		1581069d 1581069d3 = default(1581069d);
		bool flag = 1581069d.c41a9534() is dc32a2c5;
		if (flag)
		{
			1581069d3.5b4f3f03(((dc32a2c5)1581069d.c41a9534()).ed435ea9(1581069d2.61f3d758()));
		}
		else
		{
			bool flag2 = 1581069d2.c41a9534() is dc32a2c5;
			if (flag2)
			{
				1581069d3.5b4f3f03(((dc32a2c5)1581069d2.c41a9534()).ed435ea9(1581069d.61f3d758()));
			}
			else
			{
				1581069d3.6535f2d7(1581069d2.61f3d758() + 1581069d.61f3d758());
			}
		}
		A_1.c544e0bc.af836684(num, 1581069d3);
		byte b = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.8ad076d9 | 867a1c12.f3907264;
		byte b2 = A_1.cd97a091[(int)867a1c12.3097c3ce].83c9551e();
		b0e33cb9.6e2f8896(1581069d.61f3d758(), 1581069d2.61f3d758(), 1581069d3.61f3d758(), 1581069d3.61f3d758(), ref b2, b);
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b2);
		A_2 = (e321097e)0;
	}
}
