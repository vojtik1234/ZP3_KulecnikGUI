/*
 * Created by SharpDevelop.
 * User: Flintstone
 * Date: 11.12.2020
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KulecnikGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rychlostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rychlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cervenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 259);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rychlostToolStripMenuItem,
            this.barvaToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Nastaveni";
            // 
            // rychlostToolStripMenuItem
            // 
            this.rychlostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomalaToolStripMenuItem,
            this.rychlaToolStripMenuItem});
            this.rychlostToolStripMenuItem.Name = "rychlostToolStripMenuItem";
            this.rychlostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rychlostToolStripMenuItem.Text = "Rychlost";
            // 
            // pomalaToolStripMenuItem
            // 
            this.pomalaToolStripMenuItem.Name = "pomalaToolStripMenuItem";
            this.pomalaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.pomalaToolStripMenuItem.Text = "Pomala";
            this.pomalaToolStripMenuItem.Click += new System.EventHandler(this.pomalaToolStripMenuItem_Click);
            // 
            // rychlaToolStripMenuItem
            // 
            this.rychlaToolStripMenuItem.Name = "rychlaToolStripMenuItem";
            this.rychlaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rychlaToolStripMenuItem.Text = "Rychla";
            this.rychlaToolStripMenuItem.Click += new System.EventHandler(this.rychlaToolStripMenuItem_Click);
            // 
            // barvaToolStripMenuItem
            // 
            this.barvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cervenaToolStripMenuItem});
            this.barvaToolStripMenuItem.Name = "barvaToolStripMenuItem";
            this.barvaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barvaToolStripMenuItem.Text = "Barva";
            // 
            // cervenaToolStripMenuItem
            // 
            this.cervenaToolStripMenuItem.Name = "cervenaToolStripMenuItem";
            this.cervenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cervenaToolStripMenuItem.Text = "Cervena";
            this.cervenaToolStripMenuItem.Click += new System.EventHandler(this.cervenaToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "KulecnikGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rychlostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rychlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cervenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
    }
}
