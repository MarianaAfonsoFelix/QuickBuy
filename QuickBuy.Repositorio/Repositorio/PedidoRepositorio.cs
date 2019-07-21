using System.Collections.Generic;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Repositorio
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio()
        {

        }

        public void Adicionar(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        Produto IBaseRepositorio<Produto>.ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Produto> IBaseRepositorio<Produto>.ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
