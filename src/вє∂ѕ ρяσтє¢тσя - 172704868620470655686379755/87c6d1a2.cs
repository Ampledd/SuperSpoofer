using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;

// Token: 0x02000096 RID: 150
internal class 87c6d1a2
{
	// Token: 0x060002A2 RID: 674 RVA: 0x00020928 File Offset: 0x0001EB28
	public static void 6517fff2(Array A_0, int A_1, object A_2, Type A_3, Type A_4)
	{
		Debug.Assert(A_2 == null || A_2.GetType() == A_3);
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(A_3, A_4);
		object obj = 87c6d1a2.c656c524[keyValuePair];
		bool flag = obj == null;
		if (flag)
		{
			Hashtable obj2 = 87c6d1a2.c656c524;
			lock (obj2)
			{
				obj = 87c6d1a2.c656c524[keyValuePair];
				bool flag2 = obj == null;
				if (flag2)
				{
					obj = 87c6d1a2.d1e02499(A_3, A_4);
					87c6d1a2.c656c524[keyValuePair] = obj;
				}
			}
		}
		((87c6d1a2.21e74e33)obj)(A_0, A_1, A_2);
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x000209E0 File Offset: 0x0001EBE0
	private static 87c6d1a2.21e74e33 d1e02499(Type A_0, Type A_1)
	{
		Type[] parameterTypes = new Type[]
		{
			typeof(Array),
			typeof(int),
			typeof(object)
		};
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), parameterTypes, 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Ldarg_0);
		ilgenerator.Emit(OpCodes.Ldarg_1);
		ilgenerator.Emit(OpCodes.Ldarg_2);
		bool isValueType = A_1.IsValueType;
		if (isValueType)
		{
			ilgenerator.Emit(OpCodes.Unbox_Any, A_0);
		}
		ilgenerator.Emit(OpCodes.Stelem, A_1);
		ilgenerator.Emit(OpCodes.Ret);
		return (87c6d1a2.21e74e33)dynamicMethod.CreateDelegate(typeof(87c6d1a2.21e74e33));
	}

	// Token: 0x04000165 RID: 357
	private static readonly Hashtable c656c524 = new Hashtable();

	// Token: 0x020000C1 RID: 193
	// (Invoke) Token: 0x06000371 RID: 881
	private delegate void 21e74e33(Array, int, object);
}
