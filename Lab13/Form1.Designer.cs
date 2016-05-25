namespace Lab13
{
    partial class frmMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumQuarters = new System.Windows.Forms.Label();
            this.lblNumToken = new System.Windows.Forms.Label();
            this.txtNumQuarters = new System.Windows.Forms.TextBox();
            this.txtNumTokens = new System.Windows.Forms.TextBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblNumQuarters
            // 
            this.lblNumQuarters.AutoSize = true;
            this.lblNumQuarters.Location = new System.Drawing.Point(115, 227);
            this.lblNumQuarters.Name = "lblNumQuarters";
            this.lblNumQuarters.Size = new System.Drawing.Size(138, 17);
            this.lblNumQuarters.TabIndex = 1;
            this.lblNumQuarters.Text = "Number of Quarters:";
            // 
            // lblNumToken
            // 
            this.lblNumToken.AutoSize = true;
            this.lblNumToken.Location = new System.Drawing.Point(115, 279);
            this.lblNumToken.Name = "lblNumToken";
            this.lblNumToken.Size = new System.Drawing.Size(129, 17);
            this.lblNumToken.TabIndex = 2;
            this.lblNumToken.Text = "Number of Tokens:";
            // 
            // txtNumQuarters
            // 
            this.txtNumQuarters.Location = new System.Drawing.Point(259, 224);
            this.txtNumQuarters.Name = "txtNumQuarters";
            this.txtNumQuarters.Size = new System.Drawing.Size(100, 22);
            this.txtNumQuarters.TabIndex = 3;
            // 
            // txtNumTokens
            // 
            this.txtNumTokens.Location = new System.Drawing.Point(259, 276);
            this.txtNumTokens.Name = "txtNumTokens";
            this.txtNumTokens.Size = new System.Drawing.Size(100, 22);
            this.txtNumTokens.TabIndex = 4;
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(177, 77);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(136, 35);
            this.btnGetToken.TabIndex = 5;
            this.btnGetToken.Text = "Get Token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(177, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(176, 154);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(137, 17);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Click Reset to Begin!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 403);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGetToken);
            this.Controls.Add(this.txtNumTokens);
            this.Controls.Add(this.txtNumQuarters);
            this.Controls.Add(this.lblNumToken);
            this.Controls.Add(this.lblNumQuarters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Token Machine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblNumQuarters;
        private System.Windows.Forms.Label lblNumToken;
        private System.Windows.Forms.TextBox txtNumQuarters;
        private System.Windows.Forms.TextBox txtNumTokens;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStart;
    }
}

