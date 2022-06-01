using System;

// Token: 0x0200002E RID: 46
internal class d6569063 : beb75257
{
	// Token: 0x06000143 RID: 323 RVA: 0x000022BA File Offset: 0x000004BA
	public byte 68b53414()
	{
		return 867a1c12.5eddecf2;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x000199D4 File Offset: 0x00017BD4
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		bool flag = (1581069d.95ecf24a() & 2147483648U) > 0U;
		Type type = (Type)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a() & 2147483647U);
		bool flag2 = Type.GetTypeCode(type) == TypeCode.String && 1581069d2.c41a9534() == null;
		if (flag2)
		{
			1581069d2.5b4f3f03(A_1.4b935237.74973c38().f3c2d292(1581069d2.95ecf24a()));
		}
		else
		{
			bool flag3 = 1581069d2.c41a9534() == null;
			if (flag3)
			{
				1581069d2.5b4f3f03(null);
			}
			else
			{
				bool flag4 = !type.IsInstanceOfType(1581069d2.c41a9534());
				if (flag4)
				{
					1581069d2.5b4f3f03(null);
					bool flag5 = flag;
					if (flag5)
					{
						throw new InvalidCastException();
					}
				}
			}
		}
		A_1.c544e0bc.af836684(num, 1581069d2);
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
