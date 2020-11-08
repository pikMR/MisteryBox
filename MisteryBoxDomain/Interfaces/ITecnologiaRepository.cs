using MisteryBoxDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MisteryBoxDomain.Interfaces
{
    public interface ITecnologiaRepository : IAsyncRepository<Tecnologia>
    {
        Task<IEnumerable<Tecnologia>> GetAllTecnologias();
    }
}
