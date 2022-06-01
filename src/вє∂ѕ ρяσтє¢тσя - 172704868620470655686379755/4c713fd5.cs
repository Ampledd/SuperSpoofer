using System;
using System.Reflection;

// Token: 0x02000038 RID: 56
internal class 4c713fd5 : beb75257
{
	// Token: 0x06000161 RID: 353 RVA: 0x0000235A File Offset: 0x0000055A
	public byte 68b53414()
	{
		return 867a1c12.d3678b1c;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0001A32C File Offset: 0x0001852C
	public unsafe void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d3 = A_1.c544e0bc.cb15379(num--);
		FieldInfo fieldInfo = (FieldInfo)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a());
		bool flag = !fieldInfo.IsStatic && 1581069d3.c41a9534() == null;
		if (flag)
		{
			throw new NullReferenceException();
		}
		bool flag2 = Type.GetTypeCode(fieldInfo.FieldType) == TypeCode.String && 1581069d2.c41a9534() == null;
		object value;
		if (flag2)
		{
			value = A_1.4b935237.74973c38().f3c2d292(1581069d2.95ecf24a());
		}
		else
		{
			value = 1581069d2.c822b8e7(fieldInfo.FieldType);
		}
		bool flag3 = fieldInfo.DeclaringType.IsValueType && 1581069d3.c41a9534() is dc32a2c5;
		if (flag3)
		{
			TypedReference obj;
			((dc32a2c5)1581069d3.c41a9534()).5f1317f4(A_1, f087c8e3.2b8998e6((void*)(&obj)), fieldInfo.DeclaringType);
			de06eb40.3dc4659f(f087c8e3.2b8998e6((void*)(&obj)), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(1581069d3.c822b8e7(fieldInfo.DeclaringType), value);
		}
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
