using System;

// Token: 0x0200007A RID: 122
internal class 7a4f305d : b8ce7618
{
	// Token: 0x0600022C RID: 556 RVA: 0x00002776 File Offset: 0x00000976
	public byte 68b53414()
	{
		return 867a1c12.6a3ae428;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0001E4E4 File Offset: 0x0001C6E4
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num);
		A_1.c544e0bc.83d7c013(num -= 1U);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		byte b = A_1.9468c108();
		bool flag = (b == 867a1c12.d7e5ab3c || b == 867a1c12.98ef7511) && 1581069d.c41a9534() is 2554693f;
		if (flag)
		{
			1581069d[] cd97a = A_1.cd97a091;
			int num2 = (int)b;
			1581069d 1581069d2 = default(1581069d);
			1581069d2.eb3abd21(((2554693f)1581069d.c41a9534()).ace6592());
			cd97a[num2] = 1581069d2;
		}
		else
		{
			A_1.cd97a091[(int)b] = 1581069d;
		}
		A_2 = (e321097e)0;
	}
}
