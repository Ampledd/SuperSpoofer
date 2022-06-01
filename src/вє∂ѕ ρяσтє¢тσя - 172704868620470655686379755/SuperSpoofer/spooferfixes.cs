using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer
{
	// Token: 0x02000012 RID: 18
	public partial class spooferfixes : Form
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000BF54 File Offset: 0x0000A154
		public spooferfixes()
		{
			spooferfixes.__VMFUNCTION__6C0C5(this);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000C01C File Offset: 0x0000A21C
		public static void __VMFUNCTION__6C0C5(spooferfixes A_0)
		{
			ResourceManager resourceManager = new ComponentResourceManager(typeof(spooferfixes));
			A_0.siticoneGroupBox3 = new SiticoneGroupBox();
			A_0.siticoneGroupBox2 = new SiticoneGroupBox();
			A_0.siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox7 = new SiticoneGroupBox();
			A_0.siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox1 = new SiticoneGroupBox();
			A_0.siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox6 = new SiticoneGroupBox();
			A_0.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			A_0.pictureBox3 = new PictureBox();
			A_0.pictureBox2 = new PictureBox();
			A_0.pictureBox5 = new PictureBox();
			A_0.pictureBox1 = new PictureBox();
			A_0.siticoneGroupBox3.SuspendLayout();
			A_0.siticoneGroupBox2.SuspendLayout();
			A_0.siticoneGroupBox7.SuspendLayout();
			A_0.siticoneGroupBox1.SuspendLayout();
			A_0.siticoneGroupBox6.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox3).BeginInit();
			((ISupportInitialize)A_0.pictureBox2).BeginInit();
			((ISupportInitialize)A_0.pictureBox5).BeginInit();
			((ISupportInitialize)A_0.pictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticoneGroupBox3.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox3.Controls.Add(A_0.siticoneGroupBox2);
			A_0.siticoneGroupBox3.Controls.Add(A_0.siticoneGroupBox7);
			A_0.siticoneGroupBox3.Controls.Add(A_0.siticoneGroupBox1);
			A_0.siticoneGroupBox3.Controls.Add(A_0.siticoneGroupBox6);
			A_0.siticoneGroupBox3.CustomBorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox3.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneGroupBox3.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox3.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox3.Location = new Point(102, 82);
			A_0.siticoneGroupBox3.Name = "siticoneGroupBox3";
			A_0.siticoneGroupBox3.ShadowDecoration.Parent = A_0.siticoneGroupBox3;
			A_0.siticoneGroupBox3.Size = new Size(848, 370);
			A_0.siticoneGroupBox3.TabIndex = 97;
			A_0.siticoneGroupBox3.Text = "Super Spoofer - Fixes";
			A_0.siticoneGroupBox3.Click += A_0.__VMFUNCTION__8C702;
			A_0.siticoneGroupBox2.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox2.Controls.Add(A_0.siticoneRoundedGradientButton4);
			A_0.siticoneGroupBox2.Controls.Add(A_0.pictureBox3);
			A_0.siticoneGroupBox2.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox2.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox2.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox2.Location = new Point(290, 202);
			A_0.siticoneGroupBox2.Name = "siticoneGroupBox2";
			A_0.siticoneGroupBox2.ShadowDecoration.Parent = A_0.siticoneGroupBox2;
			A_0.siticoneGroupBox2.Size = new Size(269, 144);
			A_0.siticoneGroupBox2.TabIndex = 109;
			A_0.siticoneGroupBox2.Text = "Method Not Downloading";
			A_0.siticoneRoundedGradientButton4.BackColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneRoundedGradientButton4.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton4.CheckedState.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.CustomImages.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.FillColor = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton4.FillColor2 = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton4.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton4.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton4.HoveredState.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.Location = new Point(12, 111);
			A_0.siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			A_0.siticoneRoundedGradientButton4.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.Size = new Size(243, 27);
			A_0.siticoneRoundedGradientButton4.TabIndex = 108;
			A_0.siticoneRoundedGradientButton4.Text = "Download Method";
			A_0.siticoneRoundedGradientButton4.Click += A_0.__VMFUNCTION__3D277;
			A_0.siticoneGroupBox7.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox7.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox7.Controls.Add(A_0.pictureBox2);
			A_0.siticoneGroupBox7.Controls.Add(A_0.siticoneRoundedGradientButton2);
			A_0.siticoneGroupBox7.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox7.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox7.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox7.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox7.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox7.Location = new Point(565, 52);
			A_0.siticoneGroupBox7.Name = "siticoneGroupBox7";
			A_0.siticoneGroupBox7.ShadowDecoration.Parent = A_0.siticoneGroupBox7;
			A_0.siticoneGroupBox7.Size = new Size(269, 144);
			A_0.siticoneGroupBox7.TabIndex = 109;
			A_0.siticoneGroupBox7.Text = "Reactivate Windows";
			A_0.siticoneRoundedGradientButton2.BackColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneRoundedGradientButton2.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton2.CheckedState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.CustomImages.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.FillColor = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton2.FillColor2 = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton2.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton2.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton2.HoveredState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Location = new Point(12, 111);
			A_0.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			A_0.siticoneRoundedGradientButton2.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Size = new Size(243, 27);
			A_0.siticoneRoundedGradientButton2.TabIndex = 108;
			A_0.siticoneRoundedGradientButton2.Text = "Reactivate Windows";
			A_0.siticoneRoundedGradientButton2.Click += A_0.__VMFUNCTION__710E9;
			A_0.siticoneGroupBox1.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneRoundedGradientButton1);
			A_0.siticoneGroupBox1.Controls.Add(A_0.pictureBox5);
			A_0.siticoneGroupBox1.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox1.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox1.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox1.Location = new Point(290, 52);
			A_0.siticoneGroupBox1.Name = "siticoneGroupBox1";
			A_0.siticoneGroupBox1.ShadowDecoration.Parent = A_0.siticoneGroupBox1;
			A_0.siticoneGroupBox1.Size = new Size(269, 144);
			A_0.siticoneGroupBox1.TabIndex = 109;
			A_0.siticoneGroupBox1.Text = "Prevent Bluescreen";
			A_0.siticoneRoundedGradientButton1.BackColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneRoundedGradientButton1.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton1.CheckedState.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.CustomImages.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.FillColor = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton1.FillColor2 = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton1.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton1.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton1.HoveredState.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.Location = new Point(12, 111);
			A_0.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			A_0.siticoneRoundedGradientButton1.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton1;
			A_0.siticoneRoundedGradientButton1.Size = new Size(243, 27);
			A_0.siticoneRoundedGradientButton1.TabIndex = 108;
			A_0.siticoneRoundedGradientButton1.Text = "Prevent Bluescreen";
			A_0.siticoneRoundedGradientButton1.Click += A_0.__VMFUNCTION__43D56;
			A_0.siticoneGroupBox6.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox6.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox6.Controls.Add(A_0.siticoneRoundedGradientButton3);
			A_0.siticoneGroupBox6.Controls.Add(A_0.pictureBox1);
			A_0.siticoneGroupBox6.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox6.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox6.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox6.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox6.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox6.Location = new Point(15, 52);
			A_0.siticoneGroupBox6.Name = "siticoneGroupBox6";
			A_0.siticoneGroupBox6.ShadowDecoration.Parent = A_0.siticoneGroupBox6;
			A_0.siticoneGroupBox6.Size = new Size(269, 144);
			A_0.siticoneGroupBox6.TabIndex = 107;
			A_0.siticoneGroupBox6.Text = "Relink Xbox Account";
			A_0.siticoneRoundedGradientButton3.BackColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneRoundedGradientButton3.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton3.CheckedState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.CustomImages.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.FillColor = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton3.FillColor2 = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton3.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton3.HoveredState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Location = new Point(12, 111);
			A_0.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			A_0.siticoneRoundedGradientButton3.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Size = new Size(243, 27);
			A_0.siticoneRoundedGradientButton3.TabIndex = 108;
			A_0.siticoneRoundedGradientButton3.Text = "Relink Xbox";
			A_0.siticoneRoundedGradientButton3.Click += A_0.__VMFUNCTION__98FF3;
			A_0.pictureBox3.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox3.Image = (Image)resourceManager.GetObject("pictureBox3.Image");
			A_0.pictureBox3.Location = new Point(12, 33);
			A_0.pictureBox3.Name = "pictureBox3";
			A_0.pictureBox3.Size = new Size(243, 72);
			A_0.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox3.TabIndex = 4;
			A_0.pictureBox3.TabStop = false;
			A_0.pictureBox2.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox2.Image = (Image)resourceManager.GetObject("pictureBox2.Image");
			A_0.pictureBox2.Location = new Point(12, 33);
			A_0.pictureBox2.Name = "pictureBox2";
			A_0.pictureBox2.Size = new Size(243, 72);
			A_0.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox2.TabIndex = 4;
			A_0.pictureBox2.TabStop = false;
			A_0.pictureBox5.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox5.Image = (Image)resourceManager.GetObject("pictureBox5.Image");
			A_0.pictureBox5.Location = new Point(12, 33);
			A_0.pictureBox5.Name = "pictureBox5";
			A_0.pictureBox5.Size = new Size(243, 72);
			A_0.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox5.TabIndex = 98;
			A_0.pictureBox5.TabStop = false;
			A_0.pictureBox5.Click += A_0.__VMFUNCTION__A142A;
			A_0.pictureBox1.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox1.Image = (Image)resourceManager.GetObject("pictureBox1.Image");
			A_0.pictureBox1.Location = new Point(12, 33);
			A_0.pictureBox1.Name = "pictureBox1";
			A_0.pictureBox1.Size = new Size(243, 72);
			A_0.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox1.TabIndex = 4;
			A_0.pictureBox1.TabStop = false;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(1043, 550);
			A_0.Controls.Add(A_0.siticoneGroupBox3);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "spooferfixes";
			A_0.Text = "spooferfixes";
			A_0.Load += A_0.__VMFUNCTION__35494;
			A_0.siticoneGroupBox3.ResumeLayout(false);
			A_0.siticoneGroupBox2.ResumeLayout(false);
			A_0.siticoneGroupBox7.ResumeLayout(false);
			A_0.siticoneGroupBox1.ResumeLayout(false);
			A_0.siticoneGroupBox6.ResumeLayout(false);
			((ISupportInitialize)A_0.pictureBox3).EndInit();
			((ISupportInitialize)A_0.pictureBox2).EndInit();
			((ISupportInitialize)A_0.pictureBox5).EndInit();
			((ISupportInitialize)A_0.pictureBox1).EndInit();
			A_0.ResumeLayout(false);
		}

		// Token: 0x04000079 RID: 121
		private PictureBox pictureBox1;

		// Token: 0x0400007A RID: 122
		private PictureBox pictureBox2;

		// Token: 0x0400007B RID: 123
		private SiticoneGroupBox siticoneGroupBox3;

		// Token: 0x0400007C RID: 124
		private PictureBox pictureBox5;

		// Token: 0x0400007D RID: 125
		private SiticoneGroupBox siticoneGroupBox6;

		// Token: 0x0400007E RID: 126
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x0400007F RID: 127
		private SiticoneGroupBox siticoneGroupBox7;

		// Token: 0x04000080 RID: 128
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x04000081 RID: 129
		private SiticoneGroupBox siticoneGroupBox1;

		// Token: 0x04000082 RID: 130
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		// Token: 0x04000083 RID: 131
		private SiticoneGroupBox siticoneGroupBox2;

		// Token: 0x04000084 RID: 132
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		// Token: 0x04000085 RID: 133
		private PictureBox pictureBox3;
	}
}
