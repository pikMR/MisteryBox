
using MisteryBoxDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MisteryBoxDomain.Interfaces
{
    public interface ICocinaRepository : IAsyncRepository<Cocina>
    {
        //Task<IEnumerable<Cocina>> GetAllCocinas();
    }
}
