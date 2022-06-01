using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using KeyAuth;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer
{
	// Token: 0x0200000F RID: 15
	public partial class dashboard : Form
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00009B04 File Offset: 0x00007D04
		public dashboard()
		{
			dashboard.__VMFUNCTION__9723A(this);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009B2C File Offset: 0x00007D2C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime3 = default(DateTime);
			dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return dateTime.AddSeconds((double)((ulong)unixtime)).ToLocalTime();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00009C34 File Offset: 0x00007E34
		public static void __VMFUNCTION__9723A(dashboard A_0)
		{
			A_0.components = (IContainer)new Container();
			ResourceManager resourceManager = new ComponentResourceManager(typeof(dashboard));
			A_0.label1 = new Label();
			A_0.timer1 = new Timer(A_0.components);
			A_0.label3 = new Label();
			A_0.label4 = new Label();
			A_0.siticoneGroupBox1 = new SiticoneGroupBox();
			A_0.exp = new Label();
			A_0.sub = new Label();
			A_0.username = new Label();
			A_0.pictureBox1 = new PictureBox();
			A_0.pictureBox4 = new PictureBox();
			A_0.pictureBox3 = new PictureBox();
			A_0.siticoneGroupBox2 = new SiticoneGroupBox();
			A_0.siticoneTextBox3 = new SiticoneTextBox();
			A_0.siticoneGroupBox3 = new SiticoneGroupBox();
			A_0.siticoneButton1 = new SiticoneButton();
			A_0.siticoneGroupBox1.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox1).BeginInit();
			((ISupportInitialize)A_0.pictureBox4).BeginInit();
			((ISupportInitialize)A_0.pictureBox3).BeginInit();
			A_0.siticoneGroupBox2.SuspendLayout();
			A_0.siticoneGroupBox3.SuspendLayout();
			A_0.SuspendLayout();
			A_0.label1.AutoSize = true;
			A_0.label1.Font = new Font("Lucida Console", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.White;
			A_0.label1.Location = new Point(28, 54);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(67, 16);
			A_0.label1.TabIndex = 5;
			A_0.label1.Text = "label1";
			A_0.timer1.Tick += A_0.__VMFUNCTION__41900;
			A_0.label3.AutoSize = true;
			A_0.label3.BackColor = Color.Transparent;
			A_0.label3.Font = new Font("Franklin Gothic Medium", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label3.ForeColor = Color.White;
			A_0.label3.Location = new Point(874, 9);
			A_0.label3.Name = "label3";
			A_0.label3.Size = new Size(154, 42);
			A_0.label3.TabIndex = 72;
			A_0.label3.Text = "Build: May 6th 2022 \r\nBuild Version: 3.0.8";
			A_0.label3.TextAlign = ContentAlignment.MiddleCenter;
			A_0.label4.AutoSize = true;
			A_0.label4.Font = new Font("Ebrima", 21.75f, FontStyle.Bold);
			A_0.label4.ForeColor = Color.White;
			A_0.label4.Location = new Point(24, 12);
			A_0.label4.Name = "label4";
			A_0.label4.Size = new Size(274, 40);
			A_0.label4.TabIndex = 105;
			A_0.label4.Text = "Welcome back, ....!";
			A_0.siticoneGroupBox1.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.Controls.Add(A_0.exp);
			A_0.siticoneGroupBox1.Controls.Add(A_0.sub);
			A_0.siticoneGroupBox1.Controls.Add(A_0.username);
			A_0.siticoneGroupBox1.Controls.Add(A_0.pictureBox1);
			A_0.siticoneGroupBox1.Controls.Add(A_0.pictureBox4);
			A_0.siticoneGroupBox1.Controls.Add(A_0.pictureBox3);
			A_0.siticoneGroupBox1.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox1.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox1.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox1.Location = new Point(711, 431);
			A_0.siticoneGroupBox1.Name = "siticoneGroupBox1";
			A_0.siticoneGroupBox1.ShadowDecoration.Parent = A_0.siticoneGroupBox1;
			A_0.siticoneGroupBox1.Size = new Size(320, 107);
			A_0.siticoneGroupBox1.TabIndex = 106;
			A_0.siticoneGroupBox1.Text = "User Information";
			A_0.exp.AutoSize = true;
			A_0.exp.BackColor = Color.FromArgb(35, 35, 35);
			A_0.exp.Font = new Font("Ebrima", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.exp.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.exp.Location = new Point(12, 73);
			A_0.exp.Name = "exp";
			A_0.exp.Size = new Size(59, 15);
			A_0.exp.TabIndex = 106;
			A_0.exp.Text = "Expiration";
			A_0.sub.AutoSize = true;
			A_0.sub.BackColor = Color.FromArgb(35, 35, 35);
			A_0.sub.Font = new Font("Ebrima", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.sub.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.sub.Location = new Point(12, 54);
			A_0.sub.Name = "sub";
			A_0.sub.Size = new Size(73, 15);
			A_0.sub.TabIndex = 105;
			A_0.sub.Text = "Subscription";
			A_0.username.AutoSize = true;
			A_0.username.BackColor = Color.FromArgb(35, 35, 35);
			A_0.username.Font = new Font("Ebrima", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.username.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.username.Location = new Point(12, 35);
			A_0.username.Name = "username";
			A_0.username.Size = new Size(59, 15);
			A_0.username.TabIndex = 104;
			A_0.username.Text = "Username";
			A_0.pictureBox1.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox1.Image = (Image)resourceManager.GetObject("pictureBox1.Image");
			A_0.pictureBox1.Location = new Point(261, 3);
			A_0.pictureBox1.Name = "pictureBox1";
			A_0.pictureBox1.Size = new Size(56, 48);
			A_0.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox1.TabIndex = 104;
			A_0.pictureBox1.TabStop = false;
			A_0.pictureBox4.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox4.Cursor = Cursors.Hand;
			A_0.pictureBox4.Image = (Image)resourceManager.GetObject("pictureBox4.Image");
			A_0.pictureBox4.Location = new Point(221, 73);
			A_0.pictureBox4.Name = "pictureBox4";
			A_0.pictureBox4.Size = new Size(45, 30);
			A_0.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox4.TabIndex = 3;
			A_0.pictureBox4.TabStop = false;
			A_0.pictureBox4.Click += A_0.__VMFUNCTION__43B00;
			A_0.pictureBox3.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox3.Cursor = Cursors.Hand;
			A_0.pictureBox3.Image = (Image)resourceManager.GetObject("pictureBox3.Image");
			A_0.pictureBox3.Location = new Point(272, 73);
			A_0.pictureBox3.Name = "pictureBox3";
			A_0.pictureBox3.Size = new Size(45, 30);
			A_0.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox3.TabIndex = 2;
			A_0.pictureBox3.TabStop = false;
			A_0.pictureBox3.Click += A_0.__VMFUNCTION__1968B;
			A_0.siticoneGroupBox2.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox2.Controls.Add(A_0.siticoneTextBox3);
			A_0.siticoneGroupBox2.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox2.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox2.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox2.Location = new Point(12, 382);
			A_0.siticoneGroupBox2.Name = "siticoneGroupBox2";
			A_0.siticoneGroupBox2.ShadowDecoration.Parent = A_0.siticoneGroupBox2;
			A_0.siticoneGroupBox2.Size = new Size(377, 156);
			A_0.siticoneGroupBox2.TabIndex = 107;
			A_0.siticoneGroupBox2.Text = "Recent Software Updates;";
			A_0.siticoneTextBox3.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.siticoneTextBox3.BorderThickness = 0;
			A_0.siticoneTextBox3.Cursor = Cursors.No;
			A_0.siticoneTextBox3.DefaultText = resourceManager.GetString("siticoneTextBox3.DefaultText");
			A_0.siticoneTextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.siticoneTextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.siticoneTextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox3.DisabledState.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox3.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneTextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.siticoneTextBox3.FocusedState.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.siticoneTextBox3.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.siticoneTextBox3.HoveredState.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.Location = new Point(5, 27);
			A_0.siticoneTextBox3.Margin = new Padding(5, 3, 5, 3);
			A_0.siticoneTextBox3.Multiline = true;
			A_0.siticoneTextBox3.Name = "siticoneTextBox3";
			A_0.siticoneTextBox3.PasswordChar = (char)0;
			A_0.siticoneTextBox3.PlaceholderText = "";
			A_0.siticoneTextBox3.ReadOnly = true;
			A_0.siticoneTextBox3.SelectedText = "";
			A_0.siticoneTextBox3.ShadowDecoration.Parent = A_0.siticoneTextBox3;
			A_0.siticoneTextBox3.Size = new Size(368, 279);
			A_0.siticoneTextBox3.TabIndex = 109;
			A_0.siticoneGroupBox3.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox3.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox3.Controls.Add(A_0.siticoneButton1);
			A_0.siticoneGroupBox3.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox3.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox3.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox3.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox3.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox3.Location = new Point(711, 341);
			A_0.siticoneGroupBox3.Name = "siticoneGroupBox3";
			A_0.siticoneGroupBox3.ShadowDecoration.Parent = A_0.siticoneGroupBox3;
			A_0.siticoneGroupBox3.Size = new Size(320, 84);
			A_0.siticoneGroupBox3.TabIndex = 108;
			A_0.siticoneGroupBox3.Text = "Important Notice! Our new website just got released!";
			A_0.siticoneButton1.BackColor = Color.Transparent;
			A_0.siticoneButton1.CheckedState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.CustomBorderColor = Color.DimGray;
			A_0.siticoneButton1.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.siticoneButton1.CustomImages.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.FillColor = Color.DimGray;
			A_0.siticoneButton1.Font = new Font("Segoe UI", 9f);
			A_0.siticoneButton1.ForeColor = Color.LightGray;
			A_0.siticoneButton1.HoveredState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Location = new Point(21, 52);
			A_0.siticoneButton1.Name = "siticoneButton1";
			A_0.siticoneButton1.ShadowDecoration.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Size = new Size(279, 24);
			A_0.siticoneButton1.TabIndex = 110;
			A_0.siticoneButton1.Text = "Take me there!";
			A_0.siticoneButton1.Click += A_0.__VMFUNCTION__26D78;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(1043, 550);
			A_0.Controls.Add(A_0.siticoneGroupBox3);
			A_0.Controls.Add(A_0.siticoneGroupBox2);
			A_0.Controls.Add(A_0.siticoneGroupBox1);
			A_0.Controls.Add(A_0.label4);
			A_0.Controls.Add(A_0.label3);
			A_0.Controls.Add(A_0.label1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "dashboard";
			A_0.Text = "dashboard";
			A_0.Load += A_0.__VMFUNCTION__5402A;
			A_0.siticoneGroupBox1.ResumeLayout(false);
			A_0.siticoneGroupBox1.PerformLayout();
			((ISupportInitialize)A_0.pictureBox1).EndInit();
			((ISupportInitialize)A_0.pictureBox4).EndInit();
			((ISupportInitialize)A_0.pictureBox3).EndInit();
			A_0.siticoneGroupBox2.ResumeLayout(false);
			A_0.siticoneGroupBox3.ResumeLayout(false);
			A_0.ResumeLayout(false);
			A_0.PerformLayout();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000AC04 File Offset: 0x00008E04
		public void __VMFUNCTION__41900(object A_1, EventArgs A_2)
		{
			DateTime dateTime = default(DateTime);
			DateTime now = DateTime.Now;
			this.label1.Text = now.ToString();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000AC3C File Offset: 0x00008E3C
		public void __VMFUNCTION__5402A(object A_1, EventArgs A_2)
		{
			DateTime dateTime = default(DateTime);
			this.timer1.Start();
			this.label4.Text = "Welcome back, " + Login.KeyAuthApp.user_data.username;
			DateTime dateTime2 = this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
			this.exp.Text = "Expiration: " + dateTime2.ToString();
			this.sub.Text = "Subscription Plan: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
			this.username.Text = "Username: " + Login.KeyAuthApp.user_data.username;
		}

		// Token: 0x04000056 RID: 86
		private PictureBox pictureBox3;

		// Token: 0x04000057 RID: 87
		private PictureBox pictureBox4;

		// Token: 0x04000058 RID: 88
		private Label label1;

		// Token: 0x04000059 RID: 89
		private Timer timer1;

		// Token: 0x0400005A RID: 90
		private Label label3;

		// Token: 0x0400005B RID: 91
		private Label label4;

		// Token: 0x0400005C RID: 92
		private SiticoneGroupBox siticoneGroupBox1;

		// Token: 0x0400005D RID: 93
		private Label exp;

		// Token: 0x0400005E RID: 94
		private Label sub;

		// Token: 0x0400005F RID: 95
		private Label username;

		// Token: 0x04000060 RID: 96
		private PictureBox pictureBox1;

		// Token: 0x04000061 RID: 97
		private SiticoneGroupBox siticoneGroupBox2;

		// Token: 0x04000062 RID: 98
		private SiticoneTextBox siticoneTextBox3;

		// Token: 0x04000063 RID: 99
		private SiticoneGroupBox siticoneGroupBox3;

		// Token: 0x04000064 RID: 100
		private SiticoneButton siticoneButton1;
	}
}
