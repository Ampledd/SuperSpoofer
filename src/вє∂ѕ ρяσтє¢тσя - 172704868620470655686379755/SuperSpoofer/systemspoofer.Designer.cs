﻿namespace SuperSpoofer
{
	// Token: 0x02000013 RID: 19
	public partial class systemspoofer : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000D024 File Offset: 0x0000B224
		protected override void Dispose(bool disposing)
		{
			uint num4;
			if ((disposing ? 1U : 0U) != (uint)0)
			{
				uint num = (object)this.components;
				uint num2 = null;
				uint num3 = num - num2;
				byte b;
				global::OldRod.Core.CodeGen.VmHelper.UpdateFL(num3, num2, num, num3, ref b, 23);
				num = ~((uint)b & (uint)20);
				num3 = ~num;
				global::OldRod.Core.CodeGen.VmHelper.UpdateFL(num, num, num3, num3, ref b, 18);
				num4 = ((uint)b & (uint)16);
			}
			else
			{
				num4 = (uint)0;
			}
			if (num4 != (uint)0)
			{
				((global::System.IDisposable)this.components).Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000086 RID: 134
		private global::System.ComponentModel.IContainer components = null;
	}
}
