
namespace ProductInformation
{
    partial class frmChangePwd
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
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.txtPwd3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(193, 72);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.Size = new System.Drawing.Size(172, 28);
            this.txtPwd1.TabIndex = 1;
            this.txtPwd1.TextChanged += new System.EventHandler(this.txtPwd1_TextChanged);
            // 
            // txtPwd3
            // 
            this.txtPwd3.Location = new System.Drawing.Point(193, 229);
            this.txtPwd3.Name = "txtPwd3";
            this.txtPwd3.PasswordChar = '*';
            this.txtPwd3.Size = new System.Drawing.Size(172, 28);
            this.txtPwd3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "确认密码：";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(193, 153);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(172, 28);
            this.txtPwd2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(269, 334);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 36);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 441);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPwd3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPwd1);
            this.Controls.Add(this.label1);
            this.Name = "frmChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.TextBox txtPwd3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReturn;
    }
}