using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Crud_App
{
    internal class DbProduct
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;username=root;password=;database=prouct_table;";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection faild! \nError number{ex.Message}\n{MessageBoxButtons.OK}{MessageBoxIcon.Error}");
            }
            return conn;
        }




        public static void AddProduct(Product prd)
        {
            string sql = "INSERT INTO products VALUES (NULL, @ProductModel, @ProductCoin, @ProductNote, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductModel", MySqlDbType.VarChar).Value = prd.Model;
            cmd.Parameters.Add("@ProductCoin", MySqlDbType.VarChar).Value = prd.Coin;
            cmd.Parameters.Add("@ProductNote", MySqlDbType.VarChar).Value = prd.Note;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Product added Succsessfully");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Product not added! \nError number{ex.Message}\n{MessageBoxButtons.OK}{MessageBoxIcon.Error}");
            }
            conn.Close();
        }




        public static void UpdateProduct(Product prd, string id)
        {
            string sql = "UPDATE products SET Model = @ProductModel, Coin = @ProductCoin, Note = @ProductNote WHERE ID = @ProductID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ProductModel", MySqlDbType.VarChar).Value = prd.Model;
            cmd.Parameters.Add("@ProductCoin", MySqlDbType.VarChar).Value = prd.Coin;
            cmd.Parameters.Add("@ProductNote", MySqlDbType.VarChar).Value = prd.Note;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Updated Succsessfully!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Product not updated! \nError number{ex.Message}\n{MessageBoxButtons.OK}{MessageBoxIcon.Error}");
            }
            conn.Close();
        }



        public static void DeleteProduct(string id)
        {
            string sql = "DELETE FROM products WHERE ID =@ProductID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Deleted Succsessfully!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Product not deleted! \nError number{ex.Message}\n{MessageBoxButtons.OK}{MessageBoxIcon.Error}");
            }
            conn.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }







    }
}
