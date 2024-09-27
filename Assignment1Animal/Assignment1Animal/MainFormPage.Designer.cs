namespace Assignment1Animal
{
    partial class frmAssignment
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
            this.mnuAnimal = new System.Windows.Forms.MenuStrip();
            this.mnuPeacock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCrow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnimal
            // 
            this.mnuAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAnimal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAnimal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPeacock,
            this.mnuDuck,
            this.mnuCrow});
            this.mnuAnimal.Location = new System.Drawing.Point(0, 0);
            this.mnuAnimal.Name = "mnuAnimal";
            this.mnuAnimal.Size = new System.Drawing.Size(800, 33);
            this.mnuAnimal.TabIndex = 1;
            this.mnuAnimal.Text = "menuStrip1";
            // 
            // mnuPeacock
            // 
            this.mnuPeacock.Name = "mnuPeacock";
            this.mnuPeacock.Size = new System.Drawing.Size(106, 29);
            this.mnuPeacock.Text = "&Peacock";
            this.mnuPeacock.Click += new System.EventHandler(this.mnuPeacock_Click);
            // 
            // mnuDuck
            // 
            this.mnuDuck.Name = "mnuDuck";
            this.mnuDuck.Size = new System.Drawing.Size(76, 29);
            this.mnuDuck.Text = "&Duck";
            this.mnuDuck.Click += new System.EventHandler(this.mnuDuck_Click);
            // 
            // mnuCrow
            // 
            this.mnuCrow.Name = "mnuCrow";
            this.mnuCrow.Size = new System.Drawing.Size(77, 29);
            this.mnuCrow.Text = "&Crow";
            this.mnuCrow.Click += new System.EventHandler(this.mnuCrow_Click);
            // 
            // frmAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuAnimal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnimal;
            this.Name = "frmAssignment";
            this.Text = "Assignment1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnimal.ResumeLayout(false);
            this.mnuAnimal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnimal;
        private System.Windows.Forms.ToolStripMenuItem mnuPeacock;
        private System.Windows.Forms.ToolStripMenuItem mnuDuck;
        private System.Windows.Forms.ToolStripMenuItem mnuCrow;
    }
}

