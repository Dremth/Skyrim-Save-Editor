﻿using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.KeyEdit {
	public partial class KeyEditForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private ListViewItem selectedItem;

		private System.Windows.Forms.TextBox  textBoxValue;
		private System.Windows.Forms.Label  label1;
		private System.Windows.Forms.Label  label2;
		private System.Windows.Forms.TextBox  textBoxKey;
		private System.Windows.Forms.Button  buttonSet;
		private System.Windows.Forms.Button  buttonCancel;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

			this.textBoxValue = (new System.Windows.Forms.TextBox());
			this.label1 = (new System.Windows.Forms.Label());
			this.label2 = (new System.Windows.Forms.Label());
			this.textBoxKey = (new System.Windows.Forms.TextBox());
			this.buttonSet = (new System.Windows.Forms.Button());
			this.buttonCancel = (new System.Windows.Forms.Button());
			this.SuspendLayout();
			// 
			// textBoxValue
			// 
			this.textBoxValue.Location = new System.Drawing.Point(12, 67);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(343, 20);
			this.textBoxValue.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Value:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Key:";
			// 
			// textBoxKey
			// 
			this.textBoxKey.Location = new System.Drawing.Point(12, 25);
			this.textBoxKey.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
			this.textBoxKey.Name = "textBoxKey";
			this.textBoxKey.ReadOnly = true;
			this.textBoxKey.Size = new System.Drawing.Size(343, 20);
			this.textBoxKey.TabIndex = 3;
			// 
			// buttonSet
			// 
			this.buttonSet.Location = new System.Drawing.Point(199, 98);
			this.buttonSet.Name = "buttonSet";
			this.buttonSet.Size = new System.Drawing.Size(75, 23);
			this.buttonSet.TabIndex = 4;
			this.buttonSet.Text = "Set";
			this.buttonSet.UseVisualStyleBackColor = true;
			this.buttonSet.Click += new System.EventHandler(buttonSet_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(280, 98);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// KeyEditForm
			// 
			this.AcceptButton = this.buttonSet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(367, 131);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSet);
			this.Controls.Add(this.textBoxKey);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxValue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "KeyEditForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Key Edit";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private void buttonSet_Click(System.Object sender, System.EventArgs e) { }
	}
}