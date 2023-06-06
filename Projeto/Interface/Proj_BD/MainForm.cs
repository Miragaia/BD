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
    public partial class MainForm : Form
    {
        ArmazensForm armazensForm;
        CarrinhasForm carrinhasForm;
        ComprasForm comprasForm;
        EmpresaForm empresaForm;
        PessoasForm pessoasForm;
        ProdutosForm produtosForm;
        VendasForm vendasForm;



        public MainForm()
        {
            InitializeComponent();
            armazensForm = new ArmazensForm();
            carrinhasForm = new CarrinhasForm();
            comprasForm = new ComprasForm();
            empresaForm = new EmpresaForm();
            pessoasForm = new PessoasForm();
            produtosForm = new ProdutosForm();
            vendasForm = new VendasForm();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeTab(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeTab(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeTab(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeTab(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changeTab(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            changeTab(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            changeTab(7);
        }


        public void changeTab(int i)
        {
            this.Hide();

            switch (i)
            {
                case 1:
                    empresaForm.Show();
                    break;
                case 2:
                    pessoasForm.Show();
                    break;
                case 3:
                    comprasForm.Show();
                    break;
                case 4:
                    produtosForm.Show();
                    break;
                case 5:
                    vendasForm.Show();
                    break;
                case 6:
                    armazensForm.Show();
                    break;
                case 7:
                    carrinhasForm.Show();
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }



    }
}
