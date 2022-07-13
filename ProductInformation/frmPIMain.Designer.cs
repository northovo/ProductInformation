
namespace ProductInformation
{
    partial class frmPIMain
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
            this.产品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.产品管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 产品管理ToolStripMenuItem
            // 
            this.产品管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyPassword,
            this.tsmiCancel});
            this.产品管理ToolStripMenuItem.Name = "产品管理ToolStripMenuItem";
            this.产品管理ToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.产品管理ToolStripMenuItem.Text = "产品管理(&U)";
            // 
            // tsmiModifyPassword
            // 
            this.tsmiModifyPassword.Name = "tsmiModifyPassword";
            this.tsmiModifyPassword.Size = new System.Drawing.Size(205, 34);
            this.tsmiModifyPassword.Text = "修改密码(&P)";
            this.tsmiModifyPassword.Click += new System.EventHandler(this.tsmiModifyPassword_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(205, 34);
            this.tsmiCancel.Text = "退出(&X)";
            this.tsmiCancel.Click += new System.EventHandler(this.tsmiCancel_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(171, 34);
            this.tsmiAbout.Text = "关于(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "产品管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "产品类别管理";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProductInformation.Properties.Resources.PIM__4_;
            this.pictureBox2.Location = new System.Drawing.Point(531, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProductInformation.Properties.Resources.PIM__1_;
            this.pictureBox1.Location = new System.Drawing.Point(203, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 619);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品信息管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 产品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}