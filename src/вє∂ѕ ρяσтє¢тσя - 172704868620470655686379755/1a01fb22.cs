using System;

// Token: 0x02000075 RID: 117
internal class 1a01fb22 : b8ce7618
{
	// Token: 0x0600021D RID: 541 RVA: 0x00002726 File Offset: 0x00000926
	public byte 68b53414()
	{
		return 867a1c12.eea191b2;
	}

	// Token: 0x0600021E RID: 542 RVA: 0x0001E19C File Offset: 0x0001C39C
	public unsafe void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num--);
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		bool flag = 1581069d.c41a9534() is dc32a2c5;
		if (flag)
		{
			((dc32a2c5)1581069d.c41a9534()).6517fff2(A_1, 1581069d2, 461c8a90.b3275caf ? ((7d18b560)3) : ((7d18b560)2));
		}
		else
		{
			bool b3275caf = 461c8a90.b3275caf;
			if (b3275caf)
			{
				ulong* ptr = 1581069d.61f3d758();
				*ptr = 1581069d2.61f3d758();
			}
			else
			{
				uint* ptr2 = 1581069d.61f3d758();
				*ptr2 = 1581069d2.95ecf24a();
			}
		}
		A_2 = (e321097e)0;
	}
}
