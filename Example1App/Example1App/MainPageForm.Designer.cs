namespace Example1App
{
    partial class MainPageForm
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
            this.components = new System.ComponentModel.Container();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSumCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSquareCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContact = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContactList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewContact = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalculator,
            this.mnuSalary,
            this.mnuContact});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(800, 28);
            this.mnuBar.TabIndex = 1;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuCalculator
            // 
            this.mnuCalculator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuSumCalculator,
            this.toolStripSeparator2,
            this.mnuSquareCalculator});
            this.mnuCalculator.Name = "mnuCalculator";
            this.mnuCalculator.Size = new System.Drawing.Size(90, 24);
            this.mnuCalculator.Text = "&Calculator";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuSumCalculator
            // 
            this.mnuSumCalculator.Name = "mnuSumCalculator";
            this.mnuSumCalculator.Size = new System.Drawing.Size(209, 26);
            this.mnuSumCalculator.Text = "&Sum Calculator";
            this.mnuSumCalculator.Click += new System.EventHandler(this.mnuSumCalculator_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuSquareCalculator
            // 
            this.mnuSquareCalculator.Name = "mnuSquareCalculator";
            this.mnuSquareCalculator.Size = new System.Drawing.Size(209, 26);
            this.mnuSquareCalculator.Text = "S&quare Calculator";
            this.mnuSquareCalculator.Click += new System.EventHandler(this.mnuSquareCalculator_Click);
            // 
            // mnuSalary
            // 
            this.mnuSalary.Name = "mnuSalary";
            this.mnuSalary.Size = new System.Drawing.Size(63, 24);
            this.mnuSalary.Text = "&Salary";
            this.mnuSalary.Click += new System.EventHandler(this.mnuSalary_Click);
            // 
            // mnuContact
            // 
            this.mnuContact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContactList,
            this.mnuNewContact});
            this.mnuContact.Name = "mnuContact";
            this.mnuContact.Size = new System.Drawing.Size(74, 24);
            this.mnuContact.Text = "C&ontact";
            // 
            // mnuContactList
            // 
            this.mnuContactList.Name = "mnuContactList";
            this.mnuContactList.Size = new System.Drawing.Size(224, 26);
            this.mnuContactList.Text = "&Contact List";
            this.mnuContactList.Click += new System.EventHandler(this.mnuContactList_Click);
            // 
            // mnuNewContact
            // 
            this.mnuNewContact.Name = "mnuNewContact";
            this.mnuNewContact.Size = new System.Drawing.Size(224, 26);
            this.mnuNewContact.Text = "&New Contact";
            this.mnuNewContact.Click += new System.EventHandler(this.mnuNewContact_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuBar;
            this.Name = "MainPageForm";
            this.Text = "Example1App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSumCalculator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSquareCalculator;
        private System.Windows.Forms.ToolStripMenuItem mnuSalary;
        private System.Windows.Forms.ToolStripMenuItem mnuContact;
        private System.Windows.Forms.ToolStripMenuItem mnuContactList;
        private System.Windows.Forms.ToolStripMenuItem mnuNewContact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

