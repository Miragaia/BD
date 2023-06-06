using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Proj_BD
{
    public partial class MainForm : Form
    {
        private static SqlConnection cn;

        ProdutosForm armazensForm;
        FornecedoresForm fornecedoresForm;
        ComprasForm comprasForm;
        EmpresaForm empresaForm;
        ClientesForm clientesForm;
        ProdutosForm produtosForm;
        VendasForm vendasForm;
        FuncionariosForm funcionariosForm;



        public MainForm()
        {
            InitializeComponent();
            armazensForm = new ProdutosForm();
            fornecedoresForm = new FornecedoresForm();
            comprasForm = new ComprasForm();
            empresaForm = new EmpresaForm();
            clientesForm = new ClientesForm();
            produtosForm = new ProdutosForm();
            vendasForm = new VendasForm();
            funcionariosForm = new FuncionariosForm();


        }

        private void Main_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            if (verifySGBDConnection())
            {
                Console.WriteLine("Connection");
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Can't connect to database", "Error!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    System.Environment.Exit(1);
                }

            }

            cn.Close();
        }

        private static bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private static SqlConnection getSGBDConnection()
        {
            String dbServer = "tcp:mednat.ieeta.pt\\SQLSERVER,8101";
            String dbName = "p8g8";
            String userName = "p8g8";
            String userPass = "Lol.008#";
            return new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass);
        }

        public static void populateList(DataGridView grid, string procedureName)
        {
            if (!verifySGBDConnection())
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Error: " + ex.Message);
            }


        }

        public static void InsertOrRemoveIntoDB(string procedureName, Dictionary<string, dynamic> parameters)
        {
            if (!verifySGBDConnection())
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, cn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var item in parameters)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public static void updateClientOrEmployee(int pk_nif, string attribute, dynamic value)
        {
            if (!verifySGBDConnection())
                return;

            try
            {
                SqlCommand cmd = new SqlCommand("updateClientOrEmployee", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nif", pk_nif);
                cmd.Parameters.AddWithValue("@attribute", attribute);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Error: " + ex.Message);
            }
        }



        public static void PopulateTableWithParameters(DataGridView grid, string procedureName, Dictionary<string, dynamic> parameters)
        {
            if (!verifySGBDConnection())
                return;

            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, cn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var item in parameters)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Error: " + ex.Message);
            }
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





        public void changeTab(int i)
        {
            this.Hide();

            switch (i)
            {
                case 1:
                    clientesForm.Show();
                    break;
                case 2:
                    fornecedoresForm.Show();
                    break;
                case 3:
                    funcionariosForm.Show();
                    break;
                case 4:
                    vendasForm.Show();
                    break;
                case 5:
                    comprasForm.Show();
                    break;
                case 6:
                    armazensForm.Show();
                    break;
            }
        }

        
    }
}
