using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000091 RID: 145
internal class 9aa017f
{
	// Token: 0x06000290 RID: 656 RVA: 0x000202A8 File Offset: 0x0001E4A8
	static 9aa017f()
	{
		bool flag = 9aa017f.7ddcca09(typeof(Exception));
		if (!flag)
		{
			Type type = Type.GetType("System.Runtime.ExceptionServices.ExceptionDispatchInfo");
			bool flag2 = type != null && 9aa017f.9c10a0d2(type);
			if (!flag2)
			{
				9aa017f.b7a4c523 = null;
			}
		}
	}

	// Token: 0x06000291 RID: 657 RVA: 0x000202F8 File Offset: 0x0001E4F8
	private static bool 9c10a0d2(Type A_0)
	{
		try
		{
			MethodInfo method = A_0.GetMethod("Capture");
			MethodInfo method2 = A_0.GetMethod("Throw");
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
			{
				typeof(Exception),
				typeof(string),
				typeof(bool)
			});
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, method);
			ilgenerator.Emit(OpCodes.Call, method2);
			ilgenerator.Emit(OpCodes.Ret);
			9aa017f.b7a4c523 = (9aa017f.fe96e14d)dynamicMethod.CreateDelegate(typeof(9aa017f.fe96e14d));
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x000203D8 File Offset: 0x0001E5D8
	private static bool 7ddcca09(Type A_0)
	{
		try
		{
			string text = (string)typeof(Environment).InvokeMember("GetResourceString", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, new object[]
			{
				"Word_At"
			});
			MethodInfo method = A_0.GetMethod("InternalPreserveStackTrace", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field = A_0.GetField("_remoteStackTraceString", BindingFlags.Instance | BindingFlags.NonPublic);
			MethodInfo getMethod = A_0.GetProperty("StackTrace", BindingFlags.Instance | BindingFlags.Public).GetGetMethod();
			MethodInfo method2 = typeof(string).GetMethod("Format", new Type[]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			});
			DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
			{
				typeof(Exception),
				typeof(string),
				typeof(bool)
			}, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			Label label = ilgenerator.DefineLabel();
			Label label2 = ilgenerator.DefineLabel();
			Label label3 = ilgenerator.DefineLabel();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Dup);
			ilgenerator.Emit(OpCodes.Dup);
			ilgenerator.Emit(OpCodes.Ldfld, field);
			ilgenerator.Emit(OpCodes.Brtrue, label2);
			ilgenerator.Emit(OpCodes.Callvirt, getMethod);
			ilgenerator.Emit(OpCodes.Br, label3);
			ilgenerator.MarkLabel(label2);
			ilgenerator.Emit(OpCodes.Ldfld, field);
			ilgenerator.MarkLabel(label3);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, method);
			ilgenerator.Emit(OpCodes.Stfld, field);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			ilgenerator.Emit(OpCodes.Brfalse, label);
			ilgenerator.Emit(OpCodes.Ldarg_2);
			ilgenerator.Emit(OpCodes.Brtrue, label);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Dup);
			ilgenerator.Emit(OpCodes.Ldstr, string.Concat(new string[]
			{
				"{1}",
				Environment.NewLine,
				"   ",
				text,
				" KoiVM [{0}]",
				Environment.NewLine
			}));
			ilgenerator.Emit(OpCodes.Ldarg_1);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldfld, field);
			ilgenerator.Emit(OpCodes.Call, method2);
			ilgenerator.Emit(OpCodes.Stfld, field);
			ilgenerator.Emit(OpCodes.Throw);
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Throw);
			9aa017f.b7a4c523 = (9aa017f.fe96e14d)dynamicMethod.CreateDelegate(typeof(9aa017f.fe96e14d));
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return false;
		}
		return true;
	}

	// Token: 0x06000293 RID: 659 RVA: 0x000206FC File Offset: 0x0001E8FC
	public static void 5405cbd4(Exception A_0, string A_1)
	{
		bool flag = A_1 == null;
		if (flag)
		{
			throw A_0;
		}
		bool flag2 = A_0.Data.Contains(9aa017f.76c3e826);
		bool flag3 = !flag2;
		if (flag3)
		{
			A_0.Data[9aa017f.76c3e826] = 9aa017f.76c3e826;
		}
		bool flag4 = 9aa017f.b7a4c523 != null;
		if (flag4)
		{
			9aa017f.b7a4c523(A_0, A_1, flag2);
		}
		throw A_0;
	}

	// Token: 0x04000161 RID: 353
	private static 9aa017f.fe96e14d b7a4c523;

	// Token: 0x04000162 RID: 354
	private static readonly object 76c3e826 = new object();

	// Token: 0x020000C0 RID: 192
	// (Invoke) Token: 0x0600036D RID: 877
	private delegate void fe96e14d(Exception, string, bool);
}
