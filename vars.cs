using System;
using System.IO;
using System.Data.SqlServerCe;

namespace ControleAcesso2019
{
     public static partial class Vars
     {
        

        public static string pasta_dados;
        public static string base_dados;
        public static string pasta_dados_LocalPC;
        public static string baseDadosLocal;

        public static void Iniciar()
        {

            //@"\\ARCH\Banco Dados\Registros_Colaboradores\";

            //pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Registros_Colaboradores\";
            pasta_dados = @"..\..\base_dados\";

            if (!Directory.Exists(pasta_dados))
            {
                    Directory.CreateDirectory(pasta_dados);
            }

                base_dados = pasta_dados + "Dados_Colaboradores.sdf ; Password = ControleCJLCacesso2019online";
            if (!File.Exists(pasta_dados + "Dados_Colaboradores.sdf"))
            {
                    CriaBaseDados();
            }

            pasta_dados_LocalPC = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AcessoLocal_Porao\";
            if (!Directory.Exists(pasta_dados))
            {
                Directory.CreateDirectory(pasta_dados);
            }

            baseDadosLocal = pasta_dados + "Dados_Porao.sdf ; Password = ControleCJLCacesso2019online";
            if (!File.Exists(pasta_dados + "Dados_Porao.sdf"))
            {
                CriaBaseDadosLocalAcesso();
            }

        }

        public static void CriaBaseDados()
        {
            // cria base de dados
            SqlCeEngine motor = new SqlCeEngine("Data Source =" + base_dados);
            motor.CreateDatabase();

            // cria estrutura da base de dados
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + base_dados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE RegistrosColaboradores("                       +
                                  "id_Registros      int identity(1,1) primary key," +
                                  "id_NP             nvarchar(20) not null,"                   +
                                  "id_TagRFID        nvarchar(10) not null,"                   +
                                  "Nome              nvarchar(50) not null,"                   +
                                  "Facilitador       nvarchar(50) not null,"                   +
                                  "Gerente           nvarchar(50) not null)";
            comando.Connection = conexao;
            comando.ExecuteNonQuery();

            comando.CommandText = "CREATE TABLE HistoricoAcesso("                              +
                                  "id_Historico     int identity(1,1) primary key," +
                                  "id_Registros     int not null,"                             +
                                  "id_NP            nvarchar(20) not null,"                    +
                                  "id_TagRFID       nvarchar(10) not null,"                    +
                                  "EntradaSaida     bit not null,"                             +
                                  "Horario          datetime not null,"                        +
                                  "Local            nvarchar(50) not null,"                    +
                                  "FOREIGN KEY(id_Registros) REFERENCES RegistrosColaboradores(id_Registros) ON DELETE CASCADE)";
            comando.ExecuteNonQuery();

            comando.CommandText = "CREATE TABLE Acessando("                                    +
                                  "id_Acessando      int identity(1,1) primary key," +
                                  "id_Registros      int not null,"                            +
                                  "id_NP             nvarchar(20)  not null, "                 +
                                  "id_TagRFID        nvarchar(10)  not null, "                 +
                                  "EntradaSaida      bit  not null, "                          +
                                  "Horario           datetime  not null,     "                 +
                                  "Local             nvarchar(50)  not null, "                 +
                                  "FOREIGN KEY(id_Registros) REFERENCES RegistrosColaboradores(id_Registros) ON DELETE CASCADE)";

            comando.ExecuteNonQuery();

            comando.CommandText = "CREATE TABLE Admin (" +
                                  "Usuario      nvarchar(20) not null," +
                                  "Senha       nvarchar(10) not null)";

            comando.ExecuteNonQuery();


        }

        public static void CriaBaseDadosLocalAcesso()
        {

            SqlCeEngine criaBancoDados = new SqlCeEngine(@"Data Source =" + baseDadosLocal);
            criaBancoDados.CreateDatabase();

            SqlCeConnection conexao = new SqlCeConnection(@"Data Source =" + baseDadosLocal);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = conexao;

            comando.CommandText = "CREATE TABLE LocalAcesso (" +
                                   "Local_Acesso nvarchar(50))";

            comando.ExecuteNonQuery();
        }
    }
}
