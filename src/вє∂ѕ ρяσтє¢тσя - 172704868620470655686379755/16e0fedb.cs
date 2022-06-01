using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200009D RID: 157
internal class 16e0fedb
{
	// Token: 0x060002BE RID: 702 RVA: 0x000226D0 File Offset: 0x000208D0
	public unsafe 16e0fedb(Module A_1, void* A_2)
	{
		bool flag = ((16e0fedb.3418847a*)A_2)->96604991 != 1752394086U;
		if (flag)
		{
			throw new InvalidProgramException();
		}
		this.315655e6 = new Dictionary<uint, 16e0fedb.986dd555>();
		this.8780f40d = new Dictionary<uint, string>();
		this.280d39e3 = new Dictionary<uint, 62af8ce4>();
		byte* ptr = (byte*)A_2 + sizeof(16e0fedb.3418847a);
		int num = 0;
		while ((long)num < (long)((ulong)((16e0fedb.3418847a*)A_2)->6bcb75bc))
		{
			uint key = b0e33cb9.b03bbec4(ref ptr);
			int eedbdb = (int)b0e33cb9.9e9dbb53(b0e33cb9.b03bbec4(ref ptr));
			this.315655e6[key] = new 16e0fedb.986dd555
			{
				ae148a4f = A_1,
				eedbdb59 = eedbdb
			};
			num++;
		}
		int num2 = 0;
		while ((long)num2 < (long)((ulong)((16e0fedb.3418847a*)A_2)->4608d5eb))
		{
			uint key2 = b0e33cb9.b03bbec4(ref ptr);
			uint num3 = b0e33cb9.b03bbec4(ref ptr);
			this.8780f40d[key2] = new string((char*)ptr, 0, (int)num3);
			ptr += num3 << 1;
			num2++;
		}
		int num4 = 0;
		while ((long)num4 < (long)((ulong)((16e0fedb.3418847a*)A_2)->3410724e))
		{
			this.280d39e3[b0e33cb9.b03bbec4(ref ptr)] = new 62af8ce4(ref ptr, A_1);
			num4++;
		}
		this.4e28da60((byte*)A_2);
		this.547d8608 = A_1;
		16e0fedb.6489a394[A_1] = this;
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002A11 File Offset: 0x00000C11
	public Module eeca267e()
	{
		return this.547d8608;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002A19 File Offset: 0x00000C19
	public unsafe byte* aa571bc5()
	{
		return this.a0fdf1c7;
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002A21 File Offset: 0x00000C21
	public unsafe void 4e28da60(byte* A_1)
	{
		this.a0fdf1c7 = A_1;
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00022824 File Offset: 0x00020A24
	public static 16e0fedb 4b935237(Module A_0)
	{
		Dictionary<Module, 16e0fedb> obj = 16e0fedb.6489a394;
		16e0fedb result;
		lock (obj)
		{
			bool flag = !16e0fedb.6489a394.TryGetValue(A_0, out result);
			if (flag)
			{
				result = (16e0fedb.6489a394[A_0] = 10618832.3a88c9e9(A_0));
			}
		}
		return result;
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0002288C File Offset: 0x00020A8C
	public MemberInfo cee44a3f(uint A_1)
	{
		return this.315655e6[A_1].924fa6b0();
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x000228B0 File Offset: 0x00020AB0
	public string f3c2d292(uint A_1)
	{
		bool flag = A_1 == 0U;
		string result;
		if (flag)
		{
			result = null;
		}
		else
		{
			result = this.8780f40d[A_1];
		}
		return result;
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x000228DC File Offset: 0x00020ADC
	public 62af8ce4 cd7bd0c9(uint A_1)
	{
		return this.280d39e3[A_1];
	}

	// Token: 0x040001EF RID: 495
	private static readonly Dictionary<Module, 16e0fedb> 6489a394 = new Dictionary<Module, 16e0fedb>();

	// Token: 0x040001F0 RID: 496
	private readonly Dictionary<uint, 62af8ce4> 280d39e3;

	// Token: 0x040001F1 RID: 497
	private readonly Dictionary<uint, 16e0fedb.986dd555> 315655e6;

	// Token: 0x040001F2 RID: 498
	private readonly Dictionary<uint, string> 8780f40d;

	// Token: 0x040001F3 RID: 499
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Module 547d8608;

	// Token: 0x040001F4 RID: 500
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private unsafe byte* a0fdf1c7;

	// Token: 0x020000C9 RID: 201
	private struct 3418847a
	{
		// Token: 0x040002DF RID: 735
		public readonly uint 96604991;

		// Token: 0x040002E0 RID: 736
		public readonly uint 6bcb75bc;

		// Token: 0x040002E1 RID: 737
		public readonly uint 4608d5eb;

		// Token: 0x040002E2 RID: 738
		public readonly uint 3410724e;
	}

	// Token: 0x020000CA RID: 202
	private class 986dd555
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00027DD8 File Offset: 0x00025FD8
		public MemberInfo 924fa6b0()
		{
			MemberInfo result;
			if ((result = this.c44c7362) == null)
			{
				result = (this.c44c7362 = this.ae148a4f.ResolveMember(this.eedbdb59));
			}
			return result;
		}

		// Token: 0x040002E3 RID: 739
		public Module ae148a4f;

		// Token: 0x040002E4 RID: 740
		public MemberInfo c44c7362;

		// Token: 0x040002E5 RID: 741
		public int eedbdb59;
	}
}
