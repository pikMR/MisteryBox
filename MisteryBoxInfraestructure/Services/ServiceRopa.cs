using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MisteryBoxDomain.Entities;
using MisteryBoxDomain.Services;

namespace MisteryBoxInfraestructure.Services
{
    class ServiceRopa : IServiceRopa
    {
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
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ropa>> GetAllRopas()
        {
            throw new NotImplementedException();
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
