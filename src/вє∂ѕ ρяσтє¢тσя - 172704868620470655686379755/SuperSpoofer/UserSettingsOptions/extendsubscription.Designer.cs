namespace SuperSpoofer.UserSettingsOptions
{
	// Token: 0x02000018 RID: 24
	public partial class extendsubscription : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
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

		// Token: 0x040000B1 RID: 177
		private global::System.ComponentModel.IContainer components = null;
	}
}
