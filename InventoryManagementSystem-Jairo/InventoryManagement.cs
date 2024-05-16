using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem_Jairo
{
    public partial class inventoryManagementForm : Form
    {
        InventoryManager inventoryManager = new InventoryManager();
        // Session variables
        public static int productId;
        public static string processType;
        public inventoryManagementForm()
        {
            InitializeComponent();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            displayData();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            // Reset the displayed products
            productDataGridView.Rows.Clear();

            // Retrieve the list of product
            DataTable dataTable = inventoryManager.DisplayProducts();
            foreach (DataRow row in dataTable.Rows)
            {
                // Assigned the value based on the set column names
                productDataGridView.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
            }

            // Display the total sales based on the GetTotalValue method
            lbl_totalSalesValue.Text = string.IsNullOrEmpty(inventoryManager.GetTotalValue().ToString()) ? "0" : inventoryManager.GetTotalValue().ToString();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult message;
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            productId = Convert.ToInt32(productDataGridView.Rows[currentRow].Cells[0].Value);
            // currentColumnIndex == 4 is for Edit
            if (currentColumnIndex == 4)
            {
                processType = "Update";
                AddProductForm addProductForm = new AddProductForm();
                addProductForm.ShowDialog();
            }
            // currentColumnIndex == 5 is for Delete
            else if (currentColumnIndex == 5)
            {
                message = MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (message == DialogResult.Yes)
                {
                    // retrieve the remove method based on productId
                    inventoryManager.RemoveProduct(productId);
                }
            }
            displayData();
        }
    }
}
