using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using KeyAuth;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace SuperSpoofer.Forms___Extras
{
	// Token: 0x0200001F RID: 31
	public partial class policyuse : Form
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00015F00 File Offset: 0x00014100
		public policyuse()
		{
			policyuse.__VMFUNCTION__34937(this);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00015FC8 File Offset: 0x000141C8
		public static void __VMFUNCTION__34937(policyuse A_0)
		{
			A_0.components = (IContainer)new Container();
			ResourceManager resourceManager = new ComponentResourceManager(typeof(policyuse));
			A_0.siticoneDragControl1 = new SiticoneDragControl(A_0.components);
			A_0.loginnow = new SiticoneRoundedButton();
			A_0.siticoneCustomCheckBox1 = new SiticoneCustomCheckBox();
			A_0.autohelper = new Label();
			A_0.label1 = new Label();
			A_0.label4 = new Label();
			A_0.label2 = new Label();
			A_0.pictureBox1 = new PictureBox();
			A_0.siticoneControlBox1 = new SiticoneControlBox();
			A_0.textBox1 = new TextBox();
			((ISupportInitialize)A_0.pictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticoneDragControl1.TargetControl = A_0;
			A_0.loginnow.BorderColor = Color.DarkRed;
			A_0.loginnow.CheckedState.Parent = A_0.loginnow;
			A_0.loginnow.Cursor = Cursors.Hand;
			A_0.loginnow.CustomImages.Parent = A_0.loginnow;
			A_0.loginnow.FillColor = Color.MediumSeaGreen;
			A_0.loginnow.Font = new Font("Segoe UI", 9f);
			A_0.loginnow.ForeColor = Color.White;
			A_0.loginnow.HoveredState.Parent = A_0.loginnow;
			A_0.loginnow.Location = new Point(281, 455);
			A_0.loginnow.Name = "loginnow";
			A_0.loginnow.ShadowDecoration.Parent = A_0.loginnow;
			A_0.loginnow.Size = new Size(105, 21);
			A_0.loginnow.TabIndex = 152;
			A_0.loginnow.Text = "Continue";
			A_0.loginnow.Click += A_0.__VMFUNCTION__A23B5;
			A_0.siticoneCustomCheckBox1.BackColor = Color.Transparent;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.MediumSeaGreen;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			A_0.siticoneCustomCheckBox1.CheckedState.FillColor = Color.MediumSeaGreen;
			A_0.siticoneCustomCheckBox1.CheckedState.Parent = A_0.siticoneCustomCheckBox1;
			A_0.siticoneCustomCheckBox1.Cursor = Cursors.Hand;
			A_0.siticoneCustomCheckBox1.Location = new Point(12, 401);
			A_0.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			A_0.siticoneCustomCheckBox1.ShadowDecoration.Parent = A_0.siticoneCustomCheckBox1;
			A_0.siticoneCustomCheckBox1.Size = new Size(17, 17);
			A_0.siticoneCustomCheckBox1.TabIndex = 151;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.DimGray;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			A_0.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.Transparent;
			A_0.siticoneCustomCheckBox1.UncheckedState.Parent = A_0.siticoneCustomCheckBox1;
			A_0.autohelper.AutoSize = true;
			A_0.autohelper.Cursor = Cursors.Arrow;
			A_0.autohelper.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.autohelper.ForeColor = SystemColors.WindowFrame;
			A_0.autohelper.Location = new Point(33, 399);
			A_0.autohelper.Name = "autohelper";
			A_0.autohelper.Size = new Size(347, 34);
			A_0.autohelper.TabIndex = 150;
			A_0.autohelper.Text = "By ticking, you are confirming that you have read and \r\nunderstood our policy use also found at superspoofer.xyz";
			A_0.autohelper.Click += A_0.__VMFUNCTION__94EFE;
			A_0.label1.AutoSize = true;
			A_0.label1.Cursor = Cursors.Hand;
			A_0.label1.Font = new Font("Ebrima", 9.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte)0);
			A_0.label1.ForeColor = Color.DodgerBlue;
			A_0.label1.Location = new Point(12, 459);
			A_0.label1.Name = "label1";
			A_0.label1.Size = new Size(230, 17);
			A_0.label1.TabIndex = 155;
			A_0.label1.Text = "https://superspoofer.xyz/policy-use";
			A_0.label1.Click += A_0.__VMFUNCTION__6A84B;
			A_0.label4.AutoSize = true;
			A_0.label4.Font = new Font("Franklin Gothic Medium", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label4.ForeColor = Color.DimGray;
			A_0.label4.Location = new Point(64, 9);
			A_0.label4.Name = "label4";
			A_0.label4.Size = new Size(221, 34);
			A_0.label4.TabIndex = 157;
			A_0.label4.Text = "Terms of service";
			A_0.label2.AutoSize = true;
			A_0.label2.Font = new Font("Courier New", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
			A_0.label2.ForeColor = Color.Gray;
			A_0.label2.Location = new Point(68, 43);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(318, 22);
			A_0.label2.TabIndex = 159;
			A_0.label2.Text = "Last updated: 26 April, 2022";
			A_0.pictureBox1.Image = (Image)resourceManager.GetObject("pictureBox1.Image");
			A_0.pictureBox1.Location = new Point(12, 12);
			A_0.pictureBox1.Name = "pictureBox1";
			A_0.pictureBox1.Size = new Size(50, 60);
			A_0.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.pictureBox1.TabIndex = 158;
			A_0.pictureBox1.TabStop = false;
			A_0.siticoneControlBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			A_0.siticoneControlBox1.ControlBoxStyle = ControlBoxStyle.Custom;
			A_0.siticoneControlBox1.FillColor = Color.WhiteSmoke;
			A_0.siticoneControlBox1.HoveredState.BorderColor = Color.WhiteSmoke;
			A_0.siticoneControlBox1.HoveredState.FillColor = Color.WhiteSmoke;
			A_0.siticoneControlBox1.HoveredState.IconColor = Color.Black;
			A_0.siticoneControlBox1.HoveredState.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.IconColor = Color.Red;
			A_0.siticoneControlBox1.Location = new Point(370, 4);
			A_0.siticoneControlBox1.Name = "siticoneControlBox1";
			A_0.siticoneControlBox1.PressedColor = Color.WhiteSmoke;
			A_0.siticoneControlBox1.ShadowDecoration.Parent = A_0.siticoneControlBox1;
			A_0.siticoneControlBox1.Size = new Size(26, 22);
			A_0.siticoneControlBox1.TabIndex = 160;
			A_0.siticoneControlBox1.Click += A_0.__VMFUNCTION__80A45;
			A_0.textBox1.BackColor = Color.WhiteSmoke;
			A_0.textBox1.Cursor = Cursors.Arrow;
			A_0.textBox1.Font = new Font("Ebrima", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.textBox1.ForeColor = Color.FromArgb(64, 64, 64);
			A_0.textBox1.Location = new Point(15, 78);
			A_0.textBox1.Multiline = true;
			A_0.textBox1.Name = "textBox1";
			A_0.textBox1.ReadOnly = true;
			A_0.textBox1.ScrollBars = ScrollBars.Both;
			A_0.textBox1.Size = new Size(365, 317);
			A_0.textBox1.TabIndex = 162;
			A_0.textBox1.Text = resourceManager.GetString("textBox1.Text");
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.WhiteSmoke;
			A_0.ClientSize = new Size(399, 488);
			A_0.Controls.Add(A_0.textBox1);
			A_0.Controls.Add(A_0.siticoneControlBox1);
			A_0.Controls.Add(A_0.label2);
			A_0.Controls.Add(A_0.pictureBox1);
			A_0.Controls.Add(A_0.label4);
			A_0.Controls.Add(A_0.label1);
			A_0.Controls.Add(A_0.loginnow);
			A_0.Controls.Add(A_0.siticoneCustomCheckBox1);
			A_0.Controls.Add(A_0.autohelper);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Icon = (Icon)resourceManager.GetObject("$this.Icon");
			A_0.Name = "policyuse";
			A_0.StartPosition = FormStartPosition.CenterScreen;
			A_0.Text = "policyuse";
			A_0.Load += A_0.__VMFUNCTION__A1406;
			((ISupportInitialize)A_0.pictureBox1).EndInit();
			A_0.ResumeLayout(false);
			A_0.PerformLayout();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00016950 File Offset: 0x00014B50
		public void __VMFUNCTION__A23B5(object A_1, EventArgs A_2)
		{
			if ((this.siticoneCustomCheckBox1.Checked ? 1U : 0U) != (uint)0)
			{
				base.Hide();
				new Main().ShowDialog();
			}
			else
			{
				MessageBox.Show("We cannot procede without you agreeing to our terms of use and policy use.", "SuperSpoofer - Policy Agreement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0400010F RID: 271
		private SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000110 RID: 272
		private SiticoneRoundedButton loginnow;

		// Token: 0x04000111 RID: 273
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x04000112 RID: 274
		private Label autohelper;

		// Token: 0x04000113 RID: 275
		private Label label1;

		// Token: 0x04000114 RID: 276
		private Label label4;

		// Token: 0x04000115 RID: 277
		private PictureBox pictureBox1;

		// Token: 0x04000116 RID: 278
		private Label label2;

		// Token: 0x04000117 RID: 279
		private SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000118 RID: 280
		private TextBox textBox1;
	}
}
