using System.Collections.Generic;

namespace ProjetoConsole.Modelos
{
     public interface IRepositorioProduto
     {
         void Incluir(Produto produto);
         void Excluir(int id);
         List<Produto> ObterTodos();
         Produto ObterPeloId(int id);
         List<Produto> ObterPeloIdDoCliente(int idCliente);
     }
}