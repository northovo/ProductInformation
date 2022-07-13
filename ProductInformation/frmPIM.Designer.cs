
namespace ProductInformation
{
    partial class frmPIM
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("正价产品");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("特价产品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("所有产品", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPIM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PSort = new System.Windows.Forms.TreeView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PSort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 936);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产品分类";
            // 
            // PSort
            // 
            this.PSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSort.ImageIndex = 0;
            this.PSort.ImageList = this.icons;
            this.PSort.Location = new System.Drawing.Point(3, 24);
            this.PSort.Name = "PSort";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "正价产品";
            treeNode1.Text = "正价产品";
            treeNode2.Name = "特价产品";
            treeNode2.Text = "特价产品";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "所有产品";
            treeNode3.Text = "所有产品";
            this.PSort.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.PSort.SelectedImageIndex = 0;
            this.PSort.Size = new System.Drawing.Size(238, 909);
            this.PSort.TabIndex = 0;
            this.PSort.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PSort_AfterSelect);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "product (1).png");
            this.icons.Images.SetKeyName(1, "product (2).png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "exit.png");
            this.imageList1.Images.SetKeyName(3, "update.png");
            this.imageList1.Images.SetKeyName(4, "search.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtSize);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(247, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 936);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产品显示";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "产品规格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "产品名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "产品编号";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(837, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(543, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 28);
            this.txtName.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(675, 69);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(126, 28);
            this.txtSize.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(411, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 28);
            this.txtID.TabIndex = 2;
            // 
            // dgvProduct
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 117);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(1);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 40;
            this.dgvProduct.RowTemplate.Height = 30;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(960, 816);
            this.dgvProduct.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnDel,
            this.tsbtnUpdate,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(960, 93);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tsbtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.tsbtnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 936);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品信息管理";
            this.Load += new System.EventHandler(this.frmPIM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView PSort;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSize;
    }
}