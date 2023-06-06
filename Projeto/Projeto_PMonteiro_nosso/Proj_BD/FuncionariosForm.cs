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
    public partial class FuncionariosForm : Form
    {
        DistribuidorForm distribuidorForm;
        VendedorForm vendedorForm;
        GerenteForm gerenteForm;
        public FuncionariosForm()
        {
            InitializeComponent();
            distribuidorForm = new DistribuidorForm();
            vendedorForm = new VendedorForm();
            gerenteForm = new GerenteForm();
        }

        private void FuncionariosForm_Load(object sender, EventArgs e)
        {

        }

        



        public void changeTab(int i)
        {
            this.Hide();

            switch (i)
            {
                case 1:
                    distribuidorForm.Show();
                    break;
                case 2:
                    vendedorForm.Show();
                    break;
                case 3:
                    gerenteForm.Show();
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changeTab(1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            changeTab(2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            changeTab(3);
        }
    }


}


