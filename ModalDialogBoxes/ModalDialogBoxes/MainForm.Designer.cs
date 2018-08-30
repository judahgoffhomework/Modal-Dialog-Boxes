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
			this.SuspendLayout();
			// 
			// PopUpButton
			// 
			this.PopUpButton.Location = new System.Drawing.Point(102, 125);
			this.PopUpButton.Name = "PopUpButton";
			this.PopUpButton.Size = new System.Drawing.Size(75, 23);
			this.PopUpButton.TabIndex = 0;
			this.PopUpButton.Text = "Pop Up!";
			this.PopUpButton.UseVisualStyleBackColor = true;
			this.PopUpButton.Click += new System.EventHandler(this.PopUpButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.PopUpButton);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button PopUpButton;
	}
}