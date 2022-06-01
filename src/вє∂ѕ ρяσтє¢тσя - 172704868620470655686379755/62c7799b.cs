using System;

// Token: 0x02000060 RID: 96
internal class 62c7799b : b8ce7618
{
	// Token: 0x060001DE RID: 478 RVA: 0x000025D6 File Offset: 0x000007D6
	public byte 68b53414()
	{
		return 867a1c12.81302ade;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		ulong num2 = A_1.c544e0bc.cb15379(num--).61f3d758();
		int index = A_1.5c71f0c7.Count - 1;
		a0c9cd35 a0c9cd = A_1.5c71f0c7[index];
		bool flag = a0c9cd.86278c2 != num2;
		if (flag)
		{
			throw new InvalidProgramException();
		}
		A_1.5c71f0c7.RemoveAt(index);
		bool flag2 = a0c9cd.d89e7d10 == 867a1c12.aa6d73b7;
		if (flag2)
		{
			A_1.c544e0bc.af836684(num += 1U, A_1.cd97a091[(int)867a1c12.6e2e8d6b]);
			A_1.cd97a091[(int)867a1c12.4b45f8d5].758039e5(0);
			A_1.cd97a091[(int)867a1c12.6e2e8d6b].6535f2d7(a0c9cd.86278c2);
		}
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
