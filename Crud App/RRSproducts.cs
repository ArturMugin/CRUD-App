namespace Crud_App
{
    public partial class RRSproducts : Form
    {
        FormProduct form;
        public RRSproducts()
        {
            InitializeComponent();
            form = new FormProduct(this);
        }

        public void Display()
        {
            DbProduct.DisplayAndSearch("SELECT ID, Model, Coin, Note FROM products", dataGridView);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }



        private void FormProductInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_txtChanged(object sender, EventArgs e)
        {
            DbProduct.DisplayAndSearch("SELECT ID, Model, Coin, Note FROM products WHERE Model LIKE'%"+ txtSearch.Text +"%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //form.Clear() FIX?????
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.model = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.coin = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.note = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?","Information" , MessageBoxButtons.YesNoCancel , MessageBoxIcon.Information) == DialogResult.Yes){ 
                    DbProduct.DeleteProduct(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}