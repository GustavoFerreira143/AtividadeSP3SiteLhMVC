using System.Globalization;

namespace LhPets.Models{
    public class Usuarios{
 public int Id{get;set;}
 public string Nome{get;set;}
 public string CPf{get;set;}
 public string Email { get; set; }
 public string Paciente { get; set; }
  public Usuarios(int id,string nome,string cpf,string email,string paciente)
 {
    this.Id=id;
    this.Nome=nome;
    this.CPf=cpf;
    this.Email=email;
    this.Paciente=paciente;
 }

}
}