using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using KoiVM.Runtime;

// Token: 0x0200009A RID: 154
internal static class 484cc138
{
	// Token: 0x060002B6 RID: 694 RVA: 0x00021C48 File Offset: 0x0001FE48
	static 484cc138()
	{
		foreach (MethodInfo methodInfo in typeof(VMEntry).GetMethods(BindingFlags.Static | BindingFlags.NonPublic))
		{
			bool flag = methodInfo.ReturnType != typeof(void) && methodInfo.GetParameters().Length > 4;
			if (flag)
			{
				484cc138.db4f17fe = methodInfo;
			}
			else
			{
				484cc138.3ad05f45 = methodInfo;
			}
		}
		484cc138.1c32d65b = (484cc138.733d9bf)Delegate.CreateDelegate(typeof(484cc138.733d9bf), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00021CE8 File Offset: 0x0001FEE8
	public static IntPtr 5bc91337(Module A_0, ulong A_1, uint A_2, 45263f4a A_3, uint A_4)
	{
		object obj = 484cc138.8cb647e0[A_1];
		bool flag = obj != null;
		IntPtr functionPointer;
		if (flag)
		{
			functionPointer = 484cc138.1c32d65b((DynamicMethod)obj).GetFunctionPointer();
		}
		else
		{
			Hashtable obj2 = 484cc138.8cb647e0;
			lock (obj2)
			{
				obj = (DynamicMethod)484cc138.8cb647e0[A_1];
				bool flag2 = obj != null;
				if (flag2)
				{
					functionPointer = 484cc138.1c32d65b((DynamicMethod)obj).GetFunctionPointer();
				}
				else
				{
					bool flag3 = 484cc138.e3abd72a(A_3);
					if (flag3)
					{
						obj = 484cc138.2c444bec(1beaa6fd.cd0b0a2a(A_0), A_1, A_2, A_3, A_4);
					}
					else
					{
						obj = 484cc138.46fd9c81(1beaa6fd.cd0b0a2a(A_0), A_1, A_2, A_3, A_4);
					}
					484cc138.8cb647e0[A_1] = obj;
					functionPointer = 484cc138.1c32d65b((DynamicMethod)obj).GetFunctionPointer();
				}
			}
		}
		return functionPointer;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00021DF0 File Offset: 0x0001FFF0
	private static bool e3abd72a(45263f4a A_0)
	{
		foreach (Type type in A_0.2ad1a621())
		{
			bool isByRef = type.IsByRef;
			if (isByRef)
			{
				return true;
			}
		}
		return A_0.2a7e890c().IsByRef;
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00021E38 File Offset: 0x00020038
	private static DynamicMethod 46fd9c81(int A_0, ulong A_1, uint A_2, 45263f4a A_3, uint A_4)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", A_3.2a7e890c(), A_3.2ad1a621(), 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Ldc_I4, A_0);
		ilgenerator.Emit(OpCodes.Ldc_I8, (long)A_1);
		ilgenerator.Emit(OpCodes.Ldc_I4, (int)A_2);
		ilgenerator.Emit(OpCodes.Ldc_I4, (int)A_4);
		ilgenerator.Emit(OpCodes.Ldc_I4, A_3.2ad1a621().Length);
		ilgenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < A_3.2ad1a621().Length; i++)
		{
			ilgenerator.Emit(OpCodes.Dup);
			ilgenerator.Emit(OpCodes.Ldc_I4, i);
			ilgenerator.Emit(OpCodes.Ldarg, i);
			bool isValueType = A_3.2ad1a621()[i].IsValueType;
			if (isValueType)
			{
				ilgenerator.Emit(OpCodes.Box, A_3.2ad1a621()[i]);
			}
			ilgenerator.Emit(OpCodes.Stelem_Ref);
		}
		ilgenerator.Emit(OpCodes.Call, 484cc138.db4f17fe);
		bool flag = A_3.2a7e890c() == typeof(void);
		if (flag)
		{
			ilgenerator.Emit(OpCodes.Pop);
		}
		else
		{
			bool isValueType2 = A_3.2a7e890c().IsValueType;
			if (isValueType2)
			{
				ilgenerator.Emit(OpCodes.Unbox_Any, A_3.2a7e890c());
			}
			else
			{
				ilgenerator.Emit(OpCodes.Castclass, A_3.2a7e890c());
			}
		}
		ilgenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00021FBC File Offset: 0x000201BC
	private unsafe static DynamicMethod 2c444bec(int A_0, ulong A_1, uint A_2, 45263f4a A_3, uint A_4)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", A_3.2a7e890c(), A_3.2ad1a621(), 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Ldc_I4, A_0);
		ilgenerator.Emit(OpCodes.Ldc_I8, (long)A_1);
		ilgenerator.Emit(OpCodes.Ldc_I4, (int)A_2);
		ilgenerator.Emit(OpCodes.Ldc_I4, (int)A_4);
		ilgenerator.Emit(OpCodes.Ldc_I4, A_3.2ad1a621().Length);
		ilgenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < A_3.2ad1a621().Length; i++)
		{
			ilgenerator.Emit(OpCodes.Dup);
			ilgenerator.Emit(OpCodes.Ldc_I4, i);
			bool isByRef = A_3.2ad1a621()[i].IsByRef;
			if (isByRef)
			{
				ilgenerator.Emit(OpCodes.Ldarg, i);
				ilgenerator.Emit(OpCodes.Mkrefany, A_3.2ad1a621()[i].GetElementType());
			}
			else
			{
				ilgenerator.Emit(OpCodes.Ldarga, i);
				ilgenerator.Emit(OpCodes.Mkrefany, A_3.2ad1a621()[i]);
			}
			LocalBuilder local = ilgenerator.DeclareLocal(typeof(TypedReference));
			ilgenerator.Emit(OpCodes.Stloc, local);
			ilgenerator.Emit(OpCodes.Ldloca, local);
			ilgenerator.Emit(OpCodes.Conv_I);
			ilgenerator.Emit(OpCodes.Stelem_I);
		}
		bool flag = A_3.2a7e890c() != typeof(void);
		if (flag)
		{
			LocalBuilder local2 = ilgenerator.DeclareLocal(A_3.2a7e890c());
			LocalBuilder local3 = ilgenerator.DeclareLocal(typeof(TypedReference));
			ilgenerator.Emit(OpCodes.Ldloca, local2);
			ilgenerator.Emit(OpCodes.Mkrefany, A_3.2a7e890c());
			ilgenerator.Emit(OpCodes.Stloc, local3);
			ilgenerator.Emit(OpCodes.Ldloca, local3);
			ilgenerator.Emit(OpCodes.Call, 484cc138.3ad05f45);
			ilgenerator.Emit(OpCodes.Ldloc, local2);
		}
		else
		{
			ilgenerator.Emit(OpCodes.Ldnull);
			ilgenerator.Emit(OpCodes.Call, 484cc138.3ad05f45);
		}
		ilgenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	// Token: 0x04000173 RID: 371
	private static readonly 484cc138.733d9bf 1c32d65b;

	// Token: 0x04000174 RID: 372
	private static readonly MethodInfo db4f17fe;

	// Token: 0x04000175 RID: 373
	private static readonly MethodInfo 3ad05f45;

	// Token: 0x04000176 RID: 374
	private static readonly Hashtable 8cb647e0 = new Hashtable();

	// Token: 0x020000C8 RID: 200
	// (Invoke) Token: 0x0600038D RID: 909
	private delegate RuntimeMethodHandle 733d9bf(DynamicMethod);
}
