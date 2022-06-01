using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x0200003C RID: 60
internal class d064add9 : beb75257
{
	// Token: 0x0600016D RID: 365 RVA: 0x000023A0 File Offset: 0x000005A0
	public byte 68b53414()
	{
		return 867a1c12.dfd0961f;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0001A770 File Offset: 0x00018970
	public void 9a70f6ec(33cd5b0d A_1, out e321097e A_2)
	{
		uint num = A_1.cd97a091[(int)867a1c12.d7e5ab3c].95ecf24a();
		1581069d 1581069d = A_1.c544e0bc.cb15379(num--);
		uint num2 = 1581069d.95ecf24a() & 1073741823U;
		byte b = (byte)(1581069d.95ecf24a() >> 30);
		MethodBase methodBase = (MethodBase)A_1.4b935237.74973c38().cee44a3f(num2);
		bool flag = b == 867a1c12.ee2e4e44;
		bool flag2 = !flag;
		if (flag2)
		{
			flag = d064add9.f511a036(A_1, num, methodBase, b == 867a1c12.4ddfaa39);
		}
		bool flag3 = flag;
		if (flag3)
		{
			this.4b5654d8(A_1, methodBase, b, ref num, out A_2);
		}
		else
		{
			this.596f9a1d(A_1, methodBase, b, ref num, out A_2);
		}
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0001A828 File Offset: 0x00018A28
	private static object e9013d64(33cd5b0d A_0, Type A_1, ref uint A_2)
	{
		f6dce402 c544e0bc = A_0.c544e0bc;
		uint num = A_2;
		A_2 = num - 1U;
		1581069d 1581069d = c544e0bc.cb15379(num);
		bool flag = Type.GetTypeCode(A_1) == TypeCode.String && 1581069d.c41a9534() == null;
		object result;
		if (flag)
		{
			result = A_0.4b935237.74973c38().f3c2d292(1581069d.95ecf24a());
		}
		else
		{
			result = 1581069d.c822b8e7(A_1);
		}
		return result;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0001A88C File Offset: 0x00018A8C
	private unsafe static dc32a2c5 8eb8e973(33cd5b0d A_0, Type A_1, ref uint A_2)
	{
		1581069d 1581069d = A_0.c544e0bc.cb15379(A_2);
		bool isByRef = A_1.IsByRef;
		dc32a2c5 result;
		if (isByRef)
		{
			A_2 -= 1U;
			A_1 = A_1.GetElementType();
			bool flag = 1581069d.c41a9534() is Pointer;
			if (flag)
			{
				void* ptr = Pointer.Unbox(1581069d.c41a9534());
				result = new 994e98c0(ptr);
			}
			else
			{
				bool flag2 = 1581069d.c41a9534() is dc32a2c5;
				if (flag2)
				{
					result = (dc32a2c5)1581069d.c41a9534();
				}
				else
				{
					result = new 994e98c0(1581069d.61f3d758());
				}
			}
		}
		else
		{
			bool flag3 = Type.GetTypeCode(A_1) == TypeCode.String && 1581069d.c41a9534() == null;
			if (flag3)
			{
				1581069d.5b4f3f03(A_0.4b935237.74973c38().f3c2d292(1581069d.95ecf24a()));
				A_0.c544e0bc.af836684(A_2, 1581069d);
			}
			uint num = A_2;
			A_2 = num - 1U;
			result = new 2554693f(num);
		}
		return result;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0001A98C File Offset: 0x00018B8C
	private static bool f511a036(33cd5b0d A_0, uint A_1, MethodBase A_2, bool A_3)
	{
		bool flag = !A_3 && !A_2.IsStatic;
		if (flag)
		{
			bool isValueType = A_2.DeclaringType.IsValueType;
			if (isValueType)
			{
				return true;
			}
		}
		foreach (ParameterInfo parameterInfo in A_2.GetParameters())
		{
			bool isByRef = parameterInfo.ParameterType.IsByRef;
			if (isByRef)
			{
				return true;
			}
		}
		return A_2 is MethodInfo && ((MethodInfo)A_2).ReturnType.IsByRef;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0001AA20 File Offset: 0x00018C20
	private void 596f9a1d(33cd5b0d A_1, MethodBase A_2, byte A_3, ref uint A_4, out e321097e A_5)
	{
		uint num = A_4;
		ParameterInfo[] parameters = A_2.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		bool flag = A_3 == 867a1c12.19034e2f && A_2.IsVirtual;
		if (flag)
		{
			int num2 = A_2.IsStatic ? 0 : 1;
			array = new object[parameters.Length + num2];
			for (int i = parameters.Length - 1; i >= 0; i--)
			{
				array[i + num2] = d064add9.e9013d64(A_1, parameters[i].ParameterType, ref A_4);
			}
			bool flag2 = !A_2.IsStatic;
			if (flag2)
			{
				array[0] = d064add9.e9013d64(A_1, A_2.DeclaringType, ref A_4);
			}
			A_2 = c1513df6.79451cdd(A_2);
		}
		else
		{
			array = new object[parameters.Length];
			for (int j = parameters.Length - 1; j >= 0; j--)
			{
				array[j] = d064add9.e9013d64(A_1, parameters[j].ParameterType, ref A_4);
			}
			bool flag3 = !A_2.IsStatic && A_3 != 867a1c12.4ddfaa39;
			if (flag3)
			{
				obj = d064add9.e9013d64(A_1, A_2.DeclaringType, ref A_4);
				bool flag4 = obj != null && !A_2.DeclaringType.IsInstanceOfType(obj);
				if (flag4)
				{
					this.4b5654d8(A_1, A_2, A_3, ref num, out A_5);
					return;
				}
			}
		}
		bool flag5 = A_3 == 867a1c12.4ddfaa39;
		object obj2;
		if (flag5)
		{
			try
			{
				obj2 = ((ConstructorInfo)A_2).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				9aa017f.5405cbd4(ex.InnerException, null);
				throw;
			}
		}
		else
		{
			bool flag6 = !A_2.IsStatic && obj == null;
			if (flag6)
			{
				throw new NullReferenceException();
			}
			Type type;
			bool flag7 = obj != null && (type = obj.GetType()).IsArray && A_2.Name == "SetValue";
			if (flag7)
			{
				bool flag8 = array[0] == null;
				Type type2;
				if (flag8)
				{
					type2 = type.GetElementType();
				}
				else
				{
					type2 = array[0].GetType();
				}
				87c6d1a2.6517fff2((Array)obj, (int)array[1], array[0], type2, type.GetElementType());
				obj2 = null;
			}
			else
			{
				try
				{
					obj2 = A_2.Invoke(obj, array);
				}
				catch (TargetInvocationException ex2)
				{
					a4d544eb.e288c662(A_1, ex2.InnerException);
					throw;
				}
			}
		}
		bool flag9 = A_2 is MethodInfo && ((MethodInfo)A_2).ReturnType != typeof(void);
		if (flag9)
		{
			f6dce402 c544e0bc = A_1.c544e0bc;
			uint num3 = A_4 + 1U;
			A_4 = num3;
			c544e0bc.af836684(num3, 1581069d.99db5886(obj2, ((MethodInfo)A_2).ReturnType));
		}
		else
		{
			bool flag10 = A_3 == 867a1c12.4ddfaa39;
			if (flag10)
			{
				f6dce402 c544e0bc2 = A_1.c544e0bc;
				uint num3 = A_4 + 1U;
				A_4 = num3;
				c544e0bc2.af836684(num3, 1581069d.99db5886(obj2, A_2.DeclaringType));
			}
		}
		A_1.c544e0bc.83d7c013(A_4);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(A_4);
		A_5 = (e321097e)0;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0001AD38 File Offset: 0x00018F38
	private void 4b5654d8(33cd5b0d A_1, MethodBase A_2, byte A_3, ref uint A_4, out e321097e A_5)
	{
		ParameterInfo[] parameters = A_2.GetParameters();
		int num = parameters.Length;
		bool flag = !A_2.IsStatic && A_3 != 867a1c12.4ddfaa39;
		if (flag)
		{
			num++;
		}
		Type type = null;
		bool flag2 = A_3 == 867a1c12.ee2e4e44;
		if (flag2)
		{
			16e0fedb 16e0fedb = A_1.4b935237.74973c38();
			f6dce402 c544e0bc = A_1.c544e0bc;
			uint num2 = A_4;
			A_4 = num2 - 1U;
			type = (Type)16e0fedb.cee44a3f(c544e0bc.cb15379(num2).95ecf24a());
		}
		int num3 = (A_2.IsStatic || A_3 == 867a1c12.4ddfaa39) ? 0 : 1;
		dc32a2c5[] array = new dc32a2c5[num];
		Type[] array2 = new Type[num];
		for (int i = num - 1; i >= 0; i--)
		{
			bool flag3 = !A_2.IsStatic && A_3 != 867a1c12.4ddfaa39;
			Type type2;
			if (flag3)
			{
				bool flag4 = i == 0;
				if (flag4)
				{
					bool flag5 = !A_2.IsStatic;
					if (flag5)
					{
						1581069d 1581069d = A_1.c544e0bc.cb15379(A_4);
						bool flag6 = 1581069d.c41a9534() is ValueType && !A_2.DeclaringType.IsValueType;
						if (flag6)
						{
							Debug.Assert(A_2.DeclaringType.IsInterface);
							Debug.Assert(A_3 == 867a1c12.7557a5c2);
							type = 1581069d.c41a9534().GetType();
						}
					}
					bool flag7 = type != null;
					if (flag7)
					{
						type2 = type.MakeByRefType();
					}
					else
					{
						bool isValueType = A_2.DeclaringType.IsValueType;
						if (isValueType)
						{
							type2 = A_2.DeclaringType.MakeByRefType();
						}
						else
						{
							type2 = A_2.DeclaringType;
						}
					}
				}
				else
				{
					type2 = parameters[i - 1].ParameterType;
				}
			}
			else
			{
				type2 = parameters[i].ParameterType;
			}
			array[i] = d064add9.8eb8e973(A_1, type2, ref A_4);
			bool isByRef = type2.IsByRef;
			if (isByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[i] = type2;
		}
		bool flag8 = A_3 == 867a1c12.19034e2f;
		OpCode opCode;
		Type type3;
		if (flag8)
		{
			opCode = OpCodes.Call;
			type3 = ((A_2 is MethodInfo) ? ((MethodInfo)A_2).ReturnType : typeof(void));
		}
		else
		{
			bool flag9 = A_3 == 867a1c12.7557a5c2 || A_3 == 867a1c12.ee2e4e44;
			if (flag9)
			{
				opCode = OpCodes.Callvirt;
				type3 = ((A_2 is MethodInfo) ? ((MethodInfo)A_2).ReturnType : typeof(void));
			}
			else
			{
				bool flag10 = A_3 == 867a1c12.4ddfaa39;
				if (!flag10)
				{
					throw new InvalidProgramException();
				}
				opCode = OpCodes.Newobj;
				type3 = A_2.DeclaringType;
			}
		}
		c1513df6.ba071825 ba = c1513df6.c0067898(A_2, opCode, type);
		object obj = ba(A_1, array, array2);
		bool flag11 = type3 != typeof(void);
		if (flag11)
		{
			f6dce402 c544e0bc2 = A_1.c544e0bc;
			uint num2 = A_4 + 1U;
			A_4 = num2;
			c544e0bc2.af836684(num2, 1581069d.99db5886(obj, type3));
		}
		else
		{
			bool flag12 = A_3 == 867a1c12.4ddfaa39;
			if (flag12)
			{
				f6dce402 c544e0bc3 = A_1.c544e0bc;
				uint num2 = A_4 + 1U;
				A_4 = num2;
				c544e0bc3.af836684(num2, 1581069d.99db5886(obj, type3));
			}
		}
		A_1.c544e0bc.83d7c013(A_4);
		A_1.cd97a091[(int)867a1c12.d7e5ab3c].eb3abd21(A_4);
		A_5 = (e321097e)0;
	}
}
