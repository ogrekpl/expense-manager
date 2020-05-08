using System.Windows.Forms;

namespace expense_manager
{
	partial class AddExpenseForm : Form
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
			this.addButton = new System.Windows.Forms.Button();
			this.categoryPicker = new System.Windows.Forms.ComboBox();
			this.descriptionInput = new System.Windows.Forms.RichTextBox();
			this.datePicker = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ammountInput = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.addButton.Location = new System.Drawing.Point(235, 339);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(90, 38);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Dodaj";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// categoryPicker
			// 
			this.categoryPicker.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.categoryPicker.FormattingEnabled = true;
			this.categoryPicker.Location = new System.Drawing.Point(310, 149);
			this.categoryPicker.Name = "categoryPicker";
			this.categoryPicker.Size = new System.Drawing.Size(121, 32);
			this.categoryPicker.TabIndex = 4;
			// 
			// descriptionInput
			// 
			this.descriptionInput.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.descriptionInput.Location = new System.Drawing.Point(310, 203);
			this.descriptionInput.Name = "descriptionInput";
			this.descriptionInput.Size = new System.Drawing.Size(81, 29);
			this.descriptionInput.TabIndex = 5;
			this.descriptionInput.Text = "";
			// 
			// datePicker
			// 
			this.datePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.datePicker.Location = new System.Drawing.Point(310, 258);
			this.datePicker.Name = "datePicker";
			this.datePicker.Size = new System.Drawing.Size(240, 22);
			this.datePicker.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(99, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cena";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.label3.Location = new System.Drawing.Point(99, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "Kategoria";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.label4.Location = new System.Drawing.Point(99, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "Opis";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F);
			this.label5.Location = new System.Drawing.Point(179, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 33);
			this.label5.TabIndex = 11;
			this.label5.Text = "Dodaj wydatek";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.label6.Location = new System.Drawing.Point(99, 256);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Data";
			// 
			// ammountInput
			// 
			this.ammountInput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ammountInput.Location = new System.Drawing.Point(310, 101);
			this.ammountInput.Name = "ammountInput";
			this.ammountInput.Size = new System.Drawing.Size(81, 29);
			this.ammountInput.TabIndex = 13;
			this.ammountInput.Text = "test";
			// 
			// AddExpenseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 453);
			this.Controls.Add(this.ammountInput);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.datePicker);
			this.Controls.Add(this.descriptionInput);
			this.Controls.Add(this.categoryPicker);
			this.Controls.Add(this.addButton);
			this.Name = "AddExpenseForm";
			this.Text = "AddExpenseForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.ComboBox categoryPicker;
		private System.Windows.Forms.RichTextBox descriptionInput;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox ammountInput;
	}
}