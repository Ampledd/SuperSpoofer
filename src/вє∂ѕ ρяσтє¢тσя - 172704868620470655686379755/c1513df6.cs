using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000097 RID: 151
internal static class c1513df6
{
	// Token: 0x060002A6 RID: 678 RVA: 0x00020AB0 File Offset: 0x0001ECB0
	static c1513df6()
	{
		foreach (MethodInfo methodInfo in typeof(dc32a2c5).GetMethods())
		{
			foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
			{
				bool flag = parameterInfo.ParameterType == typeof(f087c8e3);
				if (flag)
				{
					c1513df6.9d4cc94c = methodInfo;
					break;
				}
			}
			bool flag2 = c1513df6.9d4cc94c != null;
			if (flag2)
			{
				break;
			}
		}
		foreach (MethodInfo methodInfo2 in typeof(de06eb40).GetMethods())
		{
			bool flag3 = methodInfo2.GetParameters()[0].ParameterType == typeof(f087c8e3);
			if (flag3)
			{
				c1513df6.79f5743b = methodInfo2;
				break;
			}
		}
		foreach (ConstructorInfo constructorInfo in typeof(c9a038a7).GetConstructors())
		{
			foreach (ParameterInfo parameterInfo2 in constructorInfo.GetParameters())
			{
				bool flag4 = parameterInfo2.ParameterType == typeof(TypedReference);
				if (flag4)
				{
					c1513df6.93f85c5e = constructorInfo;
					break;
				}
			}
			bool flag5 = c1513df6.93f85c5e != null;
			if (flag5)
			{
				break;
			}
		}
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00020C30 File Offset: 0x0001EE30
	public static MethodBase 79451cdd(MethodBase A_0)
	{
		MethodBase methodBase = (MethodBase)c1513df6.57a7a317[A_0];
		bool flag = methodBase != null;
		MethodBase result;
		if (flag)
		{
			result = methodBase;
		}
		else
		{
			Hashtable obj = c1513df6.57a7a317;
			lock (obj)
			{
				methodBase = (MethodBase)c1513df6.57a7a317[A_0];
				bool flag2 = methodBase != null;
				if (flag2)
				{
					result = methodBase;
				}
				else
				{
					ParameterInfo[] parameters = A_0.GetParameters();
					Type[] array = new Type[parameters.Length + (A_0.IsStatic ? 0 : 1)];
					for (int i = 0; i < array.Length; i++)
					{
						bool isStatic = A_0.IsStatic;
						if (isStatic)
						{
							array[i] = parameters[i].ParameterType;
						}
						else
						{
							bool flag3 = i == 0;
							if (flag3)
							{
								array[0] = A_0.DeclaringType;
							}
							else
							{
								array[i] = parameters[i - 1].ParameterType;
							}
						}
					}
					Type returnType = (A_0 is MethodInfo) ? ((MethodInfo)A_0).ReturnType : typeof(void);
					DynamicMethod dynamicMethod = new DynamicMethod("", returnType, array, 944f0596.cc51fffd, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					for (int j = 0; j < array.Length; j++)
					{
						bool flag4 = !A_0.IsStatic && j == 0 && array[0].IsValueType;
						if (flag4)
						{
							ilgenerator.Emit(OpCodes.Ldarga, j);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldarg, j);
						}
					}
					bool flag5 = A_0 is MethodInfo;
					if (flag5)
					{
						ilgenerator.Emit(OpCodes.Call, (MethodInfo)A_0);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, (ConstructorInfo)A_0);
					}
					ilgenerator.Emit(OpCodes.Ret);
					c1513df6.57a7a317[A_0] = dynamicMethod;
					result = dynamicMethod;
				}
			}
		}
		return result;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00020E24 File Offset: 0x0001F024
	public static c1513df6.ba071825 c0067898(MethodBase A_0, OpCode A_1, Type A_2)
	{
		bool flag = A_2 == null;
		object key;
		Hashtable hashtable;
		if (flag)
		{
			key = new KeyValuePair<MethodBase, OpCode>(A_0, A_1);
			hashtable = c1513df6.682c658a;
		}
		else
		{
			key = new KeyValuePair<MethodBase, Type>(A_0, A_2);
			hashtable = c1513df6.219f1761;
		}
		c1513df6.ba071825 ba = (c1513df6.ba071825)hashtable[key];
		bool flag2 = ba != null;
		c1513df6.ba071825 result;
		if (flag2)
		{
			result = ba;
		}
		else
		{
			Hashtable obj = c1513df6.682c658a;
			lock (obj)
			{
				ba = (c1513df6.ba071825)hashtable[key];
				bool flag3 = ba != null;
				if (flag3)
				{
					result = ba;
				}
				else
				{
					ParameterInfo[] parameters = A_0.GetParameters();
					bool flag4 = A_1 != OpCodes.Newobj;
					Type[] array;
					if (flag4)
					{
						array = new Type[parameters.Length + (A_0.IsStatic ? 0 : 1) + 1];
						for (int i = 0; i < array.Length - 1; i++)
						{
							bool isStatic = A_0.IsStatic;
							if (isStatic)
							{
								array[i] = parameters[i].ParameterType;
							}
							else
							{
								bool flag5 = i == 0;
								if (flag5)
								{
									bool flag6 = A_2 != null;
									if (flag6)
									{
										array[0] = A_2.MakeByRefType();
									}
									else
									{
										bool isValueType = A_0.DeclaringType.IsValueType;
										if (isValueType)
										{
											array[0] = A_0.DeclaringType.MakeByRefType();
										}
										else
										{
											array[0] = A_0.DeclaringType;
										}
									}
								}
								else
								{
									array[i] = parameters[i - 1].ParameterType;
								}
							}
						}
					}
					else
					{
						array = new Type[parameters.Length + 1];
						for (int j = 0; j < array.Length - 1; j++)
						{
							array[j] = parameters[j].ParameterType;
						}
					}
					Type type = (A_0 is MethodInfo) ? ((MethodInfo)A_0).ReturnType : typeof(void);
					bool flag7 = A_1 == OpCodes.Newobj;
					if (flag7)
					{
						type = A_0.DeclaringType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod("", typeof(object), new Type[]
					{
						typeof(33cd5b0d),
						typeof(dc32a2c5[]),
						typeof(Type[])
					}, 944f0596.cc51fffd, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					for (int k = 0; k < array.Length - 1; k++)
					{
						Type type2 = array[k];
						bool isByRef = type2.IsByRef;
						bool flag8 = isByRef;
						if (flag8)
						{
							type2 = type2.GetElementType();
						}
						LocalBuilder local = ilgenerator.DeclareLocal(typeof(TypedReference));
						ilgenerator.Emit(OpCodes.Ldarg_1);
						ilgenerator.Emit(OpCodes.Ldc_I4, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						ilgenerator.Emit(OpCodes.Ldarg_0);
						ilgenerator.Emit(OpCodes.Ldloca, local);
						ilgenerator.Emit(OpCodes.Ldarg_2);
						ilgenerator.Emit(OpCodes.Ldc_I4, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						ilgenerator.Emit(OpCodes.Callvirt, c1513df6.9d4cc94c);
						ilgenerator.Emit(OpCodes.Ldloca, local);
						ilgenerator.Emit(OpCodes.Ldarg_2);
						ilgenerator.Emit(OpCodes.Ldc_I4, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						ilgenerator.Emit(OpCodes.Call, c1513df6.79f5743b);
						ilgenerator.Emit(OpCodes.Ldloc, local);
						ilgenerator.Emit(OpCodes.Refanyval, type2);
						bool flag9 = !isByRef;
						if (flag9)
						{
							ilgenerator.Emit(OpCodes.Ldobj, type2);
						}
					}
					bool flag10 = A_2 != null;
					if (flag10)
					{
						ilgenerator.Emit(OpCodes.Constrained, A_2);
					}
					bool flag11 = A_0 is MethodInfo;
					if (flag11)
					{
						ilgenerator.Emit(A_1, (MethodInfo)A_0);
					}
					else
					{
						ilgenerator.Emit(A_1, (ConstructorInfo)A_0);
					}
					bool isByRef2 = type.IsByRef;
					if (isByRef2)
					{
						ilgenerator.Emit(OpCodes.Mkrefany, type.GetElementType());
						ilgenerator.Emit(OpCodes.Newobj, c1513df6.93f85c5e);
					}
					else
					{
						bool flag12 = type == typeof(void);
						if (flag12)
						{
							ilgenerator.Emit(OpCodes.Ldnull);
						}
						else
						{
							bool isValueType2 = type.IsValueType;
							if (isValueType2)
							{
								ilgenerator.Emit(OpCodes.Box, type);
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					ba = (c1513df6.ba071825)dynamicMethod.CreateDelegate(typeof(c1513df6.ba071825));
					hashtable[key] = ba;
					result = ba;
				}
			}
		}
		return result;
	}

	// Token: 0x04000166 RID: 358
	private static readonly Hashtable 57a7a317 = new Hashtable();

	// Token: 0x04000167 RID: 359
	private static readonly Hashtable 682c658a = new Hashtable();

	// Token: 0x04000168 RID: 360
	private static readonly Hashtable 219f1761 = new Hashtable();

	// Token: 0x04000169 RID: 361
	private static readonly MethodInfo 9d4cc94c;

	// Token: 0x0400016A RID: 362
	private static readonly MethodInfo 79f5743b;

	// Token: 0x0400016B RID: 363
	private static readonly ConstructorInfo 93f85c5e;

	// Token: 0x020000C2 RID: 194
	// (Invoke) Token: 0x06000375 RID: 885
	public delegate object ba071825(33cd5b0d, dc32a2c5[], Type[]);
}
