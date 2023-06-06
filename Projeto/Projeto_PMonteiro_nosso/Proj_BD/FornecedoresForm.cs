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
    public partial class FornecedoresForm : Form
    {
        public FornecedoresForm()
        {
            InitializeComponent();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            MainForm.populateList(dataGridView1, "getFornecedores");
        }

        private void nomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nifTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@nif", nifTxt.Text },
                { "@nome", nomeTxt.Text },
                { "@num_fornecedor", numFornecedorTxt.Text },
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
                MessageBox.Show("Name of fornecedor can't be null!");
            }
            else if (string.IsNullOrWhiteSpace(emailTxt.Text))
            {
                MessageBox.Show("Email of fornecedor can't be null!");
            }
            else if (string.IsNullOrWhiteSpace(telemovelTxt.Text))
            {
                MessageBox.Show("Phone Number of fornecedor can't be null!");
            }
            else if (string.IsNullOrWhiteSpace(numFornecedorTxt.Text.ToString()))
            {
                MessageBox.Show("Number of fornecedor can't be null!");
            }
            else
            {
                MainForm.InsertOrRemoveIntoDB("addFornecedor", parameters);
                searchBtn.PerformClick(); // Populate/Update List after adding new employee
            }
        }

        private void dataTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telemovelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void moradaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void numFornecedorTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@nif", nifTxt.Text },
                { "@nome", nomeTxt.Text },
                { "@num_fornecedor", numFornecedorTxt.Text },
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

            MainForm.PopulateTableWithParameters(dataGridView1, "filterFornecedores", parameters);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                MessageBox.Show("Fornecedor removed");
                parameters["@nif"] = Convert.ToInt32(row.Cells[0].Value.ToString());

                MainForm.InsertOrRemoveIntoDB("deleteFornecedor", parameters);
            }
            searchBtn.PerformClick();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nomeTxt.Clear();
            nifTxt.Clear();
            emailTxt.Clear();
            telemovelTxt.Clear();
            numFornecedorTxt.Clear();
            dataTxt.Clear();
            moradaTxt.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide(); // mudar de screen
            mainForm.Show();
        }
    }
}
