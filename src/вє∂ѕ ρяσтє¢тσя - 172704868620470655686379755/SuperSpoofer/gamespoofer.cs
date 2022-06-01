using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer
{
	// Token: 0x02000010 RID: 16
	public partial class gamespoofer : Form
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000AD20 File Offset: 0x00008F20
		public gamespoofer()
		{
			gamespoofer.__VMFUNCTION__6BB1E(this);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000AD48 File Offset: 0x00008F48
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000AE2C File Offset: 0x0000902C
		public static void __VMFUNCTION__6BB1E(gamespoofer A_0)
		{
			A_0.components = (IContainer)new Container();
			ResourceManager resourceManager = new ComponentResourceManager(typeof(gamespoofer));
			A_0.siticoneGroupBox3 = new SiticoneGroupBox();
			A_0.panel2 = new Panel();
			A_0.siticoneGroupBox1 = new SiticoneGroupBox();
			A_0.siticonePanel2 = new SiticonePanel();
			A_0.siticoneButton6 = new SiticoneButton();
			A_0.label1 = new Label();
			A_0.siticonePanel4 = new SiticonePanel();
			A_0.label4 = new Label();
			A_0.siticoneButton7 = new SiticoneButton();
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.label2 = new Label();
			A_0.siticoneButton2 = new SiticoneButton();
			A_0.siticoneButton1 = new SiticoneButton();
			A_0.siticoneButton3 = new SiticoneButton();
			A_0.listBox1 = new ListBox();
			A_0.pictureBox1 = new PictureBox();
			A_0.panel1 = new Panel();
			A_0.timer1 = new Timer(A_0.components);
			A_0.siticoneGroupBox3.SuspendLayout();
			A_0.siticoneGroupBox1.SuspendLayout();
			A_0.siticonePanel2.SuspendLayout();
			A_0.siticonePanel4.SuspendLayout();
			A_0.siticonePanel1.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticoneGroupBox3.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox3.Controls.Add(A_0.panel2);
			A_0.siticoneGroupBox3.Controls.Add(A_0.siticoneGroupBox1);
			A_0.siticoneGroupBox3.Controls.Add(A_0.listBox1);
			A_0.siticoneGroupBox3.Controls.Add(A_0.pictureBox1);
			A_0.siticoneGroupBox3.Controls.Add(A_0.panel1);
			A_0.siticoneGroupBox3.CustomBorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox3.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneGroupBox3.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox3.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox3.Location = new Point(12, 9);
			A_0.siticoneGroupBox3.Name = "siticoneGroupBox3";
			A_0.siticoneGroupBox3.ShadowDecoration.Parent = A_0.siticoneGroupBox3;
			A_0.siticoneGroupBox3.Size = new Size(1019, 529);
			A_0.siticoneGroupBox3.TabIndex = 96;
			A_0.siticoneGroupBox3.Text = "FiveM Spoofer";
			A_0.siticoneGroupBox3.Click += A_0.__VMFUNCTION__61A25;
			A_0.panel2.BackColor = Color.Gainsboro;
			A_0.panel2.Location = new Point(-24, 111);
			A_0.panel2.Name = "panel2";
			A_0.panel2.Size = new Size(1057, 1);
			A_0.panel2.TabIndex = 103;
			A_0.siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticonePanel2);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticonePanel4);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticonePanel1);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneButton1);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneButton3);
			A_0.siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox1.Location = new Point(12, 243);
			A_0.siticoneGroupBox1.Name = "siticoneGroupBox1";
			A_0.siticoneGroupBox1.ShadowDecoration.Parent = A_0.siticoneGroupBox1;
			A_0.siticoneGroupBox1.Size = new Size(992, 270);
			A_0.siticoneGroupBox1.TabIndex = 102;
			A_0.siticoneGroupBox1.Text = "Spoofing Settings";
			A_0.siticonePanel2.BackColor = Color.FromArgb(27, 30, 34);
			A_0.siticonePanel2.Controls.Add(A_0.siticoneButton6);
			A_0.siticonePanel2.Controls.Add(A_0.label1);
			A_0.siticonePanel2.Location = new Point(593, 151);
			A_0.siticonePanel2.Name = "siticonePanel2";
			A_0.siticonePanel2.ShadowDecoration.Parent = A_0.siticonePanel2;
			A_0.siticonePanel2.Size = new Size(181, 104);
			A_0.siticonePanel2.TabIndex = 13;
			A_0.siticonePanel2.Paint += A_0.__VMFUNCTION__9448F;
			A_0.siticoneButton6.CheckedState.Parent = A_0.siticoneButton6;
			A_0.siticoneButton6.CustomImages.Parent = A_0.siticoneButton6;
			A_0.siticoneButton6.FillColor = Color.DodgerBlue;
			A_0.siticoneButton6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton6.ForeColor = Color.White;
			A_0.siticoneButton6.HoveredState.Parent = A_0.siticoneButton6;
			A_0.siticoneButton6.Location = new Point(19, 63);
			A_0.siticoneButton6.Name = "siticoneButton6";
			A_0.siticoneButton6.ShadowDecoration.Parent = A_0.siticoneButton6;
			A_0.siticoneButton6.Size = new Size(143, 26);
			A_0.siticoneButton6.TabIndex = 12;
			A_0.siticoneButton6.Text = "Run";
			A_0.label1.AutoSize = true;
			A_0.label1.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.Gainsboro;
			A_0.label1.Location = new Point(25, 14);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(128, 34);
			A_0.label1.TabIndex = 8;
			A_0.label1.Text = "Unlink your accounts\r\nfrom FiveM's data";
			A_0.label1.TextAlign = ContentAlignment.MiddleCenter;
			A_0.siticonePanel4.BackColor = Color.FromArgb(27, 30, 34);
			A_0.siticonePanel4.Controls.Add(A_0.label4);
			A_0.siticonePanel4.Controls.Add(A_0.siticoneButton7);
			A_0.siticonePanel4.Location = new Point(406, 151);
			A_0.siticonePanel4.Name = "siticonePanel4";
			A_0.siticonePanel4.ShadowDecoration.Parent = A_0.siticonePanel4;
			A_0.siticonePanel4.Size = new Size(181, 104);
			A_0.siticonePanel4.TabIndex = 14;
			A_0.siticonePanel4.Paint += A_0.__VMFUNCTION__34FCE;
			A_0.label4.AutoSize = true;
			A_0.label4.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label4.ForeColor = Color.Gainsboro;
			A_0.label4.Location = new Point(29, 14);
			A_0.label4.Name = "label4";
			A_0.label4.Size = new Size(123, 34);
			A_0.label4.TabIndex = 8;
			A_0.label4.Text = "Change FiveM build\r\nversion";
			A_0.label4.TextAlign = ContentAlignment.MiddleCenter;
			A_0.siticoneButton7.CheckedState.Parent = A_0.siticoneButton7;
			A_0.siticoneButton7.CustomImages.Parent = A_0.siticoneButton7;
			A_0.siticoneButton7.FillColor = Color.DodgerBlue;
			A_0.siticoneButton7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton7.ForeColor = Color.White;
			A_0.siticoneButton7.HoveredState.Parent = A_0.siticoneButton7;
			A_0.siticoneButton7.Location = new Point(19, 63);
			A_0.siticoneButton7.Name = "siticoneButton7";
			A_0.siticoneButton7.ShadowDecoration.Parent = A_0.siticoneButton7;
			A_0.siticoneButton7.Size = new Size(143, 26);
			A_0.siticoneButton7.TabIndex = 11;
			A_0.siticoneButton7.Text = "Run";
			A_0.siticoneButton7.Click += A_0.__VMFUNCTION__6A81C;
			A_0.siticonePanel1.BackColor = Color.FromArgb(27, 30, 34);
			A_0.siticonePanel1.Controls.Add(A_0.label2);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneButton2);
			A_0.siticonePanel1.Location = new Point(219, 151);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(181, 104);
			A_0.siticonePanel1.TabIndex = 12;
			A_0.siticonePanel1.Paint += A_0.__VMFUNCTION__554CB;
			A_0.label2.AutoSize = true;
			A_0.label2.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label2.ForeColor = Color.Gainsboro;
			A_0.label2.Location = new Point(25, 14);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(131, 34);
			A_0.label2.TabIndex = 8;
			A_0.label2.Text = "Reset your firewall to\r\ndefault settings";
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
			A_0.siticoneButton2.Click += A_0.__VMFUNCTION__A22B7;
			A_0.siticoneButton1.CheckedState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.CustomImages.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton1.ForeColor = Color.White;
			A_0.siticoneButton1.HoveredState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Location = new Point(10, 48);
			A_0.siticoneButton1.Name = "siticoneButton1";
			A_0.siticoneButton1.ShadowDecoration.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Size = new Size(174, 26);
			A_0.siticoneButton1.TabIndex = 5;
			A_0.siticoneButton1.Text = "Start Spoofing FiveM";
			A_0.siticoneButton1.Click += A_0.__VMFUNCTION__9BA5D;
			A_0.siticoneButton3.CheckedState.Parent = A_0.siticoneButton3;
			A_0.siticoneButton3.CustomImages.Parent = A_0.siticoneButton3;
			A_0.siticoneButton3.FillColor = Color.Gray;
			A_0.siticoneButton3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton3.ForeColor = Color.White;
			A_0.siticoneButton3.HoveredState.Parent = A_0.siticoneButton3;
			A_0.siticoneButton3.Location = new Point(190, 48);
			A_0.siticoneButton3.Name = "siticoneButton3";
			A_0.siticoneButton3.ShadowDecoration.Parent = A_0.siticoneButton3;
			A_0.siticoneButton3.Size = new Size(143, 26);
			A_0.siticoneButton3.TabIndex = 7;
			A_0.siticoneButton3.Text = "Download Method";
			A_0.siticoneButton3.Click += A_0.__VMFUNCTION__1E719;
			A_0.listBox1.BackColor = Color.FromArgb(25, 26, 30);
			A_0.listBox1.BorderStyle = BorderStyle.None;
			A_0.listBox1.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.listBox1.ForeColor = Color.White;
			A_0.listBox1.FormattingEnabled = true;
			A_0.listBox1.ItemHeight = 16;
			ListBox.ObjectCollection items = A_0.listBox1.Items;
			items.AddRange(new object[]
			{
				"Waiting for user interaction..."
			});
			A_0.listBox1.Location = new Point(6, 120);
			A_0.listBox1.Name = "listBox1";
			A_0.listBox1.Size = new Size(1010, 96);
			A_0.listBox1.TabIndex = 3;
			A_0.listBox1.SelectedIndexChanged += A_0.__VMFUNCTION__3E06F;
			A_0.pictureBox1.Image = (Image)resourceManager.GetObject("pictureBox1.Image");
			A_0.pictureBox1.Location = new Point(6, 43);
			A_0.pictureBox1.Name = "pictureBox1";
			A_0.pictureBox1.Size = new Size(1010, 63);
			A_0.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox1.TabIndex = 1;
			A_0.pictureBox1.TabStop = false;
			A_0.pictureBox1.Click += A_0.__VMFUNCTION__84249;
			A_0.panel1.BackColor = Color.Gainsboro;
			A_0.panel1.Location = new Point(-4, 216);
			A_0.panel1.Name = "panel1";
			A_0.panel1.Size = new Size(1042, 1);
			A_0.panel1.TabIndex = 4;
			A_0.timer1.Interval = 10;
			A_0.timer1.Tick += A_0.__VMFUNCTION__699F1;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(1043, 550);
			A_0.Controls.Add(A_0.siticoneGroupBox3);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "gamespoofer";
			A_0.Text = "gamespoofer";
			A_0.Load += A_0.__VMFUNCTION__3CF87;
			A_0.siticoneGroupBox3.ResumeLayout(false);
			A_0.siticoneGroupBox1.ResumeLayout(false);
			A_0.siticonePanel2.ResumeLayout(false);
			A_0.siticonePanel2.PerformLayout();
			A_0.siticonePanel4.ResumeLayout(false);
			A_0.siticonePanel4.PerformLayout();
			A_0.siticonePanel1.ResumeLayout(false);
			A_0.siticonePanel1.PerformLayout();
			((ISupportInitialize)A_0.pictureBox1).EndInit();
			A_0.ResumeLayout(false);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000BE84 File Offset: 0x0000A084
		public unsafe void __VMFUNCTION__9BA5D(object A_1, EventArgs A_2)
		{
			gamespoofer.<siticoneButton1_Click_1>d__24 <siticoneButton1_Click_1>d__ = new gamespoofer.<siticoneButton1_Click_1>d__24();
			<siticoneButton1_Click_1>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneButton1_Click_1>d__.<>4__this = this;
			<siticoneButton1_Click_1>d__.sender = A_1;
			<siticoneButton1_Click_1>d__.e = A_2;
			<siticoneButton1_Click_1>d__.<>1__state = -1;
			((gamespoofer.<siticoneButton1_Click_1>d__24*)<siticoneButton1_Click_1>d__).<>t__builder.Start<gamespoofer.<siticoneButton1_Click_1>d__24>(ref <siticoneButton1_Click_1>d__);
		}

		// Token: 0x04000066 RID: 102
		private PictureBox pictureBox1;

		// Token: 0x04000067 RID: 103
		private SiticoneGroupBox siticoneGroupBox3;

		// Token: 0x04000068 RID: 104
		private ListBox listBox1;

		// Token: 0x04000069 RID: 105
		private Timer timer1;

		// Token: 0x0400006A RID: 106
		private Panel panel1;

		// Token: 0x0400006B RID: 107
		private SiticoneButton siticoneButton1;

		// Token: 0x0400006C RID: 108
		private SiticoneButton siticoneButton2;

		// Token: 0x0400006D RID: 109
		private SiticoneButton siticoneButton3;

		// Token: 0x0400006E RID: 110
		private SiticoneGroupBox siticoneGroupBox1;

		// Token: 0x0400006F RID: 111
		private SiticoneButton siticoneButton7;

		// Token: 0x04000070 RID: 112
		private Panel panel2;

		// Token: 0x04000071 RID: 113
		private SiticonePanel siticonePanel1;

		// Token: 0x04000072 RID: 114
		private Label label2;

		// Token: 0x04000073 RID: 115
		private SiticonePanel siticonePanel4;

		// Token: 0x04000074 RID: 116
		private Label label4;

		// Token: 0x04000075 RID: 117
		private SiticonePanel siticonePanel2;

		// Token: 0x04000076 RID: 118
		private Label label1;

		// Token: 0x04000077 RID: 119
		private SiticoneButton siticoneButton6;
	}
}
