using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmissionPortal.Infra.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SisContext _sisContext;

        public GenericRepository(SisContext sisContext)
        {
            _sisContext = sisContext;
        }

        public Task Add(T entity)
        {
            _sisContext.Set<T>().Add(entity);
            return Task.CompletedTask;
        }

        public void Delete(T entity)
        {
            _sisContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _sisContext.Set<T>().AsNoTracking();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
