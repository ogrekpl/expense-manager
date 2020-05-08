namespace expense_manager
{
	partial class ExpenseControl
	{
		/// <summary> 
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod wygenerowany przez Projektanta składników

		/// <summary> 
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.delete_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.amount_label = new System.Windows.Forms.Label();
			this.category_label = new System.Windows.Forms.Label();
			this.description_label = new System.Windows.Forms.Label();
			this.date_label = new System.Windows.Forms.Label();
			this.edit_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// delete_button
			// 
			this.delete_button.Location = new System.Drawing.Point(81, 106);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(75, 23);
			this.delete_button.TabIndex = 0;
			this.delete_button.Text = "Usuń";
			this.delete_button.UseVisualStyleBackColor = true;
			this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(5, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cena";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label2.Location = new System.Drawing.Point(5, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kategoria";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label3.Location = new System.Drawing.Point(3, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Opis";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label4.Location = new System.Drawing.Point(3, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 21);
			this.label4.TabIndex = 4;
			this.label4.Text = "Data";
			// 
			// amount_label
			// 
			this.amount_label.AutoSize = true;
			this.amount_label.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.amount_label.Location = new System.Drawing.Point(144, 10);
			this.amount_label.Name = "amount_label";
			this.amount_label.Size = new System.Drawing.Size(54, 21);
			this.amount_label.TabIndex = 5;
			this.amount_label.Text = "Cena";
			// 
			// category_label
			// 
			this.category_label.AutoSize = true;
			this.category_label.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.category_label.Location = new System.Drawing.Point(144, 34);
			this.category_label.Name = "category_label";
			this.category_label.Size = new System.Drawing.Size(87, 21);
			this.category_label.TabIndex = 6;
			this.category_label.Text = "Kategoria";
			// 
			// description_label
			// 
			this.description_label.AutoSize = true;
			this.description_label.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.description_label.Location = new System.Drawing.Point(144, 55);
			this.description_label.Name = "description_label";
			this.description_label.Size = new System.Drawing.Size(44, 21);
			this.description_label.TabIndex = 7;
			this.description_label.Text = "Opis";
			// 
			// date_label
			// 
			this.date_label.AutoSize = true;
			this.date_label.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.date_label.Location = new System.Drawing.Point(144, 79);
			this.date_label.Name = "date_label";
			this.date_label.Size = new System.Drawing.Size(51, 21);
			this.date_label.TabIndex = 8;
			this.date_label.Text = "Data";
			// 
			// edit_button
			// 
			this.edit_button.Location = new System.Drawing.Point(162, 106);
			this.edit_button.Name = "edit_button";
			this.edit_button.Size = new System.Drawing.Size(75, 23);
			this.edit_button.TabIndex = 9;
			this.edit_button.Text = "Edytuj";
			this.edit_button.UseVisualStyleBackColor = true;
			this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
			// 
			// ExpenseControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.edit_button);
			this.Controls.Add(this.date_label);
			this.Controls.Add(this.description_label);
			this.Controls.Add(this.category_label);
			this.Controls.Add(this.amount_label);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.delete_button);
			this.Name = "ExpenseControl";
			this.Size = new System.Drawing.Size(300, 132);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button delete_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label amount_label;
		private System.Windows.Forms.Label category_label;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Label date_label;
		private System.Windows.Forms.Button edit_button;
	}
}
