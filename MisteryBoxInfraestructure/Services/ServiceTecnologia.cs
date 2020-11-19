using MisteryBoxDomain.Entities;
using MisteryBoxDomain.Interfaces;
using MisteryBoxDomain.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MisteryBoxInfraestructure.Services
{
    public class ServiceTecnologia : IServiceTecnologia
    {
        ITecnologiaRepository _repository;
        public ServiceTecnologia(ITecnologiaRepository repository)
        {
            _repository = repository;
        }

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
            return _repository.GetAll();
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
