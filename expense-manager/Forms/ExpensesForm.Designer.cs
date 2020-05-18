namespace expense_manager
{
	partial class ExpensesForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.addExpenseButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSortDate = new System.Windows.Forms.Button();
			this.buttonSortAmmount = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonFiltrDate = new System.Windows.Forms.Button();
			this.buttonFiltrCategory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(222, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(338, 525);
			this.panel1.TabIndex = 3;
			// 
			// addExpenseButton
			// 
			this.addExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addExpenseButton.Location = new System.Drawing.Point(41, 74);
			this.addExpenseButton.Name = "addExpenseButton";
			this.addExpenseButton.Size = new System.Drawing.Size(124, 38);
			this.addExpenseButton.TabIndex = 4;
			this.addExpenseButton.Text = "Dodaj wydatek";
			this.addExpenseButton.UseVisualStyleBackColor = true;
			this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(37, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Lista wydatków";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(37, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 22);
			this.label2.TabIndex = 6;
			this.label2.Text = "Sortuj według:";
			// 
			// buttonSortDate
			// 
			this.buttonSortDate.Location = new System.Drawing.Point(28, 196);
			this.buttonSortDate.Name = "buttonSortDate";
			this.buttonSortDate.Size = new System.Drawing.Size(80, 37);
			this.buttonSortDate.TabIndex = 7;
			this.buttonSortDate.Text = "Data";
			this.buttonSortDate.UseVisualStyleBackColor = true;
			this.buttonSortDate.Click += new System.EventHandler(this.buttonSortDate_Click);
			// 
			// buttonSortAmmount
			// 
			this.buttonSortAmmount.Location = new System.Drawing.Point(114, 196);
			this.buttonSortAmmount.Name = "buttonSortAmmount";
			this.buttonSortAmmount.Size = new System.Drawing.Size(80, 37);
			this.buttonSortAmmount.TabIndex = 8;
			this.buttonSortAmmount.Text = "Cena";
			this.buttonSortAmmount.UseVisualStyleBackColor = true;
			this.buttonSortAmmount.Click += new System.EventHandler(this.buttonSortAmmount_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(79, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "Filtruj";
			// 
			// buttonFiltrDate
			// 
			this.buttonFiltrDate.Location = new System.Drawing.Point(28, 303);
			this.buttonFiltrDate.Name = "buttonFiltrDate";
			this.buttonFiltrDate.Size = new System.Drawing.Size(80, 37);
			this.buttonFiltrDate.TabIndex = 10;
			this.buttonFiltrDate.Text = "Data";
			this.buttonFiltrDate.UseVisualStyleBackColor = true;
			this.buttonFiltrDate.Click += new System.EventHandler(this.buttonFiltrDate_Click);
			// 
			// buttonFiltrCategory
			// 
			this.buttonFiltrCategory.Location = new System.Drawing.Point(114, 303);
			this.buttonFiltrCategory.Name = "buttonFiltrCategory";
			this.buttonFiltrCategory.Size = new System.Drawing.Size(80, 37);
			this.buttonFiltrCategory.TabIndex = 11;
			this.buttonFiltrCategory.Text = "Kategoria";
			this.buttonFiltrCategory.UseVisualStyleBackColor = true;
			this.buttonFiltrCategory.Click += new System.EventHandler(this.buttonFiltrCategory_Click);
			// 
			// ExpensesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 571);
			this.Controls.Add(this.buttonFiltrCategory);
			this.Controls.Add(this.buttonFiltrDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonSortAmmount);
			this.Controls.Add(this.buttonSortDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addExpenseButton);
			this.Controls.Add(this.panel1);
			this.Name = "ExpensesForm";
			this.Text = "ExpensesForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button addExpenseButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSortDate;
		private System.Windows.Forms.Button buttonSortAmmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonFiltrDate;
		private System.Windows.Forms.Button buttonFiltrCategory;
	}
}