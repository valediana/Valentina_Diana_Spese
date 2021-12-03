using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneSpese.Core.BusinessLayer;
using GestioneSpese.Core.Entities;
using GestioneSpese.Core.Interfaces;

namespace GestioneSpese.Core.Interfaces
{
    public interface ISpesaRepo : IMockRepository<Spesa>
    {
        bool Add(Spesa nuovaSpesa);
        List<Spesa> FetchAll();
        List<Spesa> GetByIdUtente(int id);
        List<decimal> GetByIdCat(int id);
        List<Spesa> GetByData();
        List<Spesa> FetchAllByData();
    }
}
