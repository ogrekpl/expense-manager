namespace expense_manager
{
	partial class Form1
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

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ProfilePicker = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SelectButton = new System.Windows.Forms.Button();
			this.CreateButton = new System.Windows.Forms.Button();
			this.XButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(72, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(358, 78);
			this.label1.TabIndex = 0;
			this.label1.Text = "Zaloguj się";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(137, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(223, 39);
			this.label2.TabIndex = 1;
			this.label2.Text = "Wybierz profil";
			// 
			// ProfilePicker
			// 
			this.ProfilePicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ProfilePicker.FormattingEnabled = true;
			this.ProfilePicker.Location = new System.Drawing.Point(144, 257);
			this.ProfilePicker.Name = "ProfilePicker";
			this.ProfilePicker.Size = new System.Drawing.Size(200, 21);
			this.ProfilePicker.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(209, 374);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 30);
			this.label3.TabIndex = 3;
			this.label3.Text = "lub";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(137, 453);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 39);
			this.label4.TabIndex = 4;
			this.label4.Text = "Utwórz nowy";
			// 
			// SelectButton
			// 
			this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SelectButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SelectButton.Location = new System.Drawing.Point(183, 284);
			this.SelectButton.Name = "SelectButton";
			this.SelectButton.Size = new System.Drawing.Size(109, 49);
			this.SelectButton.TabIndex = 5;
			this.SelectButton.Text = "Wybierz";
			this.SelectButton.UseVisualStyleBackColor = true;
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			// 
			// CreateButton
			// 
			this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CreateButton.Location = new System.Drawing.Point(183, 534);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(109, 49);
			this.CreateButton.TabIndex = 6;
			this.CreateButton.Text = "Utwórz profil";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// XButton
			// 
			this.XButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("XButton.BackgroundImage")));
			this.XButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.XButton.Location = new System.Drawing.Point(463, 12);
			this.XButton.Name = "XButton";
			this.XButton.Size = new System.Drawing.Size(24, 24);
			this.XButton.TabIndex = 7;
			this.XButton.UseVisualStyleBackColor = true;
			this.XButton.Click += new System.EventHandler(this.XButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
			this.ClientSize = new System.Drawing.Size(499, 706);
			this.Controls.Add(this.XButton);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.SelectButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ProfilePicker);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ProfilePicker;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button SelectButton;
		private System.Windows.Forms.Button CreateButton;
		private System.Windows.Forms.Button XButton;
	}
}

