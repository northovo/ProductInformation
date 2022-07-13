
namespace ProductInformation
{
    partial class frmPSort
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSort = new System.Windows.Forms.DataGridView();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSort)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnDel,
            this.tsbtnUpdate,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(711, 93);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSort);
            this.groupBox1.Location = new System.Drawing.Point(13, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 586);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  显示数据";
            // 
            // dgvSort
            // 
            this.dgvSort.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSort.Location = new System.Drawing.Point(3, 24);
            this.dgvSort.Name = "dgvSort";
            this.dgvSort.RowHeadersWidth = 62;
            this.dgvSort.RowTemplate.Height = 30;
            this.dgvSort.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSort.Size = new System.Drawing.Size(680, 559);
            this.dgvSort.TabIndex = 0;
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = global::ProductInformation.Properties.Resources.add;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Margin = new System.Windows.Forms.Padding(10, 12, 10, 13);
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(50, 68);
            this.tsbtnAdd.Text = "增加";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnDel
            // 
            this.tsbtnDel.Image = global::ProductInformation.Properties.Resources.delete;
            this.tsbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDel.Margin = new System.Windows.Forms.Padding(10, 12, 10, 13);
            this.tsbtnDel.Name = "tsbtnDel";
            this.tsbtnDel.Size = new System.Drawing.Size(50, 68);
            this.tsbtnDel.Text = "删除";
            this.tsbtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDel.Click += new System.EventHandler(this.tsbtnDel_Click);
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.Image = global::ProductInformation.Properties.Resources.update;
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Margin = new System.Windows.Forms.Padding(10, 12, 10, 13);
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(50, 68);
            this.tsbtnUpdate.Text = "修改";
            this.tsbtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnUpdate.Click += new System.EventHandler(this.tsbtnUpdate_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = global::ProductInformation.Properties.Resources.exit;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Margin = new System.Windows.Forms.Padding(10, 12, 10, 13);
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(50, 68);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // frmPSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 746);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品类别";
            this.Load += new System.EventHandler(this.frmPSort_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSort;
    }
}