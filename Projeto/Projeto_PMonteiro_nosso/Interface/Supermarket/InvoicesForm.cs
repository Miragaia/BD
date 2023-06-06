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
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            Main.populateList(dataGridView1, "getInvoices"); // Mudar para getInvoices
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
            txt_reference.Clear();
            txt_employee.Clear();
            txt_paid.Clear();
            txt_value.Clear();
            txt_date.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@referenceNumber", txt_reference.Text },
                { "@date", txt_date.Text },
                { "@paymentValue", txt_value.Text },
                { "@paid", txt_paid.Text },
                { "@employee", txt_employee.Text }
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            Main.PopulateTableWithParameters(dataGridView1, "dbo.filterInvoices", parameters);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@referenceNumber", txt_reference.Text },
                { "@date", txt_date.Text },
                { "@paymentValue", txt_value.Text },
                { "@paid", txt_paid.Text },
                { "@employee", txt_employee.Text }
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            Main.InsertOrRemoveIntoDB("addInvoice", parameters);
            btn_search.PerformClick(); // Populate/Update List after adding new invoice
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                parameters["@referenceNumber"] = Convert.ToInt32(row.Cells[0].Value.ToString());
                Main.InsertOrRemoveIntoDB("deleteInvoice", parameters);
            }
            btn_search.PerformClick(); // Populate/Update List after adding new invoice
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

            //Main.updateInvoice(pk_nif, changedAttribute, value);
        }
    }
}
