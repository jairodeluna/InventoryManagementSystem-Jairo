namespace InventoryManagementSystem_Jairo
{
    partial class inventoryManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_totalSales = new System.Windows.Forms.Label();
            this.lbl_totalSalesValue = new System.Windows.Forms.Label();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_totalSales
            // 
            this.lbl_totalSales.AutoSize = true;
            this.lbl_totalSales.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalSales.Location = new System.Drawing.Point(13, 413);
            this.lbl_totalSales.Name = "lbl_totalSales";
            this.lbl_totalSales.Size = new System.Drawing.Size(92, 19);
            this.lbl_totalSales.TabIndex = 1;
            this.lbl_totalSales.Text = "Total Sales:";
            // 
            // lbl_totalSalesValue
            // 
            this.lbl_totalSalesValue.AutoSize = true;
            this.lbl_totalSalesValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalSalesValue.Location = new System.Drawing.Point(111, 413);
            this.lbl_totalSalesValue.Name = "lbl_totalSalesValue";
            this.lbl_totalSalesValue.Size = new System.Drawing.Size(19, 19);
            this.lbl_totalSalesValue.TabIndex = 2;
            this.lbl_totalSalesValue.Text = "0";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addProduct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.Location = new System.Drawing.Point(676, 406);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(112, 32);
            this.btn_addProduct.TabIndex = 3;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(193, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(429, 35);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "Inventory Management System";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNo,
            this.ProductName,
            this.Quantity,
            this.Price,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.productDataGridView.Location = new System.Drawing.Point(47, 75);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.Size = new System.Drawing.Size(701, 313);
            this.productDataGridView.TabIndex = 11;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // ProductNo
            // 
            this.ProductNo.HeaderText = "Product Id";
            this.ProductNo.Name = "ProductNo";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 247;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::InventoryManagementSystem_Jairo.Properties.Resources.edit;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::InventoryManagementSystem_Jairo.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.Width = 50;
            // 
            // inventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.lbl_totalSalesValue);
            this.Controls.Add(this.lbl_totalSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "inventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_totalSales;
        private System.Windows.Forms.Label lbl_totalSalesValue;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}

