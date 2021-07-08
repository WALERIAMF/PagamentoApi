using System.Collections.Generic;

namespace PagamentoDomain.IRepository
{
    public interface IRepositoryBase<T> where T : class
    {
        void Adicionar(T obj);
        void Salvar(T obj);
        void Deletar(T obj);
        T BuscarPorId(string id);
        IEnumerable<T> BuscarTodos();

    }
}
