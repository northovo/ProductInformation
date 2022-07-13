
namespace ProductInformation
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用产品信息管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(93, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 28);
            this.txtName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(215, 190);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(179, 28);
            this.txtPwd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(93, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "密  码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 346);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

