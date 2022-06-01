using System;

// Token: 0x0200003A RID: 58
internal class 8a9bd8cf : beb75257
{
	// Token: 0x06000167 RID: 359 RVA: 0x0000237A File Offset: 0x0000057A
	public byte 68b53414()
	{
		return 867a1c12.fec90eae;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0001A63C File Offset: 0x0001883C
	public unsafe void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		bool flag = (1581069d.95ecf24a() & 2147483648U) > 0U;
		Type type = (Type)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a() & 2147483647U);
		bool flag2 = flag;
		if (flag2)
		{
			TypedReference typedReference;
			de06eb40.26446329(1581069d2.c41a9534(), f087c8e3.2b8998e6((void*)(&typedReference)));
			c9a038a7 c9a038a = new c9a038a7(typedReference);
			1581069d2 = 1581069d.99db5886(1581069d2.c41a9534(), type);
			A_1.c544e0bc.af836684(num, 1581069d2);
		}
		else
		{
			bool flag3 = type == typeof(object) && 1581069d2.c41a9534() != null;
			if (flag3)
			{
				type = 1581069d2.c41a9534().GetType();
			}
			1581069d2 = 1581069d.99db5886(1581069d2.c41a9534(), type);
			A_1.c544e0bc.af836684(num, 1581069d2);
		}
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
