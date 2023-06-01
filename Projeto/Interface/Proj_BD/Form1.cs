﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proj_BD
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        private Button btnUtilizadores;
        private Button btnConteudo;
        private Button btnCanal;
        private Button btnComentario;
        private Button btnPlaylist;
        private Button btnHistorico;
        private Panel pnlContent;
        private Button enviarUser;
        private Button enviarFunc;
        private Button enviarClient;
        private Button enviarForn;
        private Button verPessoas;
        private Button clearPnlContent;
        private Button enviarConteudo;
        private Button verConteudos;
        private Button enviarComentario;
        private Button verComentarios;
        private Button enviarPlayList;
        private Button verPlayLists;
        private DataRepository dataRepository;
        private Button verPlayListCodigo;


        // Campos de texto para capturar os valores do utilizador
        private TextBox txtNIF;
        private TextBox txtNome;
        private TextBox txtNascimento;
        private TextBox txtemail;
        private TextBox txtMorada;
        private TextBox txtlblTelemovel;
        private TextBox txtlblNIFEmpresa;




        // campos de texto para capturar os valores do conteudo
        private TextBox TextoAutorConteudo;
        private TextBox TextoEstado;
        private TextBox TextoNumLikes;
        private TextBox TextoTipoConteudo;
        private TextBox TextTituloVideo;
        private TextBox textoDuracao;
        private TextBox textoDataPub;
        private TextBox textoNumVisualizacoes;
        private TextBox txtIdConteudo;

        // Campos de texto para capturar os valores do comentario
        private TextBox textUserComentario;
        private TextBox txtIdConteudoComent;
        private TextBox ComentText;
        private TextBox ComentDataText;
        private TextBox CodigoC;


        // Campos de texto para capturar os valores do Playlist
        private TextBox textUserPlaylistAutor;
        private TextBox txtTituloPlay;
        private TextBox idPlayList;
        private TextBox EstadoPlayList;
        private TextBox CodigoP;



        // Campos de texto para capturar os valores do Historico
        private TextBox VideosHistorico;
        private TextBox textUserHistoricpOwner;
        private TextBox DataHistorico;


        private TextBox Canal;



        public Form1()
        {
            InitializeComponent();
            dataRepository = new DataRepository();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeComponentCustom();
        }

        private void InitializeComponentCustom()
        {
            btnUtilizadores = new Button();
            btnUtilizadores.Text = "Pessoas";
            btnUtilizadores.Font = new Font(btnUtilizadores.Font, FontStyle.Bold);
            btnUtilizadores.Size = new Size(this.Width / 6, 50);
            btnUtilizadores.Location = new Point(0, 0);
            btnUtilizadores.BackColor = Color.White; // Define a cor de fundo como branco
            btnUtilizadores.FlatStyle = FlatStyle.Flat;
            btnUtilizadores.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            btnUtilizadores.Click += btnPessoas_Click;
            this.Controls.Add(btnUtilizadores);

            btnConteudo = new Button();
            btnConteudo.Text = "Vendas";
            btnConteudo.Font = new Font(btnConteudo.Font, FontStyle.Bold);
            btnConteudo.Size = new Size(this.Width / 6, 50);
            btnConteudo.Location = new Point(btnUtilizadores.Right, 0);
            btnConteudo.BackColor = Color.White; // Define a cor de fundo como branco
            btnConteudo.FlatStyle = FlatStyle.Flat;
            btnConteudo.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            btnConteudo.Click += btnConteudo_Click;
            this.Controls.Add(btnConteudo);

            btnComentario = new Button();
            btnComentario.Text = "Comentários";
            btnComentario.Font = new Font(btnComentario.Font, FontStyle.Bold);
            btnComentario.Size = new Size(this.Width / 6, 50);
            btnComentario.Location = new Point(btnConteudo.Right, 0);
            btnComentario.BackColor = Color.White; // Define a cor de fundo como branco
            btnComentario.FlatStyle = FlatStyle.Flat;
            btnComentario.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            btnComentario.Click += btnCmentarios_Click;
            this.Controls.Add(btnComentario);

            btnPlaylist = new Button();
            btnPlaylist.Text = "Playlist";
            btnPlaylist.Font = new Font(btnPlaylist.Font, FontStyle.Bold);
            btnPlaylist.Size = new Size(this.Width / 6, 50);
            btnPlaylist.Location = new Point(btnComentario.Right, 0);
            btnPlaylist.BackColor = Color.White; // Define a cor de fundo como branco
            btnPlaylist.FlatStyle = FlatStyle.Flat;
            btnPlaylist.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            btnPlaylist.Click += btnPlaylist_Click;
            this.Controls.Add(btnPlaylist);

            btnHistorico = new Button();
            btnHistorico.Text = "Histórico";
            btnHistorico.Font = new Font(btnHistorico.Font, FontStyle.Bold);
            btnHistorico.Size = new Size(this.Width / 6, 50);
            btnHistorico.Location = new Point(btnPlaylist.Right, 0);
            btnHistorico.BackColor = Color.White; // Define a cor de fundo como branco
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            btnHistorico.Click += btnHistorico_Click;
            this.Controls.Add(btnHistorico);

            btnCanal = new Button();
            btnCanal.Text = "Canal";
            btnCanal.Font = new Font(btnCanal.Font, FontStyle.Bold);
            btnCanal.Size = new Size(this.Width / 6, 50);
            btnCanal.Location = new Point(btnHistorico.Right, 0);
            btnCanal.BackColor = Color.White; // Define a cor de fundo como branco
            btnCanal.FlatStyle = FlatStyle.Flat;
            btnCanal.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            btnCanal.Click += btnCanal_Click;
            this.Controls.Add(btnCanal);

            pnlContent = new Panel();
            pnlContent.Size = new Size(this.Width, this.Height - btnUtilizadores.Height);
            pnlContent.Location = new Point(0, btnUtilizadores.Bottom);
            pnlContent.BackColor = Color.DarkRed;
            pnlContent.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pnlContent);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Obter o objeto Graphics do formulário
            Graphics g = e.Graphics;

            // Definir a cor e a espessura da linha
            Pen pen = new Pen(Color.Black, 3);

            // Desenhar uma linha preta na parte superior do formulário
            g.DrawLine(pen, 0, 0, this.Width, 0);
        }
        
        private void btnCanal_Click(object sender, EventArgs e)
        {
            // Limpar os dados do painel
            pnlContent.Controls.Clear();

            Label lblNIFPessoa = new Label();
            lblNIFPessoa.Text = "Nome de Utilizador:";
            lblNIFPessoa.ForeColor = Color.White;
            lblNIFPessoa.Font = new Font(lblNIFPessoa.Font, FontStyle.Bold);
            lblNIFPessoa.Location = new Point(20, 10);
            lblNIFPessoa.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNIFPessoa);

            Canal = new TextBox();
            Canal.Location = new Point(200, 10);
            Canal.Size = new Size(450, 40);
            pnlContent.Controls.Add(Canal);

            Button enviarUser = new Button();
            enviarUser.Text = "Procurar o Canal";
            enviarUser.Font = new Font(enviarUser.Font, FontStyle.Bold);
            enviarUser.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarUser.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarUser.BackColor = Color.White; // Define a cor de fundo como branco
            enviarUser.FlatStyle = FlatStyle.Flat;
            enviarUser.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarUser.Click += ProcurarUser_Click;
            pnlContent.Controls.Add(enviarUser);

            Button verPessoas = new Button();
            verPessoas.Text = "Listar todos os canais";
            verPessoas.Font = new Font(verPessoas.Font, FontStyle.Bold);
            verPessoas.Size = new Size(200, 30); // Ajusta o tamanho do botão
            verPessoas.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 90);
            verPessoas.BackColor = Color.White; // Define a cor de fundo como branco
            verPessoas.FlatStyle = FlatStyle.Flat;
            verPessoas.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            verPessoas.Click += ProcurarUser_Click;
            pnlContent.Controls.Add(verPessoas);

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.Size = new Size(200, 30); // Ajusta o tamanho do botão
            clearPnlContent.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 50);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);
        }
        private void ProcurarUser_Click(object sender, EventArgs e)
        {
            // Obter os valores dos campos de texto
            string NIFPessoa = Canal.Text;

            // Limpar os dados do painel
            pnlContent.Controls.Clear();

            clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 250, pnlContent.Height - 300);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

            // Obter os utilizadores do DataRepository
            DataTable utilizadores = dataRepository.ProcurarUser(NIFPessoa);

            // Criar uma DataGridView para exibir os utilizadores
            DataGridView dgvUtilizadores = new DataGridView();
            dgvUtilizadores.BackgroundColor = Color.Gray;
            dgvUtilizadores.Font = new Font(dgvUtilizadores.Font, FontStyle.Bold);
            dgvUtilizadores.DataSource = utilizadores;
            dgvUtilizadores.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(dgvUtilizadores);
        }

        //
        // Utilizador
        //



        private void EnviarUser_Click(object sender, EventArgs e)
        {
            // Obter os valores dos campos de texto
            string NIFPessoa = txtNIF.Text;
            string nomePessoa = txtNome.Text;
            string nascimentoText = txtNascimento.Text;
            string email = txtemail.Text;
            string morada = txtMorada.Text;
            string telemovel = txtlblTelemovel.Text;
            string NIFEmpresa = txtlblNIFEmpresa.Text;


            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(NIFPessoa) || string.IsNullOrWhiteSpace(nomePessoa) || string.IsNullOrWhiteSpace(nascimentoText) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(morada) || string.IsNullOrWhiteSpace(telemovel) || string.IsNullOrWhiteSpace(NIFEmpresa))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!DateTime.TryParse(nascimentoText, out DateTime nascimento))
            {
                MessageBox.Show("Formato de data inválido. Por favor, insira uma data válida.");
                return;
            }
            int nifP = int.Parse(NIFPessoa);
            int tel = int.Parse(telemovel);
            int nifE = int.Parse(NIFEmpresa);

            // Enviar os dados para o DataRepository
            bool sucesso = dataRepository.InserirUtilizador(nifP, nomePessoa, nascimento, email, morada, tel, nifE);

            if (sucesso)
            {
                MessageBox.Show("Utilizador criado com sucesso!");
                LimparCamposUtilizador();
            }
            else
            {
                MessageBox.Show("Erro ao criar o utilizador. Por favor, tente novamente.");
            }
        }

        private void enviarFunc_Click(object sender, EventArgs e)
        {
            // Obter os valores dos campos de texto
            string NIFPessoa = txtNIF.Text;
            string nomePessoa = txtNome.Text;
            string nascimentoText = txtNascimento.Text;
            string email = txtemail.Text;
            string morada = txtMorada.Text;
            string telemovel = txtlblTelemovel.Text;
            string NIFEmpresa = txtlblNIFEmpresa.Text;


            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(NIFPessoa) || string.IsNullOrWhiteSpace(nomePessoa) || string.IsNullOrWhiteSpace(nascimentoText) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(morada) || string.IsNullOrWhiteSpace(telemovel) || string.IsNullOrWhiteSpace(NIFEmpresa))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!DateTime.TryParse(nascimentoText, out DateTime nascimento))
            {
                MessageBox.Show("Formato de data inválido. Por favor, insira uma data válida.");
                return;
            }
            int nifP = int.Parse(NIFPessoa);
            int tel = int.Parse(telemovel);
            int nifE = int.Parse(NIFEmpresa);

            // Enviar os dados para o DataRepository
            bool sucesso = dataRepository.InserirUtilizador(nifP, nomePessoa, nascimento, email, morada, tel, nifE);

            if (sucesso)
            {
                MessageBox.Show("Utilizador criado com sucesso!");
                LimparCamposUtilizador();
            }
            else
            {
                MessageBox.Show("Erro ao criar o utilizador. Por favor, tente novamente.");
            }
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            // Limpar os dados do painel
            pnlContent.Controls.Clear();
        }


        private void btnPessoas_Click(object sender, EventArgs e)
        {
            // Limpar os dados do painel
            pnlContent.Controls.Clear();

            Button enviarPessoas = new Button();
            enviarPessoas.Text = "Listar Pessoas";
            enviarPessoas.Font = new Font(enviarPessoas.Font, FontStyle.Bold);
            enviarPessoas.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarPessoas.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 270);
            enviarPessoas.BackColor = Color.White; // Define a cor de fundo como branco
            enviarPessoas.FlatStyle = FlatStyle.Flat;
            enviarPessoas.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarPessoas.Click += btnPessoas_Click;
            pnlContent.Controls.Add(enviarPessoas);

            Button enviarForn = new Button();
            enviarForn.Text = "Listar Fornecedores";
            enviarForn.Font = new Font(enviarForn.Font, FontStyle.Bold);
            enviarForn.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarForn.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 230);
            enviarForn.BackColor = Color.White; // Define a cor de fundo como branco
            enviarForn.FlatStyle = FlatStyle.Flat;
            enviarForn.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarForn.Click += btnForn_Click;
            pnlContent.Controls.Add(enviarForn);

            Button enviarCliente = new Button();
            enviarCliente.Text = "Listar Clientes";
            enviarCliente.Font = new Font(enviarCliente.Font, FontStyle.Bold);
            enviarCliente.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarCliente.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 190);
            enviarCliente.BackColor = Color.White; // Define a cor de fundo como branco
            enviarCliente.FlatStyle = FlatStyle.Flat;
            enviarCliente.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarCliente.Click += btnCliente_Click;
            pnlContent.Controls.Add(enviarCliente);

            Button enviarFunc = new Button();
            enviarFunc.Text = "Listar Funcionarios";
            enviarFunc.Font = new Font(enviarFunc.Font, FontStyle.Bold);
            enviarFunc.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarFunc.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 150);
            enviarFunc.BackColor = Color.White; // Define a cor de fundo como branco
            enviarFunc.FlatStyle = FlatStyle.Flat;
            enviarFunc.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarFunc.Click += btnFunc_Click;
            pnlContent.Controls.Add(enviarFunc);

            Button enviarDist = new Button();
            enviarDist.Text = "Listar Distribuidores";
            enviarDist.Font = new Font(enviarDist.Font, FontStyle.Bold);
            enviarDist.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarDist.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 110);
            enviarDist.BackColor = Color.White; // Define a cor de fundo como branco
            enviarDist.FlatStyle = FlatStyle.Flat;
            enviarDist.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarDist.Click += btnDist_Click;
            pnlContent.Controls.Add(enviarDist);

            Button enviarGerente = new Button();
            enviarGerente.Text = "Listar Gerente";
            enviarGerente.Font = new Font(enviarGerente.Font, FontStyle.Bold);
            enviarGerente.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarGerente.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 70);
            enviarGerente.BackColor = Color.White; // Define a cor de fundo como branco
            enviarGerente.FlatStyle = FlatStyle.Flat;
            enviarGerente.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarGerente.Click += btnGerente_Click;
            pnlContent.Controls.Add(enviarGerente);

            Button enviarVendedor = new Button();
            enviarVendedor.Text = "Listar Vendedor";
            enviarVendedor.Font = new Font(enviarVendedor.Font, FontStyle.Bold);
            enviarVendedor.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarVendedor.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 30);
            enviarVendedor.BackColor = Color.White; // Define a cor de fundo como branco
            enviarVendedor.FlatStyle = FlatStyle.Flat;
            enviarVendedor.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarVendedor.Click += btnVendedor_Click;
            pnlContent.Controls.Add(enviarVendedor);

            /*
            Button enviarUser = new Button();
            enviarUser.Text = "Criar Pessoa";
            enviarUser.Font = new Font(enviarUser.Font, FontStyle.Bold);
            enviarUser.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarUser.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarUser.BackColor = Color.White; // Define a cor de fundo como branco
            enviarUser.FlatStyle = FlatStyle.Flat;
            enviarUser.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarUser.Click += CriarPessoa_Click;
            pnlContent.Controls.Add(enviarUser);
            */

            clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como brancoCriarPessoa_Click
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 250, pnlContent.Height - 200);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

            // Obter os utilizadores do DataRepository
            DataTable utilizadores = dataRepository.ListarPessoas();

            // Criar uma DataGridView para exibir os utilizadores
            DataGridView dgvUtilizadores = new DataGridView();
            dgvUtilizadores.BackgroundColor = Color.Gray;
            dgvUtilizadores.Font = new Font(dgvUtilizadores.Font, FontStyle.Bold);
            dgvUtilizadores.DataSource = utilizadores;
            dgvUtilizadores.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(dgvUtilizadores);


        }

        private void CriarPessoa_Click(object sender, EventArgs e)
        {
            // Limpa os dados do painel 
            pnlContent.Controls.Clear();



            /*
            // Cria os controles para inserir os dados do utilizador
            Label lblNIF = new Label();
            lblNIF.Text = "NIF da Pessoa:";
            lblNIF.ForeColor = Color.White;
            lblNIF.Font = new Font(lblNIF.Font, FontStyle.Bold);
            lblNIF.Location = new Point(20, 10);
            lblNIF.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNIF);

            txtNIF = new TextBox();
            txtNIF.Location = new Point(200, 10);
            txtNIF.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtNIF);

            Label lblNomePessoa = new Label();
            lblNomePessoa.Text = "Nome:";
            lblNomePessoa.ForeColor = Color.White;
            lblNomePessoa.Font = new Font(lblNomePessoa.Font, FontStyle.Bold);
            lblNomePessoa.Location = new Point(20, 50);
            lblNomePessoa.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNomePessoa);

            txtNome = new TextBox();
            txtNome.Location = new Point(200, 50);
            txtNome.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtNome);

            Label lblNascimento = new Label();
            lblNascimento.Text = "Data de Nascimento:";
            lblNascimento.ForeColor = Color.White;
            lblNascimento.Font = new Font(lblNascimento.Font, FontStyle.Bold);
            lblNascimento.Location = new Point(20, 90);
            lblNascimento.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNascimento);

            txtNascimento = new TextBox();
            txtNascimento.Location = new Point(200, 90);
            txtNascimento.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtNascimento);

            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.ForeColor = Color.White;
            lblEmail.Font = new Font(lblEmail.Font, FontStyle.Bold);
            lblEmail.Location = new Point(20, 130);
            lblEmail.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblEmail);

            txtemail = new TextBox();
            txtemail.Location = new Point(200, 130);
            txtemail.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtemail);

            Label lblMorada = new Label();
            lblMorada.Text = "Morada:";
            lblMorada.ForeColor = Color.White;
            lblMorada.Font = new Font(lblMorada.Font, FontStyle.Bold);
            lblMorada.Location = new Point(20, 170);
            lblMorada.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblMorada);

            txtMorada = new TextBox();
            txtMorada.Location = new Point(200, 170);
            txtMorada.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtMorada);

            Label lblTelemovel = new Label();
            lblTelemovel.Text = "Contacto Telefónico:";
            lblTelemovel.ForeColor = Color.White;
            lblTelemovel.Font = new Font(lblTelemovel.Font, FontStyle.Bold);
            lblTelemovel.Location = new Point(20, 210);
            lblTelemovel.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblTelemovel);

            txtlblTelemovel = new TextBox();
            txtlblTelemovel.Location = new Point(200, 210);
            txtlblTelemovel.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtlblTelemovel);

            Label lblNIFEmpresa = new Label();
            lblNIFEmpresa.Text = "NIF Empresa:";
            lblNIFEmpresa.ForeColor = Color.White;
            lblNIFEmpresa.Font = new Font(lblNIFEmpresa.Font, FontStyle.Bold);
            lblNIFEmpresa.Location = new Point(20, 250);
            lblNIFEmpresa.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNIFEmpresa);

            txtlblNIFEmpresa = new TextBox();
            txtlblNIFEmpresa.Location = new Point(200, 250);
            txtlblNIFEmpresa.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtlblNIFEmpresa);
            
            Button enviarUser = new Button();
            enviarUser.Text = "Guardar Utilizador";
            enviarUser.Font = new Font(enviarUser.Font, FontStyle.Bold);
            enviarUser.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarUser.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarUser.BackColor = Color.White; // Define a cor de fundo como branco
            enviarUser.FlatStyle = FlatStyle.Flat;
            enviarUser.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarUser.Click += EnviarUser_Click;
            pnlContent.Controls.Add(enviarUser);
            */

            Button enviarFunc = new Button();
            enviarFunc.Text = "Criar Funcionário";
            enviarFunc.Font = new Font(enviarFunc.Font, FontStyle.Bold);
            enviarFunc.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarFunc.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarFunc.BackColor = Color.White; // Define a cor de fundo como branco
            enviarFunc.FlatStyle = FlatStyle.Flat;
            enviarFunc.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarFunc.Click += enviarFunc_Click;
            pnlContent.Controls.Add(enviarFunc);
            
            Button enviarClient = new Button();
            enviarClient.Text = "Criar Cliente";
            enviarClient.Font = new Font(enviarClient.Font, FontStyle.Bold);
            enviarClient.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarClient.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarClient.BackColor = Color.White; // Define a cor de fundo como branco
            enviarClient.FlatStyle = FlatStyle.Flat;
            enviarClient.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            //enviarClient.Click += enviarClient_Click;
            pnlContent.Controls.Add(enviarClient);

            Button enviarForn = new Button();
            enviarForn.Text = "Criar Fornecedor";
            enviarForn.Font = new Font(enviarForn.Font, FontStyle.Bold);
            enviarForn.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarForn.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarForn.BackColor = Color.White; // Define a cor de fundo como branco
            enviarForn.FlatStyle = FlatStyle.Flat;
            enviarForn.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            //enviarForn.Click += enviarForn_Click;
            pnlContent.Controls.Add(enviarForn);

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.Size = new Size(200, 30); // Ajusta o tamanho do botão
            clearPnlContent.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 50);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);
        }





































        private void LimparCamposUtilizador()
        {
            txtNIF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNascimento.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtMorada.Text = string.Empty;
            txtlblTelemovel.Text = string.Empty;
            txtlblNIFEmpresa.Text = string.Empty;
        }

        //
        // Conteudo
        // 
        private void btnConteudo_Click(object sender, EventArgs e)
        {
            // Limpa os dados do painel 
            pnlContent.Controls.Clear();

            // Cria os controles para inserir os dados do utilizador
            Label lblTituloConteudo = new Label();
            lblTituloConteudo.Text = "Nome de Conteudo:";
            lblTituloConteudo.ForeColor = Color.White;
            lblTituloConteudo.Font = new Font(lblTituloConteudo.Font, FontStyle.Bold);
            lblTituloConteudo.Location = new Point(20, 10);
            lblTituloConteudo.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblTituloConteudo);

            TextTituloVideo = new TextBox();
            TextTituloVideo.Location = new Point(200, 10);
            TextTituloVideo.Size = new Size(450, 40);
            pnlContent.Controls.Add(TextTituloVideo);

            Label IdConteudo = new Label();
            IdConteudo.Text = "Id Conteudo:";
            IdConteudo.ForeColor = Color.White;
            IdConteudo.Font = new Font(IdConteudo.Font, FontStyle.Bold);
            IdConteudo.Location = new Point(20, 50);
            IdConteudo.Size = new Size(180, 30);
            pnlContent.Controls.Add(IdConteudo);

            txtIdConteudo = new TextBox();
            txtIdConteudo.Location = new Point(200, 50);
            txtIdConteudo.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtIdConteudo);

            Label AutorConteudo = new Label();
            AutorConteudo.Text = "Autor:";
            AutorConteudo.ForeColor = Color.White;
            AutorConteudo.Font = new Font(AutorConteudo.Font, FontStyle.Bold);
            AutorConteudo.Location = new Point(20, 90);
            AutorConteudo.Size = new Size(180, 30);
            pnlContent.Controls.Add(AutorConteudo);

            TextoAutorConteudo = new TextBox();
            TextoAutorConteudo.Location = new Point(200, 90);
            TextoAutorConteudo.Size = new Size(450, 40);
            pnlContent.Controls.Add(TextoAutorConteudo);

            Label TipoConteudo = new Label();
            TipoConteudo.Text = "Tipo:";
            TipoConteudo.ForeColor = Color.White;
            TipoConteudo.Font = new Font(TipoConteudo.Font, FontStyle.Bold);
            TipoConteudo.Location = new Point(20, 130);
            TipoConteudo.Size = new Size(180, 30);
            pnlContent.Controls.Add(TipoConteudo);

            TextoTipoConteudo = new TextBox();
            TextoTipoConteudo.Location = new Point(200, 130);
            TextoTipoConteudo.Size = new Size(450, 40);
            pnlContent.Controls.Add(TextoTipoConteudo);

            Label lblEstado = new Label();
            lblEstado.Text = "Estado:";
            lblEstado.ForeColor = Color.White;
            lblEstado.Font = new Font(lblEstado.Font, FontStyle.Bold);
            lblEstado.Location = new Point(20, 170);
            lblEstado.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblEstado);

            TextoEstado = new TextBox();
            TextoEstado.Location = new Point(200, 170);
            TextoEstado.Size = new Size(450, 40);
            pnlContent.Controls.Add(TextoEstado);

            Label lblDuracao = new Label();
            lblDuracao.Text = "Duração:";
            lblDuracao.ForeColor = Color.White;
            lblDuracao.Font = new Font(lblDuracao.Font, FontStyle.Bold);
            lblDuracao.Location = new Point(20, 210);
            lblDuracao.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblDuracao);

            textoDuracao = new TextBox();
            textoDuracao.Location = new Point(200, 210);
            textoDuracao.Size = new Size(450, 40);
            pnlContent.Controls.Add(textoDuracao);

            Label lblNumLikes = new Label();
            lblNumLikes.Text = "Nr Likes:";
            lblNumLikes.ForeColor = Color.White;
            lblNumLikes.Font = new Font(lblNumLikes.Font, FontStyle.Bold);
            lblNumLikes.Location = new Point(20, 250);
            lblNumLikes.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNumLikes);

            TextoNumLikes = new TextBox();
            TextoNumLikes.Location = new Point(200, 250);
            TextoNumLikes.Size = new Size(450, 40);
            pnlContent.Controls.Add(TextoNumLikes);

            Label lblNumVisualizacoes = new Label();
            lblNumVisualizacoes.Text = "Nr Views:";
            lblNumVisualizacoes.ForeColor = Color.White;
            lblNumVisualizacoes.Font = new Font(lblNumVisualizacoes.Font, FontStyle.Bold);
            lblNumVisualizacoes.Location = new Point(20, 290);
            lblNumVisualizacoes.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNumVisualizacoes);

            textoNumVisualizacoes = new TextBox();
            textoNumVisualizacoes.Location = new Point(200, 290);
            textoNumVisualizacoes.Size = new Size(450, 40);
            pnlContent.Controls.Add(textoNumVisualizacoes);

            Label lblDataPub = new Label();
            lblDataPub.Text = "Publicado:";
            lblDataPub.ForeColor = Color.White;
            lblDataPub.Font = new Font(lblDataPub.Font, FontStyle.Bold);
            lblDataPub.Location = new Point(20, 330);
            lblDataPub.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblDataPub);

            textoDataPub = new TextBox();
            textoDataPub.Location = new Point(200, 330);
            textoDataPub.Size = new Size(450, 40);
            pnlContent.Controls.Add(textoDataPub);

            Button enviarConteudo = new Button();
            enviarConteudo.Text = "Criar Conteúdo";
            enviarConteudo.Font = new Font(enviarConteudo.Font, FontStyle.Bold);
            enviarConteudo.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarConteudo.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarConteudo.BackColor = Color.White; // Define a cor de fundo como branco
            enviarConteudo.FlatStyle = FlatStyle.Flat;
            enviarConteudo.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarConteudo.Click += enviarConteudo_Click;
            pnlContent.Controls.Add(enviarConteudo);

            Button verConteudos = new Button();
            verConteudos.Text = "Ver Conteúdo";
            verConteudos.Font = new Font(verConteudos.Font, FontStyle.Bold);
            verConteudos.Size = new Size(200, 30); // Ajusta o tamanho do botão
            verConteudos.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 90);
            verConteudos.BackColor = Color.White; // Define a cor de fundo como branco
            verConteudos.FlatStyle = FlatStyle.Flat;
            verConteudos.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            verConteudos.Click += verConteudos_Click;
            pnlContent.Controls.Add(verConteudos);

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.Size = new Size(200, 30); // Ajusta o tamanho do botão
            clearPnlContent.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 50);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);
        }
        public void enviarConteudo_Click(object sender, EventArgs e)
        {

            string tipoConteudo = TextoTipoConteudo.Text;
            string idConteudo = txtIdConteudo.Text;
            string EstadoConteudo = TextoEstado.Text;
            string ViewsConteudo = textoNumVisualizacoes.Text;
            string pubConteudo = textoDataPub.Text;
            string DuracaoConteudo = textoDuracao.Text;
            string AutorConteudo = TextoAutorConteudo.Text;
            string TituloConteudo = TextTituloVideo.Text;
            string likesConteudo = TextoNumLikes.Text;

            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(tipoConteudo) || string.IsNullOrWhiteSpace(idConteudo) ||
                string.IsNullOrWhiteSpace(EstadoConteudo) || string.IsNullOrWhiteSpace(ViewsConteudo) ||
                string.IsNullOrWhiteSpace(pubConteudo) || string.IsNullOrWhiteSpace(DuracaoConteudo) ||
                string.IsNullOrWhiteSpace(AutorConteudo) || string.IsNullOrWhiteSpace(TituloConteudo) || string.IsNullOrWhiteSpace(likesConteudo))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            int id = int.Parse(idConteudo);
            int likes = int.Parse(likesConteudo);
            int views = int.Parse(ViewsConteudo);
            TimeSpan duracao = TimeSpan.Parse(DuracaoConteudo);
            DateTime pub = DateTime.Parse(pubConteudo);

            // Enviar os dados para o DataRepository
            bool sucesso = dataRepository.InserirConteudo(tipoConteudo, id, EstadoConteudo, views, pub, duracao, AutorConteudo, TituloConteudo, likes);

            if (sucesso)
            {
                MessageBox.Show("Conteudo criado com sucesso!");
                LimparCamposConteudo();
            }
            else
            {
                MessageBox.Show("Erro ao criar o conteudo. Por favor, tente novamente.");
            }


        }
        public void verConteudos_Click(object sender, EventArgs e)
        {
            // Limpar os dados do painel
            pnlContent.Controls.Clear();

            clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 90);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

            // Obter os utilizadores do DataRepository
            DataTable utilizadores = dataRepository.ListarConteudo();

            // Criar uma DataGridView para exibir os utilizadores
            DataGridView dgvUtilizadores = new DataGridView();
            dgvUtilizadores.DataSource = utilizadores;
            dgvUtilizadores.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(dgvUtilizadores);
        }
        public void LimparCamposConteudo()
        {
            TextoTipoConteudo.Text = string.Empty;
            txtIdConteudo.Text = string.Empty;
            TextoEstado.Text = string.Empty;
            textoNumVisualizacoes.Text = string.Empty;
            textoDataPub.Text = string.Empty;
            textoDuracao.Text = string.Empty;
            TextoAutorConteudo.Text = string.Empty;
            TextTituloVideo.Text = string.Empty;
            TextoNumLikes.Text = string.Empty;
        }



        //
        // Comentarios 
        // 
        private void btnCmentarios_Click(object sender, EventArgs e)
        {
            // Limpa os dados do painel 
            pnlContent.Controls.Clear();

            // Cria os controles para inserir os dados do utilizador
            Label lblNomeUser = new Label();
            lblNomeUser.Text = "Nome de Utilizador:";
            lblNomeUser.ForeColor = Color.White;
            lblNomeUser.Font = new Font(lblNomeUser.Font, FontStyle.Bold);
            lblNomeUser.Location = new Point(20, 10);
            lblNomeUser.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNomeUser);

            textUserComentario = new TextBox();
            textUserComentario.Location = new Point(200, 10);
            textUserComentario.Size = new Size(450, 40);
            pnlContent.Controls.Add(textUserComentario);

            Label IdConteudo = new Label();
            IdConteudo.Text = "Id Conteudo:";
            IdConteudo.ForeColor = Color.White;
            IdConteudo.Font = new Font(IdConteudo.Font, FontStyle.Bold);
            IdConteudo.Location = new Point(20, 50);
            IdConteudo.Size = new Size(180, 30);
            pnlContent.Controls.Add(IdConteudo);

            txtIdConteudoComent = new TextBox();
            txtIdConteudoComent.Location = new Point(200, 50);
            txtIdConteudoComent.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtIdConteudoComent);

            Label Comentario = new Label();
            Comentario.Text = "Comentário:";
            Comentario.ForeColor = Color.White;
            Comentario.Font = new Font(Comentario.Font, FontStyle.Bold);
            Comentario.Location = new Point(20, 90);
            Comentario.Size = new Size(180, 30);
            pnlContent.Controls.Add(Comentario);

            ComentText = new TextBox();
            ComentText.Location = new Point(200, 90);
            ComentText.Size = new Size(450, 40);
            pnlContent.Controls.Add(ComentText);

            Label DataComentario = new Label();
            DataComentario.Text = "Data do Comentário:";
            DataComentario.ForeColor = Color.White;
            DataComentario.Font = new Font(DataComentario.Font, FontStyle.Bold);
            DataComentario.Location = new Point(20, 130);
            DataComentario.Size = new Size(180, 30);
            pnlContent.Controls.Add(DataComentario);

            ComentDataText = new TextBox();
            ComentDataText.Location = new Point(200, 130);
            ComentDataText.Size = new Size(450, 40);
            pnlContent.Controls.Add(ComentDataText);

            Button enviarComentario = new Button();
            enviarComentario.Text = "Criar Comentário";
            enviarComentario.Font = new Font(enviarComentario.Font, FontStyle.Bold);
            enviarComentario.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarComentario.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarComentario.BackColor = Color.White; // Define a cor de fundo como branco
            enviarComentario.FlatStyle = FlatStyle.Flat;
            enviarComentario.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarComentario.Click += enviarComentario_Click;
            pnlContent.Controls.Add(enviarComentario);

            Button verComentarios = new Button();
            verComentarios.Text = "Ver Comentários";
            verComentarios.Font = new Font(verComentarios.Font, FontStyle.Bold);
            verComentarios.Size = new Size(200, 30); // Ajusta o tamanho do botão
            verComentarios.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 90);
            verComentarios.BackColor = Color.White; // Define a cor de fundo como branco
            verComentarios.FlatStyle = FlatStyle.Flat;
            verComentarios.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            verComentarios.Click += verComentarios_Click;
            pnlContent.Controls.Add(verComentarios);

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.Size = new Size(200, 30); // Ajusta o tamanho do botão
            clearPnlContent.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 50);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);


            Label TextCodigoP = new Label();
            TextCodigoP.Text = "A informação abaixo so é preenchida no caso do utilizador querer saber mais informações sobre os comentarios de algum conteudo.";
            TextCodigoP.ForeColor = Color.White;
            TextCodigoP.Font = new Font(TextCodigoP.Font, FontStyle.Bold);
            TextCodigoP.Location = new Point(20, 350);
            TextCodigoP.Size = new Size(650, 30);
            pnlContent.Controls.Add(TextCodigoP);

            Label lblCodigoP = new Label();
            lblCodigoP.Text = "Codigo Conteudo:";
            lblCodigoP.ForeColor = Color.White;
            lblCodigoP.Font = new Font(lblCodigoP.Font, FontStyle.Bold);
            lblCodigoP.Location = new Point(20, 390);
            lblCodigoP.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblCodigoP);

            CodigoC = new TextBox();
            CodigoC.Location = new Point(200, 390);
            CodigoC.Size = new Size(450, 40);
            pnlContent.Controls.Add(CodigoC);


            Button allComentarios = new Button();
            allComentarios.Text = "Ver Mais Sobre uma PlayList";
            allComentarios.Font = new Font(allComentarios.Font, FontStyle.Bold);
            allComentarios.Size = new Size(200, 30);
            allComentarios.Location = new Point(pnlContent.Width - 230, 390);
            allComentarios.BackColor = Color.White;
            allComentarios.FlatStyle = FlatStyle.Flat;
            allComentarios.FlatAppearance.BorderColor = Color.Black;
            allComentarios.Click += allComentarios_Click;
            pnlContent.Controls.Add(allComentarios);
        }
        public void enviarComentario_Click(object sender, EventArgs e)
        {
            //apos o user clicar no mentario em vez de dar clear a tudo como fazia antes mostrar o comentario ou seja dar clear dos buttons e das labels e dar print com o codigo do conteudo, nome do conteudo, user que comentou, comentario e data 
            string UserComentario = textUserComentario.Text;
            string idConteudo = txtIdConteudoComent.Text;
            string Comentario = ComentText.Text;
            string data = ComentDataText.Text;

            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(UserComentario) || string.IsNullOrWhiteSpace(idConteudo) ||
                string.IsNullOrWhiteSpace(Comentario) || string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            DateTime duracao = DateTime.Parse(data);
            int id = int.Parse(idConteudo);

            // Enviar os dados para o DataRepository
            bool sucesso = dataRepository.InserirComentario(UserComentario, Comentario, duracao, id);

            if (sucesso)
            {
                MessageBox.Show("Comentario criado com sucesso!");
                // Limpar os dados do painel
                pnlContent.Controls.Clear();

                clearPnlContent = new Button();
                clearPnlContent.Text = "Close";
                clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
                clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
                clearPnlContent.FlatStyle = FlatStyle.Flat;
                clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
                clearPnlContent.Size = new Size(80, 30);
                clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 50);
                clearPnlContent.Click += ClearPnlContent_Click;
                pnlContent.Controls.Add(clearPnlContent);

                // Obter os utilizadores do DataRepository
                DataTable utilizadores = dataRepository.ListarUmComentario(id);

                // Criar uma DataGridView para exibir os utilizadores
                DataGridView dgvUtilizadores = new DataGridView();
                dgvUtilizadores.DataSource = utilizadores;
                dgvUtilizadores.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(dgvUtilizadores);

            }
            else
            {
                MessageBox.Show("Erro ao criar o Comentario. Por favor, tente novamente.");
            }


        }
        public void verComentarios_Click(object sender, EventArgs e)
        {
            // Limpar os dados do painel
            pnlContent.Controls.Clear();

            clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 50);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

            // Obter os utilizadores do DataRepository
            DataTable utilizadores = dataRepository.ListarComentario();

            // Criar uma DataGridView para exibir os utilizadores
            DataGridView dgvUtilizadores = new DataGridView();
            dgvUtilizadores.DataSource = utilizadores;
            dgvUtilizadores.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(dgvUtilizadores);

        }
        public void allComentarios_Click(object sender, EventArgs e)
        {

            string idConteudo = CodigoC.Text;
            int id = int.Parse(idConteudo);
            // Limpar os dados do painel
            pnlContent.Controls.Clear();

            clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 50);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

            // Obter os utilizadores do DataRepository
            DataTable utilizadores = dataRepository.ListarUmComentario(id);

            // Criar uma DataGridView para exibir os utilizadores
            DataGridView dgvUtilizadores = new DataGridView();
            dgvUtilizadores.DataSource = utilizadores;
            dgvUtilizadores.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(dgvUtilizadores);



        }

        //
        // Playlist 
        // 
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            // Limpa os dados do painel 
            pnlContent.Controls.Clear();

            // Cria os controles para inserir os dados do utilizador
            Label lblNomeUser = new Label();
            lblNomeUser.Text = "Nome de Utilizador:";
            lblNomeUser.ForeColor = Color.White;
            lblNomeUser.Font = new Font(lblNomeUser.Font, FontStyle.Bold);
            lblNomeUser.Location = new Point(20, 10);
            lblNomeUser.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNomeUser);

            textUserPlaylistAutor = new TextBox();
            textUserPlaylistAutor.Location = new Point(200, 10);
            textUserPlaylistAutor.Size = new Size(450, 40);
            pnlContent.Controls.Add(textUserPlaylistAutor);

            Label TituloPlay = new Label();
            TituloPlay.Text = "Titulo PlayList:";
            TituloPlay.ForeColor = Color.White;
            TituloPlay.Font = new Font(TituloPlay.Font, FontStyle.Bold);
            TituloPlay.Location = new Point(20, 50);
            TituloPlay.Size = new Size(180, 30);
            pnlContent.Controls.Add(TituloPlay);

            txtTituloPlay = new TextBox();
            txtTituloPlay.Location = new Point(200, 50);
            txtTituloPlay.Size = new Size(450, 40);
            pnlContent.Controls.Add(txtTituloPlay);

            Label lblidPlayList = new Label();
            lblidPlayList.Text = "Id Playlist:";
            lblidPlayList.ForeColor = Color.White;
            lblidPlayList.Font = new Font(lblidPlayList.Font, FontStyle.Bold);
            lblidPlayList.Location = new Point(20, 90);
            lblidPlayList.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblidPlayList);

            idPlayList = new TextBox();
            idPlayList.Location = new Point(200, 90);
            idPlayList.Size = new Size(450, 40);
            pnlContent.Controls.Add(idPlayList);

            Label lblEstadoPlayList = new Label();
            lblEstadoPlayList.Text = "Estado:";
            lblEstadoPlayList.ForeColor = Color.White;
            lblEstadoPlayList.Font = new Font(lblEstadoPlayList.Font, FontStyle.Bold);
            lblEstadoPlayList.Location = new Point(20, 130);
            lblEstadoPlayList.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblEstadoPlayList);


            EstadoPlayList = new TextBox();
            EstadoPlayList.Location = new Point(200, 130);
            EstadoPlayList.Size = new Size(450, 40);
            pnlContent.Controls.Add(EstadoPlayList);


            Label TextCodigoP = new Label();
            TextCodigoP.Text = "A informação abaixo so é preenchida no caso do utilizador querer saber mais informações a cerca de alguma playlis, como por exemplo o conteudo, etc.";
            TextCodigoP.ForeColor = Color.White;
            TextCodigoP.Font = new Font(TextCodigoP.Font, FontStyle.Bold);
            TextCodigoP.Location = new Point(20, 350);
            TextCodigoP.Size = new Size(650, 30);
            pnlContent.Controls.Add(TextCodigoP);

            Label lblCodigoP = new Label();
            lblCodigoP.Text = "Codigo Playlist:";
            lblCodigoP.ForeColor = Color.White;
            lblCodigoP.Font = new Font(lblCodigoP.Font, FontStyle.Bold);
            lblCodigoP.Location = new Point(20, 390);
            lblCodigoP.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblCodigoP);

            CodigoP = new TextBox();
            CodigoP.Location = new Point(200, 390);
            CodigoP.Size = new Size(450, 40);
            pnlContent.Controls.Add(CodigoP);


            Button enviarPlayList = new Button();
            enviarPlayList.Text = "Criar PlayList";
            enviarPlayList.Font = new Font(enviarPlayList.Font, FontStyle.Bold);
            enviarPlayList.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarPlayList.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarPlayList.BackColor = Color.White; // Define a cor de fundo como branco
            enviarPlayList.FlatStyle = FlatStyle.Flat;
            enviarPlayList.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarPlayList.Click += enviarPlayList_Click;
            pnlContent.Controls.Add(enviarPlayList);

            Button verPlayList = new Button();
            verPlayList.Text = "Ver PlayLists Criadas";
            verPlayList.Font = new Font(verPlayList.Font, FontStyle.Bold);
            verPlayList.Size = new Size(200, 30); // Ajusta o tamanho do botão
            verPlayList.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 90);
            verPlayList.BackColor = Color.White; // Define a cor de fundo como branco
            verPlayList.FlatStyle = FlatStyle.Flat;
            verPlayList.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            verPlayList.Click += verPlayList_Click;
            pnlContent.Controls.Add(verPlayList);

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.Size = new Size(200, 30); // Ajusta o tamanho do botão
            clearPnlContent.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 50);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

            Button verPlayListCodigo = new Button();
            verPlayListCodigo.Text = "Ver Mais Sobre uma PlayList";
            verPlayListCodigo.Font = new Font(verPlayListCodigo.Font, FontStyle.Bold);
            verPlayListCodigo.Size = new Size(200, 30);
            verPlayListCodigo.Location = new Point(pnlContent.Width - 230, 390);
            verPlayListCodigo.BackColor = Color.White;
            verPlayListCodigo.FlatStyle = FlatStyle.Flat;
            verPlayListCodigo.FlatAppearance.BorderColor = Color.Black;
            verPlayListCodigo.Click += verPlayListCodigo_Click;
            pnlContent.Controls.Add(verPlayListCodigo);


        }
        public void enviarPlayList_Click(object sender, EventArgs e)
        {
            //apos o user clicar no criar em vez de dar clear a tudo como fazia antes mostrar a playlist ou seja dar clear dos buttons e das labels e dar print de uma tabela do comentario
            string UserPlaylistAutor = textUserPlaylistAutor.Text;
            string TituloPlayList = txtTituloPlay.Text;
            string CodigoPlayList = idPlayList.Text;
            string EstadoP = EstadoPlayList.Text;

            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(UserPlaylistAutor) || string.IsNullOrWhiteSpace(TituloPlayList) ||
                 string.IsNullOrWhiteSpace(CodigoPlayList) || string.IsNullOrWhiteSpace(EstadoP))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            int CodigoP = int.Parse(CodigoPlayList);
            int EstadoP2 = int.Parse(EstadoP);
            int Num_Likes = 0;

            bool sucesso = dataRepository.InserirPlayList(TituloPlayList, CodigoP, UserPlaylistAutor, Num_Likes, EstadoP2);


            if (sucesso)
            {
                MessageBox.Show("Playlist criada com sucesso.");
                LimparCamposPlaylist();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao criar a playlist.");
            }
        }
        public void verPlayList_Click(object sender, EventArgs e)
        {

            pnlContent.Controls.Clear();

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White;
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black;
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 90);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

            // Retrieve playlists from the database
            DataTable playlists = dataRepository.ListarPlayList();

            // Create a DataGridView to display the playlists
            DataGridView dgvUtilizadores = new DataGridView();
            dgvUtilizadores.DataSource = playlists;
            dgvUtilizadores.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(dgvUtilizadores);
        }

        public void verPlayListCodigo_Click(object sender, EventArgs e)
        {

            string codigoP = CodigoP.Text;

            int codigo = int.Parse(codigoP);

            if (string.IsNullOrWhiteSpace(codigoP))
            {
                MessageBox.Show("Por favor, preencha o campo para saber mais dados.");
                return;
            }


            pnlContent.Controls.Clear();

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White;
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black;
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 90);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);


            // Retrieve playlists from the database
            DataTable playlists2 = dataRepository.ListarConteudoPlaylist(codigo);

            // Create a DataGridView to display the playlists
            DataGridView dgvUtilizadores = new DataGridView();
            dgvUtilizadores.DataSource = playlists2;
            dgvUtilizadores.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(dgvUtilizadores);

        }


        public void LimparCamposPlaylist()
        {
            textUserPlaylistAutor.Text = "";
            txtTituloPlay.Text = "";
            idPlayList.Text = "";
            EstadoPlayList.Text = "";
        }

        //
        // Historico 
        // 
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            // Limpa os dados do painel 
            pnlContent.Controls.Clear();

            // Cria os controles para inserir os dados do utilizador
            Label lblNomeUser = new Label();
            lblNomeUser.Text = "Nome de Utilizador:";
            lblNomeUser.ForeColor = Color.White;
            lblNomeUser.Font = new Font(lblNomeUser.Font, FontStyle.Bold);
            lblNomeUser.Location = new Point(20, 10);
            lblNomeUser.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblNomeUser);

            textUserHistoricpOwner = new TextBox();
            textUserHistoricpOwner.Location = new Point(200, 10);
            textUserHistoricpOwner.Size = new Size(450, 40);
            pnlContent.Controls.Add(textUserHistoricpOwner);

            Label lblVideos = new Label();
            lblVideos.Text = "Conteudo Historico:\nInserir Ids separados ';' :";
            lblVideos.ForeColor = Color.White;
            lblVideos.Font = new Font(lblVideos.Font, FontStyle.Bold);
            lblVideos.Location = new Point(20, 50);
            lblVideos.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblVideos);

            VideosHistorico = new TextBox();
            VideosHistorico.Location = new Point(200, 50);
            VideosHistorico.Size = new Size(450, 40);
            pnlContent.Controls.Add(VideosHistorico);


            Label lblDatas = new Label();
            lblDatas.Text = "Datas Historico:\nInserir datas separados ';' :";
            lblDatas.ForeColor = Color.White;
            lblDatas.Font = new Font(lblDatas.Font, FontStyle.Bold);
            lblDatas.Location = new Point(20, 90);
            lblDatas.Size = new Size(180, 30);
            pnlContent.Controls.Add(lblDatas);

            DataHistorico = new TextBox();
            DataHistorico.Location = new Point(200, 90);
            DataHistorico.Size = new Size(450, 40);
            pnlContent.Controls.Add(DataHistorico);

            Button enviarHistoricos = new Button();
            enviarHistoricos.Text = "Criar Historico";
            enviarHistoricos.Font = new Font(enviarHistoricos.Font, FontStyle.Bold);
            enviarHistoricos.Size = new Size(200, 30); // Ajusta o tamanho do botão
            enviarHistoricos.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 130);
            enviarHistoricos.BackColor = Color.White; // Define a cor de fundo como branco
            enviarHistoricos.FlatStyle = FlatStyle.Flat;
            enviarHistoricos.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            enviarHistoricos.Click += enviarHistoricos_Click;
            pnlContent.Controls.Add(enviarHistoricos);

            Button verHistoricos = new Button();
            verHistoricos.Text = "Ver Historicos";
            verHistoricos.Font = new Font(verHistoricos.Font, FontStyle.Bold);
            verHistoricos.Size = new Size(200, 30); // Ajusta o tamanho do botão
            verHistoricos.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 90);
            verHistoricos.BackColor = Color.White; // Define a cor de fundo como branco
            verHistoricos.FlatStyle = FlatStyle.Flat;
            verHistoricos.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            verHistoricos.Click += verHistoricos_Click;
            pnlContent.Controls.Add(verHistoricos);

            Button clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.Size = new Size(200, 30); // Ajusta o tamanho do botão
            clearPnlContent.Location = new Point(pnlContent.Width - 230, pnlContent.Height / 2 - 50);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);
        }
        public void enviarHistoricos_Click(object sender, EventArgs e)
        {
            //apos o user clicar no criar em vez de dar clear a tudo como fazia antes mostrar a playlist ou seja dar clear dos buttons e das labels e dar print de uma tabela do comentario
            string userHistorico = textUserHistoricpOwner.Text;
            string data = DataHistorico.Text;
            string videos = VideosHistorico.Text;

            // Verificar se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(userHistorico) || string.IsNullOrWhiteSpace(data) ||
                string.IsNullOrWhiteSpace(videos))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Enviar os dados para o DataRepository
            /*bool sucesso = dataRepository.InserirHistoricos(tipoConteudo, idConteudo, EstadoConteudo, ViewsConteudo, pubConteudo, DuracaoConteudo, AutorConteudo, TituloConteudo, likesConteudo);

             if (sucesso)
             {
                 MessageBox.Show("Utilizador criado com sucesso!");
                 // Limpar os dados do painel
                pnlContent.Controls.Clear();

                clearPnlContent = new Button();
                clearPnlContent.Text = "Close";
                clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
                clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
                clearPnlContent.FlatStyle = FlatStyle.Flat;
                clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
                clearPnlContent.Size = new Size(80, 30);
                clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 50);
                clearPnlContent.Click += ClearPnlContent_Click;
                pnlContent.Controls.Add(clearPnlContent);


             }
             else
             {
                 MessageBox.Show("Erro ao criar o utilizador. Por favor, tente novamente.");
             }*/


        }
        public void verHistoricos_Click(object sender, EventArgs e)
        {
            // Limpar os dados do painel
            pnlContent.Controls.Clear();

            // Obter os utilizadores do DataRepository
            /* DataTable utilizadores = dataRepository.ListarHistoricos();

             // Criar uma DataGridView para exibir os utilizadores
             DataGridView dgvUtilizadores = new DataGridView();
             dgvUtilizadores.DataSource = utilizadores;
             dgvUtilizadores.Dock = DockStyle.Fill;
             pnlContent.Controls.Add(dgvUtilizadores);*/

            clearPnlContent = new Button();
            clearPnlContent.Text = "Close";
            clearPnlContent.Font = new Font(clearPnlContent.Font, FontStyle.Bold);
            clearPnlContent.BackColor = Color.White; // Define a cor de fundo como branco
            clearPnlContent.FlatStyle = FlatStyle.Flat;
            clearPnlContent.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda como preta
            clearPnlContent.Size = new Size(80, 30);
            clearPnlContent.Location = new Point(pnlContent.Width - 100, pnlContent.Height - 50);
            clearPnlContent.Click += ClearPnlContent_Click;
            pnlContent.Controls.Add(clearPnlContent);

        }

        // Limpar tudo botao close geral

        private void ClearPnlContent_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
        }
    }
}