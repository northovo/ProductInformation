
namespace ProductInformation
{
    partial class frmEditSort
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
            this.txtSort = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别名称：";
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(151, 44);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(136, 28);
            this.txtSort.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(63, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 166);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑类别";
            this.Load += new System.EventHandler(this.frmEditSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}