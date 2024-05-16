using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem_Jairo
{
    public partial class AddProductForm : Form
    {
        InventoryManager inventoryManager = new InventoryManager();
        ConnectionDB con = new ConnectionDB(); 
        public AddProductForm()
        {
            InitializeComponent();
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // Display data based proceeType sesion value
            if (inventoryManagementForm.processType == "Update")
            {
                con.Open();
                string query = "SELECT Name, QuantityInStock, Price FROM Product WHERE ProductId = '" + inventoryManagementForm.productId + "'";
                SqlDataReader row = con.ExecuteReader(query);
                if (row.Read())
                {
                    txt_nameValue.Text = row.GetString(0);
                    txt_quantityValue.Text = row.GetInt32(1).ToString();
                    txt_priceValue.Text = row.GetDecimal(2).ToString();
                    txt_nameValue.Enabled = false;
                    txt_priceValue.Enabled = false;
                }
                con.Close();
            }
            else
            {
                txt_nameValue.Text = "";
                txt_quantityValue.Text = "";
                txt_priceValue.Text = "";
                txt_nameValue.Enabled = true;
                txt_priceValue.Enabled = true;
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductId = inventoryManagementForm.productId;
            product.Name = txt_nameValue.Text;
            product.Quantity = Convert.ToInt32(txt_quantityValue.Text);
            product.Price = Convert.ToDecimal(txt_priceValue.Text);
            if (inventoryManagementForm.processType == "Update")
            {
                inventoryManager.UpdateProduct(product.ProductId, product.Quantity);
            }
            else
            {
                inventoryManager.AddProduct(product);
            }
            this.Hide();
        }

        private void txt_quantityValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Added key press that will not allow to enter letters
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_priceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Added key press that will not allow to enter letters
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
    }
}
