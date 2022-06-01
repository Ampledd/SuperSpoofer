using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer.Forms___Spoofer
{
	// Token: 0x0200001A RID: 26
	public partial class fivembuildchanger : Form
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00010DEC File Offset: 0x0000EFEC
		public fivembuildchanger()
		{
			fivembuildchanger.__VMFUNCTION__F824(this);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		public static void __VMFUNCTION__F824(fivembuildchanger A_0)
		{
			A_0.components = (IContainer)new Container();
			A_0.siticoneControlBox3 = new SiticoneControlBox();
			A_0.label1 = new Label();
			A_0.label2 = new Label();
			A_0.siticoneButton1 = new SiticoneButton();
			A_0.siticoneDragControl1 = new SiticoneDragControl(A_0.components);
			A_0.path = new SiticoneTextBox();
			A_0.siticoneTextBox1 = new SiticoneTextBox();
			A_0.SuspendLayout();
			A_0.siticoneControlBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			A_0.siticoneControlBox3.BackColor = Color.Transparent;
			A_0.siticoneControlBox3.BorderColor = Color.Silver;
			A_0.siticoneControlBox3.BorderRadius = 10;
			A_0.siticoneControlBox3.Cursor = Cursors.Hand;
			A_0.siticoneControlBox3.FillColor = Color.Transparent;
			A_0.siticoneControlBox3.HoveredState.BorderColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneControlBox3.HoveredState.FillColor = Color.FromArgb(25, 26, 30);
			A_0.siticoneControlBox3.HoveredState.IconColor = Color.White;
			A_0.siticoneControlBox3.HoveredState.Parent = A_0.siticoneControlBox3;
			A_0.siticoneControlBox3.IconColor = Color.White;
			A_0.siticoneControlBox3.Location = new Point(422, 3);
			A_0.siticoneControlBox3.Name = "siticoneControlBox3";
			A_0.siticoneControlBox3.ShadowDecoration.Parent = A_0.siticoneControlBox3;
			A_0.siticoneControlBox3.Size = new Size(39, 23);
			A_0.siticoneControlBox3.TabIndex = 1;
			A_0.siticoneControlBox3.Click += A_0.__VMFUNCTION__92CC7;
			A_0.label1.AutoSize = true;
			A_0.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
			A_0.label1.ForeColor = Color.White;
			A_0.label1.Location = new Point(12, 42);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(346, 16);
			A_0.label1.TabIndex = 57;
			A_0.label1.Text = "FiveM Path (C:\\users\\user\\AppData\\Local\\FiveM)";
			A_0.label2.AutoSize = true;
			A_0.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
			A_0.label2.ForeColor = Color.White;
			A_0.label2.Location = new Point(12, 107);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(293, 16);
			A_0.label2.TabIndex = 58;
			A_0.label2.Text = "Build Version (1604/2060/2189/2372/2545)";
			A_0.siticoneButton1.CheckedState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.CustomImages.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.FillColor = Color.DarkRed;
			A_0.siticoneButton1.Font = new Font("Ebrima", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton1.ForeColor = Color.White;
			A_0.siticoneButton1.HoveredState.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Location = new Point(11, 174);
			A_0.siticoneButton1.Name = "siticoneButton1";
			A_0.siticoneButton1.ShadowDecoration.Parent = A_0.siticoneButton1;
			A_0.siticoneButton1.Size = new Size(439, 27);
			A_0.siticoneButton1.TabIndex = 59;
			A_0.siticoneButton1.Text = "Change Build Version";
			A_0.siticoneButton1.Click += A_0.__VMFUNCTION__51E9F;
			A_0.siticoneDragControl1.TargetControl = null;
			A_0.path.BorderColor = Color.FromArgb(70, 70, 70);
			A_0.path.BorderRadius = 2;
			A_0.path.Cursor = Cursors.IBeam;
			A_0.path.DefaultText = "...";
			A_0.path.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.path.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.path.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.path.DisabledState.Parent = A_0.path;
			A_0.path.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.path.FillColor = Color.Transparent;
			A_0.path.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			A_0.path.FocusedState.Parent = A_0.path;
			A_0.path.ForeColor = Color.FromArgb(155, 157, 161);
			A_0.path.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.path.HoveredState.Parent = A_0.path;
			A_0.path.Location = new Point(12, 61);
			A_0.path.Name = "path";
			A_0.path.PasswordChar = (char)0;
			A_0.path.PlaceholderText = "";
			A_0.path.SelectedText = "";
			A_0.path.ShadowDecoration.Parent = A_0.path;
			A_0.path.Size = new Size(439, 36);
			A_0.path.TabIndex = 143;
			A_0.siticoneTextBox1.BorderColor = Color.FromArgb(70, 70, 70);
			A_0.siticoneTextBox1.BorderRadius = 2;
			A_0.siticoneTextBox1.Cursor = Cursors.IBeam;
			A_0.siticoneTextBox1.DefaultText = "";
			A_0.siticoneTextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			A_0.siticoneTextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			A_0.siticoneTextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox1.DisabledState.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			A_0.siticoneTextBox1.FillColor = Color.Transparent;
			A_0.siticoneTextBox1.FocusedState.BorderColor = Color.FromArgb(102, 121, 193);
			A_0.siticoneTextBox1.FocusedState.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.ForeColor = Color.FromArgb(155, 157, 161);
			A_0.siticoneTextBox1.HoveredState.BorderColor = Color.FromArgb(4, 4, 5);
			A_0.siticoneTextBox1.HoveredState.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.Location = new Point(11, 126);
			A_0.siticoneTextBox1.Name = "siticoneTextBox1";
			A_0.siticoneTextBox1.PasswordChar = (char)0;
			A_0.siticoneTextBox1.PlaceholderText = "";
			A_0.siticoneTextBox1.SelectedText = "";
			A_0.siticoneTextBox1.ShadowDecoration.Parent = A_0.siticoneTextBox1;
			A_0.siticoneTextBox1.Size = new Size(439, 36);
			A_0.siticoneTextBox1.TabIndex = 144;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(462, 237);
			A_0.Controls.Add(A_0.siticoneControlBox3);
			A_0.Controls.Add(A_0.siticoneTextBox1);
			A_0.Controls.Add(A_0.path);
			A_0.Controls.Add(A_0.siticoneButton1);
			A_0.Controls.Add(A_0.label2);
			A_0.Controls.Add(A_0.label1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "fivembuildchanger";
			A_0.StartPosition = FormStartPosition.CenterScreen;
			A_0.Text = "fivembuildchanger";
			A_0.Load += A_0.__VMFUNCTION__927D8;
			A_0.ResumeLayout(false);
			A_0.PerformLayout();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001179C File Offset: 0x0000F99C
		public void __VMFUNCTION__51E9F(object A_1, EventArgs A_2)
		{
			try
			{
				string str = this.path.Text + "\\FiveM.app";
				Func<string, bool> <>9__1_ = fivembuildchanger.<>c.<>9__1_0;
				IEnumerable<string> source = (IEnumerable<string>)File.ReadAllLines(str + "\\CitizenFX.ini");
				if (<>9__1_ == null)
				{
					Func<string, bool> <>9__1_2 = new Func<string, bool>(fivembuildchanger.<>c.<>9.__VMFUNCTION__562AD);
					fivembuildchanger.<>c.<>9__1_0 = <>9__1_2;
				}
				IEnumerable<string> contents = source.Where(<>9__1_);
				File.WriteAllLines(str + "\\CitizenFX.ini", contents);
				TextWriter textWriter = new StreamWriter(str + "\\CitizenFX.ini", true);
				textWriter.WriteLine("SavedBuildNumber=" + this.siticoneTextBox1.Text);
				textWriter.Close();
				MessageBox.Show("We have changed your fivem build version! You can now spoof and play on the server.", "SuperSpoofer - Build Changer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception str2)
			{
				MessageBox.Show(str2 + "We cannot change your fivem build version! Please launch in admin, turn antivirus off or even make sure the path is correct! [".Message.ToString() + "]", "SuperSpoofer - Build Changer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000118B8 File Offset: 0x0000FAB8
		public void __VMFUNCTION__927D8(object A_1, EventArgs A_2)
		{
			this.path.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM";
		}

		// Token: 0x040000C6 RID: 198
		private SiticoneControlBox siticoneControlBox3;

		// Token: 0x040000C7 RID: 199
		private Label label1;

		// Token: 0x040000C8 RID: 200
		private Label label2;

		// Token: 0x040000C9 RID: 201
		private SiticoneButton siticoneButton1;

		// Token: 0x040000CA RID: 202
		private SiticoneDragControl siticoneDragControl1;

		// Token: 0x040000CB RID: 203
		private SiticoneTextBox path;

		// Token: 0x040000CC RID: 204
		private SiticoneTextBox siticoneTextBox1;
	}
}
