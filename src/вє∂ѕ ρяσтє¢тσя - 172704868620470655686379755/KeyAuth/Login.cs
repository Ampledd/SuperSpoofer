using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x0200000D RID: 13
	public partial class Login : Form
	{
		// Token: 0x060000B0 RID: 176
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x060000B1 RID: 177
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x060000B2 RID: 178
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060000B3 RID: 179 RVA: 0x00008448 File Offset: 0x00006648
		public Login()
		{
			Login.KeyAuthApp.init();
			if (((Process.GetProcessesByName("ProcessHacker").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
			{
				<Module>.__VMFUNCTION__A0E29(this);
			}
			else
			{
				<Module>.__VMFUNCTION__516F1(this);
			}
			Login.__VMFUNCTION__6C50B(this);
			this.timer2.Start();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000084B4 File Offset: 0x000066B4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				CreateParams createParams2 = createParams;
				createParams2.ClassStyle = (int)(~(int)(~(int)((uint)createParams2.ClassStyle | (uint)131072)));
				return createParams;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000084F0 File Offset: 0x000066F0
		public static void SendWebhook()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00008504 File Offset: 0x00006704
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime dateTime = default(DateTime);
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime3 = default(DateTime);
			dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return dateTime.AddSeconds((double)((ulong)unixtime)).ToLocalTime();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000856C File Offset: 0x0000676C
		public string GetIP()
		{
			string input = new WebClient().DownloadString("http://checkip.dyndns.org/");
			return new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}").Matches(input)[0].ToString();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000086B8 File Offset: 0x000068B8
		public static void __VMFUNCTION__6C50B(Login A_0)
		{
			A_0.components = (IContainer)new Container();
			ResourceManager resourceManager = new ComponentResourceManager(typeof(Login));
			A_0.siticoneDragControl1 = new SiticoneDragControl(A_0.components);
			A_0.label1 = new Label();
			A_0.label4 = new Label();
			A_0.label6 = new Label();
			A_0.AAA = new Label();
			A_0.siticoneDragControl2 = new SiticoneDragControl(A_0.components);
			A_0.timer2 = new Timer(A_0.components);
			A_0.label5 = new Label();
			A_0.timer3 = new Timer(A_0.components);
			A_0.siticoneDragControl3 = new SiticoneDragControl(A_0.components);
			A_0.watermark = new Label();
			A_0.password = new SiticoneTextBox();
			A_0.siticoneCustomCheckBox1 = new SiticoneCustomCheckBox();
			A_0.loginnow = new SiticoneRoundedButton();
			A_0.autohelper = new Label();
			A_0.user = new SiticoneTextBox();
			A_0.menu = new SiticoneComboBox();
			A_0.pictureBox1 = new PictureBox();
			((ISupportInitialize)A_0.pictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticoneDragControl1.TargetControl = null;
			A_0.label1.AutoSize = true;
			A_0.label1.Font = new Font("Segoe UI Light", 10f);
			A_0.label1.ForeColor = Color.White;
			A_0.label1.Location = new Point(-1, 206);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(0, 19);
			A_0.label1.TabIndex = 22;
			A_0.label4.AutoSize = true;
			A_0.label4.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label4.Location = new Point(1212, 402);
			A_0.label4.Name = "label4";
			A_0.label4.Size = new Size(0, 17);
			A_0.label4.TabIndex = 48;
			A_0.label4.Visible = false;
			A_0.label6.AutoSize = true;
			A_0.label6.Location = new Point(1083, 374);
			A_0.label6.Name = "label6";
			A_0.label6.Size = new Size(35, 13);
			A_0.label6.TabIndex = 78;
			A_0.label6.Text = "label6";
			A_0.label6.Visible = false;
			A_0.AAA.AutoSize = true;
			A_0.AAA.Font = new Font("Courier New", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.AAA.ForeColor = Color.White;
			A_0.AAA.Location = new Point(259, 467);
			A_0.AAA.Name = "AAA";
			A_0.AAA.Size = new Size(0, 16);
			A_0.AAA.TabIndex = 106;
			A_0.AAA.Visible = false;
			A_0.siticoneDragControl2.TargetControl = A_0;
			A_0.timer2.Interval = 10;
			A_0.timer2.Tick += A_0.__VMFUNCTION__A12D9;
			A_0.label5.AutoSize = true;
			A_0.label5.Location = new Point(1086, 361);
			A_0.label5.Name = "label5";
			A_0.label5.Size = new Size(14, 13);
			A_0.label5.TabIndex = 110;
			A_0.label5.Text = "is";
			A_0.label5.Visible = false;
			A_0.timer3.Interval = 10;
			A_0.timer3.Tick += A_0.__VMFUNCTION__EB73;
			A_0.siticoneDragControl3.TargetControl = null;
			A_0.watermark.AutoSize = true;
			A_0.watermark.BackColor = Color.FromArgb(25, 26, 30);
			A_0.watermark.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.watermark.ForeColor = Color.WhiteSmoke;
			A_0.watermark.Location = new Point(12, 9);
			A_0.watermark.Name = "watermark";
			A_0.watermark.Size = new Size(134, 17);
			A_0.watermark.TabIndex = 138;
			A_0.watermark.Text = "SuperSpoofer - Login";
			A_0.password.BorderColor = Color.FromArgb(70, 70, 70);
			A_0.password.BorderRadius = 2;
			A_0.password.Cursor = Cursors.IBeam;
			A_0.password.DefaultText = "";
			A_0.password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.password.DisabledState.Parent = A_0.password;
			A_0.password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.password.FillColor = Color.FromArgb(25, 26, 30);
			A_0.password.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			A_0.password.FocusedState.Parent = A_0.password;
			A_0.password.ForeColor = Color.Snow;
			A_0.password.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.password.HoveredState.Parent = A_0.password;
			A_0.password.Location = new Point(86, 113);
			A_0.password.Name = "password";
			A_0.password.PasswordChar = (char)0;
			A_0.password.PlaceholderForeColor = Color.Gray;
			A_0.password.PlaceholderText = "Enter Password...";
			A_0.password.SelectedText = "";
			A_0.password.ShadowDecoration.Parent = A_0.password;
			A_0.password.Size = new Size(353, 36);
			A_0.password.TabIndex = 146;
			A_0.password.TextChanged += A_0.__VMFUNCTION__A0DE1;
			A_0.siticoneCustomCheckBox1.BackColor = Color.Transparent;
			A_0.siticoneCustomCheckBox1.Checked = true;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.SteelBlue;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			A_0.siticoneCustomCheckBox1.CheckedState.FillColor = Color.SteelBlue;
			A_0.siticoneCustomCheckBox1.CheckedState.Parent = A_0.siticoneCustomCheckBox1;
			A_0.siticoneCustomCheckBox1.CheckState = CheckState.Checked;
			A_0.siticoneCustomCheckBox1.Cursor = Cursors.Hand;
			A_0.siticoneCustomCheckBox1.Location = new Point(87, 157);
			A_0.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			A_0.siticoneCustomCheckBox1.ShadowDecoration.Parent = A_0.siticoneCustomCheckBox1;
			A_0.siticoneCustomCheckBox1.Size = new Size(17, 17);
			A_0.siticoneCustomCheckBox1.TabIndex = 145;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.White;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			A_0.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.Transparent;
			A_0.siticoneCustomCheckBox1.UncheckedState.Parent = A_0.siticoneCustomCheckBox1;
			A_0.siticoneCustomCheckBox1.CheckedChanged += A_0.__VMFUNCTION__8BA64;
			A_0.loginnow.BorderColor = Color.DarkRed;
			A_0.loginnow.CheckedState.Parent = A_0.loginnow;
			A_0.loginnow.Cursor = Cursors.Hand;
			A_0.loginnow.CustomImages.Parent = A_0.loginnow;
			A_0.loginnow.FillColor = Color.SteelBlue;
			A_0.loginnow.Font = new Font("Segoe UI", 9f);
			A_0.loginnow.ForeColor = Color.White;
			A_0.loginnow.HoveredState.Parent = A_0.loginnow;
			A_0.loginnow.Location = new Point(86, 182);
			A_0.loginnow.Name = "loginnow";
			A_0.loginnow.ShadowDecoration.Parent = A_0.loginnow;
			A_0.loginnow.Size = new Size(353, 29);
			A_0.loginnow.TabIndex = 144;
			A_0.loginnow.Text = "Login";
			A_0.loginnow.Click += A_0.__VMFUNCTION__3C8EC;
			A_0.autohelper.AutoSize = true;
			A_0.autohelper.Cursor = Cursors.Arrow;
			A_0.autohelper.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.autohelper.ForeColor = Color.WhiteSmoke;
			A_0.autohelper.Location = new Point(109, 156);
			A_0.autohelper.Name = "autohelper";
			A_0.autohelper.Size = new Size(100, 17);
			A_0.autohelper.TabIndex = 143;
			A_0.autohelper.Text = "Remember me?";
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
			A_0.user.ForeColor = Color.Snow;
			A_0.user.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.user.HoveredState.Parent = A_0.user;
			A_0.user.Location = new Point(86, 71);
			A_0.user.Name = "user";
			A_0.user.PasswordChar = (char)0;
			A_0.user.PlaceholderForeColor = Color.Gray;
			A_0.user.PlaceholderText = "Enter Username...";
			A_0.user.SelectedText = "";
			A_0.user.ShadowDecoration.Parent = A_0.user;
			A_0.user.Size = new Size(353, 36);
			A_0.user.TabIndex = 142;
			A_0.menu.BackColor = Color.Transparent;
			A_0.menu.BorderColor = Color.Transparent;
			A_0.menu.DrawMode = DrawMode.OwnerDrawFixed;
			A_0.menu.DropDownStyle = ComboBoxStyle.DropDownList;
			A_0.menu.FillColor = Color.FromArgb(25, 26, 30);
			A_0.menu.FocusedColor = Color.FromArgb(25, 26, 30);
			A_0.menu.Font = new Font("Segoe UI", 10f);
			A_0.menu.ForeColor = Color.FromArgb(224, 224, 224);
			A_0.menu.FormattingEnabled = true;
			A_0.menu.HoveredState.BorderColor = Color.Transparent;
			A_0.menu.HoveredState.FillColor = Color.FromArgb(25, 26, 30);
			A_0.menu.HoveredState.Parent = A_0.menu;
			A_0.menu.ItemHeight = 30;
			ComboBox.ObjectCollection items = A_0.menu.Items;
			items.AddRange(new object[]
			{
				"Always on top",
				"Official website",
				"Reload application",
				"Exit application"
			});
			A_0.menu.ItemsAppearance.BackColor = Color.FromArgb(25, 26, 30);
			A_0.menu.ItemsAppearance.Parent = A_0.menu;
			A_0.menu.Location = new Point(322, 4);
			A_0.menu.Name = "menu";
			A_0.menu.ShadowDecoration.Parent = A_0.menu;
			A_0.menu.Size = new Size(190, 36);
			A_0.menu.TabIndex = 147;
			A_0.menu.SelectedIndexChanged += A_0.__VMFUNCTION__586B0;
			A_0.pictureBox1.Image = (Image)resourceManager.GetObject("pictureBox1.Image");
			A_0.pictureBox1.Location = new Point(401, 120);
			A_0.pictureBox1.Name = "pictureBox1";
			A_0.pictureBox1.Size = new Size(32, 23);
			A_0.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox1.TabIndex = 148;
			A_0.pictureBox1.TabStop = false;
			A_0.pictureBox1.Click += A_0.__VMFUNCTION__10D42;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.AutoValidate = AutoValidate.Disable;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(524, 282);
			A_0.ControlBox = false;
			A_0.Controls.Add(A_0.pictureBox1);
			A_0.Controls.Add(A_0.menu);
			A_0.Controls.Add(A_0.password);
			A_0.Controls.Add(A_0.siticoneCustomCheckBox1);
			A_0.Controls.Add(A_0.loginnow);
			A_0.Controls.Add(A_0.autohelper);
			A_0.Controls.Add(A_0.user);
			A_0.Controls.Add(A_0.watermark);
			A_0.Controls.Add(A_0.label5);
			A_0.Controls.Add(A_0.AAA);
			A_0.Controls.Add(A_0.label6);
			A_0.Controls.Add(A_0.label1);
			A_0.Controls.Add(A_0.label4);
			A_0.Cursor = Cursors.SizeAll;
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Icon = (Icon)resourceManager.GetObject("$this.Icon");
			A_0.MaximizeBox = false;
			A_0.MinimizeBox = false;
			A_0.Name = "Login";
			A_0.ShowIcon = false;
			A_0.StartPosition = FormStartPosition.CenterScreen;
			A_0.Text = "Loader";
			A_0.TransparencyKey = Color.Maroon;
			A_0.Load += A_0.__VMFUNCTION__8D0AA;
			A_0.Click += A_0.__VMFUNCTION__8436C;
			A_0.DragOver += A_0.__VMFUNCTION__A18FA;
			A_0.Move += A_0.__VMFUNCTION__42FE0;
			((ISupportInitialize)A_0.pictureBox1).EndInit();
			A_0.ResumeLayout(false);
			A_0.PerformLayout();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00009750 File Offset: 0x00007950
		public void __VMFUNCTION__A0DE1(object A_1, EventArgs A_2)
		{
			if (((this.password.Text == "") ? 1U : 0U) != (uint)0)
			{
				this.password.UseSystemPasswordChar = false;
			}
			else
			{
				this.password.UseSystemPasswordChar = true;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000097A8 File Offset: 0x000079A8
		public void __VMFUNCTION__8BA64(object A_1, EventArgs A_2)
		{
			try
			{
				TextWriter textWriter = new StreamWriter("username");
				textWriter.WriteLine(this.user.Text);
				textWriter.Close();
				TextWriter textWriter2 = new StreamWriter("password");
				textWriter2.WriteLine(this.password.Text);
				textWriter2.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000222B File Offset: 0x0000042B
		public void __VMFUNCTION__3C8EC(object, EventArgs)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00009820 File Offset: 0x00007A20
		public void __VMFUNCTION__586B0(object A_1, EventArgs A_2)
		{
			try
			{
				if (((this.menu.SelectedItem.ToString() == "Official website") ? 1U : 0U) != (uint)0)
				{
					Process.Start("https://superspoofer.xyz");
				}
				if (((this.menu.SelectedItem.ToString() == "Reload application") ? 1U : 0U) != (uint)0)
				{
					Application.Restart();
				}
				if (((this.menu.SelectedItem.ToString() == "Exit application") ? 1U : 0U) != (uint)0)
				{
					Application.Exit();
				}
				if (((this.menu.SelectedItem.ToString() == "Always on top") ? 1U : 0U) != (uint)0)
				{
					Login.SetWindowPos(base.Handle, Login.HWND_TOPMOST, 0, 0, 0, 0, (uint)3);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000992C File Offset: 0x00007B2C
		public void __VMFUNCTION__10D42(object A_1, EventArgs A_2)
		{
			this.password.UseSystemPasswordChar = false;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000994C File Offset: 0x00007B4C
		public void __VMFUNCTION__8D0AA(object A_1, EventArgs A_2)
		{
			<Module>.__VMFUNCTION__8BD7B(this);
			Login.__VMFUNCTION__6E6E3(this);
			this.timer2.Start();
			this.timer3.Start();
			Process.Start("https://discord.gg/r9nUMNmnKB");
			try
			{
				using (object obj = (object)File.ReadLines("username", Encoding.UTF8).GetEnumerator())
				{
					while ((((IEnumerator)obj).MoveNext() ? 1U : 0U) != (uint)0)
					{
						this.user.Text = ((IEnumerator<string>)obj).Current;
					}
				}
				using (object obj2 = (object)File.ReadLines("password", Encoding.UTF8).GetEnumerator())
				{
					while ((((IEnumerator)obj2).MoveNext() ? 1U : 0U) != (uint)0)
					{
						this.password.Text = ((IEnumerator<string>)obj2).Current;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00009AB4 File Offset: 0x00007CB4
		public void __VMFUNCTION__A18FA(object A_1, DragEventArgs A_2)
		{
			base.Opacity = 30.0;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000222C File Offset: 0x0000042C
		public static void __VMFUNCTION__401DC(object)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000222D File Offset: 0x0000042D
		public static void __VMFUNCTION__6E6E3(object)
		{
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

		// Token: 0x04000039 RID: 57
		private const uint SWP_NOSIZE = 1U;

		// Token: 0x0400003A RID: 58
		private const uint SWP_NOMOVE = 2U;

		// Token: 0x0400003B RID: 59
		private const uint TOPMOST_FLAGS = 3U;

		// Token: 0x0400003C RID: 60
		private static string name = "SuperSpoofer";

		// Token: 0x0400003D RID: 61
		private static string ownerid = "ReuNyTjomm";

		// Token: 0x0400003E RID: 62
		private static string secret = "9214a82022cab6bd88dcaefbe4c3ad38732a0e0aabb784c2c508f4a002fb7fd2";

		// Token: 0x0400003F RID: 63
		private static string version = "3.0.8";

		// Token: 0x04000040 RID: 64
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);

		// Token: 0x04000041 RID: 65
		private const int CS_DropShadow = 131072;

		// Token: 0x04000043 RID: 67
		private SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000044 RID: 68
		private Label label1;

		// Token: 0x04000045 RID: 69
		private Label label4;

		// Token: 0x04000046 RID: 70
		private Label label6;

		// Token: 0x04000047 RID: 71
		private Label AAA;

		// Token: 0x04000048 RID: 72
		private SiticoneDragControl siticoneDragControl2;

		// Token: 0x04000049 RID: 73
		private Timer timer2;

		// Token: 0x0400004A RID: 74
		private Label label5;

		// Token: 0x0400004B RID: 75
		private Timer timer3;

		// Token: 0x0400004C RID: 76
		private SiticoneDragControl siticoneDragControl3;

		// Token: 0x0400004D RID: 77
		private Label watermark;

		// Token: 0x0400004E RID: 78
		private SiticoneTextBox password;

		// Token: 0x0400004F RID: 79
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000050 RID: 80
		private SiticoneRoundedButton loginnow;

		// Token: 0x04000051 RID: 81
		private Label autohelper;

		// Token: 0x04000052 RID: 82
		private SiticoneTextBox user;

		// Token: 0x04000053 RID: 83
		private SiticoneComboBox menu;

		// Token: 0x04000054 RID: 84
		private PictureBox pictureBox1;
	}
}
