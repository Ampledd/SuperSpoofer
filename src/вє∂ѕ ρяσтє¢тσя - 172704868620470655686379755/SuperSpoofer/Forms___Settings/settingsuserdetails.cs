using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KeyAuth;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace SuperSpoofer.Forms___Settings
{
	// Token: 0x0200001D RID: 29
	public partial class settingsuserdetails : Form
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00013E4C File Offset: 0x0001204C
		public settingsuserdetails()
		{
			settingsuserdetails.__VMFUNCTION__543C3(this);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00013E74 File Offset: 0x00012074
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime3 = default(DateTime);
			dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return dateTime.AddSeconds((double)((ulong)unixtime)).ToLocalTime();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00013EDC File Offset: 0x000120DC
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00013FC0 File Offset: 0x000121C0
		public static void __VMFUNCTION__543C3(settingsuserdetails A_0)
		{
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			A_0.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			A_0.label1 = new Label();
			A_0.siticonePanel4 = new SiticonePanel();
			A_0.creation = new Label();
			A_0.label3 = new Label();
			A_0.exp = new Label();
			A_0.sub = new Label();
			A_0.label9 = new Label();
			A_0.label13 = new Label();
			A_0.siticonePanel3 = new SiticonePanel();
			A_0.siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			A_0.label12 = new Label();
			A_0.label11 = new Label();
			A_0.label10 = new Label();
			A_0.siticonePanel2 = new SiticonePanel();
			A_0.passoutput = new Label();
			A_0.useroutput = new Label();
			A_0.label7 = new Label();
			A_0.label2 = new Label();
			A_0.siticoneCirclePictureBox1 = new SiticoneCirclePictureBox();
			A_0.siticonePanel1.SuspendLayout();
			((ISupportInitialize)A_0.siticoneCirclePictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticonePanel1.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticonePanel1.BorderColor = Color.Black;
			A_0.siticonePanel1.BorderThickness = 1;
			A_0.siticonePanel1.Controls.Add(A_0.siticoneRoundedGradientButton4);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneRoundedGradientButton3);
			A_0.siticonePanel1.Controls.Add(A_0.label1);
			A_0.siticonePanel1.Controls.Add(A_0.siticonePanel4);
			A_0.siticonePanel1.Controls.Add(A_0.creation);
			A_0.siticonePanel1.Controls.Add(A_0.label3);
			A_0.siticonePanel1.Controls.Add(A_0.exp);
			A_0.siticonePanel1.Controls.Add(A_0.sub);
			A_0.siticonePanel1.Controls.Add(A_0.label9);
			A_0.siticonePanel1.Controls.Add(A_0.label13);
			A_0.siticonePanel1.Controls.Add(A_0.siticonePanel3);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneRoundedGradientButton2);
			A_0.siticonePanel1.Controls.Add(A_0.label12);
			A_0.siticonePanel1.Controls.Add(A_0.label11);
			A_0.siticonePanel1.Controls.Add(A_0.label10);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneCirclePictureBox1);
			A_0.siticonePanel1.Controls.Add(A_0.siticonePanel2);
			A_0.siticonePanel1.Controls.Add(A_0.passoutput);
			A_0.siticonePanel1.Controls.Add(A_0.useroutput);
			A_0.siticonePanel1.Controls.Add(A_0.label7);
			A_0.siticonePanel1.Controls.Add(A_0.label2);
			A_0.siticonePanel1.FillColor = Color.FromArgb(41, 42, 62);
			A_0.siticonePanel1.Location = new Point(240, 51);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(330, 405);
			A_0.siticonePanel1.TabIndex = 121;
			A_0.siticonePanel1.Paint += A_0.__VMFUNCTION__A24BC;
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
			A_0.siticoneRoundedGradientButton4.Location = new Point(255, 211);
			A_0.siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			A_0.siticoneRoundedGradientButton4.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton4;
			A_0.siticoneRoundedGradientButton4.Size = new Size(69, 30);
			A_0.siticoneRoundedGradientButton4.TabIndex = 131;
			A_0.siticoneRoundedGradientButton4.Text = "Extend";
			A_0.siticoneRoundedGradientButton4.Click += A_0.__VMFUNCTION__4800F;
			A_0.siticoneRoundedGradientButton3.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneRoundedGradientButton3.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton3.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton3.CheckedState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.CustomImages.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.FillColor = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.FillColor2 = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton3.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton3.HoveredState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Location = new Point(255, 362);
			A_0.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			A_0.siticoneRoundedGradientButton3.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Size = new Size(69, 30);
			A_0.siticoneRoundedGradientButton3.TabIndex = 130;
			A_0.siticoneRoundedGradientButton3.Text = "Close";
			A_0.siticoneRoundedGradientButton3.Click += A_0.__VMFUNCTION__41AD0;
			A_0.label1.AutoSize = true;
			A_0.label1.BackColor = Color.Transparent;
			A_0.label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.Red;
			A_0.label1.Location = new Point(12, 362);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(211, 26);
			A_0.label1.TabIndex = 129;
			A_0.label1.Text = "Close superspoofer.cc account\r\n(Delete your spoofer account and data)";
			A_0.siticonePanel4.FillColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel4.Location = new Point(4, 349);
			A_0.siticonePanel4.Name = "siticonePanel4";
			A_0.siticonePanel4.ShadowDecoration.Parent = A_0.siticonePanel4;
			A_0.siticonePanel4.Size = new Size(323, 1);
			A_0.siticonePanel4.TabIndex = 102;
			A_0.creation.AutoSize = true;
			A_0.creation.BackColor = Color.Transparent;
			A_0.creation.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.creation.ForeColor = Color.White;
			A_0.creation.Location = new Point(14, 315);
			A_0.creation.Name = "creation";
			A_0.creation.Size = new Size(78, 20);
			A_0.creation.TabIndex = 128;
			A_0.creation.Text = "accreation";
			A_0.label3.AutoSize = true;
			A_0.label3.BackColor = Color.Transparent;
			A_0.label3.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label3.ForeColor = Color.DarkGray;
			A_0.label3.Location = new Point(15, 302);
			A_0.label3.Name = "label3";
			A_0.label3.Size = new Size(100, 13);
			A_0.label3.TabIndex = 127;
			A_0.label3.Text = "Account Creation:";
			A_0.exp.AutoSize = true;
			A_0.exp.BackColor = Color.Transparent;
			A_0.exp.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.exp.ForeColor = Color.White;
			A_0.exp.Location = new Point(14, 269);
			A_0.exp.Name = "exp";
			A_0.exp.Size = new Size(56, 20);
			A_0.exp.TabIndex = 126;
			A_0.exp.Text = "subexp";
			A_0.sub.AutoSize = true;
			A_0.sub.BackColor = Color.Transparent;
			A_0.sub.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.sub.ForeColor = Color.White;
			A_0.sub.Location = new Point(13, 221);
			A_0.sub.Name = "sub";
			A_0.sub.Size = new Size(89, 20);
			A_0.sub.TabIndex = 125;
			A_0.sub.Text = "subscription";
			A_0.label9.AutoSize = true;
			A_0.label9.BackColor = Color.Transparent;
			A_0.label9.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label9.ForeColor = Color.DarkGray;
			A_0.label9.Location = new Point(14, 204);
			A_0.label9.Name = "label9";
			A_0.label9.Size = new Size(72, 13);
			A_0.label9.TabIndex = 123;
			A_0.label9.Text = "Subscription";
			A_0.label13.AutoSize = true;
			A_0.label13.BackColor = Color.Transparent;
			A_0.label13.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label13.ForeColor = Color.DarkGray;
			A_0.label13.Location = new Point(15, 256);
			A_0.label13.Name = "label13";
			A_0.label13.Size = new Size(131, 13);
			A_0.label13.TabIndex = 124;
			A_0.label13.Text = "Subscription Expiration:";
			A_0.siticonePanel3.FillColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel3.Location = new Point(4, 194);
			A_0.siticonePanel3.Name = "siticonePanel3";
			A_0.siticonePanel3.ShadowDecoration.Parent = A_0.siticonePanel3;
			A_0.siticonePanel3.Size = new Size(323, 1);
			A_0.siticonePanel3.TabIndex = 101;
			A_0.siticoneRoundedGradientButton2.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneRoundedGradientButton2.BorderColor = Color.White;
			A_0.siticoneRoundedGradientButton2.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton2.CheckedState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.CustomImages.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.FillColor = Color.FromArgb(64, 64, 64);
			A_0.siticoneRoundedGradientButton2.FillColor2 = Color.FromArgb(64, 64, 64);
			A_0.siticoneRoundedGradientButton2.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton2.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton2.HoveredState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Location = new Point(255, 149);
			A_0.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			A_0.siticoneRoundedGradientButton2.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Size = new Size(69, 30);
			A_0.siticoneRoundedGradientButton2.TabIndex = 122;
			A_0.siticoneRoundedGradientButton2.Text = "Change";
			A_0.siticoneRoundedGradientButton2.Click += A_0.__VMFUNCTION__93323;
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
			A_0.siticonePanel2.FillColor = Color.FromArgb(224, 224, 224);
			A_0.siticonePanel2.Location = new Point(4, 82);
			A_0.siticonePanel2.Name = "siticonePanel2";
			A_0.siticonePanel2.ShadowDecoration.Parent = A_0.siticonePanel2;
			A_0.siticonePanel2.Size = new Size(323, 1);
			A_0.siticonePanel2.TabIndex = 100;
			A_0.passoutput.AutoSize = true;
			A_0.passoutput.BackColor = Color.Transparent;
			A_0.passoutput.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.passoutput.ForeColor = Color.White;
			A_0.passoutput.Location = new Point(15, 159);
			A_0.passoutput.Name = "passoutput";
			A_0.passoutput.Size = new Size(70, 20);
			A_0.passoutput.TabIndex = 99;
			A_0.passoutput.Text = "Password";
			A_0.useroutput.AutoSize = true;
			A_0.useroutput.BackColor = Color.Transparent;
			A_0.useroutput.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.useroutput.ForeColor = Color.White;
			A_0.useroutput.Location = new Point(14, 111);
			A_0.useroutput.Name = "useroutput";
			A_0.useroutput.Size = new Size(75, 20);
			A_0.useroutput.TabIndex = 98;
			A_0.useroutput.Text = "Username";
			A_0.label7.AutoSize = true;
			A_0.label7.BackColor = Color.Transparent;
			A_0.label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label7.ForeColor = Color.DarkGray;
			A_0.label7.Location = new Point(15, 94);
			A_0.label7.Name = "label7";
			A_0.label7.Size = new Size(62, 13);
			A_0.label7.TabIndex = 34;
			A_0.label7.Text = "Username:";
			A_0.label2.AutoSize = true;
			A_0.label2.BackColor = Color.Transparent;
			A_0.label2.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label2.ForeColor = Color.DarkGray;
			A_0.label2.Location = new Point(16, 146);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(60, 13);
			A_0.label2.TabIndex = 96;
			A_0.label2.Text = "Password:";
			A_0.siticoneCirclePictureBox1.BackColor = Color.FromArgb(41, 42, 62);
			A_0.siticoneCirclePictureBox1.Location = new Point(244, 3);
			A_0.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
			A_0.siticoneCirclePictureBox1.ShadowDecoration.Mode = ShadowMode.Circle;
			A_0.siticoneCirclePictureBox1.ShadowDecoration.Parent = A_0.siticoneCirclePictureBox1;
			A_0.siticoneCirclePictureBox1.Size = new Size(80, 73);
			A_0.siticoneCirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.siticoneCirclePictureBox1.TabIndex = 101;
			A_0.siticoneCirclePictureBox1.TabStop = false;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(809, 508);
			A_0.Controls.Add(A_0.siticonePanel1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "settingsuserdetails";
			A_0.Text = "settingsuserdetails";
			A_0.Load += A_0.__VMFUNCTION__C1B8;
			A_0.siticonePanel1.ResumeLayout(false);
			A_0.siticonePanel1.PerformLayout();
			((ISupportInitialize)A_0.siticoneCirclePictureBox1).EndInit();
			A_0.ResumeLayout(false);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00015308 File Offset: 0x00013508
		public unsafe void __VMFUNCTION__41AD0(object A_1, EventArgs A_2)
		{
			settingsuserdetails.<siticoneRoundedGradientButton3_Click_1>d__16 <siticoneRoundedGradientButton3_Click_1>d__ = new settingsuserdetails.<siticoneRoundedGradientButton3_Click_1>d__16();
			<siticoneRoundedGradientButton3_Click_1>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneRoundedGradientButton3_Click_1>d__.<>4__this = this;
			<siticoneRoundedGradientButton3_Click_1>d__.sender = A_1;
			<siticoneRoundedGradientButton3_Click_1>d__.e = A_2;
			<siticoneRoundedGradientButton3_Click_1>d__.<>1__state = -1;
			((settingsuserdetails.<siticoneRoundedGradientButton3_Click_1>d__16*)<siticoneRoundedGradientButton3_Click_1>d__).<>t__builder.Start<settingsuserdetails.<siticoneRoundedGradientButton3_Click_1>d__16>(ref <siticoneRoundedGradientButton3_Click_1>d__);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00015360 File Offset: 0x00013560
		public void __VMFUNCTION__C1B8(object A_1, EventArgs A_2)
		{
			DateTime dateTime = default(DateTime);
			try
			{
				string text = this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString();
				Control control = this.exp;
				if (text == null)
				{
				}
				control.Text = text;
				this.sub.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
				DateTime dateTime2 = this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
				this.creation.Text = dateTime2.ToString();
			}
			catch (Exception ex)
			{
				Application.Exit();
			}
			try
			{
				this.useroutput.Text = Login.KeyAuthApp.user_data.username;
			}
			catch (Exception ex2)
			{
				this.useroutput.Text = "Failed to load username";
			}
			try
			{
				using (object obj = (object)File.ReadLines("password", Encoding.UTF8).GetEnumerator())
				{
					while ((((IEnumerator)obj).MoveNext() ? 1U : 0U) != (uint)0)
					{
						this.passoutput.Text = ((IEnumerator<string>)obj).Current;
					}
				}
			}
			catch (Exception ex3)
			{
				this.passoutput.Text = "";
			}
			try
			{
				this.label11.Text = "Subscription Level;";
				if (((this.useroutput.Text == "JPWQJWS") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.Cyan;
					this.label12.Text = "Spoofer Developer";
				}
				if (((this.useroutput.Text == "4Tiger.") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.SlateBlue;
					this.label12.Text = "Management";
				}
				if (((this.useroutput.Text == "IPQELDZ") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.SlateBlue;
					this.label12.Text = "Management";
				}
				if (((this.useroutput.Text == "ISPANAS") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.Crimson;
					this.label12.Text = "Administration";
				}
				if (((this.useroutput.Text == "OENOULA") ? 1U : 0U) != (uint)0)
				{
					this.label12.ForeColor = Color.HotPink;
					this.label12.Text = "Used Condom";
				}
			}
			catch (Exception ex4)
			{
			}
		}

		// Token: 0x040000F1 RID: 241
		private SiticonePanel siticonePanel1;

		// Token: 0x040000F2 RID: 242
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		// Token: 0x040000F3 RID: 243
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x040000F4 RID: 244
		private Label label1;

		// Token: 0x040000F5 RID: 245
		private SiticonePanel siticonePanel4;

		// Token: 0x040000F6 RID: 246
		private Label creation;

		// Token: 0x040000F7 RID: 247
		private Label label3;

		// Token: 0x040000F8 RID: 248
		private Label exp;

		// Token: 0x040000F9 RID: 249
		private Label sub;

		// Token: 0x040000FA RID: 250
		private Label label9;

		// Token: 0x040000FB RID: 251
		private Label label13;

		// Token: 0x040000FC RID: 252
		private SiticonePanel siticonePanel3;

		// Token: 0x040000FD RID: 253
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x040000FE RID: 254
		private Label label12;

		// Token: 0x040000FF RID: 255
		private Label label11;

		// Token: 0x04000100 RID: 256
		private Label label10;

		// Token: 0x04000101 RID: 257
		private SiticoneCirclePictureBox siticoneCirclePictureBox1;

		// Token: 0x04000102 RID: 258
		private SiticonePanel siticonePanel2;

		// Token: 0x04000103 RID: 259
		private Label passoutput;

		// Token: 0x04000104 RID: 260
		private Label useroutput;

		// Token: 0x04000105 RID: 261
		private Label label7;

		// Token: 0x04000106 RID: 262
		private Label label2;
	}
}
