﻿using System;

// Token: 0x0200006F RID: 111
internal class cb4e5b7c : b8ce7618
{
	// Token: 0x0600020B RID: 523 RVA: 0x000026C6 File Offset: 0x000008C6
	public byte 68b53414()
	{
		return 867a1c12.a8fc1e8c;
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0001DD60 File Offset: 0x0001BF60
	public unsafe void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num);
		bool flag = 1581069d.c41a9534() is dc32a2c5;
		1581069d 1581069d2;
		if (flag)
		{
			1581069d2 = ((dc32a2c5)1581069d.c41a9534()).4109351f(A_1, 461c8a90.b3275caf ? ((7d18b560)3) : ((7d18b560)2));
		}
		else
		{
			bool b3275caf = 461c8a90.b3275caf;
			if (b3275caf)
			{
				ulong* ptr = 1581069d.61f3d758();
				1581069d 1581069d3 = default(1581069d);
				1581069d3.6535f2d7(*ptr);
				1581069d2 = 1581069d3;
			}
			else
			{
				uint* ptr2 = 1581069d.61f3d758();
				1581069d 1581069d3 = default(1581069d);
				1581069d3.eb3abd21(*ptr2);
				1581069d2 = 1581069d3;
			}
		}
		A_1.c544e0bc.af836684(num, 1581069d2);
		A_2 = (e321097e)0;
	}
}
