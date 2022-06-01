using System;
using System.Diagnostics;

// Token: 0x0200002D RID: 45
internal class 6cae0349 : beb75257
{
	// Token: 0x06000140 RID: 320 RVA: 0x000022AA File Offset: 0x000004AA
	public byte 68b53414()
	{
		return 867a1c12.cfda2bcb;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x000198E0 File Offset: 0x00017AE0
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		Type type = (Type)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a());
		bool flag = Type.GetTypeCode(type) == TypeCode.String && 1581069d2.c41a9534() == null;
		if (flag)
		{
			1581069d2.5b4f3f03(A_1.4b935237.74973c38().f3c2d292(1581069d2.95ecf24a()));
		}
		else
		{
			Debug.Assert(type.IsValueType);
			1581069d2.5b4f3f03(1581069d2.c822b8e7(type));
		}
		A_1.c544e0bc.af836684(num, 1581069d2);
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
