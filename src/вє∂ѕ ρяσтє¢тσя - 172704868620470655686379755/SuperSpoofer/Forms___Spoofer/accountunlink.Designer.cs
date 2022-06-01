namespace SuperSpoofer.Forms___Spoofer
{
	// Token: 0x02000019 RID: 25
	public partial class accountunlink : global::System.Windows.Forms.Form
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00010758 File Offset: 0x0000E958
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

		// Token: 0x040000BE RID: 190
		private global::System.ComponentModel.IContainer components = null;
	}
}
