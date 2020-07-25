using System.ComponentModel.DataAnnotations;

namespace ProjetoConsole.Modelos
{
     public class Cliente
     {
          [Key]
          public int Id { get; set; }
          public string Nome { get; set; }

          public Cliente(int _id, string _nome)
          {
              this.Id = _id;
              this.Nome = _nome;
          }

          public override string ToString()
          {
               return 
               "**** ID: " + Id + 
               " - " + 
               "Nome: " + Nome;
          }
     }
}