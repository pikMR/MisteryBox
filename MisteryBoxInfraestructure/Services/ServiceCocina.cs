using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MisteryBoxDomain.Entities;
using MisteryBoxDomain.Interfaces;
using MisteryBoxDomain.Services;

namespace MisteryBoxInfraestructure.Services
{
    public class ServiceCocina : IServiceCocina
    {
        ICocinaRepository _repository;
        public ServiceCocina(ICocinaRepository repository)
        {
            _repository = repository;
        }

        public Task Add(Cocina entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<Cocina, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Cocina> FirstOrDefault(Expression<Func<Cocina, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cocina>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Cocina> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<IEnumerable<Cocina>> GetWhere(Expression<Func<Cocina, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Cocina entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Cocina entity)
        {
            throw new NotImplementedException();
        }
    }
}
