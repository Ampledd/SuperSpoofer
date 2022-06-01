using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KeyAuth;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer.UserSettingsOptions
{
	// Token: 0x02000017 RID: 23
	public partial class changepassword : Form
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		public changepassword()
		{
			changepassword.__VMFUNCTION__263CD(this);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000EC10 File Offset: 0x0000CE10
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime3 = default(DateTime);
			dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return dateTime.AddSeconds((double)((ulong)unixtime)).ToLocalTime();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000ED18 File Offset: 0x0000CF18
		public static void __VMFUNCTION__263CD(changepassword A_0)
		{
			A_0.components = (IContainer)new Container();
			ResourceManager resourceManager = new ComponentResourceManager(typeof(changepassword));
			A_0.label10 = new Label();
			A_0.siticonePanel2 = new SiticonePanel();
			A_0.label1 = new Label();
			A_0.label7 = new Label();
			A_0.newpas = new SiticoneTextBox();
			A_0.hwidr = new SiticoneTextBox();
			A_0.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			A_0.siticoneControlBox1 = new SiticoneControlBox();
			A_0.siticoneDragControl1 = new SiticoneDragControl(A_0.components);
			A_0.SuspendLayout();
			A_0.label10.AutoSize = true;
			A_0.label10.BackColor = Color.Transparent;
			A_0.label10.Font = new Font("Ebrima", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label10.ForeColor = Color.White;
			A_0.label10.Location = new Point(12, 9);
			A_0.label10.Name = "label10";
			A_0.label10.Size = new Size(165, 34);
			A_0.label10.TabIndex = 103;
			A_0.label10.Text = "superspoofer.cc account: \r\nChange Password";
			A_0.siticonePanel2.FillColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel2.Location = new Point(-18, 91);
			A_0.siticonePanel2.Name = "siticonePanel2";
			A_0.siticonePanel2.ShadowDecoration.Parent = A_0.siticonePanel2;
			A_0.siticonePanel2.Size = new Size(355, 1);
			A_0.siticonePanel2.TabIndex = 105;
			A_0.label1.AutoSize = true;
			A_0.label1.BackColor = Color.Transparent;
			A_0.label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.DarkGray;
			A_0.label1.Location = new Point(15, 161);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(104, 13);
			A_0.label1.TabIndex = 138;
			A_0.label1.Text = "Set new password:";
			A_0.label7.AutoSize = true;
			A_0.label7.BackColor = Color.Transparent;
			A_0.label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label7.ForeColor = Color.DarkGray;
			A_0.label7.Location = new Point(15, 105);
			A_0.label7.Name = "label7";
			A_0.label7.Size = new Size(107, 13);
			A_0.label7.TabIndex = 137;
			A_0.label7.Text = "Account username:";
			A_0.newpas.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.newpas.Cursor = Cursors.IBeam;
			A_0.newpas.DefaultText = "";
			A_0.newpas.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.newpas.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.newpas.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.newpas.DisabledState.Parent = A_0.newpas;
			A_0.newpas.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.newpas.FillColor = Color.FromArgb(25, 26, 30);
			A_0.newpas.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.newpas.FocusedState.Parent = A_0.newpas;
			A_0.newpas.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.newpas.HoveredState.Parent = A_0.newpas;
			A_0.newpas.Location = new Point(18, 177);
			A_0.newpas.Name = "newpas";
			A_0.newpas.PasswordChar = (char)0;
			A_0.newpas.PlaceholderText = "";
			A_0.newpas.SelectedText = "";
			A_0.newpas.ShadowDecoration.Parent = A_0.newpas;
			A_0.newpas.Size = new Size(296, 30);
			A_0.newpas.TabIndex = 135;
			A_0.hwidr.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.hwidr.Cursor = Cursors.Arrow;
			A_0.hwidr.DefaultText = "";
			A_0.hwidr.DisabledState.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.hwidr.DisabledState.FillColor = Color.FromArgb(25, 26, 30);
			A_0.hwidr.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.hwidr.DisabledState.Parent = A_0.hwidr;
			A_0.hwidr.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.hwidr.Enabled = false;
			A_0.hwidr.FillColor = Color.FromArgb(25, 26, 30);
			A_0.hwidr.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.hwidr.FocusedState.Parent = A_0.hwidr;
			A_0.hwidr.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.hwidr.HoveredState.Parent = A_0.hwidr;
			A_0.hwidr.Location = new Point(18, 121);
			A_0.hwidr.Name = "hwidr";
			A_0.hwidr.PasswordChar = (char)0;
			A_0.hwidr.PlaceholderText = "";
			A_0.hwidr.ReadOnly = true;
			A_0.hwidr.SelectedText = "";
			A_0.hwidr.ShadowDecoration.Parent = A_0.hwidr;
			A_0.hwidr.Size = new Size(296, 30);
			A_0.hwidr.TabIndex = 134;
			A_0.siticoneRoundedGradientButton3.BackColor = Color.FromArgb(50, 54, 73);
			A_0.siticoneRoundedGradientButton3.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton3.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton3.CheckedState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.CustomImages.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.FillColor = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.FillColor2 = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton3.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton3.HoveredState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Location = new Point(104, 218);
			A_0.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			A_0.siticoneRoundedGradientButton3.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Size = new Size(120, 30);
			A_0.siticoneRoundedGradientButton3.TabIndex = 139;
			A_0.siticoneRoundedGradientButton3.Text = "Change Password";
			A_0.siticoneRoundedGradientButton3.Click += A_0.__VMFUNCTION__120C5;
			A_0.siticoneControlBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			A_0.siticoneControlBox1.FillColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneControlBox1.HoveredState.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.IconColor = Color.Red;
			A_0.siticoneControlBox1.Location = new Point(284, 7);
			A_0.siticoneControlBox1.Name = "siticoneControlBox1";
			A_0.siticoneControlBox1.ShadowDecoration.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.Size = new Size(38, 29);
			A_0.siticoneControlBox1.TabIndex = 140;
			A_0.siticoneControlBox1.Click += A_0.__VMFUNCTION__36FA1;
			A_0.siticoneDragControl1.TargetControl = A_0;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(41, 42, 62);
			A_0.ClientSize = new Size(328, 258);
			A_0.Controls.Add(A_0.siticoneControlBox1);
			A_0.Controls.Add(A_0.siticoneRoundedGradientButton3);
			A_0.Controls.Add(A_0.label1);
			A_0.Controls.Add(A_0.label7);
			A_0.Controls.Add(A_0.newpas);
			A_0.Controls.Add(A_0.hwidr);
			A_0.Controls.Add(A_0.siticonePanel2);
			A_0.Controls.Add(A_0.label10);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Icon = (Icon)resourceManager.GetObject("$this.Icon");
			A_0.Name = "changepassword";
			A_0.StartPosition = FormStartPosition.CenterScreen;
			A_0.Text = "changepassword";
			A_0.Load += A_0.__VMFUNCTION__364CA;
			A_0.ResumeLayout(false);
			A_0.PerformLayout();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002233 File Offset: 0x00000433
		public void __VMFUNCTION__120C5(object, EventArgs)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000F758 File Offset: 0x0000D958
		public void __VMFUNCTION__364CA(object A_1, EventArgs A_2)
		{
			this.hwidr.Text = Login.KeyAuthApp.user_data.username;
		}

		// Token: 0x040000A8 RID: 168
		private Label label10;

		// Token: 0x040000A9 RID: 169
		private SiticonePanel siticonePanel2;

		// Token: 0x040000AA RID: 170
		private Label label1;

		// Token: 0x040000AB RID: 171
		private Label label7;

		// Token: 0x040000AC RID: 172
		private SiticoneTextBox newpas;

		// Token: 0x040000AD RID: 173
		private SiticoneTextBox hwidr;

		// Token: 0x040000AE RID: 174
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x040000AF RID: 175
		private SiticoneControlBox siticoneControlBox1;

		// Token: 0x040000B0 RID: 176
		private SiticoneDragControl siticoneDragControl1;
	}
}
