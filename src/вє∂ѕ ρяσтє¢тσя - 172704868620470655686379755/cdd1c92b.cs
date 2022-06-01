using System;
using System.Diagnostics;

// Token: 0x02000094 RID: 148
internal static class cdd1c92b
{
	// Token: 0x0600029C RID: 668 RVA: 0x000207C0 File Offset: 0x0001E9C0
	public static 48621248 6cae0349(object A_0, Type A_1)
	{
		Debug.Assert(A_1.IsValueType);
		Type type = typeof(36206ad1<>).MakeGenericType(new Type[]
		{
			A_1
		});
		return (48621248)Activator.CreateInstance(type, new object[]
		{
			A_0
		});
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00020810 File Offset: 0x0001EA10
	public static object 8a9bd8cf(object A_0)
	{
		bool flag = A_0 is 48621248;
		object result;
		if (flag)
		{
			result = ((48621248)A_0).4109351f();
		}
		else
		{
			result = A_0;
		}
		return result;
	}
}
