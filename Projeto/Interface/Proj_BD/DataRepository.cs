using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proj_BD
{
    public class DataRepository
    {
        private SqlConnection connection;

        public DataRepository()
        {
            connection = getConnection();
        }

        private SqlConnection getConnection()
        {
            return new SqlConnection("data Source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;initial Catalog = p8g8;uid = p8g8;password = Lol.008#");
        }

        private bool verifyConnection()
        {
            if (connection == null)
                connection = getConnection();

            if (connection.State != ConnectionState.Open)
                connection.Open();


            return (connection.State == ConnectionState.Open);
        }






        /// /////////////////////////////////////// Mudar Queries ////////////////////////////////////////
        public DataTable ProcurarUser(string username)
        {

            if (!verifyConnection())
            {
                MessageBox.Show("No Connection!");
                return null;
            }

            string query = "SELECT cn.Nome_Utilizador AS NomeCanal, cn.Num_Subscritores, cn.Num_conteudo, c.Titulo AS TituloConteudo, c.Tipo AS TipoConteudo, c.Num_Likes AS LikesConteudo, c.Num_Views AS VisualizaçõesConteudo, c.Duracao AS DuraçãoConteudo, c.Data_Pub AS DataPublicaçãoConteudo, com.Autor AS AutorComentário, com.Texto AS TextoComentário, com.Data_Comentário AS DataComentário, com2.Autor AS AutorComentárioVídeo, com2.Texto AS TextoComentárioVídeo, com2.Data_Comentário AS DataComentárioVídeo FROM [p5g2].[Youtube].[Canal] cn INNER JOIN [p5g2].[Youtube].[Conteúdo] c ON cn.Nome_Utilizador = c.Autor LEFT JOIN [p5g2].[Youtube].[Comentários] com ON com.Codigo = c.Codigo AND com.Autor = cn.Nome_Utilizador LEFT JOIN [p5g2].[Youtube].[Comentários] com2 ON com2.Codigo = c.Codigo";

            if (!string.IsNullOrEmpty(username))
            {
                query += " WHERE cn.Nome_Utilizador = @NomeCanal";
            }
            query += " ORDER BY cn.Nome_Utilizador, c.Titulo";


            // Execute a consulta e obtenha os resultados
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            if (!string.IsNullOrEmpty(username))
                            {
                                command.Parameters.AddWithValue("@NomeCanal", username);
                            }
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            return dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }

        }

        // Utilzadores
        public bool InserirUtilizador(int nifP, string nomePessoa, DateTime nascimentoText, string email, string morada, int tel, int nifE)
        {
            try
            {
                if (!verifyConnection())
                    return false;

                string query = "INSERT INTO [p8g8].[Higiliquidos].[Pessoa] (NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico, NIF_Empresa) " +
                               "VALUES (@NIF, @Nome, @Data_de_Nascimento, @Email, @Morada, @ContactoTelefonico, @NIF_Empresa)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NIF", nifP);
                    command.Parameters.AddWithValue("@Nome", nomePessoa);
                    command.Parameters.AddWithValue("@Data_de_Nascimento", nascimentoText);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Morada", morada);
                    command.Parameters.AddWithValue("@ContactoTelefonico", tel);
                    command.Parameters.AddWithValue("@NIF_Empresa", nifE);


                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir utilizador: " + ex.Message);
                return false;
            }
        }



        public DataTable ListarPessoas()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Pessoa]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarClientes()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Cliente]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarFunc()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Funcionario]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarVendedores()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Vendedor]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarFornecedores()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Fornecedor]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarGerentes()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Gerente]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarDistribuidores()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Distribuidor]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarEmpresa()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Empresa]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarVendas()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Venda]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarCompras()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Compra]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarProdutos()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Produto]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarArmazens()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Armazem]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarCarrinhas()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p8g8].[Higiliquidos].[Carrinha]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }


        // Conteudo
        public bool InserirConteudo(string tipoConteudo, int id, string EstadoConteudo, int views, DateTime pub, TimeSpan duracao, string AutorConteudo, string TituloConteudo, int likes)
        {
            try
            {
                if (!verifyConnection())
                    return false;

                string query = "INSERT INTO [p5g2].[Youtube].[Conteúdo] (Titulo, Codigo, Autor, Tipo, Estado, Duracao, Num_Likes, Num_Views, Data_Pub) " +
                               "VALUES (@Titulo, @id, @autor, @Tipo, @estado, @dura, @Likes, @views, @pub)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titulo", TituloConteudo);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@autor", AutorConteudo);
                    command.Parameters.AddWithValue("@Tipo", tipoConteudo);
                    command.Parameters.AddWithValue("@estado", EstadoConteudo);
                    command.Parameters.AddWithValue("@dura", duracao);
                    command.Parameters.AddWithValue("@Likes", likes);
                    command.Parameters.AddWithValue("@views", views);
                    command.Parameters.AddWithValue("@pub", pub);


                    int rowsAffected = command.ExecuteNonQuery();

                    // apagar a proxima linha de codigo esta ca so para testes
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir utilizador: " + ex.Message);
                return false;
            }
        }
        public DataTable ListarConteudo()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p5g2].[Youtube].[Conteúdo]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter Comentarios: " + ex.Message);
                return null;
            }
        }

        // Comentario
        public bool InserirComentario(string Autor, string Texto, DateTime Data_Comentário, int CódigoV)
        {
            //apos o user clicar no mentario em vez de dar clear a tudo como fazia antes mostrar o comentario ou seja dar clear dos buttons e das labels e dar print com o codigo do conteudo, nome do conteudo, user que comentou, comentario e data 


            try
            {
                if (!verifyConnection())
                    return false;

                string query = "INSERT INTO Youtube.Comentários (Autor,Texto,Data_Comentário,CódigoV) " +
                               "VALUES (@Autor, @Texto, @Data_Comentário, @CódigoV)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Autor", Autor);
                    command.Parameters.AddWithValue("@Texto", Texto);
                    command.Parameters.AddWithValue("@Data_Comentário", Data_Comentário);
                    command.Parameters.AddWithValue("@CódigoV", CódigoV);

                    int rowsAffected = command.ExecuteNonQuery();
                    // apagar a proxima linha de codigo esta ca so para testes
                    return rowsAffected > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir utilizador: " + ex.Message);
                return false;
            }
        }
        public DataTable ListarComentario()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p5g2].[Youtube].[Comentários]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        public DataTable ListarUmComentario(int idConteudo)
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT c.Titulo AS NomeConteudo, c.Tipo AS TipoConteudo, cn.Nome_Utilizador AS AutorConteudo, c.Data_Pub, c.Num_Views, c.Num_Likes, u.Nome_Utilizador AS NomeUtilizador, com.Texto AS Comentario, com.Data_Comentário FROM Youtube.Conteúdo c INNER JOIN Youtube.Canal cn ON c.Autor = cn.Nome_Utilizador INNER JOIN Youtube.Comentários com ON com.CódigoV = c.Codigo INNER JOIN Youtube.Utilizador u ON u.Nome_Utilizador = com.Autor WHERE c.Codigo = @idConteudo;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idConteudo", idConteudo);

                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao obter Comentarios: " + ex.Message);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }

        // PlayList
        public bool InserirPlayList(String Titulo, int CodigoP, String Autor, int Num_Likes, int EstadoP)
        {
            //apos o user clicar no mentario em vez de dar clear a tudo como fazia antes mostrar o comentario ou seja dar clear dos buttons e das labels e dar print com o codigo do conteudo, nome do conteudo, user que comentou, comentario e data 
            try
            {
                if (!verifyConnection())
                    return false;

                string query = "INSERT INTO Youtube.Playlist (Titulo, CodigoP, Autor, Num_Likes, Estado) " +
                               "VALUES (@TituloPlaylist, @CodigoP, @AutorPlaylist,  @Num_Likes, @Estado)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TituloPlaylist", Titulo);
                    command.Parameters.AddWithValue("@CodigoP", CodigoP);
                    command.Parameters.AddWithValue("@AutorPlaylist", Autor);
                    command.Parameters.AddWithValue("@Num_Likes", Num_Likes);
                    command.Parameters.AddWithValue("@Estado", EstadoP);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir playlist: " + ex.Message);
                return false;
            }
        }
        public DataTable ListarPlayList()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p5g2].[Youtube].[Playlist]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter playlists: " + ex.Message);
                return null;
            }
        }


        public DataTable ListarConteudoPlaylist(int CodigoP)
        {

            //by the code of the playlist we can see the content of the playlist
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT C.Codigo, C.Titulo, C.Autor, C.Tipo, C.Estado, C.Dura, C.Num_Likes, C.Num_Views, C.Data_Pub FROM Youtube.Conteúdo AS C INNER JOIN Youtube.PlaylistVideo AS PV ON C.Codigo = PV.VideoID WHERE PV.PlaylistID = @playlistID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@playlistID", CodigoP);
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao obter Comentarios: " + ex.Message);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter conteudo da playlist: " + ex.Message);
                return null;
            }

        }

        // Historicos
        public bool InserirHistorico()
        {
            //apos o user clicar no mentario em vez de dar clear a tudo como fazia antes mostrar o comentario ou seja dar clear dos buttons e das labels e dar print com o codigo do conteudo, nome do conteudo, user que comentou, comentario e data 

            try
            {
                if (!verifyConnection())
                    return false;

                string query = "INSERT INTO Youtube.Histórico (Titulo,Codigo,Data_de_Visualização) " +
                               "VALUES (@Titulo, @Codigo, @Data_de_Visualização)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {/*
                    command.Parameters.AddWithValue("@Titulo", tipoConteudo);
                    command.Parameters.AddWithValue("@Codigo", idConteudo);
                    command.Parameters.AddWithValue("@Data_de_Visualização", EstadoConteudo);
                    command.Parameters.AddWithValue("@Data_de_Visualização", ViewsConteudo);
                    */
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir utilizador: " + ex.Message);
                return false;
            }
        }
        public DataTable ListaHistoricos()
        {
            try
            {
                if (!verifyConnection())
                {
                    Console.WriteLine("No Connection!");
                    return null;
                }

                string query = "SELECT * FROM [p5g2].[Youtube].[Historicos]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter utilizadores: " + ex.Message);
                return null;
            }
        }
        public void FecharConexao()
        {
            connection.Close();
        }
    }
}
