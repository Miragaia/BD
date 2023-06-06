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
    public partial class ComprasForm : Form
    {
        public ComprasForm()
        {
            InitializeComponent();
        }

        private void ComprasForm_Load(object sender, EventArgs e)
        {
            MainForm.populateList(dataGridView1, "getCompras");
        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide(); // mudar de screen
            mainForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@data_comp", dataCompTxt.Text },
                { "@id_compra", ID_CompraTxt.Text },
                { "@id_produto", ID_ProdTxt.Text },
                { "@nome_produto", Nome_ProdTxt.Text },
                { "@type_prod", Type_ProdTxt.Text },
                { "@nome_forn", nome_fornTxt.Text },
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            MainForm.PopulateTableWithParameters(dataGridView1, "filterCompras", parameters);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataCompTxt.Clear();
            ID_CompraTxt.Clear();
            ID_ProdTxt.Clear();
            Nome_ProdTxt.Clear();
            Type_ProdTxt.Clear();
            nome_fornTxt.Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            idCompraTXT.Clear();
            IDProdTXT.Clear();
            quantTXT.Clear();
            data_compraTXT.Clear();
            nomeFornTXT.Clear();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@data_comp", data_compraTXT.Text },
                { "@id_compra", idCompraTXT.Text },
                { "@id_produto", IDProdTXT.Text },
                { "@Quantidade", quantTXT.Text },
                { "@nome_forn", nomeFornTXT.Text },
            };
            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            if (string.IsNullOrWhiteSpace(idCompraTXT.Text.ToString()))
            {
                MessageBox.Show("ID de venda field is empty!");
            }
            else if (string.IsNullOrWhiteSpace(IDProdTXT.Text.ToString()))
            {
                MessageBox.Show("ID of product can't be null!");
            }

            else
            {
                MainForm.InsertOrRemoveIntoDB("addCompra", parameters);
                searchBtn.PerformClick(); // Populate/Update List after adding new employee
            }
        }
    }
}
