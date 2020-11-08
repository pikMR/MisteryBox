
using MisteryBoxDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MisteryBoxDomain.Interfaces
{
    public interface IRopaRepository :IAsyncRepository<Ropa>
    {
        Task<IEnumerable<Ropa>> GetAllRopas();
    }
}
