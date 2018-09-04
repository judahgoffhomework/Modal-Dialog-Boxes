namespace ModalDialogBoxes
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PopUpButton = new System.Windows.Forms.Button();
			this.CheckBox1 = new System.Windows.Forms.Label();
			this.CheckBox2 = new System.Windows.Forms.Label();
			this.CheckBox3 = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.Label();
			this.dropDown = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PopUpButton
			// 
			this.PopUpButton.Location = new System.Drawing.Point(99, 215);
			this.PopUpButton.Name = "PopUpButton";
			this.PopUpButton.Size = new System.Drawing.Size(75, 23);
			this.PopUpButton.TabIndex = 0;
			this.PopUpButton.Text = "Pop Up!";
			this.PopUpButton.UseVisualStyleBackColor = true;
			this.PopUpButton.Click += new System.EventHandler(this.PopUpButton_Click);
			// 
			// CheckBox1
			// 
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new System.Drawing.Point(12, 29);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(62, 13);
			this.CheckBox1.TabIndex = 1;
			this.CheckBox1.Text = "CheckBox1";
			// 
			// CheckBox2
			// 
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Location = new System.Drawing.Point(12, 60);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new System.Drawing.Size(62, 13);
			this.CheckBox2.TabIndex = 2;
			this.CheckBox2.Text = "CheckBox2";
			// 
			// CheckBox3
			// 
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.Location = new System.Drawing.Point(12, 92);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new System.Drawing.Size(62, 13);
			this.CheckBox3.TabIndex = 3;
			this.CheckBox3.Text = "CheckBox3";
			// 
			// textBox
			// 
			this.textBox.AutoSize = true;
			this.textBox.Location = new System.Drawing.Point(180, 60);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(0, 13);
			this.textBox.TabIndex = 5;
			// 
			// dropDown
			// 
			this.dropDown.AutoSize = true;
			this.dropDown.Location = new System.Drawing.Point(113, 157);
			this.dropDown.Name = "dropDown";
			this.dropDown.Size = new System.Drawing.Size(60, 13);
			this.dropDown.TabIndex = 6;
			this.dropDown.Text = "dropdown1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.dropDown);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.CheckBox3);
			this.Controls.Add(this.CheckBox2);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.PopUpButton);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button PopUpButton;
		private System.Windows.Forms.Label CheckBox1;
		private System.Windows.Forms.Label CheckBox2;
		private System.Windows.Forms.Label CheckBox3;
		private System.Windows.Forms.Label textBox;
		private System.Windows.Forms.Label dropDown;
	}
}