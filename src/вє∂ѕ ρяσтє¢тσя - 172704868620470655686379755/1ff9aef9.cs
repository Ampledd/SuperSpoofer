using System;

// Token: 0x02000057 RID: 87
internal class 1ff9aef9 : b8ce7618
{
	// Token: 0x060001C2 RID: 450 RVA: 0x00002546 File Offset: 0x00000746
	public byte 68b53414()
	{
		return 867a1c12.f844bf51;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0001C5AC File Offset: 0x0001A7AC
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
			1581069d3.6535f2d7(1581069d.61f3d758() / 1581069d2.61f3d758());
		}
		else
		{
			1581069d3.6535f2d7((ulong)((int)1581069d.61f3d758() / (int)1581069d2.61f3d758()));
		}
		A_1.c544e0bc.af836684(num, 1581069d3);
		byte b2 = 867a1c12.541c9a73 | 867a1c12.fca79d36 | 867a1c12.33db731d;
		b0e33cb9.6e2f8896(1581069d.61f3d758(), 1581069d2.61f3d758(), 1581069d3.61f3d758(), 1581069d3.61f3d758(), ref b, b2);
		A_1.cd97a091[(int)867a1c12.3097c3ce].758039e5(b);
		A_2 = (e321097e)0;
	}
}
