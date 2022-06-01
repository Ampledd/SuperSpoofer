using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x02000090 RID: 144
internal class f6dce402
{
	// Token: 0x06000287 RID: 647 RVA: 0x0001FEF4 File Offset: 0x0001E0F4
	public 1581069d cb15379(uint A_1)
	{
		bool flag = A_1 > this.8c762241;
		1581069d result;
		if (flag)
		{
			result = 1581069d.89f2356f;
		}
		else
		{
			uint index = A_1 >> 6;
			result = this.4f64c3ea[(int)index][(int)(A_1 & 63U)];
		}
		return result;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0001FF34 File Offset: 0x0001E134
	public void af836684(uint A_1, 1581069d A_2)
	{
		bool flag = A_1 > this.8c762241;
		if (!flag)
		{
			uint index = A_1 >> 6;
			this.4f64c3ea[(int)index][(int)(A_1 & 63U)] = A_2;
		}
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0001FF6C File Offset: 0x0001E16C
	public void 83d7c013(uint A_1)
	{
		bool flag = A_1 > 2147483647U;
		if (flag)
		{
			throw new StackOverflowException();
		}
		uint num = A_1 >> 6;
		bool flag2 = (ulong)num >= (ulong)((long)this.4f64c3ea.Count);
		if (flag2)
		{
			do
			{
				this.4f64c3ea.Add(new 1581069d[64]);
			}
			while ((ulong)num >= (ulong)((long)this.4f64c3ea.Count));
		}
		else
		{
			bool flag3 = (ulong)num < (ulong)((long)(this.4f64c3ea.Count - 2));
			if (flag3)
			{
				do
				{
					this.4f64c3ea.RemoveAt(this.4f64c3ea.Count - 1);
				}
				while ((ulong)num < (ulong)((long)(this.4f64c3ea.Count - 2)));
			}
		}
		uint num2 = (A_1 & 63U) + 1U;
		1581069d[] array = this.4f64c3ea[(int)num];
		while ((ulong)num2 < (ulong)((long)array.Length) && array[(int)num2].c41a9534() != null)
		{
			array[(int)num2++] = 1581069d.89f2356f;
		}
		bool flag4 = (ulong)num2 == (ulong)((long)array.Length) && (ulong)(num + 1U) < (ulong)((long)this.4f64c3ea.Count);
		if (flag4)
		{
			num2 = 0U;
			array = this.4f64c3ea[(int)(num + 1U)];
			while ((ulong)num2 < (ulong)((long)array.Length) && array[(int)num2].c41a9534() != null)
			{
				array[(int)num2++] = 1581069d.89f2356f;
			}
		}
		this.8c762241 = A_1;
		this.a6c64656();
	}

	// Token: 0x0600028A RID: 650 RVA: 0x000200E0 File Offset: 0x0001E2E0
	private void a6c64656()
	{
		while (this.7a7942f7 != null && this.7a7942f7.636e70be > this.8c762241)
		{
			this.7a7942f7 = this.7a7942f7.cad4221b();
		}
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00020124 File Offset: 0x0001E324
	public IntPtr 8730f0fa(uint A_1, uint A_2)
	{
		f6dce402.c86d96ac c86d96ac = new f6dce402.c86d96ac
		{
			636e70be = A_1,
			4c846105 = Marshal.AllocHGlobal((int)A_2)
		};
		f6dce402.c86d96ac 574cdea;
		for (574cdea = this.7a7942f7; 574cdea != null; 574cdea = 574cdea.574cdea0)
		{
			bool flag = 574cdea.574cdea0 == null || 574cdea.574cdea0.636e70be < A_1;
			if (flag)
			{
				break;
			}
		}
		bool flag2 = 574cdea == null;
		if (flag2)
		{
			this.7a7942f7 = c86d96ac;
		}
		else
		{
			c86d96ac.574cdea0 = 574cdea.574cdea0;
			574cdea.574cdea0 = c86d96ac;
		}
		return c86d96ac.4c846105;
	}

	// Token: 0x0600028C RID: 652 RVA: 0x000201BC File Offset: 0x0001E3BC
	public void 92ecc9bd()
	{
		for (f6dce402.c86d96ac c86d96ac = this.7a7942f7; c86d96ac != null; c86d96ac = c86d96ac.cad4221b())
		{
		}
		this.7a7942f7 = null;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x000201EC File Offset: 0x0001E3EC
	protected virtual void be4b7ff8()
	{
		try
		{
			this.92ecc9bd();
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0002021C File Offset: 0x0001E41C
	public void 5f1317f4(uint A_1, f087c8e3 A_2, Type A_3)
	{
		bool flag = A_1 > this.8c762241;
		if (flag)
		{
			throw new ExecutionEngineException();
		}
		1581069d[] array = this.4f64c3ea[(int)(A_1 >> 6)];
		uint num = A_1 & 63U;
		bool isEnum = A_3.IsEnum;
		if (isEnum)
		{
			A_3 = Enum.GetUnderlyingType(A_3);
		}
		bool flag2 = A_3.IsPrimitive || A_3.IsPointer;
		if (flag2)
		{
			array[(int)num].16edd62d(A_2);
			de06eb40.3dc4659f(A_2, A_3);
		}
		else
		{
			array[(int)num].143dc1a8(A_2, A_3);
		}
	}

	// Token: 0x0400015E RID: 350
	private f6dce402.c86d96ac 7a7942f7;

	// Token: 0x0400015F RID: 351
	private readonly List<1581069d[]> 4f64c3ea = new List<1581069d[]>();

	// Token: 0x04000160 RID: 352
	private uint 8c762241;

	// Token: 0x020000BF RID: 191
	private class c86d96ac
	{
		// Token: 0x06000369 RID: 873 RVA: 0x00027D38 File Offset: 0x00025F38
		protected virtual void be4b7ff8()
		{
			try
			{
				bool flag = this.4c846105 != IntPtr.Zero;
				if (flag)
				{
					Marshal.FreeHGlobal(this.4c846105);
					this.4c846105 = IntPtr.Zero;
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00027D90 File Offset: 0x00025F90
		public f6dce402.c86d96ac cad4221b()
		{
			bool flag = this.4c846105 != IntPtr.Zero;
			if (flag)
			{
				Marshal.FreeHGlobal(this.4c846105);
				this.4c846105 = IntPtr.Zero;
			}
			return this.574cdea0;
		}

		// Token: 0x040002DC RID: 732
		public uint 636e70be;

		// Token: 0x040002DD RID: 733
		public IntPtr 4c846105;

		// Token: 0x040002DE RID: 734
		public f6dce402.c86d96ac 574cdea0;
	}
}
