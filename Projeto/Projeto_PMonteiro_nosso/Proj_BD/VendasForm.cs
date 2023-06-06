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
    public partial class VendasForm : Form
    {
        public VendasForm()
        {
            InitializeComponent();
        }

        private void nomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendasForm_Load(object sender, EventArgs e)
        {
            MainForm.populateList(dataGridView1, "getVendas");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide(); // mudar de screen
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataEntTxt.Clear();
            ID_VendaTxt.Clear();
            ID_ProdTxt.Clear();
            Nome_ProdTxt.Clear();
            Type_ProdTxt.Clear();
            ID_ArmTxt.Clear();
            nome_distTxt.Clear();
            nome_VendTxt.Clear();
            nome_CTxt.Clear();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@data_ent", dataEntTxt.Text },
                { "@id_venda", ID_VendaTxt.Text },
                { "@id_produto", ID_ProdTxt.Text },
                { "@nome_produto", Nome_ProdTxt.Text },
                { "@type_prod", Type_ProdTxt.Text },
                { "@id_armazem", ID_ArmTxt.Text },
                { "@nome_dis", nome_distTxt.Text },
                { "@nome_vend", nome_VendTxt.Text},
                { "@nome_client", nome_CTxt.Text},
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            MainForm.PopulateTableWithParameters(dataGridView1, "filterVendas", parameters);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@id_venda", idVendaTXT.Text },
                { "@id_prod", IDProdTXT.Text },
                { "@Quantidade", quantTXT.Text },
                { "@data_venda", data_vendaTXT.Text },
                { "@nome_vendedor", nomeVendTXT.Text },
                { "@id_arm", IDArmTXT.Text },
                { "@nif_cliente", NIFClientTXT.Text },
                { "@nome_dist", NumDistTXT.Text},
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            if (string.IsNullOrWhiteSpace(idVendaTXT.Text.ToString()))
            {
                MessageBox.Show("ID de venda field is empty!");
            }
            else if (string.IsNullOrWhiteSpace(IDProdTXT.Text.ToString()))
            {
                MessageBox.Show("ID of product can't be null!");
            }
            
            else
            {
                MainForm.InsertOrRemoveIntoDB("addVenda", parameters);
                searchBtn.PerformClick(); // Populate/Update List after adding new employee
            }
        }
    }
}
