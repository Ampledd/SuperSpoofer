using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer.Forms___Spoofer
{
	// Token: 0x02000019 RID: 25
	public partial class accountunlink : Form
	{
		// Token: 0x060000FC RID: 252 RVA: 0x000106EC File Offset: 0x0000E8EC
		public accountunlink()
		{
			accountunlink.__VMFUNCTION__41750(this);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00010714 File Offset: 0x0000E914
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000107F8 File Offset: 0x0000E9F8
		public static void __VMFUNCTION__41750(accountunlink A_0)
		{
			A_0.siticonePanel2 = new SiticonePanel();
			A_0.label1 = new Label();
			A_0.siticoneButton1 = new SiticoneButton();
			A_0.label2 = new Label();
			A_0.siticoneButton2 = new SiticoneButton();
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.siticonePanel2.SuspendLayout();
			A_0.siticonePanel1.SuspendLayout();
			A_0.SuspendLayout();
			A_0.siticonePanel2.BackColor = Color.FromArgb(27, 30, 34);
			A_0.siticonePanel2.Controls.Add(A_0.label1);
			A_0.siticonePanel2.Controls.Add(A_0.siticoneButton1);
			A_0.siticonePanel2.Location = new Point(271, 84);
			A_0.siticonePanel2.Name = "siticonePanel2";
			A_0.siticonePanel2.ShadowDecoration.Parent = A_0.siticonePanel2;
			A_0.siticonePanel2.Size = new Size(181, 104);
			A_0.siticonePanel2.TabIndex = 18;
			A_0.label1.AutoSize = true;
			A_0.label1.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.Gainsboro;
			A_0.label1.Location = new Point(16, 14);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(141, 34);
			A_0.label1.TabIndex = 9;
			A_0.label1.Text = "Unlink Discord account\r\nfrom FiveM's cache!";
			A_0.label1.TextAlign = ContentAlignment.MiddleCenter;
			A_0.siticoneButton1.CheckedState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.CustomImages.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.FillColor = Color.DodgerBlue;
			A_0.siticoneButton1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton1.ForeColor = Color.White;
			A_0.siticoneButton1.HoveredState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Location = new Point(19, 63);
			A_0.siticoneButton1.Name = "siticoneButton1";
			A_0.siticoneButton1.ShadowDecoration.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Size = new Size(143, 26);
			A_0.siticoneButton1.TabIndex = 6;
			A_0.siticoneButton1.Text = "Run";
			A_0.label2.AutoSize = true;
			A_0.label2.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label2.ForeColor = Color.Gainsboro;
			A_0.label2.Location = new Point(16, 14);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(153, 34);
			A_0.label2.TabIndex = 8;
			A_0.label2.Text = "Unlink Xbox-Live account\r\nfrom FiveM's cache!";
			A_0.label2.TextAlign = ContentAlignment.MiddleCenter;
			A_0.siticoneButton2.CheckedState.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.CustomImages.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.FillColor = Color.DodgerBlue;
			A_0.siticoneButton2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton2.ForeColor = Color.White;
			A_0.siticoneButton2.HoveredState.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.Location = new Point(19, 63);
			A_0.siticoneButton2.Name = "siticoneButton2";
			A_0.siticoneButton2.ShadowDecoration.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.Size = new Size(143, 26);
			A_0.siticoneButton2.TabIndex = 6;
			A_0.siticoneButton2.Text = "Run";
			A_0.siticoneButton2.Click += A_0.__VMFUNCTION__A0E05;
			A_0.siticonePanel1.BackColor = Color.FromArgb(27, 30, 34);
			A_0.siticonePanel1.Controls.Add(A_0.label2);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneButton2);
			A_0.siticonePanel1.Location = new Point(84, 84);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(181, 104);
			A_0.siticonePanel1.TabIndex = 17;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(537, 272);
			A_0.Controls.Add(A_0.siticonePanel2);
			A_0.Controls.Add(A_0.siticonePanel1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "accountunlink";
			A_0.Text = "accountunlink";
			A_0.siticonePanel2.ResumeLayout(false);
			A_0.siticonePanel2.PerformLayout();
			A_0.siticonePanel1.ResumeLayout(false);
			A_0.siticonePanel1.PerformLayout();
			A_0.ResumeLayout(false);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00010D94 File Offset: 0x0000EF94
		public unsafe void __VMFUNCTION__A0E05(object A_1, EventArgs A_2)
		{
			accountunlink.<siticoneButton2_Click>d__3 <siticoneButton2_Click>d__ = new accountunlink.<siticoneButton2_Click>d__3();
			<siticoneButton2_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneButton2_Click>d__.<>4__this = this;
			<siticoneButton2_Click>d__.sender = A_1;
			<siticoneButton2_Click>d__.e = A_2;
			<siticoneButton2_Click>d__.<>1__state = -1;
			((accountunlink.<siticoneButton2_Click>d__3*)<siticoneButton2_Click>d__).<>t__builder.Start<accountunlink.<siticoneButton2_Click>d__3>(ref <siticoneButton2_Click>d__);
		}

		// Token: 0x040000BF RID: 191
		private SiticonePanel siticonePanel2;

		// Token: 0x040000C0 RID: 192
		private Label label1;

		// Token: 0x040000C1 RID: 193
		private SiticoneButton siticoneButton1;

		// Token: 0x040000C2 RID: 194
		private Label label2;

		// Token: 0x040000C3 RID: 195
		private SiticoneButton siticoneButton2;

		// Token: 0x040000C4 RID: 196
		private SiticonePanel siticonePanel1;
	}
}
