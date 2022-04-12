using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_App
{
    public partial class FormProduct : Form
    {
        private readonly RRSproducts _parent;
        public string id, model, coin, note;
        public FormProduct(RRSproducts parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lblText.Text = "Update product";
            btnSave2.Text = "Update";
            txtModel.Text = model;
            txtCoin.Text = coin;
            txtNote.Text = note;


        }

        public void SaveInfo()
        {
            lblText.Text = "Add product";
            btnSave2.Text = "Save";
        }

        public void Clear()
        {
            txtModel.Text = txtCoin.Text = txtNote.Text = string.Empty;
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if(txtModel.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product model field is Empty");
                return;
            }

            if (txtCoin.Text.Trim().Length < 1)
            {
                MessageBox.Show("Product coin field is Empty");
                return;
            }
            if (txtNote.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product note field is Empty");
                return;
            }
            if (btnSave2.Text == "Save")
            {
                Product prd = new Product(txtModel.Text.Trim(), txtCoin.Text.Trim(), txtNote.Text.Trim());
                DbProduct.AddProduct(prd);




















                Clear();

            }

            if(btnSave2.Text == "Update")
            {
                Product prd = new Product(txtModel.Text.Trim(), txtCoin.Text.Trim(), txtNote.Text.Trim());
                DbProduct.UpdateProduct(prd, id);
            }
            _parent.Display();
        }

 
    }
}
