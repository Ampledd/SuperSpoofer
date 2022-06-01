using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using KeyAuth;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer.UserSettingsOptions
{
	// Token: 0x02000018 RID: 24
	public partial class extendsubscription : Form
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0000F788 File Offset: 0x0000D988
		public extendsubscription()
		{
			extendsubscription.__VMFUNCTION__3E2ED(this);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000F850 File Offset: 0x0000DA50
		public static void __VMFUNCTION__3E2ED(extendsubscription A_0)
		{
			A_0.components = (IContainer)new Container();
			ResourceManager resourceManager = new ComponentResourceManager(typeof(extendsubscription));
			A_0.siticoneControlBox1 = new SiticoneControlBox();
			A_0.label10 = new Label();
			A_0.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			A_0.siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			A_0.siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.label1 = new Label();
			A_0.label7 = new Label();
			A_0.newpas = new SiticoneTextBox();
			A_0.hwidr = new SiticoneTextBox();
			A_0.siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			A_0.siticoneDragControl1 = new SiticoneDragControl(A_0.components);
			A_0.SuspendLayout();
			A_0.siticoneControlBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			A_0.siticoneControlBox1.FillColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneControlBox1.HoveredState.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.IconColor = Color.Red;
			A_0.siticoneControlBox1.Location = new Point(424, 12);
			A_0.siticoneControlBox1.Name = "siticoneControlBox1";
			A_0.siticoneControlBox1.ShadowDecoration.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.Size = new Size(38, 29);
			A_0.siticoneControlBox1.TabIndex = 142;
			A_0.siticoneControlBox1.Click += A_0.__VMFUNCTION__73566;
			A_0.label10.AutoSize = true;
			A_0.label10.BackColor = Color.Transparent;
			A_0.label10.Font = new Font("Ebrima", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label10.ForeColor = Color.White;
			A_0.label10.Location = new Point(12, 9);
			A_0.label10.Name = "label10";
			A_0.label10.Size = new Size(165, 34);
			A_0.label10.TabIndex = 141;
			A_0.label10.Text = "superspoofer.cc account: \r\nExtend Subscription";
			A_0.siticoneRoundedGradientButton3.BackColor = Color.FromArgb(50, 54, 73);
			A_0.siticoneRoundedGradientButton3.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton3.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton3.CheckedState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.CustomImages.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.FillColor = Color.DarkCyan;
			A_0.siticoneRoundedGradientButton3.FillColor2 = Color.DarkCyan;
			A_0.siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton3.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton3.HoveredState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Location = new Point(15, 278);
			A_0.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			A_0.siticoneRoundedGradientButton3.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Size = new Size(120, 30);
			A_0.siticoneRoundedGradientButton3.TabIndex = 143;
			A_0.siticoneRoundedGradientButton3.Text = "Weekly";
			A_0.siticoneRoundedGradientButton3.Click += A_0.__VMFUNCTION__45F3F;
			A_0.siticoneRoundedGradientButton1.BackColor = Color.FromArgb(50, 54, 73);
			A_0.siticoneRoundedGradientButton1.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton1.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton1.CheckedState.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.CustomImages.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.FillColor = Color.DarkCyan;
			A_0.siticoneRoundedGradientButton1.FillColor2 = Color.DarkCyan;
			A_0.siticoneRoundedGradientButton1.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton1.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton1.HoveredState.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.Location = new Point(177, 278);
			A_0.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			A_0.siticoneRoundedGradientButton1.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.Size = new Size(120, 30);
			A_0.siticoneRoundedGradientButton1.TabIndex = 144;
			A_0.siticoneRoundedGradientButton1.Text = "Monthly";
			A_0.siticoneRoundedGradientButton1.Click += A_0.__VMFUNCTION__95692;
			A_0.siticoneRoundedGradientButton2.BackColor = Color.FromArgb(50, 54, 73);
			A_0.siticoneRoundedGradientButton2.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton2.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton2.CheckedState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.CustomImages.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.FillColor = Color.DarkCyan;
			A_0.siticoneRoundedGradientButton2.FillColor2 = Color.DarkCyan;
			A_0.siticoneRoundedGradientButton2.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton2.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton2.HoveredState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Location = new Point(342, 278);
			A_0.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			A_0.siticoneRoundedGradientButton2.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Size = new Size(120, 30);
			A_0.siticoneRoundedGradientButton2.TabIndex = 145;
			A_0.siticoneRoundedGradientButton2.Text = "Lifetime";
			A_0.siticoneRoundedGradientButton2.Click += A_0.__VMFUNCTION__41721;
			A_0.siticonePanel1.FillColor = Color.White;
			A_0.siticonePanel1.Location = new Point(-13, 256);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(494, 1);
			A_0.siticonePanel1.TabIndex = 146;
			A_0.label1.AutoSize = true;
			A_0.label1.BackColor = Color.Transparent;
			A_0.label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.DarkGray;
			A_0.label1.Location = new Point(58, 126);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(93, 13);
			A_0.label1.TabIndex = 158;
			A_0.label1.Text = "New license key:";
			A_0.label7.AutoSize = true;
			A_0.label7.BackColor = Color.Transparent;
			A_0.label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label7.ForeColor = Color.DarkGray;
			A_0.label7.Location = new Point(58, 70);
			A_0.label7.Name = "label7";
			A_0.label7.Size = new Size(107, 13);
			A_0.label7.TabIndex = 157;
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
			A_0.newpas.Location = new Point(61, 142);
			A_0.newpas.Name = "newpas";
			A_0.newpas.PasswordChar = (char)0;
			A_0.newpas.PlaceholderText = "";
			A_0.newpas.SelectedText = "";
			A_0.newpas.ShadowDecoration.Parent = A_0.newpas;
			A_0.newpas.Size = new Size(356, 30);
			A_0.newpas.TabIndex = 156;
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
			A_0.hwidr.Location = new Point(61, 86);
			A_0.hwidr.Name = "hwidr";
			A_0.hwidr.PasswordChar = (char)0;
			A_0.hwidr.PlaceholderText = "";
			A_0.hwidr.ReadOnly = true;
			A_0.hwidr.SelectedText = "";
			A_0.hwidr.ShadowDecoration.Parent = A_0.hwidr;
			A_0.hwidr.Size = new Size(356, 30);
			A_0.hwidr.TabIndex = 155;
			A_0.siticoneRoundedGradientButton4.BackColor = Color.FromArgb(50, 54, 73);
			A_0.siticoneRoundedGradientButton4.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton4.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton4.CheckedState.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.CustomImages.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.FillColor = Color.DarkRed;
			A_0.siticoneRoundedGradientButton4.FillColor2 = Color.DarkRed;
			A_0.siticoneRoundedGradientButton4.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton4.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton4.HoveredState.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.Location = new Point(165, 182);
			A_0.siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			A_0.siticoneRoundedGradientButton4.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.Size = new Size(145, 30);
			A_0.siticoneRoundedGradientButton4.TabIndex = 160;
			A_0.siticoneRoundedGradientButton4.Text = "Upgrade Subscription";
			A_0.siticoneRoundedGradientButton4.Click += A_0.__VMFUNCTION__69A15;
			A_0.siticoneDragControl1.TargetControl = A_0;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(41, 42, 62);
			A_0.ClientSize = new Size(474, 321);
			A_0.Controls.Add(A_0.siticoneRoundedGradientButton4);
			A_0.Controls.Add(A_0.label1);
			A_0.Controls.Add(A_0.label7);
			A_0.Controls.Add(A_0.newpas);
			A_0.Controls.Add(A_0.hwidr);
			A_0.Controls.Add(A_0.siticonePanel1);
			A_0.Controls.Add(A_0.siticoneRoundedGradientButton2);
			A_0.Controls.Add(A_0.siticoneRoundedGradientButton1);
			A_0.Controls.Add(A_0.siticoneRoundedGradientButton3);
			A_0.Controls.Add(A_0.siticoneControlBox1);
			A_0.Controls.Add(A_0.label10);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Icon = (Icon)resourceManager.GetObject("$this.Icon");
			A_0.Name = "extendsubscription";
			A_0.StartPosition = FormStartPosition.CenterScreen;
			A_0.Text = "extendsubscription";
			A_0.Load += A_0.__VMFUNCTION__1EAC8;
			A_0.ResumeLayout(false);
			A_0.PerformLayout();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000106BC File Offset: 0x0000E8BC
		public void __VMFUNCTION__1EAC8(object A_1, EventArgs A_2)
		{
			this.hwidr.Text = Login.KeyAuthApp.user_data.username;
		}

		// Token: 0x040000B2 RID: 178
		private SiticoneControlBox siticoneControlBox1;

		// Token: 0x040000B3 RID: 179
		private Label label10;

		// Token: 0x040000B4 RID: 180
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x040000B5 RID: 181
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		// Token: 0x040000B6 RID: 182
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x040000B7 RID: 183
		private SiticonePanel siticonePanel1;

		// Token: 0x040000B8 RID: 184
		private Label label1;

		// Token: 0x040000B9 RID: 185
		private Label label7;

		// Token: 0x040000BA RID: 186
		private SiticoneTextBox newpas;

		// Token: 0x040000BB RID: 187
		private SiticoneTextBox hwidr;

		// Token: 0x040000BC RID: 188
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		// Token: 0x040000BD RID: 189
		private SiticoneDragControl siticoneDragControl1;
	}
}
