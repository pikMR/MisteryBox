using MisteryBoxDomain.Entities;
using MisteryBoxDomain.Interfaces;
using MisteryBoxInfraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisteryBoxInfraestructure.Models.Data
{
    public class TecnologiaRepository : EfRepository<Tecnologia>, ITecnologiaRepository
    {
        public TecnologiaRepository(Context context) : base(context) { }
        public Task<IEnumerable<Tecnologia>> GetAllTecnologias() => GetAll();
    }
}
