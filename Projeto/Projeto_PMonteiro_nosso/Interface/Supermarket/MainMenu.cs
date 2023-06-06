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
    public partial class MainMenu : Form
    {
        EmployeesForm employeesForm;
        ClientsForm clientsForm;
        ProductsForm productsForm;
        SuppliersForm suppliersForm;
        InvoicesForm invoicesForm;
        public MainMenu()
        {
            InitializeComponent();
            productsForm = new ProductsForm();
            employeesForm = new EmployeesForm();
            clientsForm = new ClientsForm();
            suppliersForm = new SuppliersForm();
            invoicesForm = new InvoicesForm();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            changeTab(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeTab(5);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //salesmenu button
        }
        private void button11_Click(object sender, EventArgs e)
        {
            changeTab(2);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            changeTab(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            changeTab(4);
        }

        private void btn_employees_Click_1(object sender, EventArgs e)
        {
            changeTab(6);
        }
        public void changeTab(int i)
        {
            this.Hide();

            switch (i)
            {
                case 2:
                    invoicesForm.Show();
                    break;
                case 3:
                    productsForm.Show();
                    break;
                case 4:
                    suppliersForm.Show();
                    break;
                case 5:
                    clientsForm.Show();
                    break;
                case 6: 
                    employeesForm.Show();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1";
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Product Bar Code";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Brand";
            dataGridView1.Columns[3].Name = "Product Price";
            dataGridView1.Columns[4].Name = "Amount";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox2.Text);
            value++;
            textBox2.Text = value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox2.Text);

            if (value > 1)
                value--;

            textBox2.Text = value.ToString();
        }

        private void add_product_Click(object sender, EventArgs e)
        {                
            int barcode = Int32.Parse(textBox1.Text);
            int amount = Int32.Parse(textBox2.Text);
            bool retval = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (barcode.ToString() == row.Cells[0].Value.ToString())
                {
                    row.Cells[4].Value = Int32.Parse(row.Cells[4].Value.ToString()) + amount;
                    retval = false;
                }
            }

            if (retval)
            {
                Main.addProductToShoppingList(dataGridView1, barcode, amount);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int counter = Main.get_table_rows("supermarket.invoice"); // returns number of column lines
            Boolean paid;
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>();
            Dictionary<string, dynamic> parameters2 = new Dictionary<string, dynamic>();
            parameters["@referenceNumber"] = counter;
            parameters["@date"] = DateTime.Now;
            parameters["@paymentValue"] = 0;
            if (checkBox1.Checked)
            {
                paid = false;
            }
            else
            {
                paid = true;
            }

            parameters["@paid"] = paid;
            parameters["@counter"] = 1;
            parameters["@employee"] = textBox3.Text;
            Main.InsertOrRemoveIntoDB("createInvoice", parameters);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                parameters2["@orderNumber"] = counter;
                parameters2["@barCode"] = Convert.ToInt32(row.Cells[0].Value.ToString());
                parameters2["@amount"] = Convert.ToInt32(row.Cells[4].Value.ToString());
                Main.InsertOrRemoveIntoDB("addToShoppingList", parameters2);
            }
            dataGridView1.Rows.Clear();
        }

     }
    }
