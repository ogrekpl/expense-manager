namespace expense_manager
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
			this.addExpenseButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// addExpenseButton
			// 
			this.addExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addExpenseButton.Location = new System.Drawing.Point(75, 41);
			this.addExpenseButton.Name = "addExpenseButton";
			this.addExpenseButton.Size = new System.Drawing.Size(124, 38);
			this.addExpenseButton.TabIndex = 0;
			this.addExpenseButton.Text = "Dodaj wydatek";
			this.addExpenseButton.UseVisualStyleBackColor = true;
			this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(470, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lista wydatków";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(713, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(338, 552);
			this.panel1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1146, 644);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addExpenseButton);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addExpenseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}