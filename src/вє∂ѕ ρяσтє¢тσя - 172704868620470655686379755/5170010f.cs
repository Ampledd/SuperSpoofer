using System;

// Token: 0x02000074 RID: 116
internal class 5170010f : b8ce7618
{
	// Token: 0x0600021A RID: 538 RVA: 0x00002716 File Offset: 0x00000916
	public byte 68b53414()
	{
		return 867a1c12.f5124569;
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0001E0FC File Offset: 0x0001C2FC
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num--);
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		bool flag = 1581069d.c41a9534() is dc32a2c5;
		if (flag)
		{
			((dc32a2c5)1581069d.c41a9534()).6517fff2(A_1, 1581069d2, (7d18b560)4);
			A_2 = (e321097e)0;
			return;
		}
		throw new ExecutionEngineException();
	}
}
