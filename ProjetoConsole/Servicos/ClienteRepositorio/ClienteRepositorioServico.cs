using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoConsole.Modelos
{
     public class ClienteRepositorioServico : IRepositorioCliente
     {
          public List<Cliente> ListaDeClientes { get; set; }

          public ClienteRepositorioServico()
          {
               this.ListaDeClientes = new List<Cliente>();
          }

          public void Incluir(Cliente cliente)
          {
               this.ListaDeClientes.Add(cliente);
          }

          public void Excluir(int id)
          {
               this.ListaDeClientes.RemoveAll(cli => cli.Id == id);
          }

          public List<Cliente> ObterTodos()
          {
               return ListaDeClientes;
          }

          public Cliente ObterPeloId(int id)
          {
               return this.ListaDeClientes.Where(cli => cli.Id == id).FirstOrDefault();
          }

          public string ObterClienteEListaDeProdutos(int idCliente, ProdutoRepositorioServico produtoServico)
          {               
               StringBuilder sb = new StringBuilder();
               foreach (var cliente in ListaDeClientes.Where(c => c.Id == idCliente))
               {
                    sb.AppendLine("------------------------------------------------------------------");                    
                    sb.AppendLine("CLIENTE");
                    sb.AppendLine("------------------------------------------------------------------");
                    sb.AppendLine(cliente.ToString());
                    sb.AppendLine("------------------------------------------------------------------");
                    sb.AppendLine("PRODUTOS");
                    sb.AppendLine("------------------------------------------------------------------");
                    foreach (var produto in produtoServico.ListaDeProdutos.Where(pc => pc.IdCliente == idCliente))
                    {
                         sb.AppendLine(produto.ToString());
                    }
               }
               return sb.ToString();
          }
     }
}