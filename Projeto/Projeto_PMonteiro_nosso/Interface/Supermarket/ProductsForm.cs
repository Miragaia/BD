using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            Main.populateList(dataGridView1, "getProducts"); // Mudar para getProducts
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = new MainMenu();
            this.Hide(); // mudar de screen
            mainForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_barcode.Clear();
            txt_name.Clear();
            txt_brand.Clear();
            txt_stock.Clear();
            txt_type.Clear();
            txt_warehouse.Clear();
            txt_buyprice.Clear();
            txt_retailunitprice.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@barcode", txt_barcode.Text },
                { "@name", txt_name.Text },
                { "@brand", txt_brand.Text },
                { "@stock", txt_stock.Text },
                { "@buyPrice", txt_buyprice.Text },
                { "@retailUnitPrice", txt_retailunitprice.Text },
                { "@productType", txt_type.Text},
                { "@wareHouseNumber", txt_warehouse.Text }
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            Main.PopulateTableWithParameters(dataGridView1, "dbo.filterProducts", parameters);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@barcode", txt_barcode.Text },
                { "@name", txt_name.Text },
                { "@brand", txt_brand.Text },
                { "@stock", txt_stock.Text },
                { "@buyPrice", txt_buyprice.Text },
                { "@retailUnitPrice", txt_retailunitprice.Text },
                { "@productType", txt_type.Text},
                { "@wareHouseNumber", txt_warehouse.Text }
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }
            if (string.IsNullOrWhiteSpace(txt_barcode.Text.ToString()))
            {
                MessageBox.Show("Barcode field is empty!");
            }
            else if (string.IsNullOrWhiteSpace(txt_stock.Text.ToString()))
            {
                MessageBox.Show("Must insert stock!");
            }
            else if (string.IsNullOrWhiteSpace(txt_name.Text.ToString()))
            {
                MessageBox.Show("Please insert product name!");
            }
            else if (string.IsNullOrWhiteSpace(txt_buyprice.Text.ToString()))
            {
                MessageBox.Show("Must insert price!");
            }
            else if (string.IsNullOrWhiteSpace(txt_retailunitprice.Text.ToString()))
            {
                MessageBox.Show("Must insert price!");
            }
            else
            {
                MessageBox.Show(txt_name.Text.ToString());  
                Main.InsertOrRemoveIntoDB("addProduct", parameters);
                btn_search.PerformClick(); // Populate/Update List after adding new product
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                parameters["@barcode"] = Convert.ToInt32(row.Cells[0].Value.ToString());
                Main.InsertOrRemoveIntoDB("deleteProduct", parameters);
            }
            btn_search.PerformClick(); // Populate/Update List after adding new product
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var changedAttribute = dataGridView1.Columns[e.ColumnIndex].Name;
            var value = row.Cells[e.ColumnIndex].Value;
            var pk_nif = (int)row.Cells[0].Value;

            //Main.updateProduct(pk_nif, changedAttribute, value);
        }
    }
}
