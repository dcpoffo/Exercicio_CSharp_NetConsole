using System.Collections.Generic;

namespace ProjetoConsole.Modelos
{
    public interface IRepositorioCliente
    {
        void Incluir(Cliente cliente);
        void Excluir(int id);
        List<Cliente> ObterTodos();
        Cliente ObterPeloId(int id);
        string ObterClienteEListaDeProdutos(int idCliente, ProdutoRepositorioServico produtoServico);
    }
}