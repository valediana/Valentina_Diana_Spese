using GestioneSpese.Core.Entities;
using GestioneSpese.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Core.MockRepositories
{
    public class UtenteMockRepo : IUtenteRepo
    {
        public bool Add(Utente item)
        {
            throw new NotImplementedException();
        }

        public List<Utente> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Utente item)
        {
            throw new NotImplementedException();
        }
    }
}
