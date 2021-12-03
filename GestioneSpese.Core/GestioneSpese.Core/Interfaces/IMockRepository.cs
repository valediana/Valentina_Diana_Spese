using GestioneSpese.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Core.Interfaces
{
    public interface IMockRepository<T>
    {
        List<T> FetchAll();
        T GetById(int id);
        bool Add(T item);
        bool Update(T item);

        //bool Delete(T item);
    }
}
