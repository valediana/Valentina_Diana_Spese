using GestioneSpese.Core.Entities;
using GestioneSpese.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Core.MockRepositories
{
    public class CategoriaMockRepo : ICategoriaRepo
    {
        public bool Add(Categoria item)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Categoria GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categoria item)
        {
            throw new NotImplementedException();
        }
    }
}
