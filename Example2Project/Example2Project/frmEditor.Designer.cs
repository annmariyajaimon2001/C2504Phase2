namespace Example2Project
{
    partial class frmEditor
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.staPage = new System.Windows.Forms.StatusStrip();
            this.staColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.staForeColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlueBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreenBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toLeft = new System.Windows.Forms.ToolStripButton();
            this.toCenter = new System.Windows.Forms.ToolStripButton();
            this.toRight = new System.Windows.Forms.ToolStripButton();
            this.pnlBottom.SuspendLayout();
            this.staPage.SuspendLayout();
            this.mnuBar.SuspendLayout();
            this.mnuEditor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Plum;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(871, 84);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Editor App";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.PaleGreen;
            this.txtEditor.ContextMenuStrip = this.mnuEditor;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 145);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(871, 568);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "I am Ann Mariya\r\nIntern of c#\r\nQuest Global\r\n";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnForeColor);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.label1);
            this.pnlBottom.Controls.Add(this.btnColor);
            this.pnlBottom.Controls.Add(this.btnBlue);
            this.pnlBottom.Controls.Add(this.btnGreen);
            this.pnlBottom.Controls.Add(this.btnRed);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 567);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(871, 120);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.IndianRed;
            this.btnRed.Location = new System.Drawing.Point(24, 46);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(97, 35);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGreen.Location = new System.Drawing.Point(230, 46);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(97, 35);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBlue.Location = new System.Drawing.Point(127, 46);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(97, 35);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(333, 46);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(82, 35);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // staPage
            // 
            this.staPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staColor,
            this.staForeColor});
            this.staPage.Location = new System.Drawing.Point(0, 687);
            this.staPage.Name = "staPage";
            this.staPage.Size = new System.Drawing.Size(871, 26);
            this.staPage.TabIndex = 3;
            this.staPage.Text = "statusStrip1";
            // 
            // staColor
            // 
            this.staColor.Name = "staColor";
            this.staColor.Size = new System.Drawing.Size(76, 20);
            this.staColor.Text = "IndianRed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Background";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Foreground";
            // 
            // btnForeColor
            // 
            this.btnForeColor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForeColor.Location = new System.Drawing.Point(504, 46);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(127, 35);
            this.btnForeColor.TabIndex = 6;
            this.btnForeColor.Text = "Pick Color";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // staForeColor
            // 
            this.staForeColor.Name = "staForeColor";
            this.staForeColor.Size = new System.Drawing.Size(45, 20);
            this.staForeColor.Text = "Color";
            // 
            // mnuBar
            // 
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuColor,
            this.mnuFormat});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(871, 30);
            this.mnuBar.TabIndex = 4;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripSeparator3,
            this.mnuSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 26);
            this.mnuFile.Text = "File";
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedBg,
            this.mnuBlueBg,
            this.mnuGreenBg,
            this.mnuBg,
            this.toolStripSeparator1,
            this.mnuFg});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(59, 26);
            this.mnuColor.Text = "Color";
            // 
            // mnuRedBg
            // 
            this.mnuRedBg.Name = "mnuRedBg";
            this.mnuRedBg.Size = new System.Drawing.Size(254, 26);
            this.mnuRedBg.Text = "Red Background Color";
            this.mnuRedBg.Click += new System.EventHandler(this.mnuRedBg_Click);
            // 
            // mnuBlueBg
            // 
            this.mnuBlueBg.Name = "mnuBlueBg";
            this.mnuBlueBg.Size = new System.Drawing.Size(254, 26);
            this.mnuBlueBg.Text = "Blue Background Color";
            this.mnuBlueBg.Click += new System.EventHandler(this.mnuBlueBg_Click);
            // 
            // mnuGreenBg
            // 
            this.mnuGreenBg.Name = "mnuGreenBg";
            this.mnuGreenBg.Size = new System.Drawing.Size(254, 26);
            this.mnuGreenBg.Text = "Green Background Color";
            this.mnuGreenBg.Click += new System.EventHandler(this.mnuGreenBg_Click);
            // 
            // mnuBg
            // 
            this.mnuBg.Name = "mnuBg";
            this.mnuBg.Size = new System.Drawing.Size(254, 26);
            this.mnuBg.Text = "Other Background Color";
            this.mnuBg.Click += new System.EventHandler(this.mnuBg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuFg
            // 
            this.mnuFg.Name = "mnuFg";
            this.mnuFg.Size = new System.Drawing.Size(254, 26);
            this.mnuFg.Text = "Foreground Color...";
            this.mnuFg.Click += new System.EventHandler(this.mnuFg_Click);
            // 
            // mnuEditor
            // 
            this.mnuEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRed2,
            this.mnuBlue2,
            this.mnuGreen2});
            this.mnuEditor.Name = "contextMenuStrip1";
            this.mnuEditor.Size = new System.Drawing.Size(241, 76);
            // 
            // mnuRed2
            // 
            this.mnuRed2.Name = "mnuRed2";
            this.mnuRed2.Size = new System.Drawing.Size(240, 24);
            this.mnuRed2.Text = "Red Background Color";
            this.mnuRed2.Click += new System.EventHandler(this.mnuRed2_Click);
            // 
            // mnuBlue2
            // 
            this.mnuBlue2.Name = "mnuBlue2";
            this.mnuBlue2.Size = new System.Drawing.Size(240, 24);
            this.mnuBlue2.Text = "Blue Background Color";
            this.mnuBlue2.Click += new System.EventHandler(this.mnuBlue2_Click);
            // 
            // mnuGreen2
            // 
            this.mnuGreen2.Name = "mnuGreen2";
            this.mnuGreen2.Size = new System.Drawing.Size(240, 24);
            this.mnuGreen2.Text = "Green Background Color";
            this.mnuGreen2.Click += new System.EventHandler(this.mnuGreen2_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.toolStripSeparator2,
            this.mnuAlignLeft,
            this.mnuAlignCenter,
            this.mnuAlignRight});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(70, 26);
            this.mnuFormat.Text = "Format";
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(224, 26);
            this.mnuFont.Text = "Font...";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuAlignLeft
            // 
            this.mnuAlignLeft.Image = global::Example2Project.Properties.Resources.leftAlign;
            this.mnuAlignLeft.Name = "mnuAlignLeft";
            this.mnuAlignLeft.Size = new System.Drawing.Size(224, 26);
            this.mnuAlignLeft.Text = "Align Left";
            this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
            // 
            // mnuAlignCenter
            // 
            this.mnuAlignCenter.Image = global::Example2Project.Properties.Resources.centerAlign;
            this.mnuAlignCenter.Name = "mnuAlignCenter";
            this.mnuAlignCenter.Size = new System.Drawing.Size(224, 26);
            this.mnuAlignCenter.Text = "Align Center";
            this.mnuAlignCenter.Click += new System.EventHandler(this.mnuAlignCenter_Click);
            // 
            // mnuAlignRight
            // 
            this.mnuAlignRight.Image = global::Example2Project.Properties.Resources.rightAlign;
            this.mnuAlignRight.Name = "mnuAlignRight";
            this.mnuAlignRight.Size = new System.Drawing.Size(224, 26);
            this.mnuAlignRight.Text = "Align Right";
            this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(224, 26);
            this.mnuSave.Text = "Save...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "mytext";
            this.dlgOpen.Filter = "Text File (*.txt) | JSON File (*.json)";
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "mytext1.txt";
            this.dlgSave.Filter = "Text File (*.txt) | JSON File (*.json)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toLeft,
            this.toCenter,
            this.toRight});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(871, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toLeft
            // 
            this.toLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toLeft.Image = global::Example2Project.Properties.Resources.leftAlign;
            this.toLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toLeft.Name = "toLeft";
            this.toLeft.Size = new System.Drawing.Size(29, 28);
            this.toLeft.Text = "toolStripButton1";
            this.toLeft.Click += new System.EventHandler(this.toLeft_Click);
            // 
            // toCenter
            // 
            this.toCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toCenter.Image = global::Example2Project.Properties.Resources.centerAlign;
            this.toCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toCenter.Name = "toCenter";
            this.toCenter.Size = new System.Drawing.Size(29, 28);
            this.toCenter.Text = "toolStripButton2";
            this.toCenter.Click += new System.EventHandler(this.toCenter_Click);
            // 
            // toRight
            // 
            this.toRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toRight.Image = global::Example2Project.Properties.Resources.rightAlign;
            this.toRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toRight.Name = "toRight";
            this.toRight.Size = new System.Drawing.Size(29, 28);
            this.toRight.Text = "toolStripButton3";
            this.toRight.Click += new System.EventHandler(this.toRight_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 713);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.staPage);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuBar;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmEditor";
            this.Text = "Editor App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.staPage.ResumeLayout(false);
            this.staPage.PerformLayout();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.mnuEditor.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.StatusStrip staPage;
        private System.Windows.Forms.ToolStripStatusLabel staColor;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel staForeColor;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuRedBg;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueBg;
        private System.Windows.Forms.ToolStripMenuItem mnuGreenBg;
        private System.Windows.Forms.ToolStripMenuItem mnuBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFg;
        private System.Windows.Forms.ContextMenuStrip mnuEditor;
        private System.Windows.Forms.ToolStripMenuItem mnuRed2;
        private System.Windows.Forms.ToolStripMenuItem mnuBlue2;
        private System.Windows.Forms.ToolStripMenuItem mnuGreen2;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toLeft;
        private System.Windows.Forms.ToolStripButton toCenter;
        private System.Windows.Forms.ToolStripButton toRight;
    }
}

