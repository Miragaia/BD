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
    public partial class DistribuidorForm : Form
    {
        public DistribuidorForm()
        {
            InitializeComponent();
        }

        private void DistribuidorForm_Load(object sender, EventArgs e)
        {
            MainForm.populateList(dataGridView1, "getDistribuidores");
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nomeTxt.Clear();
            nifTxt.Clear();
            emailTxt.Clear();
            num_funcTxt.Clear();
            Id_vendaTxt.Clear();
            matriculaTxt.Clear();
            num_dist.Clear();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> parameters = new Dictionary<string, dynamic>()
            {
                { "@nif", nifTxt.Text },
                { "@nome", nomeTxt.Text },
                { "@email", emailTxt.Text },
                { "@num_func", num_funcTxt.Text },
                { "@id_venda", Id_vendaTxt.Text },
                { "@matricula", matriculaTxt.Text },
                { "@num_dist", num_dist.Text },

            };

            List<string> parametersKeys = new List<string>(parameters.Keys);
            foreach (var key in parametersKeys) // replace empty inputs with null (required for the db stored procedure)
            {
                if (parameters[key] == "")
                    parameters[key] = null;
            }

            MainForm.PopulateTableWithParameters(dataGridView1, "filterDistribuidores", parameters);
        }
    }
}
