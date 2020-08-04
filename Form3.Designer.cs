namespace MedicDeFamilie
{
	partial class Form3
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inchideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generareTabelaFfmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inchideToolStripMenuItem,
            this.generareTabelaFfmToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inchideToolStripMenuItem
			// 
			this.inchideToolStripMenuItem.Name = "inchideToolStripMenuItem";
			this.inchideToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
			this.inchideToolStripMenuItem.Text = "Inchide";
			this.inchideToolStripMenuItem.Click += new System.EventHandler(this.inchideToolStripMenuItem_Click);
			// 
			// generareTabelaFfmToolStripMenuItem
			// 
			this.generareTabelaFfmToolStripMenuItem.Name = "generareTabelaFfmToolStripMenuItem";
			this.generareTabelaFfmToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
			this.generareTabelaFfmToolStripMenuItem.Text = "Generare tabela ffm";
			this.generareTabelaFfmToolStripMenuItem.Click += new System.EventHandler(this.generareTabelaFfmToolStripMenuItem_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form3";
			this.Text = "Form3";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem inchideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generareTabelaFfmToolStripMenuItem;
	}
}