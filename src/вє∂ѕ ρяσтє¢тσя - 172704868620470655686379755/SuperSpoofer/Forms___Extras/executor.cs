using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using OldRod.Core.CodeGen;
using Siticone.UI.WinForms;

namespace SuperSpoofer.Forms___Extras
{
	// Token: 0x0200001E RID: 30
	public partial class executor : Form
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00015710 File Offset: 0x00013910
		public executor()
		{
			executor.__VMFUNCTION__325E2(this);
			try
			{
				string path = "C:\\Windows\\SuperProj\\Drive";
				if ((((Directory.Exists(path) ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					Directory.CreateDirectory(path);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not complete function [DIR-CIR], Your windows is not compatiable!", "Super Spoofer - Error Notice!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00015834 File Offset: 0x00013A34
		public static void __VMFUNCTION__325E2(executor A_0)
		{
			ResourceManager resourceManager = new ComponentResourceManager(typeof(executor));
			A_0.siticonePanel1 = new SiticonePanel();
			A_0.listBox1 = new ListBox();
			A_0.siticonePictureBox1 = new SiticonePictureBox();
			A_0.siticoneCustomCheckBox1 = new SiticoneCustomCheckBox();
			A_0.label2 = new Label();
			A_0.siticoneButton2 = new SiticoneButton();
			A_0.siticonePanel1.SuspendLayout();
			((ISupportInitialize)A_0.siticonePictureBox1).BeginInit();
			A_0.SuspendLayout();
			A_0.siticonePanel1.BackColor = Color.FromArgb(27, 30, 34);
			A_0.siticonePanel1.Controls.Add(A_0.listBox1);
			A_0.siticonePanel1.Controls.Add(A_0.siticonePictureBox1);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneCustomCheckBox1);
			A_0.siticonePanel1.Controls.Add(A_0.label2);
			A_0.siticonePanel1.Controls.Add(A_0.siticoneButton2);
			A_0.siticonePanel1.Location = new Point(311, 163);
			A_0.siticonePanel1.Name = "siticonePanel1";
			A_0.siticonePanel1.ShadowDecoration.Parent = A_0.siticonePanel1;
			A_0.siticonePanel1.Size = new Size(421, 224);
			A_0.siticonePanel1.TabIndex = 15;
			A_0.listBox1.BackColor = Color.FromArgb(27, 30, 34);
			A_0.listBox1.BorderStyle = BorderStyle.None;
			A_0.listBox1.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.listBox1.ForeColor = Color.White;
			A_0.listBox1.FormattingEnabled = true;
			A_0.listBox1.ItemHeight = 17;
			ListBox.ObjectCollection items = A_0.listBox1.Items;
			items.AddRange(new object[]
			{
				"Executor Open Key: INSERT",
				"----------------------------------",
				"Executor Status;",
				"✔ Trigger Executor",
				"✔ Trigger TAB",
				"✔ Resource Stopper",
				"✔ Resource Dumper",
				"❌ LUA Menu Executor",
				"(Just execute triggers)"
			});
			A_0.listBox1.Location = new Point(12, 44);
			A_0.listBox1.Name = "listBox1";
			A_0.listBox1.Size = new Size(216, 170);
			A_0.listBox1.TabIndex = 15;
			A_0.siticonePictureBox1.Image = (Image)resourceManager.GetObject("siticonePictureBox1.Image");
			A_0.siticonePictureBox1.Location = new Point(238, 11);
			A_0.siticonePictureBox1.Name = "siticonePictureBox1";
			A_0.siticonePictureBox1.ShadowDecoration.Parent = A_0.siticonePictureBox1;
			A_0.siticonePictureBox1.Size = new Size(166, 169);
			A_0.siticonePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			A_0.siticonePictureBox1.TabIndex = 15;
			A_0.siticonePictureBox1.TabStop = false;
			A_0.siticoneCustomCheckBox1.Checked = true;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(0, 192, 0);
			A_0.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
			A_0.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
			A_0.siticoneCustomCheckBox1.CheckedState.FillColor = Color.FromArgb(0, 192, 0);
			A_0.siticoneCustomCheckBox1.CheckedState.Parent = A_0.siticoneCustomCheckBox1;
			A_0.siticoneCustomCheckBox1.CheckState = CheckState.Checked;
			A_0.siticoneCustomCheckBox1.Location = new Point(12, 11);
			A_0.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
			A_0.siticoneCustomCheckBox1.ShadowDecoration.Parent = A_0.siticoneCustomCheckBox1;
			A_0.siticoneCustomCheckBox1.Size = new Size(20, 20);
			A_0.siticoneCustomCheckBox1.TabIndex = 15;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(0, 192, 0);
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
			A_0.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
			A_0.siticoneCustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(0, 192, 0);
			A_0.siticoneCustomCheckBox1.UncheckedState.Parent = A_0.siticoneCustomCheckBox1;
			A_0.label2.AutoSize = true;
			A_0.label2.Font = new Font("Ebrima", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.label2.ForeColor = Color.Gainsboro;
			A_0.label2.Location = new Point(35, 11);
			A_0.label2.Name = "label2";
			A_0.label2.Size = new Size(130, 17);
			A_0.label2.TabIndex = 8;
			A_0.label2.Text = "Working: 26/02/2022";
			A_0.label2.TextAlign = ContentAlignment.MiddleCenter;
			A_0.siticoneButton2.CheckedState.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.CustomImages.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.FillColor = Color.DodgerBlue;
			A_0.siticoneButton2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
			A_0.siticoneButton2.ForeColor = Color.White;
			A_0.siticoneButton2.HoveredState.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.Location = new Point(238, 186);
			A_0.siticoneButton2.Name = "siticoneButton2";
			A_0.siticoneButton2.ShadowDecoration.Parent = A_0.siticoneButton2;
			A_0.siticoneButton2.Size = new Size(166, 26);
			A_0.siticoneButton2.TabIndex = 6;
			A_0.siticoneButton2.Text = "Inject Executor";
			A_0.siticoneButton2.Click += A_0.__VMFUNCTION__43E25;
			A_0.AutoScaleDimensions = new SizeF(6f, 13f);
			A_0.AutoScaleMode = AutoScaleMode.Font;
			A_0.BackColor = Color.FromArgb(25, 26, 30);
			A_0.ClientSize = new Size(1043, 550);
			A_0.Controls.Add(A_0.siticonePanel1);
			A_0.FormBorderStyle = FormBorderStyle.None;
			A_0.Name = "executor";
			A_0.Text = "executor";
			A_0.Load += A_0.__VMFUNCTION__116FE;
			A_0.siticonePanel1.ResumeLayout(false);
			A_0.siticonePanel1.PerformLayout();
			((ISupportInitialize)A_0.siticonePictureBox1).EndInit();
			A_0.ResumeLayout(false);
		}

		// Token: 0x04000108 RID: 264
		private SiticonePanel siticonePanel1;

		// Token: 0x04000109 RID: 265
		private ListBox listBox1;

		// Token: 0x0400010A RID: 266
		private SiticonePictureBox siticonePictureBox1;

		// Token: 0x0400010B RID: 267
		private SiticoneCustomCheckBox siticoneCustomCheckBox1;

		// Token: 0x0400010C RID: 268
		private Label label2;

		// Token: 0x0400010D RID: 269
		private SiticoneButton siticoneButton2;
	}
}
