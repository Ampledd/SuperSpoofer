using System;
using System.Runtime.Serialization;

// Token: 0x02000034 RID: 52
internal class 2258cc11 : beb75257
{
	// Token: 0x06000155 RID: 341 RVA: 0x0000231A File Offset: 0x0000051A
	public byte 68b53414()
	{
		return 867a1c12.27dce646;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00019E20 File Offset: 0x00018020
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num--);
		Type type = (Type)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a());
		bool flag = 1581069d2.c41a9534() is dc32a2c5;
		if (flag)
		{
			dc32a2c5 dc32a2c = (dc32a2c5)1581069d2.c41a9534();
			1581069d 1581069d3 = default(1581069d);
			bool isValueType = type.IsValueType;
			if (isValueType)
			{
				object obj = null;
				bool flag2 = Nullable.GetUnderlyingType(type) == null;
				if (flag2)
				{
					obj = FormatterServices.GetUninitializedObject(type);
				}
				1581069d3.5b4f3f03(cdd1c92b.6cae0349(obj, type));
			}
			else
			{
				1581069d3.5b4f3f03(null);
			}
			dc32a2c.6517fff2(A_1, 1581069d3, (7d18b560)4);
			A_1.c544e0bc.83d7c013(num);
			A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
			A_2 = (e321097e)0;
			return;
		}
		throw new NotSupportedException();
	}
}
