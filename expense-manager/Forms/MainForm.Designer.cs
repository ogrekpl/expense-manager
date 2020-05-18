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
			this.label1 = new System.Windows.Forms.Label();
			this.panelSideMenu = new System.Windows.Forms.Panel();
			this.buttonChangeProfile = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonPlots = new System.Windows.Forms.Button();
			this.buttonExpenses = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.panelSideMenu.SuspendLayout();
			this.SuspendLayout();
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
			// panelSideMenu
			// 
			this.panelSideMenu.AutoScroll = true;
			this.panelSideMenu.Controls.Add(this.buttonChangeProfile);
			this.panelSideMenu.Controls.Add(this.buttonExit);
			this.panelSideMenu.Controls.Add(this.buttonPlots);
			this.panelSideMenu.Controls.Add(this.buttonExpenses);
			this.panelSideMenu.Controls.Add(this.panelLogo);
			this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
			this.panelSideMenu.Name = "panelSideMenu";
			this.panelSideMenu.Size = new System.Drawing.Size(200, 667);
			this.panelSideMenu.TabIndex = 3;
			// 
			// buttonChangeProfile
			// 
			this.buttonChangeProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonChangeProfile.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonChangeProfile.Location = new System.Drawing.Point(0, 194);
			this.buttonChangeProfile.Name = "buttonChangeProfile";
			this.buttonChangeProfile.Size = new System.Drawing.Size(200, 59);
			this.buttonChangeProfile.TabIndex = 4;
			this.buttonChangeProfile.Text = "Zmień profil";
			this.buttonChangeProfile.UseVisualStyleBackColor = true;
			this.buttonChangeProfile.Click += new System.EventHandler(this.buttonChangeProfile_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonExit.Location = new System.Drawing.Point(0, 610);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(200, 57);
			this.buttonExit.TabIndex = 4;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonPlots
			// 
			this.buttonPlots.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonPlots.Location = new System.Drawing.Point(0, 136);
			this.buttonPlots.Name = "buttonPlots";
			this.buttonPlots.Size = new System.Drawing.Size(200, 58);
			this.buttonPlots.TabIndex = 4;
			this.buttonPlots.Text = "Wykresy";
			this.buttonPlots.UseVisualStyleBackColor = true;
			this.buttonPlots.Click += new System.EventHandler(this.buttonPlots_Click);
			// 
			// buttonExpenses
			// 
			this.buttonExpenses.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonExpenses.Location = new System.Drawing.Point(0, 71);
			this.buttonExpenses.Name = "buttonExpenses";
			this.buttonExpenses.Size = new System.Drawing.Size(200, 65);
			this.buttonExpenses.TabIndex = 1;
			this.buttonExpenses.Text = "Wydatki";
			this.buttonExpenses.UseVisualStyleBackColor = true;
			this.buttonExpenses.Click += new System.EventHandler(this.buttonExpenses_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.AutoScroll = true;
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(200, 71);
			this.panelLogo.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(200, 610);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(946, 57);
			this.panel2.TabIndex = 4;
			// 
			// panelChildForm
			// 
			this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChildForm.Location = new System.Drawing.Point(200, 0);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(946, 610);
			this.panelChildForm.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1146, 667);
			this.Controls.Add(this.panelChildForm);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelSideMenu);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Wydatki";
			this.panelSideMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelSideMenu;
		private System.Windows.Forms.Button buttonExpenses;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Button buttonChangeProfile;
		private System.Windows.Forms.Button buttonPlots;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelChildForm;
	}
}