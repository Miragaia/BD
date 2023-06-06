using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_BD
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
            
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide(); // mudar de screen
            mainForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@nif", nifTxt.Text },
                { "@nome", nomeTxt.Text },
                { "@num_cliente", numClientTxt.Text },
                { "@dataNasc", dataTxt.Text },
                { "@email", emailTxt.Text },
                { "@morada", moradaTxt.Text },
                { "@telemovel", telemovelTxt.Text},
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            MainForm.PopulateTableWithParameters(dataGridView1, "filterClients", parameters);
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@nif", nifTxt.Text },
                { "@nome", nomeTxt.Text },
                { "@num_cliente", numClientTxt.Text },
                { "@dataNasc", dataTxt.Text },
                { "@email", emailTxt.Text },
                { "@morada", moradaTxt.Text },
                { "@telemovel", telemovelTxt.Text},
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            if (string.IsNullOrWhiteSpace(nifTxt.Text.ToString()))
            {
                MessageBox.Show("NIF field is empty!");
            }
            else if (string.IsNullOrWhiteSpace(nomeTxt.Text))
            {
                MessageBox.Show("Name of client can't be null!");
            }
            else if (string.IsNullOrWhiteSpace(emailTxt.Text))
            {
                MessageBox.Show("Email of client can't be null!");
            }
            else if (string.IsNullOrWhiteSpace(telemovelTxt.Text))
            {
                MessageBox.Show("Phone Number of client can't be null!");
            }
            else if (string.IsNullOrWhiteSpace(numClientTxt.Text.ToString()))
            {
                MessageBox.Show("Number of client can't be null!");
            }
            else
            {
                MainForm.InsertOrRemoveIntoDB("addClient", parameters);
                searchBtn.PerformClick(); // Populate/Update List after adding new employee
            }
        }

        

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
               MessageBox.Show("Client removed");
               parameters["@nif"] = Convert.ToInt32(row.Cells[0].Value.ToString());

                MainForm.InsertOrRemoveIntoDB("deleteClient", parameters);
            }
            searchBtn.PerformClick();
        }


        private void PessoasForm_Load(object sender, EventArgs e)
        {
            MainForm.populateList(dataGridView1, "getClients");
        }

        

        private void moradaLbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void moradaLbl_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void nomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nifTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telemovelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void moradaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numClientTxt_TextChanged(object sender, EventArgs e)
        {

        }



        

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nomeTxt.Clear();
            nifTxt.Clear();
            emailTxt.Clear();
            telemovelTxt.Clear();
            numClientTxt.Clear();
            dataTxt.Clear();
            moradaTxt.Clear();
        }
    }
}
