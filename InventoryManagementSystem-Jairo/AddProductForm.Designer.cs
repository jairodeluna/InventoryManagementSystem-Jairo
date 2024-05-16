namespace InventoryManagementSystem_Jairo
{
    partial class AddProductForm
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_nameValue = new System.Windows.Forms.TextBox();
            this.txt_quantityValue = new System.Windows.Forms.TextBox();
            this.txt_priceValue = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(479, 242);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(112, 32);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(17, 242);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 32);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_nameValue
            // 
            this.txt_nameValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameValue.Location = new System.Drawing.Point(109, 92);
            this.txt_nameValue.Name = "txt_nameValue";
            this.txt_nameValue.Size = new System.Drawing.Size(482, 27);
            this.txt_nameValue.TabIndex = 1;
            // 
            // txt_quantityValue
            // 
            this.txt_quantityValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantityValue.Location = new System.Drawing.Point(109, 152);
            this.txt_quantityValue.MaxLength = 3;
            this.txt_quantityValue.Name = "txt_quantityValue";
            this.txt_quantityValue.Size = new System.Drawing.Size(185, 27);
            this.txt_quantityValue.TabIndex = 2;
            this.txt_quantityValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantityValue_KeyPress);
            // 
            // txt_priceValue
            // 
            this.txt_priceValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priceValue.Location = new System.Drawing.Point(406, 152);
            this.txt_priceValue.MaxLength = 10;
            this.txt_priceValue.Name = "txt_priceValue";
            this.txt_priceValue.Size = new System.Drawing.Size(185, 27);
            this.txt_priceValue.TabIndex = 3;
            this.txt_priceValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_priceValue_KeyPress);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(13, 90);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 19);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(13, 153);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(75, 19);
            this.lbl_quantity.TabIndex = 6;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(337, 156);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(49, 19);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "Price:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-5, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 40);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 306);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_priceValue);
            this.Controls.Add(this.txt_quantityValue);
            this.Controls.Add(this.txt_nameValue);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_nameValue;
        private System.Windows.Forms.TextBox txt_quantityValue;
        private System.Windows.Forms.TextBox txt_priceValue;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}