using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000098 RID: 152
internal static class de06eb40
{
	// Token: 0x060002A9 RID: 681 RVA: 0x000212C8 File Offset: 0x0001F4C8
	public unsafe static void 3dc4659f(f087c8e3 A_0, Type A_1)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)f087c8e3.2b8998e6(A_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, A_1);
		object obj = de06eb40.1d9b27f1[keyValuePair];
		bool flag = obj == null;
		if (flag)
		{
			Hashtable obj2 = de06eb40.1d9b27f1;
			lock (obj2)
			{
				obj = de06eb40.1d9b27f1[keyValuePair];
				bool flag2 = obj == null;
				if (flag2)
				{
					obj = de06eb40.112b47c6(targetType, A_1);
					de06eb40.1d9b27f1[keyValuePair] = obj;
				}
			}
		}
		((de06eb40.ba28fdaf)obj)(A_0);
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0002137C File Offset: 0x0001F57C
	public unsafe static void 8c6c7672(void* A_0, f087c8e3 A_1, Type A_2)
	{
		object obj = de06eb40.75c3009c[A_2];
		bool flag = obj == null;
		if (flag)
		{
			Hashtable obj2 = de06eb40.75c3009c;
			lock (obj2)
			{
				obj = de06eb40.75c3009c[A_2];
				bool flag2 = obj == null;
				if (flag2)
				{
					obj = de06eb40.5c907c6d(A_2);
					de06eb40.75c3009c[A_2] = obj;
				}
			}
		}
		((de06eb40.cbae8f42)obj)(A_0, A_1);
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00021400 File Offset: 0x0001F600
	public static void 26446329(object A_0, f087c8e3 A_1)
	{
		de06eb40.26446329(A_0, A_1, A_0.GetType());
		bool flag = A_0 is 48621248;
		if (flag)
		{
			de06eb40.3dc4659f(A_1, ((48621248)A_0).c5ba9107());
		}
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0002143C File Offset: 0x0001F63C
	public static void 26446329(object A_0, f087c8e3 A_1, Type A_2)
	{
		object obj = de06eb40.f8d0234b[A_2];
		bool flag = obj == null;
		if (flag)
		{
			Hashtable obj2 = de06eb40.f8d0234b;
			lock (obj2)
			{
				obj = de06eb40.f8d0234b[A_2];
				bool flag2 = obj == null;
				if (flag2)
				{
					obj = de06eb40.a7fdb2e8(A_2);
					de06eb40.f8d0234b[A_2] = obj;
				}
			}
		}
		((de06eb40.1ed285b9)obj)(A_0, A_1);
	}

	// Token: 0x060002AD RID: 685 RVA: 0x000214C0 File Offset: 0x0001F6C0
	public unsafe static void 1c6b5274(object A_0, f087c8e3 A_1)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)f087c8e3.2b8998e6(A_1));
		object obj = de06eb40.3f63a02e[targetType];
		bool flag = obj == null;
		if (flag)
		{
			Hashtable obj2 = de06eb40.3f63a02e;
			lock (obj2)
			{
				obj = de06eb40.3f63a02e[targetType];
				bool flag2 = obj == null;
				if (flag2)
				{
					obj = de06eb40.52417927(targetType);
					de06eb40.3f63a02e[targetType] = obj;
				}
			}
		}
		((de06eb40.bd7873c4)obj)(A_0, A_1);
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00021558 File Offset: 0x0001F758
	public unsafe static void 7e105b43(33cd5b0d A_0, object A_1, FieldInfo A_2, f087c8e3 A_3)
	{
		object obj = de06eb40.cace69b5[A_2];
		bool flag = obj == null;
		if (flag)
		{
			Hashtable obj2 = de06eb40.cace69b5;
			lock (obj2)
			{
				obj = de06eb40.cace69b5[A_2];
				bool flag2 = obj == null;
				if (flag2)
				{
					obj = de06eb40.54d6a45a(A_2);
					de06eb40.cace69b5[A_2] = obj;
				}
			}
		}
		bool flag3 = A_1 == null;
		TypedReference typedReference;
		if (flag3)
		{
			typedReference = default(TypedReference);
		}
		else
		{
			bool flag4 = A_1 is dc32a2c5;
			if (flag4)
			{
				((dc32a2c5)A_1).5f1317f4(A_0, f087c8e3.2b8998e6((void*)(&typedReference)), A_2.DeclaringType);
			}
			else
			{
				typedReference = __makeref(A_1);
				de06eb40.3dc4659f(f087c8e3.2b8998e6((void*)(&typedReference)), A_1.GetType());
			}
		}
		((de06eb40.27d0ec53)obj)(f087c8e3.2b8998e6((void*)(&typedReference)), A_3);
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00021648 File Offset: 0x0001F848
	private static de06eb40.ba28fdaf 112b47c6(Type A_0, Type A_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
		{
			typeof(f087c8e3)
		}, 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Ldarga, 0);
		ilgenerator.Emit(OpCodes.Ldfld, de06eb40.19b56f90);
		ilgenerator.Emit(OpCodes.Dup);
		ilgenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		ilgenerator.Emit(OpCodes.Refanyval, A_0);
		ilgenerator.Emit(OpCodes.Mkrefany, A_1);
		ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		ilgenerator.Emit(OpCodes.Ret);
		return (de06eb40.ba28fdaf)dynamicMethod.CreateDelegate(typeof(de06eb40.ba28fdaf));
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00021720 File Offset: 0x0001F920
	private unsafe static de06eb40.cbae8f42 5c907c6d(Type A_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
		{
			typeof(void*),
			typeof(f087c8e3)
		}, 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Ldarga, 1);
		ilgenerator.Emit(OpCodes.Ldfld, de06eb40.19b56f90);
		ilgenerator.Emit(OpCodes.Ldarg_0);
		ilgenerator.Emit(OpCodes.Mkrefany, A_0);
		ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		ilgenerator.Emit(OpCodes.Ret);
		return (de06eb40.cbae8f42)dynamicMethod.CreateDelegate(typeof(de06eb40.cbae8f42));
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x000217E4 File Offset: 0x0001F9E4
	private static de06eb40.1ed285b9 a7fdb2e8(Type A_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
		{
			typeof(object),
			typeof(f087c8e3)
		}, 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Ldarga, 1);
		ilgenerator.Emit(OpCodes.Ldfld, de06eb40.19b56f90);
		ilgenerator.Emit(OpCodes.Ldarg_0);
		ilgenerator.Emit(OpCodes.Unbox, A_0);
		ilgenerator.Emit(OpCodes.Mkrefany, A_0);
		ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		ilgenerator.Emit(OpCodes.Ret);
		return (de06eb40.1ed285b9)dynamicMethod.CreateDelegate(typeof(de06eb40.1ed285b9));
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x000218B4 File Offset: 0x0001FAB4
	private static de06eb40.bd7873c4 52417927(Type A_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
		{
			typeof(object),
			typeof(f087c8e3)
		}, 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Ldarga, 1);
		ilgenerator.Emit(OpCodes.Ldfld, de06eb40.19b56f90);
		ilgenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		ilgenerator.Emit(OpCodes.Refanyval, A_0);
		ilgenerator.Emit(OpCodes.Ldarg_0);
		ilgenerator.Emit(OpCodes.Unbox_Any, A_0);
		ilgenerator.Emit(OpCodes.Stobj, A_0);
		ilgenerator.Emit(OpCodes.Ret);
		return (de06eb40.bd7873c4)dynamicMethod.CreateDelegate(typeof(de06eb40.bd7873c4));
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00021990 File Offset: 0x0001FB90
	private static de06eb40.27d0ec53 54d6a45a(FieldInfo A_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
		{
			typeof(f087c8e3),
			typeof(f087c8e3)
		}, 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		bool isStatic = A_0.IsStatic;
		if (isStatic)
		{
			ilgenerator.Emit(OpCodes.Ldarga, 1);
			ilgenerator.Emit(OpCodes.Ldfld, de06eb40.19b56f90);
			ilgenerator.Emit(OpCodes.Ldsflda, A_0);
			ilgenerator.Emit(OpCodes.Mkrefany, A_0.FieldType);
			ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			ilgenerator.Emit(OpCodes.Ret);
		}
		else
		{
			ilgenerator.Emit(OpCodes.Ldarga, 1);
			ilgenerator.Emit(OpCodes.Ldfld, de06eb40.19b56f90);
			ilgenerator.Emit(OpCodes.Ldarga, 0);
			ilgenerator.Emit(OpCodes.Ldfld, de06eb40.19b56f90);
			ilgenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
			ilgenerator.Emit(OpCodes.Refanyval, A_0.DeclaringType);
			bool flag = !A_0.DeclaringType.IsValueType;
			if (flag)
			{
				ilgenerator.Emit(OpCodes.Ldobj, A_0.DeclaringType);
			}
			ilgenerator.Emit(OpCodes.Ldflda, A_0);
			ilgenerator.Emit(OpCodes.Mkrefany, A_0.FieldType);
			ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			ilgenerator.Emit(OpCodes.Ret);
		}
		return (de06eb40.27d0ec53)dynamicMethod.CreateDelegate(typeof(de06eb40.27d0ec53));
	}

	// Token: 0x0400016C RID: 364
	private static readonly Hashtable 1d9b27f1 = new Hashtable();

	// Token: 0x0400016D RID: 365
	private static readonly Hashtable 75c3009c = new Hashtable();

	// Token: 0x0400016E RID: 366
	private static readonly Hashtable f8d0234b = new Hashtable();

	// Token: 0x0400016F RID: 367
	private static readonly Hashtable 3f63a02e = new Hashtable();

	// Token: 0x04000170 RID: 368
	private static readonly Hashtable cace69b5 = new Hashtable();

	// Token: 0x04000171 RID: 369
	private static readonly FieldInfo 19b56f90 = typeof(f087c8e3).GetFields()[0];

	// Token: 0x020000C3 RID: 195
	// (Invoke) Token: 0x06000379 RID: 889
	private delegate void ba28fdaf(f087c8e3);

	// Token: 0x020000C4 RID: 196
	// (Invoke) Token: 0x0600037D RID: 893
	private unsafe delegate void cbae8f42(void*, f087c8e3);

	// Token: 0x020000C5 RID: 197
	// (Invoke) Token: 0x06000381 RID: 897
	private delegate void 1ed285b9(object, f087c8e3);

	// Token: 0x020000C6 RID: 198
	// (Invoke) Token: 0x06000385 RID: 901
	private delegate void bd7873c4(object, f087c8e3);

	// Token: 0x020000C7 RID: 199
	// (Invoke) Token: 0x06000389 RID: 905
	private delegate void 27d0ec53(f087c8e3, f087c8e3);
}
