namespace Assignment1Animal
{
    partial class CrowFrom
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
            this.pbCrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCrow
            // 
            this.pbCrow.Image = global::Assignment1Animal.Properties.Resources.crow;
            this.pbCrow.Location = new System.Drawing.Point(12, 12);
            this.pbCrow.Name = "pbCrow";
            this.pbCrow.Size = new System.Drawing.Size(776, 426);
            this.pbCrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrow.TabIndex = 0;
            this.pbCrow.TabStop = false;
            // 
            // CrowFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCrow);
            this.Name = "CrowFrom";
            this.Text = "Crow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCrow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCrow;
    }
}