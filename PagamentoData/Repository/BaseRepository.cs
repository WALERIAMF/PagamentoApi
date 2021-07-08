using Microsoft.EntityFrameworkCore;
using PagamentoDomain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using Context = PagamentoData.Context;

namespace PagamentoData.Repository
{
    public abstract class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        private readonly Context.Context _context;

        public BaseRepository(Context.Context context)
        {
            _context = context;
        }


        public void Adicionar(T obj)
        {
            try
            {
                _context.Set<T>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T BuscarPorId(string id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> BuscarTodos()
        {
            return _context.Set<T>().ToList();
        }

        public void Deletar(T id)
        {
            try
            {
                _context.Set<T>().Remove(id);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Salvar(T obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
