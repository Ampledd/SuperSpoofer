using System;
using System.ComponentModel;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer
{
	// Token: 0x02000014 RID: 20
	public partial class userinformation : Form
	{
		// Token: 0x060000DE RID: 222 RVA: 0x0000E8BC File Offset: 0x0000CABC
		public userinformation()
		{
			userinformation.__VMFUNCTION__3F0B1(this);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime3 = default(DateTime);
			dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return dateTime.AddSeconds((double)((ulong)unixtime)).ToLocalTime();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000E94C File Offset: 0x0000CB4C
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000E990 File Offset: 0x0000CB90
		public static void dcrpc()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000222E File Offset: 0x0000042E
		public static void __VMFUNCTION__3F0B1(object)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000222F File Offset: 0x0000042F
		public void __VMFUNCTION__5BB37(object, PaintEventArgs)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002230 File Offset: 0x00000430
		public void __VMFUNCTION__93132(object, EventArgs)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002231 File Offset: 0x00000431
		public void __VMFUNCTION__2DF77(object, EventArgs)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002232 File Offset: 0x00000432
		public void __VMFUNCTION__4012F(object, EventArgs)
		{
		}

		// Token: 0x0400009B RID: 155
		private Panel panel1;

		// Token: 0x0400009C RID: 156
		private ColorWithAlpha colorWithAlpha1;

		// Token: 0x0400009D RID: 157
		private SiticonePanel siticonePanel2;

		// Token: 0x0400009E RID: 158
		private SiticoneGradientButton lockedserials;

		// Token: 0x0400009F RID: 159
		private SiticoneGradientButton userdetails;

		// Token: 0x040000A0 RID: 160
		private ColorDialog colorDialog1;

		// Token: 0x040000A1 RID: 161
		private AlphaGradientPanel mainn;

		// Token: 0x040000A2 RID: 162
		private SiticoneGradientButton bugrepo;

		// Token: 0x040000A3 RID: 163
		private SiticonePanel siticonePanel1;
	}
}
