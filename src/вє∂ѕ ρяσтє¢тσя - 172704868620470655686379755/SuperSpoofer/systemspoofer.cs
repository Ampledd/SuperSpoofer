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
	// Token: 0x02000013 RID: 19
	public partial class systemspoofer : Form
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
		public systemspoofer()
		{
			systemspoofer.__VMFUNCTION__6C64F(this);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public static void __VMFUNCTION__6C64F(systemspoofer A_0)
		{
			ResourceManager resourceManager = new ComponentResourceManager(typeof(systemspoofer));
			A_0.siticoneGroupBox1 = new SiticoneGroupBox();
			A_0.siticoneGroupBox5 = new SiticoneGroupBox();
			A_0.pictureBox4 = new PictureBox();
			A_0.siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox4 = new SiticoneGroupBox();
			A_0.pictureBox14 = new PictureBox();
			A_0.siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox7 = new SiticoneGroupBox();
			A_0.pictureBox5 = new PictureBox();
			A_0.siticoneRoundedGradientButton5 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox8 = new SiticoneGroupBox();
			A_0.pictureBox6 = new PictureBox();
			A_0.siticoneRoundedGradientButton6 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox2 = new SiticoneGroupBox();
			A_0.pictureBox3 = new PictureBox();
			A_0.siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			A_0.siticoneGroupBox6 = new SiticoneGroupBox();
			A_0.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			A_0.pictureBox15 = new PictureBox();
			A_0.siticoneGroupBox1.SuspendLayout();
			A_0.siticoneGroupBox5.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox4).BeginInit();
			A_0.siticoneGroupBox4.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox14).BeginInit();
			A_0.siticoneGroupBox7.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox5).BeginInit();
			A_0.siticoneGroupBox8.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox6).BeginInit();
			A_0.siticoneGroupBox2.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox3).BeginInit();
			A_0.siticoneGroupBox6.SuspendLayout();
			((ISupportInitialize)A_0.pictureBox15).BeginInit();
			A_0.SuspendLayout();
			A_0.siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneGroupBox5);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneGroupBox4);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneGroupBox7);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneGroupBox8);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneGroupBox2);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneGroupBox6);
			A_0.siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox1.Location = new Point(102, 82);
			A_0.siticoneGroupBox1.Name = "siticoneGroupBox1";
			A_0.siticoneGroupBox1.ShadowDecoration.Parent = A_0.siticoneGroupBox1;
			A_0.siticoneGroupBox1.Size = new Size(838, 369);
			A_0.siticoneGroupBox1.TabIndex = 99;
			A_0.siticoneGroupBox1.Text = "SYSTEM SPOOFER";
			A_0.siticoneGroupBox1.Click += A_0.__VMFUNCTION__97E54;
			A_0.siticoneGroupBox5.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox5.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox5.Controls.Add(A_0.pictureBox4);
			A_0.siticoneGroupBox5.Controls.Add(A_0.siticoneRoundedGradientButton4);
			A_0.siticoneGroupBox5.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox5.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox5.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox5.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox5.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox5.Location = new Point(558, 55);
			A_0.siticoneGroupBox5.Name = "siticoneGroupBox5";
			A_0.siticoneGroupBox5.ShadowDecoration.Parent = A_0.siticoneGroupBox5;
			A_0.siticoneGroupBox5.Size = new Size(269, 144);
			A_0.siticoneGroupBox5.TabIndex = 113;
			A_0.siticoneGroupBox5.Text = "Spoof BIOS";
			A_0.pictureBox4.BackColor = Color.Transparent;
			A_0.pictureBox4.Image = (Image)resourceManager.GetObject("pictureBox4.Image");
			A_0.pictureBox4.Location = new Point(12, 33);
			A_0.pictureBox4.Name = "pictureBox4";
			A_0.pictureBox4.Size = new Size(243, 72);
			A_0.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox4.TabIndex = 109;
			A_0.pictureBox4.TabStop = false;
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
			A_0.siticoneRoundedGradientButton4.Text = "Spoof BIOS IDS";
			A_0.siticoneRoundedGradientButton4.Click += A_0.__VMFUNCTION__DDDA;
			A_0.siticoneGroupBox4.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox4.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox4.Controls.Add(A_0.pictureBox14);
			A_0.siticoneGroupBox4.Controls.Add(A_0.siticoneRoundedGradientButton2);
			A_0.siticoneGroupBox4.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox4.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox4.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox4.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox4.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox4.Location = new Point(558, 205);
			A_0.siticoneGroupBox4.Name = "siticoneGroupBox4";
			A_0.siticoneGroupBox4.ShadowDecoration.Parent = A_0.siticoneGroupBox4;
			A_0.siticoneGroupBox4.Size = new Size(269, 144);
			A_0.siticoneGroupBox4.TabIndex = 110;
			A_0.siticoneGroupBox4.Text = "Spoof GPU";
			A_0.pictureBox14.BackColor = Color.Transparent;
			A_0.pictureBox14.Image = (Image)resourceManager.GetObject("pictureBox14.Image");
			A_0.pictureBox14.Location = new Point(12, 33);
			A_0.pictureBox14.Name = "pictureBox14";
			A_0.pictureBox14.Size = new Size(243, 67);
			A_0.pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox14.TabIndex = 109;
			A_0.pictureBox14.TabStop = false;
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
			A_0.siticoneRoundedGradientButton2.Text = "Spoof GPU Drivers";
			A_0.siticoneRoundedGradientButton2.Click += A_0.__VMFUNCTION__66430;
			A_0.siticoneGroupBox7.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox7.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox7.Controls.Add(A_0.pictureBox5);
			A_0.siticoneGroupBox7.Controls.Add(A_0.siticoneRoundedGradientButton5);
			A_0.siticoneGroupBox7.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox7.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox7.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox7.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox7.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox7.Location = new Point(283, 55);
			A_0.siticoneGroupBox7.Name = "siticoneGroupBox7";
			A_0.siticoneGroupBox7.ShadowDecoration.Parent = A_0.siticoneGroupBox7;
			A_0.siticoneGroupBox7.Size = new Size(269, 144);
			A_0.siticoneGroupBox7.TabIndex = 112;
			A_0.siticoneGroupBox7.Text = "Spoof MAC";
			A_0.pictureBox5.BackColor = Color.Transparent;
			A_0.pictureBox5.Image = (Image)resourceManager.GetObject("pictureBox5.Image");
			A_0.pictureBox5.Location = new Point(12, 33);
			A_0.pictureBox5.Name = "pictureBox5";
			A_0.pictureBox5.Size = new Size(240, 72);
			A_0.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox5.TabIndex = 109;
			A_0.pictureBox5.TabStop = false;
			A_0.siticoneRoundedGradientButton5.BackColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneRoundedGradientButton5.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton5.CheckedState.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.CustomImages.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.FillColor = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton5.FillColor2 = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton5.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton5.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton5.HoveredState.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.Location = new Point(12, 111);
			A_0.siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
			A_0.siticoneRoundedGradientButton5.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.Size = new Size(243, 27);
			A_0.siticoneRoundedGradientButton5.TabIndex = 108;
			A_0.siticoneRoundedGradientButton5.Text = "Spoof MAC Address";
			A_0.siticoneRoundedGradientButton5.Click += A_0.__VMFUNCTION__1AFC0;
			A_0.siticoneGroupBox8.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox8.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox8.Controls.Add(A_0.pictureBox6);
			A_0.siticoneGroupBox8.Controls.Add(A_0.siticoneRoundedGradientButton6);
			A_0.siticoneGroupBox8.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox8.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox8.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox8.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox8.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox8.Location = new Point(8, 55);
			A_0.siticoneGroupBox8.Name = "siticoneGroupBox8";
			A_0.siticoneGroupBox8.ShadowDecoration.Parent = A_0.siticoneGroupBox8;
			A_0.siticoneGroupBox8.Size = new Size(269, 144);
			A_0.siticoneGroupBox8.TabIndex = 111;
			A_0.siticoneGroupBox8.Text = "Spoof Serials";
			A_0.pictureBox6.BackColor = Color.Transparent;
			A_0.pictureBox6.Image = (Image)resourceManager.GetObject("pictureBox6.Image");
			A_0.pictureBox6.Location = new Point(12, 33);
			A_0.pictureBox6.Name = "pictureBox6";
			A_0.pictureBox6.Size = new Size(243, 72);
			A_0.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox6.TabIndex = 109;
			A_0.pictureBox6.TabStop = false;
			A_0.siticoneRoundedGradientButton6.BackColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneRoundedGradientButton6.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton6.CheckedState.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.CustomImages.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.FillColor = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton6.FillColor2 = Color.DarkGreen;
			A_0.siticoneRoundedGradientButton6.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton6.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton6.HoveredState.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.Location = new Point(12, 111);
			A_0.siticoneRoundedGradientButton6.Name = "siticoneRoundedGradientButton6";
			A_0.siticoneRoundedGradientButton6.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.Size = new Size(243, 27);
			A_0.siticoneRoundedGradientButton6.TabIndex = 108;
			A_0.siticoneRoundedGradientButton6.Text = "Spoof Serial ID";
			A_0.siticoneRoundedGradientButton6.Click += A_0.__VMFUNCTION__1158E;
			A_0.siticoneGroupBox2.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox2.Controls.Add(A_0.pictureBox3);
			A_0.siticoneGroupBox2.Controls.Add(A_0.siticoneRoundedGradientButton1);
			A_0.siticoneGroupBox2.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox2.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox2.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox2.Location = new Point(283, 205);
			A_0.siticoneGroupBox2.Name = "siticoneGroupBox2";
			A_0.siticoneGroupBox2.ShadowDecoration.Parent = A_0.siticoneGroupBox2;
			A_0.siticoneGroupBox2.Size = new Size(269, 144);
			A_0.siticoneGroupBox2.TabIndex = 109;
			A_0.siticoneGroupBox2.Text = "Spoof Registery";
			A_0.pictureBox3.BackColor = Color.Transparent;
			A_0.pictureBox3.Image = (Image)resourceManager.GetObject("pictureBox3.Image");
			A_0.pictureBox3.Location = new Point(12, 33);
			A_0.pictureBox3.Name = "pictureBox3";
			A_0.pictureBox3.Size = new Size(242, 72);
			A_0.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox3.TabIndex = 109;
			A_0.pictureBox3.TabStop = false;
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
			A_0.siticoneRoundedGradientButton1.Text = "Spoof Registery System";
			A_0.siticoneRoundedGradientButton1.Click += A_0.__VMFUNCTION__A097C;
			A_0.siticoneGroupBox6.BackColor = Color.FromArgb(18, 19, 23);
			A_0.siticoneGroupBox6.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox6.Controls.Add(A_0.siticoneRoundedGradientButton3);
			A_0.siticoneGroupBox6.Controls.Add(A_0.pictureBox15);
			A_0.siticoneGroupBox6.CustomBorderColor = Color.White;
			A_0.siticoneGroupBox6.CustomBorderThickness = new Padding(0);
			A_0.siticoneGroupBox6.FillColor = Color.FromArgb(35, 35, 35);
			A_0.siticoneGroupBox6.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox6.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox6.Location = new Point(8, 205);
			A_0.siticoneGroupBox6.Name = "siticoneGroupBox6";
			A_0.siticoneGroupBox6.ShadowDecoration.Parent = A_0.siticoneGroupBox6;
			A_0.siticoneGroupBox6.Size = new Size(269, 144);
			A_0.siticoneGroupBox6.TabIndex = 108;
			A_0.siticoneGroupBox6.Text = "Spoof Xbox";
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
			A_0.siticoneRoundedGradientButton3.Text = "Spoof Xbox Connections";
			A_0.siticoneRoundedGradientButton3.Click += A_0.__VMFUNCTION__44ABD;
			A_0.pictureBox15.BackColor = Color.FromArgb(35, 35, 35);
			A_0.pictureBox15.Image = (Image)resourceManager.GetObject("pictureBox15.Image");
			A_0.pictureBox15.Location = new Point(12, 33);
			A_0.pictureBox15.Name = "pictureBox15";
			A_0.pictureBox15.Size = new Size(243, 72);
			A_0.pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox15.TabIndex = 4;
			A_0.pictureBox15.TabStop = false;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(1043, 550);
			A_0.Controls.Add(A_0.siticoneGroupBox1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "systemspoofer";
			A_0.Text = "s";
			A_0.Load += A_0.__VMFUNCTION__33D23;
			A_0.siticoneGroupBox1.ResumeLayout(false);
			A_0.siticoneGroupBox5.ResumeLayout(false);
			((ISupportInitialize)A_0.pictureBox4).EndInit();
			A_0.siticoneGroupBox4.ResumeLayout(false);
			((ISupportInitialize)A_0.pictureBox14).EndInit();
			A_0.siticoneGroupBox7.ResumeLayout(false);
			((ISupportInitialize)A_0.pictureBox5).EndInit();
			A_0.siticoneGroupBox8.ResumeLayout(false);
			((ISupportInitialize)A_0.pictureBox6).EndInit();
			A_0.siticoneGroupBox2.ResumeLayout(false);
			((ISupportInitialize)A_0.pictureBox3).EndInit();
			A_0.siticoneGroupBox6.ResumeLayout(false);
			((ISupportInitialize)A_0.pictureBox15).EndInit();
			A_0.ResumeLayout(false);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000E704 File Offset: 0x0000C904
		public unsafe void __VMFUNCTION__DDDA(object A_1, EventArgs A_2)
		{
			systemspoofer.<siticoneRoundedGradientButton4_Click>d__25 <siticoneRoundedGradientButton4_Click>d__ = new systemspoofer.<siticoneRoundedGradientButton4_Click>d__25();
			<siticoneRoundedGradientButton4_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneRoundedGradientButton4_Click>d__.<>4__this = this;
			<siticoneRoundedGradientButton4_Click>d__.sender = A_1;
			<siticoneRoundedGradientButton4_Click>d__.e = A_2;
			<siticoneRoundedGradientButton4_Click>d__.<>1__state = -1;
			((systemspoofer.<siticoneRoundedGradientButton4_Click>d__25*)<siticoneRoundedGradientButton4_Click>d__).<>t__builder.Start<systemspoofer.<siticoneRoundedGradientButton4_Click>d__25>(ref <siticoneRoundedGradientButton4_Click>d__);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000E75C File Offset: 0x0000C95C
		public unsafe void __VMFUNCTION__66430(object A_1, EventArgs A_2)
		{
			systemspoofer.<siticoneRoundedGradientButton2_Click>d__22 <siticoneRoundedGradientButton2_Click>d__ = new systemspoofer.<siticoneRoundedGradientButton2_Click>d__22();
			<siticoneRoundedGradientButton2_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneRoundedGradientButton2_Click>d__.<>4__this = this;
			<siticoneRoundedGradientButton2_Click>d__.sender = A_1;
			<siticoneRoundedGradientButton2_Click>d__.e = A_2;
			<siticoneRoundedGradientButton2_Click>d__.<>1__state = -1;
			((systemspoofer.<siticoneRoundedGradientButton2_Click>d__22*)<siticoneRoundedGradientButton2_Click>d__).<>t__builder.Start<systemspoofer.<siticoneRoundedGradientButton2_Click>d__22>(ref <siticoneRoundedGradientButton2_Click>d__);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		public unsafe void __VMFUNCTION__1AFC0(object A_1, EventArgs A_2)
		{
			systemspoofer.<siticoneRoundedGradientButton5_Click>d__24 <siticoneRoundedGradientButton5_Click>d__ = new systemspoofer.<siticoneRoundedGradientButton5_Click>d__24();
			<siticoneRoundedGradientButton5_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneRoundedGradientButton5_Click>d__.<>4__this = this;
			<siticoneRoundedGradientButton5_Click>d__.sender = A_1;
			<siticoneRoundedGradientButton5_Click>d__.e = A_2;
			<siticoneRoundedGradientButton5_Click>d__.<>1__state = -1;
			((systemspoofer.<siticoneRoundedGradientButton5_Click>d__24*)<siticoneRoundedGradientButton5_Click>d__).<>t__builder.Start<systemspoofer.<siticoneRoundedGradientButton5_Click>d__24>(ref <siticoneRoundedGradientButton5_Click>d__);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000E80C File Offset: 0x0000CA0C
		public unsafe void __VMFUNCTION__A097C(object A_1, EventArgs A_2)
		{
			systemspoofer.<siticoneRoundedGradientButton1_Click>d__21 <siticoneRoundedGradientButton1_Click>d__ = new systemspoofer.<siticoneRoundedGradientButton1_Click>d__21();
			<siticoneRoundedGradientButton1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneRoundedGradientButton1_Click>d__.<>4__this = this;
			<siticoneRoundedGradientButton1_Click>d__.sender = A_1;
			<siticoneRoundedGradientButton1_Click>d__.e = A_2;
			<siticoneRoundedGradientButton1_Click>d__.<>1__state = -1;
			((systemspoofer.<siticoneRoundedGradientButton1_Click>d__21*)<siticoneRoundedGradientButton1_Click>d__).<>t__builder.Start<systemspoofer.<siticoneRoundedGradientButton1_Click>d__21>(ref <siticoneRoundedGradientButton1_Click>d__);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000E864 File Offset: 0x0000CA64
		public unsafe void __VMFUNCTION__44ABD(object A_1, EventArgs A_2)
		{
			systemspoofer.<siticoneRoundedGradientButton3_Click>d__20 <siticoneRoundedGradientButton3_Click>d__ = new systemspoofer.<siticoneRoundedGradientButton3_Click>d__20();
			<siticoneRoundedGradientButton3_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneRoundedGradientButton3_Click>d__.<>4__this = this;
			<siticoneRoundedGradientButton3_Click>d__.sender = A_1;
			<siticoneRoundedGradientButton3_Click>d__.e = A_2;
			<siticoneRoundedGradientButton3_Click>d__.<>1__state = -1;
			((systemspoofer.<siticoneRoundedGradientButton3_Click>d__20*)<siticoneRoundedGradientButton3_Click>d__).<>t__builder.Start<systemspoofer.<siticoneRoundedGradientButton3_Click>d__20>(ref <siticoneRoundedGradientButton3_Click>d__);
		}

		// Token: 0x04000087 RID: 135
		private SiticoneGroupBox siticoneGroupBox1;

		// Token: 0x04000088 RID: 136
		private SiticoneGroupBox siticoneGroupBox6;

		// Token: 0x04000089 RID: 137
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x0400008A RID: 138
		private PictureBox pictureBox15;

		// Token: 0x0400008B RID: 139
		private SiticoneGroupBox siticoneGroupBox2;

		// Token: 0x0400008C RID: 140
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		// Token: 0x0400008D RID: 141
		private SiticoneGroupBox siticoneGroupBox4;

		// Token: 0x0400008E RID: 142
		private PictureBox pictureBox14;

		// Token: 0x0400008F RID: 143
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x04000090 RID: 144
		private PictureBox pictureBox3;

		// Token: 0x04000091 RID: 145
		private SiticoneGroupBox siticoneGroupBox5;

		// Token: 0x04000092 RID: 146
		private SiticoneGroupBox siticoneGroupBox7;

		// Token: 0x04000093 RID: 147
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		// Token: 0x04000094 RID: 148
		private SiticoneGroupBox siticoneGroupBox8;

		// Token: 0x04000095 RID: 149
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton6;

		// Token: 0x04000096 RID: 150
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		// Token: 0x04000097 RID: 151
		private PictureBox pictureBox4;

		// Token: 0x04000098 RID: 152
		private PictureBox pictureBox5;

		// Token: 0x04000099 RID: 153
		private PictureBox pictureBox6;
	}
}
