using System;
using System.Collections.Generic;

// Token: 0x0200009C RID: 156
internal static class ccf7bdaa
{
	// Token: 0x060002BC RID: 700 RVA: 0x00022628 File Offset: 0x00020828
	static ccf7bdaa()
	{
		foreach (Type type in typeof(ccf7bdaa).Assembly.GetTypes())
		{
			bool flag = typeof(beb75257).IsAssignableFrom(type) && !type.IsAbstract;
			if (flag)
			{
				beb75257 beb = (beb75257)Activator.CreateInstance(type);
				ccf7bdaa.6235766c[beb.68b53414()] = beb;
			}
		}
	}

	// Token: 0x060002BD RID: 701 RVA: 0x000226B0 File Offset: 0x000208B0
	public static beb75257 e02f5101(byte A_0)
	{
		return ccf7bdaa.6235766c[A_0];
	}

	// Token: 0x040001EE RID: 494
	private static readonly Dictionary<byte, beb75257> 6235766c = new Dictionary<byte, beb75257>();
}
