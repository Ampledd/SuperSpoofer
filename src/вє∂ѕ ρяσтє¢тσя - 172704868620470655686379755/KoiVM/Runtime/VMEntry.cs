using System;
using System.Reflection;

namespace KoiVM.Runtime
{
	// Token: 0x0200002B RID: 43
	public class VMEntry
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00019020 File Offset: 0x00017220
		public static object Run(RuntimeTypeHandle A_0, uint A_1, object[] A_2)
		{
			Module module = Type.GetTypeFromHandle(A_0).Module;
			return 1beaa6fd.4b935237(module).9a70f6ec(A_1, A_2);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001904C File Offset: 0x0001724C
		public unsafe static void Run(RuntimeTypeHandle A_0, uint A_1, void*[] A_2, void* A_3)
		{
			Module module = Type.GetTypeFromHandle(A_0).Module;
			1beaa6fd.4b935237(module).9a70f6ec(A_1, A_2, A_3);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00019078 File Offset: 0x00017278
		internal static object RunInternal(int A_0, ulong A_1, uint A_2, uint A_3, object[] A_4)
		{
			return 1beaa6fd.4b935237(A_0).9a70f6ec(A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002251 File Offset: 0x00000451
		internal unsafe static void RunInternal(int A_0, ulong A_1, uint A_2, uint A_3, void*[] A_4, void* A_5)
		{
			1beaa6fd.4b935237(A_0).9a70f6ec(A_1, A_2, A_3, A_4, A_5);
		}
	}
}
