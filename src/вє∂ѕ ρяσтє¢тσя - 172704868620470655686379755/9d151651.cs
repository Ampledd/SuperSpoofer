using System;

// Token: 0x0200006E RID: 110
internal class 9d151651 : b8ce7618
{
	// Token: 0x06000208 RID: 520 RVA: 0x000026B6 File Offset: 0x000008B6
	public byte 68b53414()
	{
		return 867a1c12.4114487b;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0001DCEC File Offset: 0x0001BEEC
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num);
		bool flag = 1581069d.c41a9534() is dc32a2c5;
		if (flag)
		{
			1581069d 1581069d2 = ((dc32a2c5)1581069d.c41a9534()).4109351f(A_1, (7d18b560)4);
			A_1.c544e0bc.af836684(num, 1581069d2);
			A_2 = (e321097e)0;
			return;
		}
		throw new ExecutionEngineException();
	}
}
