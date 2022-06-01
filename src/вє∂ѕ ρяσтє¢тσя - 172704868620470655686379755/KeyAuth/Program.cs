using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x0200000E RID: 14
	internal static class Program
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00009AD8 File Offset: 0x00007CD8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
