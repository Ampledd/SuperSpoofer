using System;
using System.Reflection;

// Token: 0x02000039 RID: 57
internal class 796b0f30 : beb75257
{
	// Token: 0x06000164 RID: 356 RVA: 0x0000236A File Offset: 0x0000056A
	public byte 68b53414()
	{
		return 867a1c12.c33c88ed;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0001A4C0 File Offset: 0x000186C0
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		bool flag = (1581069d.95ecf24a() & 2147483648U) > 0U;
		FieldInfo fieldInfo = (FieldInfo)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a() & 2147483647U);
		bool flag2 = !fieldInfo.IsStatic && 1581069d2.c41a9534() == null;
		if (flag2)
		{
			throw new NullReferenceException();
		}
		bool flag3 = flag;
		if (flag3)
		{
			f6dce402 c544e0bc = A_1.c544e0bc;
			uint num2 = num;
			1581069d 1581069d3 = default(1581069d);
			1581069d3.5b4f3f03(new 10e6a946(1581069d2.c41a9534(), fieldInfo));
			c544e0bc.af836684(num2, 1581069d3);
		}
		else
		{
			bool flag4 = fieldInfo.DeclaringType.IsValueType && 1581069d2.c41a9534() is dc32a2c5;
			object obj;
			if (flag4)
			{
				obj = ((dc32a2c5)1581069d2.c41a9534()).4109351f(A_1, (7d18b560)4).c822b8e7(fieldInfo.DeclaringType);
			}
			else
			{
				obj = 1581069d2.c822b8e7(fieldInfo.DeclaringType);
			}
			A_1.c544e0bc.af836684(num, 1581069d.99db5886(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
