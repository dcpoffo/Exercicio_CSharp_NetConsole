using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ProjetoConsole.Modelos
{
     public class Produto
     {
          [Key]
          public int Id { get; set; }
          public string Descricao { get; set; }
          public double Valor { get; set; }
          public int IdCliente { get; set; }

          public Produto(int _id, string _descricao, double _valor, int _idCliente)
          {
              this.Id = _id;
              this.Descricao = _descricao;
              this.Valor = _valor;
              this.IdCliente = _idCliente;
          }

          public override string ToString()
          {
               return 
               "**** ID: " + Id + 
               " - " + 
               "Descrição: " + Descricao +
               " - " + 
               "Valor: RS " + Valor.ToString("F2",CultureInfo.InvariantCulture);
                //+ " - IdCliente: " + IdCliente;
          }
     }


}