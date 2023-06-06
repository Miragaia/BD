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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            Main.populateList(dataGridView1, "getClients");
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
            txt_name.Clear();
            txt_nif.Clear();
            txt_id.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_address.Clear();
            txt_website.Clear();
            txt_client_since.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@clientID", txt_id.Text },
                { "@name", txt_name.Text },
                { "@nif", txt_nif.Text },
                { "@address", txt_address.Text },
                { "@phone", txt_phone.Text },
                { "@email", txt_email.Text },
                { "@website", txt_website.Text},
                { "@clientSince", txt_client_since.Text }
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            Main.PopulateTableWithParameters(dataGridView1, "dbo.filterClients", parameters);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@clientID", txt_id.Text },
                { "@name", txt_name.Text },
                { "@nif", txt_nif.Text },
                { "@address", txt_address.Text },
                { "@phone", txt_phone.Text },
                { "@email", txt_email.Text },
                { "@website", txt_website.Text},
                { "@clientSince", txt_client_since.Text }
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            if (string.IsNullOrWhiteSpace(txt_nif.Text.ToString()))
            {
                MessageBox.Show("NIF field is empty!");
            }
            else if (string.IsNullOrWhiteSpace(txt_id.Text.ToString()))
            {
                MessageBox.Show("ID can't be null!");
            }
            else
            {
                Main.InsertOrRemoveIntoDB("addClient", parameters);
                btn_search.PerformClick(); // Populate/Update List after adding new employee
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                MessageBox.Show(txt_id.Text.ToString());
                parameters["@nif"] = Convert.ToInt32(row.Cells[2].Value.ToString());
                Main.InsertOrRemoveIntoDB("deleteClient", parameters);
            }
            btn_search.PerformClick(); // Populate/Update List after adding new client
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

            Main.updateClientOrEmployee(pk_nif, changedAttribute, value);
        }
    }
}
