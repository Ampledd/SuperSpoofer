using System;
using System.Collections;
using System.Reflection.Emit;

// Token: 0x02000095 RID: 149
internal class eb704c8e
{
	// Token: 0x0600029E RID: 670 RVA: 0x00020840 File Offset: 0x0001EA40
	public static int 69816a95(Type A_0)
	{
		object obj = eb704c8e.23a5118f[A_0];
		bool flag = obj == null;
		if (flag)
		{
			Hashtable obj2 = eb704c8e.23a5118f;
			lock (obj2)
			{
				obj = eb704c8e.23a5118f[A_0];
				bool flag2 = obj == null;
				if (flag2)
				{
					obj = eb704c8e.9105baf0(A_0);
					eb704c8e.23a5118f[A_0] = obj;
				}
			}
		}
		return (int)obj;
	}

	// Token: 0x0600029F RID: 671 RVA: 0x000208C8 File Offset: 0x0001EAC8
	private static int 9105baf0(Type A_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(int), Type.EmptyTypes, 944f0596.cc51fffd, true);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ilgenerator.Emit(OpCodes.Sizeof, A_0);
		ilgenerator.Emit(OpCodes.Ret);
		return (int)dynamicMethod.Invoke(null, null);
	}

	// Token: 0x04000164 RID: 356
	private static readonly Hashtable 23a5118f = new Hashtable();
}
