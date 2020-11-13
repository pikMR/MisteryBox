using MisteryBoxDomain.Entities;
using MisteryBoxDomain.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MisteryBoxInfraestructure.Services
{
    public class ServiceTecnologia : IServiceTecnologia
    {
        public Task Add(Tecnologia entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<Tecnologia, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Tecnologia> FirstOrDefault(Expression<Func<Tecnologia, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tecnologia>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tecnologia>> GetAllTecnologias()
        {
            throw new NotImplementedException();
        }

        public Task<Tecnologia> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tecnologia>> GetWhere(Expression<Func<Tecnologia, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Tecnologia entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Tecnologia entity)
        {
            throw new NotImplementedException();
        }
    }
}
