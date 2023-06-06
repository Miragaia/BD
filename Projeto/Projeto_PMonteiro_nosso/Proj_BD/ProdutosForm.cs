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
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void ArmazensForm_Load(object sender, EventArgs e)
        {
            MainForm.populateList(dataGridView1, "getProdutos");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide(); // mudar de screen
            mainForm.Show();
        }

        

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTxt.Clear();
            nomeTxt.Clear();
            marcaTxt.Clear();
            textBox1.Clear();
            precoTxt.Clear();
            textBox2.Clear();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@id", idTxt.Text },
                { "@nome", nomeTxt.Text },
                { "@marca", marcaTxt.Text },
                { "@type", textBox1.Text },
                { "@preco", precoTxt.Text },
                { "@id_arm", textBox2.Text },
            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            MainForm.PopulateTableWithParameters(dataGridView1, "filterProdutos", parameters);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
