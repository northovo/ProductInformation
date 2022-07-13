
namespace ProductInformation
{
    partial class frmEditProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsPrice = new System.Windows.Forms.CheckBox();
            this.numReducedPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReducedPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboSort);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = " 预售价格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "产品类别：";
            // 
            // cboSort
            // 
            this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Location = new System.Drawing.Point(129, 103);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(153, 26);
            this.cboSort.TabIndex = 3;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(129, 158);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(153, 28);
            this.numPrice.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 28);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkIsPrice);
            this.groupBox2.Controls.Add(this.numReducedPrice);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其他信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = " 特价价格：";
            // 
            // chkIsPrice
            // 
            this.chkIsPrice.AutoSize = true;
            this.chkIsPrice.Location = new System.Drawing.Point(129, 47);
            this.chkIsPrice.Name = "chkIsPrice";
            this.chkIsPrice.Size = new System.Drawing.Size(124, 22);
            this.chkIsPrice.TabIndex = 0;
            this.chkIsPrice.Text = "是否为特价";
            this.chkIsPrice.UseVisualStyleBackColor = true;
            this.chkIsPrice.CheckedChanged += new System.EventHandler(this.chkIsPrice_CheckedChanged);
            // 
            // numReducedPrice
            // 
            this.numReducedPrice.DecimalPlaces = 2;
            this.numReducedPrice.Location = new System.Drawing.Point(129, 101);
            this.numReducedPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numReducedPrice.Name = "numReducedPrice";
            this.numReducedPrice.Size = new System.Drawing.Size(153, 28);
            this.numReducedPrice.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消(&C)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(428, 52);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(153, 28);
            this.txtSize.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "产品规格：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(428, 103);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(153, 28);
            this.txtNum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "产品数量：";
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑产品信息";
            this.Load += new System.EventHandler(this.frmEditProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReducedPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsPrice;
        private System.Windows.Forms.NumericUpDown numReducedPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label5;
    }
}