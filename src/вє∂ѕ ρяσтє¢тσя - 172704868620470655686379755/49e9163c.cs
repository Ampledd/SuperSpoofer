using System;
using System.Reflection;

// Token: 0x02000035 RID: 53
internal class 49e9163c : beb75257
{
	// Token: 0x06000158 RID: 344 RVA: 0x0000232A File Offset: 0x0000052A
	public byte 68b53414()
	{
		return 867a1c12.2a53b9a7;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00019F34 File Offset: 0x00018134
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num);
		MemberInfo memberInfo = A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a());
		bool flag = memberInfo is Type;
		if (flag)
		{
			1581069d.5b4f3f03(cdd1c92b.6cae0349(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else
		{
			bool flag2 = memberInfo is MethodBase;
			if (flag2)
			{
				1581069d.5b4f3f03(cdd1c92b.6cae0349(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
			}
			else
			{
				bool flag3 = memberInfo is FieldInfo;
				if (flag3)
				{
					1581069d.5b4f3f03(cdd1c92b.6cae0349(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
				}
			}
		}
		A_1.c544e0bc.af836684(num, 1581069d);
		A_2 = (e321097e)0;
	}
}
