using System;
using System.Collections.Generic;

// Token: 0x0200009F RID: 159
internal static class 944ddc58
{
	// Token: 0x060002C8 RID: 712 RVA: 0x00022950 File Offset: 0x00020B50
	static 944ddc58()
	{
		foreach (Type type in typeof(944ddc58).Assembly.GetTypes())
		{
			bool flag = typeof(b8ce7618).IsAssignableFrom(type) && !type.IsAbstract;
			if (flag)
			{
				b8ce7618 b8ce = (b8ce7618)Activator.CreateInstance(type);
				944ddc58.4ec633d7[b8ce.68b53414()] = b8ce;
			}
		}
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x000229D8 File Offset: 0x00020BD8
	public static b8ce7618 e02f5101(byte A_0)
	{
		return 944ddc58.4ec633d7[A_0];
	}

	// Token: 0x040001F8 RID: 504
	private static readonly Dictionary<byte, b8ce7618> 4ec633d7 = new Dictionary<byte, b8ce7618>();
}
