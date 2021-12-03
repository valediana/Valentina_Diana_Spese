using GestioneSpese.Core.Entities;
using GestioneSpese.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneSpese.Core.MockRepositories;


namespace GestioneSpese.Core.MockRepositories
{
    public class SpesaMockRepo : ISpesaRepo
    {
        public bool Add(Spesa item)
        {
            List<Spesa> spese = FetchAll();
            spese.Add(item);
            return item.Approvato = false;
        }

        public List<Spesa> FetchAll()
        {
            List<Spesa> speseTot = InMemoryStorage.spese;
            return speseTot;
        }

        public List<Spesa> FetchAllByData()
        {
            IEnumerable<Spesa> speseNovembre =
               from s in InMemoryStorage.spese
               where (s.Data.Month==(DateTime.Now.Date.Month-1) && s.Approvato==true)
               select s;
            return speseNovembre.ToList();
        }

        public List<Spesa> GetByData()
        {
            IEnumerable<Spesa> speseOrdinate=
                from s in InMemoryStorage.spese
                orderby s.Data
                select s;
            return speseOrdinate.ToList();
        }

        public Spesa GetById(int id)
        {
            Spesa spesaScelta=InMemoryStorage.spese.FirstOrDefault(s => s.Id == id);
            return spesaScelta;
        }

        public List<decimal> GetByIdCat(int id)
        {
            //from e in employees
            //where e.Id == 2
            //select e;
            IEnumerable<decimal> importiSpese =
                from s in InMemoryStorage.spese
                where s.CategoriaId == id
                select s.Importo;
            return importiSpese.ToList();
        }

        public List<Spesa> GetByIdUtente(int id)
        {
            List<Spesa> spese=FetchAll();
            List<Spesa> speseUtente = new List<Spesa>();
            foreach(var item in spese)
            {
                if (item.UtenteId == id)
                {
                    speseUtente.Add(item);
                }
            }
            return speseUtente;
        }

        public bool Update(Spesa item)
        {
            bool approvaz = false;
            if (item.Approvato == false)
            {
                item.Approvato = true;
                approvaz = true;
            }
            return approvaz;
        }
    }
}
