/*using System.ComponentModel;
using System.Data.SqlClient;
    namespace LhPets.Models
    {
        
      class Banco : Usuarios{

public List<Usuarios> lista=new List<Usuarios>();
public List<Usuarios> GetLista(){
    return lista;
}
public Banco (){

      try
      {
        SqlConnectionStringBuilder builder=new SqlConnectionStringBuilder(
          "User Id=Gustavo;Password=12345;"+
          "Database=BancoLh;"+
          "Server=localhost\\SQLEXPRESS;"+
          "Trusted_Connection=False;"
        );
        using (SqlConnection conexao=new SqlConnection(builder.ConnectionString)){
          string sql="Select * FROM n1;";
          using(SqlCommand comando=new SqlCommand(sql,conexao)){
            conexao.Open();
            using(SqlDataReader leitor=comando.ExecuteReader()){

              while(leitor.Read()){
                lista.Add(new Usuarios(){
                Id=int.Parse(leitor["id"].ToString()),
                Nome=leitor["nome"].ToString(),
                Email=leitor["email"].ToString(),
                CPf=leitor["cpf"].ToString(),
                Paciente=leitor["paciente"].ToString()
              });
              }
            }
          }
        }
      }
      catch (Exception e)
      {
        System.Console.WriteLine("Erro "+e.ToString());
        
      }
       }

        public string GetListaString()
        {
            string enviar = "<!DOCTYPE html>\n<html>\n<head>\n<meta charset='utf-8' />\n" +
                          "<title>Cadastro de Usuarios</title>\n</head>\n<body>";
            enviar = enviar + "<b> -  CPF    -      Nome    -    Email    -   RG  - Paciente   </b>";
            foreach (Usuarios i in GetLista())
            {
                enviar = enviar +
                "\n<br><div>" +
                                "\n<p>"+"ERRo"+i.Id +"\n</p>"+ " - " +
                          i.Nome + " - " +
                                 i.Email + " - " +
                                                   i.CPf + " - " +
                                                                  i.Paciente + " - " +
                                                                                    "<br>\n</div>\n</body>";
                
            }
           return enviar;
        }
        	public void imprimirListaConsole(){

                Console.WriteLine("   CPF / CNPJ   " + " - " + "    Nome   " + 
                    " - " + "   Endereço   " + " - " + "  RG / IE  " + " - " +
                    "  Tipo " + " - " + "  Valor  " + " - " + "Valor Imposto" + 
                    " - " + "  Total  ");

                foreach (Usuarios cli in GetLista())
                {
                    Console.WriteLine(cli.CPf+ " - " + 
                    cli.Nome
                     + " - " + cli.Email + " - " + cli.Paciente + " - " +
                    cli.Id + " - ");
                }
        }

    }

    }*/