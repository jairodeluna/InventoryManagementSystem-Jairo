using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem_Jairo
{
    class InventoryManager 
    {
        private static readonly ConnectionDB con = new ConnectionDB();
        public void AddProduct(Product product)
        {
            try
            {
                con.Open();
                string query = "Insert into Product VALUES ('" + product.Name + "', '" + product.Quantity + "', '" + product.Price + "')";
                con.ExecuteNonQuery(query);
                con.Close();
                DialogResult Success;
                Success = MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveProduct(int productId)
        {
            try
            {
                con.Open();
                string deleteQuery = "DELETE Product WHERE ProductId = '" + productId + "'";
                con.ExecuteNonQuery(deleteQuery);
                MessageBox.Show("Product was deleted successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateProduct(int productId, int NewQuantity) 
        {
            try
            {
                con.Open();
                string updateQuery = "Update Product SET QuantityInStock = '" + NewQuantity + "' WHERE ProductId = '" + productId + "'";
                con.ExecuteNonQuery(updateQuery);
                MessageBox.Show("Product was updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable DisplayProducts()
        {
            con.Open();
            string query = "SELECT * FROM Product";
            DataTable dataTable = con.ExecuteDataTable(query);
            con.Close();
            return dataTable;
        }

        public decimal GetTotalValue()
        {
            Decimal totalValue = 0;
            try
            {
                con.Open();
                string query = "SELECT QuantityInStock, Price FROM Product";
                SqlDataReader row = con.ExecuteReader(query);
                while (row.Read())
                {
                    int quantity = row.GetInt32(0);
                    decimal price = row.GetDecimal(1);
                    totalValue = totalValue + price;
                    //totalValue = totalValue + (price*quantity);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return totalValue;
        }
    }
}
