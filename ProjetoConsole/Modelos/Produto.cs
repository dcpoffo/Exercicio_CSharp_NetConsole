using System.ComponentModel.DataAnnotations;

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
     }


}