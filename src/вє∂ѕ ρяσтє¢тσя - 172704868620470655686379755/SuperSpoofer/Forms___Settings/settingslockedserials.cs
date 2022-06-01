using System;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using System.Net;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KeyAuth;
using Microsoft.VisualBasic.Devices;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace SuperSpoofer.Forms___Settings
{
	// Token: 0x0200001C RID: 28
	public partial class settingslockedserials : Form
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00012B2C File Offset: 0x00010D2C
		public settingslockedserials()
		{
			settingslockedserials.__VMFUNCTION__616C0(this);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00012B54 File Offset: 0x00010D54
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00012C38 File Offset: 0x00010E38
		public static void __VMFUNCTION__616C0(settingslockedserials A_0)
		{
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			A_0.pcname = new Label();
			A_0.label7 = new Label();
			A_0.cpureturn = new Label();
			A_0.windowsa = new Label();
			A_0.label9 = new Label();
			A_0.label13 = new Label();
			A_0.siticonePanel3 = new SiticonePanel();
			A_0.label12 = new Label();
			A_0.label11 = new Label();
			A_0.label10 = new Label();
			A_0.siticoneCirclePictureBox1 = new SiticoneCirclePictureBox();
			A_0.siticonePanel2 = new SiticonePanel();
			A_0.hwidr = new Label();
			A_0.ipr = new Label();
			A_0.label8 = new Label();
			A_0.label14 = new Label();
			A_0.siticonePanel1.SuspendLayout();
			((ISupportInitialize)A_0.siticoneCirclePictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticonePanel1.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticonePanel1.BorderColor = Color.Black;
			A_0.siticonePanel1.BorderThickness = 1;
			A_0.siticonePanel1.Controls.Add(A_0.siticoneRoundedGradientButton4);
			A_0.siticonePanel1.Controls.Add(A_0.pcname);
			A_0.siticonePanel1.Controls.Add(A_0.label7);
			A_0.siticonePanel1.Controls.Add(A_0.cpureturn);
			A_0.siticonePanel1.Controls.Add(A_0.windowsa);
			A_0.siticonePanel1.Controls.Add(A_0.label9);
			A_0.siticonePanel1.Controls.Add(A_0.label13);
			A_0.siticonePanel1.Controls.Add(A_0.siticonePanel3);
			A_0.siticonePanel1.Controls.Add(A_0.label12);
			A_0.siticonePanel1.Controls.Add(A_0.label11);
			A_0.siticonePanel1.Controls.Add(A_0.label10);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneCirclePictureBox1);
			A_0.siticonePanel1.Controls.Add(A_0.siticonePanel2);
			A_0.siticonePanel1.Controls.Add(A_0.hwidr);
			A_0.siticonePanel1.Controls.Add(A_0.ipr);
			A_0.siticonePanel1.Controls.Add(A_0.label8);
			A_0.siticonePanel1.Controls.Add(A_0.label14);
			A_0.siticonePanel1.FillColor = Color.FromArgb(41, 42, 62);
			A_0.siticonePanel1.Location = new Point(240, 79);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(330, 353);
			A_0.siticonePanel1.TabIndex = 123;
			A_0.siticoneRoundedGradientButton4.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneRoundedGradientButton4.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton4.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton4.CheckedState.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.CustomImages.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.FillColor = Color.FromArgb(64, 64, 64);
			A_0.siticoneRoundedGradientButton4.FillColor2 = Color.FromArgb(64, 64, 64);
			A_0.siticoneRoundedGradientButton4.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton4.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton4.HoveredState.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.Location = new Point(255, 305);
			A_0.siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			A_0.siticoneRoundedGradientButton4.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.Size = new Size(69, 30);
			A_0.siticoneRoundedGradientButton4.TabIndex = 131;
			A_0.siticoneRoundedGradientButton4.Text = "Change";
			A_0.siticoneRoundedGradientButton4.Click += A_0.__VMFUNCTION__3CF3F;
			A_0.pcname.AutoSize = true;
			A_0.pcname.BackColor = Color.Transparent;
			A_0.pcname.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.pcname.ForeColor = Color.White;
			A_0.pcname.Location = new Point(14, 315);
			A_0.pcname.Name = "pcname";
			A_0.pcname.Size = new Size(52, 20);
			A_0.pcname.TabIndex = 128;
			A_0.pcname.Text = "device";
			A_0.label7.AutoSize = true;
			A_0.label7.BackColor = Color.Transparent;
			A_0.label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label7.ForeColor = Color.DarkGray;
			A_0.label7.Location = new Point(15, 302);
			A_0.label7.Name = "label7";
			A_0.label7.Size = new Size(78, 13);
			A_0.label7.TabIndex = 127;
			A_0.label7.Text = "Device Name:";
			A_0.cpureturn.AutoSize = true;
			A_0.cpureturn.BackColor = Color.Transparent;
			A_0.cpureturn.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.cpureturn.ForeColor = Color.White;
			A_0.cpureturn.Location = new Point(14, 269);
			A_0.cpureturn.Name = "cpureturn";
			A_0.cpureturn.Size = new Size(33, 20);
			A_0.cpureturn.TabIndex = 126;
			A_0.cpureturn.Text = "cpu";
			A_0.windowsa.AutoSize = true;
			A_0.windowsa.BackColor = Color.Transparent;
			A_0.windowsa.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.windowsa.ForeColor = Color.White;
			A_0.windowsa.Location = new Point(13, 221);
			A_0.windowsa.Name = "windowsa";
			A_0.windowsa.Size = new Size(67, 20);
			A_0.windowsa.TabIndex = 125;
			A_0.windowsa.Text = "windows";
			A_0.label9.AutoSize = true;
			A_0.label9.BackColor = Color.Transparent;
			A_0.label9.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label9.ForeColor = Color.DarkGray;
			A_0.label9.Location = new Point(14, 204);
			A_0.label9.Name = "label9";
			A_0.label9.Size = new Size(124, 13);
			A_0.label9.TabIndex = 123;
			A_0.label9.Text = "Windows Information:";
			A_0.label13.AutoSize = true;
			A_0.label13.BackColor = Color.Transparent;
			A_0.label13.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label13.ForeColor = Color.DarkGray;
			A_0.label13.Location = new Point(15, 256);
			A_0.label13.Name = "label13";
			A_0.label13.Size = new Size(82, 13);
			A_0.label13.TabIndex = 124;
			A_0.label13.Text = "CPU Identifier:";
			A_0.siticonePanel3.FillColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel3.Location = new Point(4, 194);
			A_0.siticonePanel3.Name = "siticonePanel3";
			A_0.siticonePanel3.ShadowDecoration.Parent = A_0.siticonePanel3;
			A_0.siticonePanel3.Size = new Size(323, 1);
			A_0.siticonePanel3.TabIndex = 101;
			A_0.label12.AutoSize = true;
			A_0.label12.BackColor = Color.Transparent;
			A_0.label12.Font = new Font("Ebrima", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label12.ForeColor = Color.DodgerBlue;
			A_0.label12.Location = new Point(12, 53);
			A_0.label12.Name = "label12";
			A_0.label12.Size = new Size(71, 15);
			A_0.label12.TabIndex = 104;
			A_0.label12.Text = "CUSTOMER";
			A_0.label11.AutoSize = true;
			A_0.label11.BackColor = Color.Transparent;
			A_0.label11.Font = new Font("Ebrima", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label11.ForeColor = Color.LightGray;
			A_0.label11.Location = new Point(12, 36);
			A_0.label11.Name = "label11";
			A_0.label11.Size = new Size(68, 17);
			A_0.label11.TabIndex = 103;
			A_0.label11.Text = "username";
			A_0.label10.AutoSize = true;
			A_0.label10.BackColor = Color.Transparent;
			A_0.label10.Font = new Font("Ebrima", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label10.ForeColor = Color.White;
			A_0.label10.Location = new Point(5, 6);
			A_0.label10.Name = "label10";
			A_0.label10.Size = new Size(161, 17);
			A_0.label10.TabIndex = 102;
			A_0.label10.Text = "superspoofer.cc account:";
			A_0.siticoneCirclePictureBox1.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneCirclePictureBox1.Location = new Point(244, 3);
			A_0.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
			A_0.siticoneCirclePictureBox1.ShadowDecoration.Mode = ShadowMode.Circle;
			A_0.siticoneCirclePictureBox1.ShadowDecoration.Parent = A_0.siticoneCirclePictureBox1;
			A_0.siticoneCirclePictureBox1.Size = new Size(80, 73);
			A_0.siticoneCirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.siticoneCirclePictureBox1.TabIndex = 101;
			A_0.siticoneCirclePictureBox1.TabStop = false;
			A_0.siticonePanel2.FillColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel2.Location = new Point(4, 82);
			A_0.siticonePanel2.Name = "siticonePanel2";
			A_0.siticonePanel2.ShadowDecoration.Parent = A_0.siticonePanel2;
			A_0.siticonePanel2.Size = new Size(323, 1);
			A_0.siticonePanel2.TabIndex = 100;
			A_0.hwidr.AutoSize = true;
			A_0.hwidr.BackColor = Color.Transparent;
			A_0.hwidr.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.hwidr.ForeColor = Color.White;
			A_0.hwidr.Location = new Point(15, 159);
			A_0.hwidr.Name = "hwidr";
			A_0.hwidr.Size = new Size(41, 20);
			A_0.hwidr.TabIndex = 99;
			A_0.hwidr.Text = "hwid";
			A_0.ipr.AutoSize = true;
			A_0.ipr.BackColor = Color.Transparent;
			A_0.ipr.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.ipr.ForeColor = Color.White;
			A_0.ipr.Location = new Point(14, 111);
			A_0.ipr.Name = "ipr";
			A_0.ipr.Size = new Size(120, 20);
			A_0.ipr.TabIndex = 98;
			A_0.ipr.Text = "Internet provider";
			A_0.label8.AutoSize = true;
			A_0.label8.BackColor = Color.Transparent;
			A_0.label8.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label8.ForeColor = Color.DarkGray;
			A_0.label8.Location = new Point(15, 94);
			A_0.label8.Name = "label8";
			A_0.label8.Size = new Size(60, 13);
			A_0.label8.TabIndex = 34;
			A_0.label8.Text = "IP Locked:";
			A_0.label14.AutoSize = true;
			A_0.label14.BackColor = Color.Transparent;
			A_0.label14.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label14.ForeColor = Color.DarkGray;
			A_0.label14.Location = new Point(16, 146);
			A_0.label14.Name = "label14";
			A_0.label14.Size = new Size(110, 13);
			A_0.label14.TabIndex = 96;
			A_0.label14.Text = "Hardware Identifier:";
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(809, 508);
			A_0.Controls.Add(A_0.siticonePanel1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "settingslockedserials";
			A_0.Text = "settingslockedserials";
			A_0.Load += A_0.__VMFUNCTION__46360;
			A_0.siticonePanel1.ResumeLayout(false);
			A_0.siticonePanel1.PerformLayout();
			((ISupportInitialize)A_0.siticoneCirclePictureBox1).EndInit();
			A_0.ResumeLayout(false);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00013B20 File Offset: 0x00011D20
		public void __VMFUNCTION__46360(object A_1, EventArgs A_2)
		{
			try
			{
				this.label11.Text = Login.KeyAuthApp.user_data.username;
				if (((this.label11.Text == "JPWQJWS") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.Cyan;
					this.label12.Text = "Spoofer Developer";
				}
				if (((this.label11.Text == "4Tiger.") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.SlateBlue;
					this.label12.Text = "Management";
				}
				if (((this.label11.Text == "IPQELDZ") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.SlateBlue;
					this.label12.Text = "Management";
				}
				if (((this.label11.Text == "ISPANAS") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.Crimson;
					this.label12.Text = "Administration";
				}
				if (((this.label11.Text == "OENOULA") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.HotPink;
					this.label12.Text = "Used Condom";
				}
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.hwidr.Text = WindowsIdentity.GetCurrent().User.Value;
				this.ipr.Text = this.GetIP();
			}
			catch (Exception ex2)
			{
				this.hwidr.Text = "Failed to load HWID";
				this.ipr.Text = "Failed to load IP";
			}
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("Select * From Win32_processor").Get().GetEnumerator())
			{
				while ((enumerator.MoveNext() ? 1U : 0U) != (uint)0)
				{
					settingslockedserials.cpu = ((ManagementObject)enumerator.Current)["ProcessorID"].ToString();
					settingslockedserials.cpuid = settingslockedserials.cpu.Substring((int)((uint)settingslockedserials.cpu.Length + ~(uint)10 + (uint)1));
				}
			}
			this.cpureturn.Text = settingslockedserials.cpuid;
			this.pcname.Text = Dns.GetHostName();
			this.windowsa.Text = new ComputerInfo().OSFullName + " (" + new ComputerInfo().OSVersion + ")";
		}

		// Token: 0x040000DB RID: 219
		private static string cpu;

		// Token: 0x040000DC RID: 220
		private static string cpuid;

		// Token: 0x040000DE RID: 222
		private SiticonePanel siticonePanel1;

		// Token: 0x040000DF RID: 223
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		// Token: 0x040000E0 RID: 224
		private Label pcname;

		// Token: 0x040000E1 RID: 225
		private Label label7;

		// Token: 0x040000E2 RID: 226
		private Label cpureturn;

		// Token: 0x040000E3 RID: 227
		private Label windowsa;

		// Token: 0x040000E4 RID: 228
		private Label label9;

		// Token: 0x040000E5 RID: 229
		private Label label13;

		// Token: 0x040000E6 RID: 230
		private SiticonePanel siticonePanel3;

		// Token: 0x040000E7 RID: 231
		private Label label12;

		// Token: 0x040000E8 RID: 232
		private Label label11;

		// Token: 0x040000E9 RID: 233
		private Label label10;

		// Token: 0x040000EA RID: 234
		private SiticoneCirclePictureBox siticoneCirclePictureBox1;

		// Token: 0x040000EB RID: 235
		private SiticonePanel siticonePanel2;

		// Token: 0x040000EC RID: 236
		private Label hwidr;

		// Token: 0x040000ED RID: 237
		private Label ipr;

		// Token: 0x040000EE RID: 238
		private Label label8;

		// Token: 0x040000EF RID: 239
		private Label label14;
	}
}
