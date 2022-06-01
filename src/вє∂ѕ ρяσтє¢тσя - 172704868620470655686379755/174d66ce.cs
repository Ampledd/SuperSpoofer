using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02000037 RID: 55
internal class 174d66ce : beb75257
{
	// Token: 0x0600015E RID: 350 RVA: 0x0000234A File Offset: 0x0000054A
	public byte 68b53414()
	{
		return 867a1c12.a4355568;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0001A098 File Offset: 0x00018298
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		1581069d 1581069d2 = A_1.c544e0bc.cb15379(num);
		bool flag = 1581069d2.c41a9534() != null;
		if (flag)
		{
			MethodInfo methodInfo = (MethodInfo)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a());
			Type type = 1581069d2.c41a9534().GetType();
			List<Type> list = new List<Type>();
			do
			{
				list.Add(type);
				type = type.BaseType;
			}
			while (type != null && type != methodInfo.DeclaringType);
			list.Reverse();
			MethodInfo methodInfo2 = methodInfo;
			foreach (Type type2 in list)
			{
				foreach (MethodInfo methodInfo3 in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
				{
					bool flag2 = methodInfo3.GetBaseDefinition() == methodInfo2;
					if (flag2)
					{
						methodInfo2 = methodInfo3;
						break;
					}
				}
			}
			f6dce402 c544e0bc = A_1.c544e0bc;
			uint num2 = num;
			1581069d 1581069d3 = default(1581069d);
			1581069d3.6535f2d7((ulong)((long)methodInfo2.MethodHandle.GetFunctionPointer()));
			c544e0bc.af836684(num2, 1581069d3);
		}
		bool flag3 = 1581069d2.61f3d758() > 0UL;
		if (flag3)
		{
			uint num3 = A_1.c544e0bc.cb15379(num -= 1U).95ecf24a();
			ulong num4 = 1581069d.61f3d758();
			45263f4a 267edf9d = A_1.4b935237.74973c38().cd7bd0c9(1581069d2.95ecf24a()).267edf9d;
			IntPtr value = 484cc138.5bc91337(A_1.4b935237.74973c38().eeca267e(), num4, num3, 267edf9d, 1581069d2.95ecf24a());
			f6dce402 c544e0bc2 = A_1.c544e0bc;
			uint num5 = num;
			1581069d 1581069d3 = default(1581069d);
			1581069d3.6535f2d7((ulong)((long)value));
			c544e0bc2.af836684(num5, 1581069d3);
		}
		else
		{
			MethodBase methodBase = (MethodBase)A_1.4b935237.74973c38().cee44a3f(1581069d.95ecf24a());
			f6dce402 c544e0bc3 = A_1.c544e0bc;
			uint num6 = num;
			1581069d 1581069d3 = default(1581069d);
			1581069d3.6535f2d7((ulong)((long)methodBase.MethodHandle.GetFunctionPointer()));
			c544e0bc3.af836684(num6, 1581069d3);
		}
		A_1.c544e0bc.83d7c013(num);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(num);
		A_2 = (e321097e)0;
	}
}
