using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer.Forms___Extras
{
	// Token: 0x02000020 RID: 32
	public partial class WebhookTool : Form
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000169A8 File Offset: 0x00014BA8
		public WebhookTool()
		{
			WebhookTool.__VMFUNCTION__6F136(this);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000169D0 File Offset: 0x00014BD0
		public static void sendDiscordWebhook(string URL, string escapedjson)
		{
			WebRequest webRequest = WebRequest.Create(URL);
			webRequest.ContentType = "application/json";
			webRequest.Method = "POST";
			using (TextWriter textWriter = new StreamWriter(webRequest.GetRequestStream()))
			{
				textWriter.Write(escapedjson);
			}
			webRequest.GetResponse();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00016A54 File Offset: 0x00014C54
		public static void sendDiscordWeb(string URL, string msg, string user)
		{
			Http.Post(URL, new NameValueCollection
			{
				{
					"username",
					user
				},
				{
					"content",
					msg
				}
			});
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00016A90 File Offset: 0x00014C90
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00016B74 File Offset: 0x00014D74
		public static void __VMFUNCTION__6F136(WebhookTool A_0)
		{
			A_0.keyoutput = new SiticoneGroupBox();
			A_0.siticoneRoundedGradientButton6 = new SiticoneRoundedGradientButton();
			A_0.siticoneRoundedGradientButton5 = new SiticoneRoundedGradientButton();
			A_0.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			A_0.singmgs = new SiticoneTextBox();
			A_0.label5 = new Label();
			A_0.singuser = new SiticoneTextBox();
			A_0.label1 = new Label();
			A_0.singweb = new SiticoneTextBox();
			A_0.label8 = new Label();
			A_0.siticoneGroupBox2 = new SiticoneGroupBox();
			A_0.siticoneTextBox6 = new SiticoneTextBox();
			A_0.label9 = new Label();
			A_0.siticoneGroupBox1 = new SiticoneGroupBox();
			A_0.embeddesc = new SiticoneTextBox();
			A_0.label7 = new Label();
			A_0.embedtitle = new SiticoneTextBox();
			A_0.label6 = new Label();
			A_0.embedcolour = new SiticoneTextBox();
			A_0.siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			A_0.label2 = new Label();
			A_0.embedusername = new SiticoneTextBox();
			A_0.label3 = new Label();
			A_0.embedwebhook = new SiticoneTextBox();
			A_0.label4 = new Label();
			A_0.keyoutput.SuspendLayout();
			A_0.siticoneGroupBox2.SuspendLayout();
			A_0.siticoneGroupBox1.SuspendLayout();
			A_0.SuspendLayout();
			A_0.keyoutput.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.keyoutput.Controls.Add(A_0.siticoneRoundedGradientButton6);
			A_0.keyoutput.Controls.Add(A_0.siticoneRoundedGradientButton5);
			A_0.keyoutput.Controls.Add(A_0.singmgs);
			A_0.keyoutput.Controls.Add(A_0.label5);
			A_0.keyoutput.Controls.Add(A_0.singuser);
			A_0.keyoutput.Controls.Add(A_0.label1);
			A_0.keyoutput.Controls.Add(A_0.singweb);
			A_0.keyoutput.Controls.Add(A_0.label8);
			A_0.keyoutput.CustomBorderColor = Color.FromArgb(65, 71, 85);
			A_0.keyoutput.FillColor = Color.FromArgb(25, 26, 30);
			A_0.keyoutput.Font = new Font("Segoe UI", 9f);
			A_0.keyoutput.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.keyoutput.Location = new Point(12, 12);
			A_0.keyoutput.Name = "keyoutput";
			A_0.keyoutput.ShadowDecoration.Parent = A_0.keyoutput;
			A_0.keyoutput.Size = new Size(399, 287);
			A_0.keyoutput.TabIndex = 115;
			A_0.keyoutput.Text = "Webhook Spammer - Message";
			A_0.siticoneRoundedGradientButton6.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton6.CheckedState.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.CustomImages.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.FillColor = Color.DimGray;
			A_0.siticoneRoundedGradientButton6.FillColor2 = Color.DimGray;
			A_0.siticoneRoundedGradientButton6.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton6.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton6.HoveredState.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.Location = new Point(208, 242);
			A_0.siticoneRoundedGradientButton6.Name = "siticoneRoundedGradientButton6";
			A_0.siticoneRoundedGradientButton6.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton6;
			A_0.siticoneRoundedGradientButton6.Size = new Size(178, 30);
			A_0.siticoneRoundedGradientButton6.TabIndex = 118;
			A_0.siticoneRoundedGradientButton6.Text = "Spam Message";
			A_0.siticoneRoundedGradientButton6.Click += A_0.__VMFUNCTION__85267;
			A_0.siticoneRoundedGradientButton5.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton5.CheckedState.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.CustomImages.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.FillColor = Color.DimGray;
			A_0.siticoneRoundedGradientButton5.FillColor2 = Color.DimGray;
			A_0.siticoneRoundedGradientButton5.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton5.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton5.HoveredState.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.Location = new Point(17, 242);
			A_0.siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
			A_0.siticoneRoundedGradientButton5.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton5;
			A_0.siticoneRoundedGradientButton5.Size = new Size(178, 30);
			A_0.siticoneRoundedGradientButton5.TabIndex = 117;
			A_0.siticoneRoundedGradientButton5.Text = "Send Message";
			A_0.siticoneRoundedGradientButton5.Click += A_0.__VMFUNCTION__F66A;
			A_0.siticoneRoundedGradientButton3.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton3.CheckedState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.CustomImages.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.FillColor = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.FillColor2 = Color.DarkRed;
			A_0.siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton3.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton3.HoveredState.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Location = new Point(17, 101);
			A_0.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			A_0.siticoneRoundedGradientButton3.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton3;
			A_0.siticoneRoundedGradientButton3.Size = new Size(369, 30);
			A_0.siticoneRoundedGradientButton3.TabIndex = 116;
			A_0.siticoneRoundedGradientButton3.Text = "Delete Webhook";
			A_0.siticoneRoundedGradientButton3.Click += A_0.__VMFUNCTION__813C6;
			A_0.singmgs.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.singmgs.Cursor = Cursors.No;
			A_0.singmgs.DefaultText = "";
			A_0.singmgs.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.singmgs.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.singmgs.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.singmgs.DisabledState.Parent = A_0.singmgs;
			A_0.singmgs.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.singmgs.FillColor = Color.FromArgb(25, 26, 30);
			A_0.singmgs.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.singmgs.FocusedState.Parent = A_0.singmgs;
			A_0.singmgs.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.singmgs.HoveredState.Parent = A_0.singmgs;
			A_0.singmgs.Location = new Point(17, 184);
			A_0.singmgs.Multiline = true;
			A_0.singmgs.Name = "singmgs";
			A_0.singmgs.PasswordChar = (char)0;
			A_0.singmgs.PlaceholderText = "ola";
			A_0.singmgs.SelectedText = "";
			A_0.singmgs.ShadowDecoration.Parent = A_0.singmgs;
			A_0.singmgs.Size = new Size(369, 52);
			A_0.singmgs.TabIndex = 102;
			A_0.label5.AutoSize = true;
			A_0.label5.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label5.ForeColor = Color.White;
			A_0.label5.Location = new Point(14, 168);
			A_0.label5.Name = "label5";
			A_0.label5.Size = new Size(56, 13);
			A_0.label5.TabIndex = 101;
			A_0.label5.Text = "Message:";
			A_0.singuser.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.singuser.Cursor = Cursors.No;
			A_0.singuser.DefaultText = "";
			A_0.singuser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.singuser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.singuser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.singuser.DisabledState.Parent = A_0.singuser;
			A_0.singuser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.singuser.FillColor = Color.FromArgb(25, 26, 30);
			A_0.singuser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.singuser.FocusedState.Parent = A_0.singuser;
			A_0.singuser.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.singuser.HoveredState.Parent = A_0.singuser;
			A_0.singuser.Location = new Point(17, 125);
			A_0.singuser.Name = "singuser";
			A_0.singuser.PasswordChar = (char)0;
			A_0.singuser.PlaceholderText = "hmmm";
			A_0.singuser.SelectedText = "";
			A_0.singuser.ShadowDecoration.Parent = A_0.singuser;
			A_0.singuser.Size = new Size(369, 30);
			A_0.singuser.TabIndex = 100;
			A_0.label1.AutoSize = true;
			A_0.label1.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.White;
			A_0.label1.Location = new Point(14, 109);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(62, 13);
			A_0.label1.TabIndex = 99;
			A_0.label1.Text = "Nickname:";
			A_0.singweb.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.singweb.Cursor = Cursors.No;
			A_0.singweb.DefaultText = "";
			A_0.singweb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.singweb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.singweb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.singweb.DisabledState.Parent = A_0.singweb;
			A_0.singweb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.singweb.FillColor = Color.FromArgb(25, 26, 30);
			A_0.singweb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.singweb.FocusedState.Parent = A_0.singweb;
			A_0.singweb.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.singweb.HoveredState.Parent = A_0.singweb;
			A_0.singweb.Location = new Point(17, 67);
			A_0.singweb.Name = "singweb";
			A_0.singweb.PasswordChar = (char)0;
			A_0.singweb.PlaceholderText = "https://discord.com/api/webhooks/xxxxxxxxxxx";
			A_0.singweb.SelectedText = "";
			A_0.singweb.ShadowDecoration.Parent = A_0.singweb;
			A_0.singweb.Size = new Size(369, 30);
			A_0.singweb.TabIndex = 98;
			A_0.label8.AutoSize = true;
			A_0.label8.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label8.ForeColor = Color.White;
			A_0.label8.Location = new Point(14, 51);
			A_0.label8.Name = "label8";
			A_0.label8.Size = new Size(61, 13);
			A_0.label8.TabIndex = 53;
			A_0.label8.Text = "Webhook:";
			A_0.siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox2.Controls.Add(A_0.siticoneTextBox6);
			A_0.siticoneGroupBox2.Controls.Add(A_0.label9);
			A_0.siticoneGroupBox2.Controls.Add(A_0.siticoneRoundedGradientButton3);
			A_0.siticoneGroupBox2.CustomBorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox2.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox2.Location = new Point(12, 399);
			A_0.siticoneGroupBox2.Name = "siticoneGroupBox2";
			A_0.siticoneGroupBox2.ShadowDecoration.Parent = A_0.siticoneGroupBox2;
			A_0.siticoneGroupBox2.Size = new Size(399, 139);
			A_0.siticoneGroupBox2.TabIndex = 119;
			A_0.siticoneGroupBox2.Text = "Webhook Spammer - Message";
			A_0.siticoneTextBox6.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.siticoneTextBox6.Cursor = Cursors.No;
			A_0.siticoneTextBox6.DefaultText = "";
			A_0.siticoneTextBox6.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.siticoneTextBox6.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.siticoneTextBox6.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox6.DisabledState.Parent = A_0.siticoneTextBox6;
			A_0.siticoneTextBox6.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox6.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneTextBox6.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.siticoneTextBox6.FocusedState.Parent = A_0.siticoneTextBox6;
			A_0.siticoneTextBox6.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.siticoneTextBox6.HoveredState.Parent = A_0.siticoneTextBox6;
			A_0.siticoneTextBox6.Location = new Point(17, 68);
			A_0.siticoneTextBox6.Margin = new Padding(4, 3, 4, 3);
			A_0.siticoneTextBox6.Name = "siticoneTextBox6";
			A_0.siticoneTextBox6.PasswordChar = (char)0;
			A_0.siticoneTextBox6.PlaceholderText = "";
			A_0.siticoneTextBox6.SelectedText = "";
			A_0.siticoneTextBox6.ShadowDecoration.Parent = A_0.siticoneTextBox6;
			A_0.siticoneTextBox6.Size = new Size(366, 27);
			A_0.siticoneTextBox6.TabIndex = 98;
			A_0.siticoneTextBox6.TextChanged += A_0.__VMFUNCTION__6629A;
			A_0.label9.AutoSize = true;
			A_0.label9.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label9.ForeColor = Color.White;
			A_0.label9.Location = new Point(14, 49);
			A_0.label9.Name = "label9";
			A_0.label9.Size = new Size(61, 13);
			A_0.label9.TabIndex = 53;
			A_0.label9.Text = "Webhook:";
			A_0.siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.Controls.Add(A_0.embeddesc);
			A_0.siticoneGroupBox1.Controls.Add(A_0.label7);
			A_0.siticoneGroupBox1.Controls.Add(A_0.embedtitle);
			A_0.siticoneGroupBox1.Controls.Add(A_0.label6);
			A_0.siticoneGroupBox1.Controls.Add(A_0.embedcolour);
			A_0.siticoneGroupBox1.Controls.Add(A_0.siticoneRoundedGradientButton2);
			A_0.siticoneGroupBox1.Controls.Add(A_0.label2);
			A_0.siticoneGroupBox1.Controls.Add(A_0.embedusername);
			A_0.siticoneGroupBox1.Controls.Add(A_0.label3);
			A_0.siticoneGroupBox1.Controls.Add(A_0.embedwebhook);
			A_0.siticoneGroupBox1.Controls.Add(A_0.label4);
			A_0.siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			A_0.siticoneGroupBox1.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			A_0.siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			A_0.siticoneGroupBox1.Location = new Point(632, 12);
			A_0.siticoneGroupBox1.Name = "siticoneGroupBox1";
			A_0.siticoneGroupBox1.ShadowDecoration.Parent = A_0.siticoneGroupBox1;
			A_0.siticoneGroupBox1.Size = new Size(399, 449);
			A_0.siticoneGroupBox1.TabIndex = 120;
			A_0.siticoneGroupBox1.Text = "Webhook Spammer - Embed";
			A_0.embeddesc.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.embeddesc.Cursor = Cursors.No;
			A_0.embeddesc.DefaultText = "";
			A_0.embeddesc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.embeddesc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.embeddesc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.embeddesc.DisabledState.Parent = A_0.embeddesc;
			A_0.embeddesc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.embeddesc.FillColor = Color.FromArgb(25, 26, 30);
			A_0.embeddesc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embeddesc.FocusedState.Parent = A_0.embeddesc;
			A_0.embeddesc.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embeddesc.HoveredState.Parent = A_0.embeddesc;
			A_0.embeddesc.Location = new Point(17, 300);
			A_0.embeddesc.Margin = new Padding(6, 3, 6, 3);
			A_0.embeddesc.Multiline = true;
			A_0.embeddesc.Name = "embeddesc";
			A_0.embeddesc.PasswordChar = (char)0;
			A_0.embeddesc.PlaceholderText = "my name is super...";
			A_0.embeddesc.SelectedText = "";
			A_0.embeddesc.ShadowDecoration.Parent = A_0.embeddesc;
			A_0.embeddesc.Size = new Size(369, 98);
			A_0.embeddesc.TabIndex = 123;
			A_0.label7.AutoSize = true;
			A_0.label7.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label7.ForeColor = Color.White;
			A_0.label7.Location = new Point(14, 284);
			A_0.label7.Name = "label7";
			A_0.label7.Size = new Size(108, 13);
			A_0.label7.TabIndex = 122;
			A_0.label7.Text = "Embed Description:";
			A_0.embedtitle.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.embedtitle.Cursor = Cursors.No;
			A_0.embedtitle.DefaultText = "";
			A_0.embedtitle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.embedtitle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.embedtitle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedtitle.DisabledState.Parent = A_0.embedtitle;
			A_0.embedtitle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedtitle.FillColor = Color.FromArgb(25, 26, 30);
			A_0.embedtitle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedtitle.FocusedState.Parent = A_0.embedtitle;
			A_0.embedtitle.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedtitle.HoveredState.Parent = A_0.embedtitle;
			A_0.embedtitle.Location = new Point(17, 242);
			A_0.embedtitle.Margin = new Padding(5, 3, 5, 3);
			A_0.embedtitle.Name = "embedtitle";
			A_0.embedtitle.PasswordChar = (char)0;
			A_0.embedtitle.PlaceholderText = "Hello";
			A_0.embedtitle.SelectedText = "";
			A_0.embedtitle.ShadowDecoration.Parent = A_0.embedtitle;
			A_0.embedtitle.Size = new Size(369, 30);
			A_0.embedtitle.TabIndex = 121;
			A_0.label6.AutoSize = true;
			A_0.label6.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label6.ForeColor = Color.White;
			A_0.label6.Location = new Point(14, 226);
			A_0.label6.Name = "label6";
			A_0.label6.Size = new Size(71, 13);
			A_0.label6.TabIndex = 120;
			A_0.label6.Text = "Embed Title:";
			A_0.embedcolour.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.embedcolour.Cursor = Cursors.No;
			A_0.embedcolour.DefaultText = "";
			A_0.embedcolour.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.embedcolour.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.embedcolour.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedcolour.DisabledState.Parent = A_0.embedcolour;
			A_0.embedcolour.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedcolour.FillColor = Color.FromArgb(25, 26, 30);
			A_0.embedcolour.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedcolour.FocusedState.Parent = A_0.embedcolour;
			A_0.embedcolour.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedcolour.HoveredState.Parent = A_0.embedcolour;
			A_0.embedcolour.Location = new Point(17, 184);
			A_0.embedcolour.Margin = new Padding(4, 3, 4, 3);
			A_0.embedcolour.Name = "embedcolour";
			A_0.embedcolour.PasswordChar = (char)0;
			A_0.embedcolour.PlaceholderText = "3717153 (www.spycolor.com)";
			A_0.embedcolour.SelectedText = "";
			A_0.embedcolour.ShadowDecoration.Parent = A_0.embedcolour;
			A_0.embedcolour.Size = new Size(369, 30);
			A_0.embedcolour.TabIndex = 119;
			A_0.siticoneRoundedGradientButton2.BorderThickness = 1;
			A_0.siticoneRoundedGradientButton2.CheckedState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.CustomImages.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.FillColor = Color.DimGray;
			A_0.siticoneRoundedGradientButton2.FillColor2 = Color.DimGray;
			A_0.siticoneRoundedGradientButton2.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			A_0.siticoneRoundedGradientButton2.ForeColor = Color.White;
			A_0.siticoneRoundedGradientButton2.HoveredState.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Location = new Point(17, 406);
			A_0.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			A_0.siticoneRoundedGradientButton2.ShadowDecoration.Parent = A_0.siticoneRoundedGradientButton2;
			A_0.siticoneRoundedGradientButton2.Size = new Size(369, 30);
			A_0.siticoneRoundedGradientButton2.TabIndex = 117;
			A_0.siticoneRoundedGradientButton2.Text = "Send Message";
			A_0.siticoneRoundedGradientButton2.Click += A_0.__VMFUNCTION__10A51;
			A_0.label2.AutoSize = true;
			A_0.label2.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label2.ForeColor = Color.White;
			A_0.label2.Location = new Point(14, 168);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(136, 13);
			A_0.label2.TabIndex = 101;
			A_0.label2.Text = "Embed Colour (Decimal):";
			A_0.embedusername.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.embedusername.Cursor = Cursors.No;
			A_0.embedusername.DefaultText = "";
			A_0.embedusername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.embedusername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.embedusername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedusername.DisabledState.Parent = A_0.embedusername;
			A_0.embedusername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedusername.FillColor = Color.FromArgb(25, 26, 30);
			A_0.embedusername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedusername.FocusedState.Parent = A_0.embedusername;
			A_0.embedusername.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedusername.HoveredState.Parent = A_0.embedusername;
			A_0.embedusername.Location = new Point(17, 125);
			A_0.embedusername.Name = "embedusername";
			A_0.embedusername.PasswordChar = (char)0;
			A_0.embedusername.PlaceholderText = "get recked lol";
			A_0.embedusername.SelectedText = "";
			A_0.embedusername.ShadowDecoration.Parent = A_0.embedusername;
			A_0.embedusername.Size = new Size(369, 30);
			A_0.embedusername.TabIndex = 100;
			A_0.label3.AutoSize = true;
			A_0.label3.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label3.ForeColor = Color.White;
			A_0.label3.Location = new Point(14, 109);
			A_0.label3.Name = "label3";
			A_0.label3.Size = new Size(62, 13);
			A_0.label3.TabIndex = 99;
			A_0.label3.Text = "Nickname:";
			A_0.embedwebhook.BorderColor = Color.FromArgb(79, 84, 103);
			A_0.embedwebhook.Cursor = Cursors.No;
			A_0.embedwebhook.DefaultText = "";
			A_0.embedwebhook.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.embedwebhook.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.embedwebhook.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedwebhook.DisabledState.Parent = A_0.embedwebhook;
			A_0.embedwebhook.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.embedwebhook.FillColor = Color.FromArgb(25, 26, 30);
			A_0.embedwebhook.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedwebhook.FocusedState.Parent = A_0.embedwebhook;
			A_0.embedwebhook.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			A_0.embedwebhook.HoveredState.Parent = A_0.embedwebhook;
			A_0.embedwebhook.Location = new Point(17, 67);
			A_0.embedwebhook.Name = "embedwebhook";
			A_0.embedwebhook.PasswordChar = (char)0;
			A_0.embedwebhook.PlaceholderText = "https://discord.com/api/webhooks/xxxxxxxxxxx";
			A_0.embedwebhook.SelectedText = "";
			A_0.embedwebhook.ShadowDecoration.Parent = A_0.embedwebhook;
			A_0.embedwebhook.Size = new Size(369, 30);
			A_0.embedwebhook.TabIndex = 98;
			A_0.label4.AutoSize = true;
			A_0.label4.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label4.ForeColor = Color.White;
			A_0.label4.Location = new Point(14, 51);
			A_0.label4.Name = "label4";
			A_0.label4.Size = new Size(61, 13);
			A_0.label4.TabIndex = 53;
			A_0.label4.Text = "Webhook:";
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(1043, 550);
			A_0.Controls.Add(A_0.siticoneGroupBox1);
			A_0.Controls.Add(A_0.siticoneGroupBox2);
			A_0.Controls.Add(A_0.keyoutput);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "WebhookTool";
			A_0.Text = "WebhookTool";
			A_0.Load += A_0.__VMFUNCTION__73512;
			A_0.keyoutput.ResumeLayout(false);
			A_0.keyoutput.PerformLayout();
			A_0.siticoneGroupBox2.ResumeLayout(false);
			A_0.siticoneGroupBox2.PerformLayout();
			A_0.siticoneGroupBox1.ResumeLayout(false);
			A_0.siticoneGroupBox1.PerformLayout();
			A_0.ResumeLayout(false);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00018DC0 File Offset: 0x00016FC0
		public unsafe void __VMFUNCTION__85267(object A_1, EventArgs A_2)
		{
			WebhookTool.<siticoneRoundedGradientButton6_Click>d__12 <siticoneRoundedGradientButton6_Click>d__ = new WebhookTool.<siticoneRoundedGradientButton6_Click>d__12();
			<siticoneRoundedGradientButton6_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<siticoneRoundedGradientButton6_Click>d__.<>4__this = this;
			<siticoneRoundedGradientButton6_Click>d__.sender = A_1;
			<siticoneRoundedGradientButton6_Click>d__.e = A_2;
			<siticoneRoundedGradientButton6_Click>d__.<>1__state = -1;
			((WebhookTool.<siticoneRoundedGradientButton6_Click>d__12*)<siticoneRoundedGradientButton6_Click>d__).<>t__builder.Start<WebhookTool.<siticoneRoundedGradientButton6_Click>d__12>(ref <siticoneRoundedGradientButton6_Click>d__);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002235 File Offset: 0x00000435
		public void __VMFUNCTION__F66A(object, EventArgs)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002236 File Offset: 0x00000436
		public void __VMFUNCTION__813C6(object, EventArgs)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002237 File Offset: 0x00000437
		public void __VMFUNCTION__10A51(object, EventArgs)
		{
		}

		// Token: 0x0400011A RID: 282
		private SiticoneGroupBox keyoutput;

		// Token: 0x0400011B RID: 283
		private SiticoneTextBox singmgs;

		// Token: 0x0400011C RID: 284
		private Label label5;

		// Token: 0x0400011D RID: 285
		private SiticoneTextBox singuser;

		// Token: 0x0400011E RID: 286
		private Label label1;

		// Token: 0x0400011F RID: 287
		private SiticoneTextBox singweb;

		// Token: 0x04000120 RID: 288
		private Label label8;

		// Token: 0x04000121 RID: 289
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton6;

		// Token: 0x04000122 RID: 290
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		// Token: 0x04000123 RID: 291
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		// Token: 0x04000124 RID: 292
		private SiticoneGroupBox siticoneGroupBox2;

		// Token: 0x04000125 RID: 293
		private SiticoneTextBox siticoneTextBox6;

		// Token: 0x04000126 RID: 294
		private Label label9;

		// Token: 0x04000127 RID: 295
		private SiticoneGroupBox siticoneGroupBox1;

		// Token: 0x04000128 RID: 296
		private SiticoneTextBox embeddesc;

		// Token: 0x04000129 RID: 297
		private Label label7;

		// Token: 0x0400012A RID: 298
		private SiticoneTextBox embedtitle;

		// Token: 0x0400012B RID: 299
		private Label label6;

		// Token: 0x0400012C RID: 300
		private SiticoneTextBox embedcolour;

		// Token: 0x0400012D RID: 301
		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		// Token: 0x0400012E RID: 302
		private Label label2;

		// Token: 0x0400012F RID: 303
		private SiticoneTextBox embedusername;

		// Token: 0x04000130 RID: 304
		private Label label3;

		// Token: 0x04000131 RID: 305
		private SiticoneTextBox embedwebhook;

		// Token: 0x04000132 RID: 306
		private Label label4;
	}
}
