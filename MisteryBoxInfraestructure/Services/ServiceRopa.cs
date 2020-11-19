using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MisteryBoxDomain.Entities;
using MisteryBoxDomain.Interfaces;
using MisteryBoxDomain.Services;

namespace MisteryBoxInfraestructure.Services
{
    public class ServiceRopa : IServiceRopa
    {
        IRopaRepository _repository;
        public ServiceRopa(IRopaRepository repository)
        {
            _repository = repository;
        }

        public Task Add(Ropa entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<Ropa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Ropa> FirstOrDefault(Expression<Func<Ropa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ropa>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Ropa> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ropa>> GetWhere(Expression<Func<Ropa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Ropa entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Ropa entity)
        {
            throw new NotImplementedException();
        }
    }
}
