using System.Collections.Generic;
using System.Linq;

namespace ProjetoConsole.Modelos
{
     public class ProdutoRepositorioServico : IRepositorioProduto
     {
          public List<Produto> ListaDeProdutos { get; set; }

          public ProdutoRepositorioServico()
          {
              this.ListaDeProdutos = new List<Produto>();
          }

          public void Incluir(Produto produto)
          {               
               this.ListaDeProdutos.Add(produto);
          }

          public void Excluir(int id)
          {
               this.ListaDeProdutos.RemoveAll(pro => pro.Id == id);
          }

          public List<Produto> ObterTodos()
          {
               return this.ListaDeProdutos;
          }

          public Produto ObterPeloId(int id)
          {
               return this.ListaDeProdutos.Where(pro => pro.Id == id).FirstOrDefault();
          }

          public List<Produto> ObterPeloIdDoCliente(int idCliente)
          {               
               return this.ListaDeProdutos.Where(pro => pro.IdCliente == idCliente).ToList();
          }
     }
}