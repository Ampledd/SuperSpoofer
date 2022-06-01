using System;

// Token: 0x0200002F RID: 47
internal class b606ba66 : beb75257
{
	// Token: 0x06000146 RID: 326 RVA: 0x000022CA File Offset: 0x000004CA
	public byte 68b53414()
	{
		return 867a1c12.9dbe67a9;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00019B10 File Offset: 0x00017D10
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		byte b = A_1.cd97a091[(int)867a1c12.3097c3ce].83c9551e();
		bool flag = (b & 867a1c12.33db731d) > 0;
		if (flag)
		{
			float f = 1581069d.44fe9b32();
			bool flag2 = float.IsNaN(f) || float.IsInfinity(f);
			if (flag2)
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d = 1581069d.f2602200();
			bool flag3 = double.IsNaN(d) || double.IsInfinity(d);
			if (flag3)
			{
				throw new ArithmeticException();
			}
		}
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
