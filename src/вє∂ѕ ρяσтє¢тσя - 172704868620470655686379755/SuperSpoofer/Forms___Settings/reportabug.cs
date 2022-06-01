using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace SuperSpoofer.Forms___Settings
{
	// Token: 0x0200001B RID: 27
	public partial class reportabug : Form
	{
		// Token: 0x06000106 RID: 262 RVA: 0x000118E8 File Offset: 0x0000FAE8
		public reportabug()
		{
			reportabug.__VMFUNCTION__42B53(this);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00011910 File Offset: 0x0000FB10
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000119F4 File Offset: 0x0000FBF4
		public static void __VMFUNCTION__42B53(reportabug A_0)
		{
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.label4 = new Label();
			A_0.siticoneTextBox3 = new SiticoneTextBox();
			A_0.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			A_0.label3 = new Label();
			A_0.siticoneTextBox2 = new SiticoneTextBox();
			A_0.label2 = new Label();
			A_0.siticoneTextBox1 = new SiticoneTextBox();
			A_0.label1 = new Label();
			A_0.user = new SiticoneTextBox();
			A_0.label10 = new Label();
			A_0.siticoneCirclePictureBox1 = new SiticoneCirclePictureBox();
			A_0.siticonePanel2 = new SiticonePanel();
			A_0.siticonePanel1.SuspendLayout();
			((ISupportInitialize)A_0.siticoneCirclePictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticonePanel1.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticonePanel1.BorderColor = Color.Black;
			A_0.siticonePanel1.BorderThickness = 1;
			A_0.siticonePanel1.Controls.Add(A_0.label4);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneTextBox3);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneRoundedGradientButton3);
			A_0.siticonePanel1.Controls.Add(A_0.label3);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneTextBox2);
			A_0.siticonePanel1.Controls.Add(A_0.label2);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneTextBox1);
			A_0.siticonePanel1.Controls.Add(A_0.label1);
			A_0.siticonePanel1.Controls.Add(A_0.user);
			A_0.siticonePanel1.Controls.Add(A_0.label10);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneCirclePictureBox1);
			A_0.siticonePanel1.Controls.Add(A_0.siticonePanel2);
			A_0.siticonePanel1.FillColor = Color.FromArgb(41, 42, 62);
			A_0.siticonePanel1.Location = new Point(200, 20);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(409, 469);
			A_0.siticonePanel1.TabIndex = 124;
			A_0.label4.AutoSize = true;
			A_0.label4.BackColor = Color.Transparent;
			A_0.label4.Font = new Font("Ebrima", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label4.ForeColor = Color.LightGray;
			A_0.label4.Location = new Point(26, 130);
			A_0.label4.Name = "label4";
			A_0.label4.Size = new Size(99, 15);
			A_0.label4.TabIndex = 162;
			A_0.label4.Text = "Discord account:";
			A_0.siticoneTextBox3.BorderColor = Color.FromArgb(70, 70, 70);
			A_0.siticoneTextBox3.BorderRadius = 2;
			A_0.siticoneTextBox3.Cursor = Cursors.IBeam;
			A_0.siticoneTextBox3.DefaultText = "";
			A_0.siticoneTextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.siticoneTextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.siticoneTextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox3.DisabledState.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox3.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneTextBox3.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			A_0.siticoneTextBox3.FocusedState.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.siticoneTextBox3.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.siticoneTextBox3.HoveredState.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.Location = new Point(29, 148);
			A_0.siticoneTextBox3.Name = "siticoneTextBox3";
			A_0.siticoneTextBox3.PasswordChar = (char)0;
			A_0.siticoneTextBox3.PlaceholderForeColor = Color.Gray;
			A_0.siticoneTextBox3.PlaceholderText = "Enter details...";
			A_0.siticoneTextBox3.SelectedText = "";
			A_0.siticoneTextBox3.ShadowDecoration.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.Size = new Size(353, 36);
			A_0.siticoneTextBox3.TabIndex = 161;
			A_0.siticoneRoundedGradientButton3.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneRoundedGradientButton3.BorderColor = Color.Transparent;
			A_0.siticoneRoundedGradientButton3.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton3.CheckedState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.CustomImages.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.FillColor = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.FillColor2 = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton3.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton3.HoveredState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Location = new Point(29, 432);
			A_0.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			A_0.siticoneRoundedGradientButton3.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Size = new Size(353, 22);
			A_0.siticoneRoundedGradientButton3.TabIndex = 160;
			A_0.siticoneRoundedGradientButton3.Text = "Send Bug Report";
			A_0.siticoneRoundedGradientButton3.Click += A_0.__VMFUNCTION__842A8;
			A_0.label3.AutoSize = true;
			A_0.label3.BackColor = Color.Transparent;
			A_0.label3.Font = new Font("Ebrima", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label3.ForeColor = Color.LightGray;
			A_0.label3.Location = new Point(26, 257);
			A_0.label3.Name = "label3";
			A_0.label3.Size = new Size(105, 15);
			A_0.label3.TabIndex = 159;
			A_0.label3.Text = "Issue Description:";
			A_0.siticoneTextBox2.BorderColor = Color.FromArgb(70, 70, 70);
			A_0.siticoneTextBox2.BorderRadius = 2;
			A_0.siticoneTextBox2.Cursor = Cursors.IBeam;
			A_0.siticoneTextBox2.DefaultText = "";
			A_0.siticoneTextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.siticoneTextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.siticoneTextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox2.DisabledState.Parent = A_0.siticoneTextBox2;
			A_0.siticoneTextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox2.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneTextBox2.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			A_0.siticoneTextBox2.FocusedState.Parent = A_0.siticoneTextBox2;
			A_0.siticoneTextBox2.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.siticoneTextBox2.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.siticoneTextBox2.HoveredState.Parent = A_0.siticoneTextBox2;
			A_0.siticoneTextBox2.Location = new Point(29, 275);
			A_0.siticoneTextBox2.Multiline = true;
			A_0.siticoneTextBox2.Name = "siticoneTextBox2";
			A_0.siticoneTextBox2.PasswordChar = (char)0;
			A_0.siticoneTextBox2.PlaceholderForeColor = Color.Gray;
			A_0.siticoneTextBox2.PlaceholderText = "Enter details...";
			A_0.siticoneTextBox2.SelectedText = "";
			A_0.siticoneTextBox2.ShadowDecoration.Parent = A_0.siticoneTextBox2;
			A_0.siticoneTextBox2.Size = new Size(353, 141);
			A_0.siticoneTextBox2.TabIndex = 158;
			A_0.label2.AutoSize = true;
			A_0.label2.BackColor = Color.Transparent;
			A_0.label2.Font = new Font("Ebrima", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label2.ForeColor = Color.LightGray;
			A_0.label2.Location = new Point(26, 193);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(179, 15);
			A_0.label2.TabIndex = 157;
			A_0.label2.Text = "Issue subject (Ex: Spoof Failed):";
			A_0.siticoneTextBox1.BorderColor = Color.FromArgb(70, 70, 70);
			A_0.siticoneTextBox1.BorderRadius = 2;
			A_0.siticoneTextBox1.Cursor = Cursors.IBeam;
			A_0.siticoneTextBox1.DefaultText = "";
			A_0.siticoneTextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.siticoneTextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.siticoneTextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox1.DisabledState.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox1.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneTextBox1.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			A_0.siticoneTextBox1.FocusedState.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.siticoneTextBox1.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.siticoneTextBox1.HoveredState.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.Location = new Point(29, 211);
			A_0.siticoneTextBox1.Name = "siticoneTextBox1";
			A_0.siticoneTextBox1.PasswordChar = (char)0;
			A_0.siticoneTextBox1.PlaceholderForeColor = Color.Gray;
			A_0.siticoneTextBox1.PlaceholderText = "Enter details...";
			A_0.siticoneTextBox1.SelectedText = "";
			A_0.siticoneTextBox1.ShadowDecoration.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.Size = new Size(353, 36);
			A_0.siticoneTextBox1.TabIndex = 156;
			A_0.label1.AutoSize = true;
			A_0.label1.BackColor = Color.Transparent;
			A_0.label1.Font = new Font("Ebrima", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.LightGray;
			A_0.label1.Location = new Point(26, 71);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(135, 15);
			A_0.label1.TabIndex = 155;
			A_0.label1.Text = "SuperSpoofer account:";
			A_0.user.BorderColor = Color.FromArgb(70, 70, 70);
			A_0.user.BorderRadius = 2;
			A_0.user.Cursor = Cursors.IBeam;
			A_0.user.DefaultText = "";
			A_0.user.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.user.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.user.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.user.DisabledState.Parent = A_0.user;
			A_0.user.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.user.FillColor = Color.FromArgb(25, 26, 30);
			A_0.user.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			A_0.user.FocusedState.Parent = A_0.user;
			A_0.user.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.user.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.user.HoveredState.Parent = A_0.user;
			A_0.user.Location = new Point(29, 89);
			A_0.user.Name = "user";
			A_0.user.PasswordChar = (char)0;
			A_0.user.PlaceholderForeColor = Color.Gray;
			A_0.user.PlaceholderText = "Enter details...";
			A_0.user.SelectedText = "";
			A_0.user.ShadowDecoration.Parent = A_0.user;
			A_0.user.Size = new Size(353, 36);
			A_0.user.TabIndex = 154;
			A_0.label10.AutoSize = true;
			A_0.label10.BackColor = Color.Transparent;
			A_0.label10.Font = new Font("Ebrima", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label10.ForeColor = Color.White;
			A_0.label10.Location = new Point(5, 6);
			A_0.label10.Name = "label10";
			A_0.label10.Size = new Size(92, 17);
			A_0.label10.TabIndex = 102;
			A_0.label10.Text = "Report a bug:";
			A_0.siticoneCirclePictureBox1.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneCirclePictureBox1.Location = new Point(326, 3);
			A_0.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
			A_0.siticoneCirclePictureBox1.ShadowDecoration.Mode = ShadowMode.Circle;
			A_0.siticoneCirclePictureBox1.ShadowDecoration.Parent = A_0.siticoneCirclePictureBox1;
			A_0.siticoneCirclePictureBox1.Size = new Size(80, 48);
			A_0.siticoneCirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.siticoneCirclePictureBox1.TabIndex = 101;
			A_0.siticoneCirclePictureBox1.TabStop = false;
			A_0.siticonePanel2.FillColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel2.Location = new Point(4, 58);
			A_0.siticonePanel2.Name = "siticonePanel2";
			A_0.siticonePanel2.ShadowDecoration.Parent = A_0.siticonePanel2;
			A_0.siticonePanel2.Size = new Size(414, 1);
			A_0.siticonePanel2.TabIndex = 100;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(809, 508);
			A_0.Controls.Add(A_0.siticonePanel1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "reportabug";
			A_0.Text = "reportabug";
			A_0.siticonePanel1.ResumeLayout(false);
			A_0.siticonePanel1.PerformLayout();
			((ISupportInitialize)A_0.siticoneCirclePictureBox1).EndInit();
			A_0.ResumeLayout(false);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002234 File Offset: 0x00000434
		public void __VMFUNCTION__842A8(object, EventArgs)
		{
		}

		// Token: 0x040000CE RID: 206
		private SiticonePanel siticonePanel1;

		// Token: 0x040000CF RID: 207
		private Label label4;

		// Token: 0x040000D0 RID: 208
		private SiticoneTextBox siticoneTextBox3;

		// Token: 0x040000D1 RID: 209
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x040000D2 RID: 210
		private Label label3;

		// Token: 0x040000D3 RID: 211
		private SiticoneTextBox siticoneTextBox2;

		// Token: 0x040000D4 RID: 212
		private Label label2;

		// Token: 0x040000D5 RID: 213
		private SiticoneTextBox siticoneTextBox1;

		// Token: 0x040000D6 RID: 214
		private Label label1;

		// Token: 0x040000D7 RID: 215
		private SiticoneTextBox user;

		// Token: 0x040000D8 RID: 216
		private Label label10;

		// Token: 0x040000D9 RID: 217
		private SiticoneCirclePictureBox siticoneCirclePictureBox1;

		// Token: 0x040000DA RID: 218
		private SiticonePanel siticonePanel2;
	}
}
