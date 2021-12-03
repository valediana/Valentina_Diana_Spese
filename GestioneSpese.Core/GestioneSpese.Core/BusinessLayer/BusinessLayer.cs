using GestioneSpese.Core.Entities;
using GestioneSpese.Core.Interfaces;
using GestioneSpese.Core.MockRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Core.BusinessLayer
{
    public  class BusinessLayer: IBusinessLayer
    {
        
        private readonly IUtenteRepo utentiRepo;
        private readonly ISpesaRepo speseRepo;
        private readonly ICategoriaRepo categorieRepo;
        public BusinessLayer(IUtenteRepo utenteRepo, ISpesaRepo spesaRepo, ICategoriaRepo categoriaRepo)
        {
            utentiRepo = utenteRepo;
            speseRepo = spesaRepo;
            categorieRepo = categoriaRepo;
        }

        
        public bool AggiungiSpesa(Spesa nuovaSpesa)
        {
            return speseRepo.Add(nuovaSpesa);
           
        }

        public bool ApprovaSpesa(int id)
        {
            Spesa spesa=speseRepo.GetById(id);
            return speseRepo.Update(spesa); //restituisce true se ha fatto update
        }

        public List<Spesa> VisualizzaByData()
        {
            List<Spesa> spesePerData = speseRepo.GetByData();
            return spesePerData;
        }

        public List<Spesa> VisualizzaByUtente(int id)
        {
            List<Spesa> speseUtente = speseRepo.GetByIdUtente(id);
            return speseUtente;
        }

        public List<Spesa> VisualizzaSpese()
        {
            List<Spesa> speseTot = speseRepo.FetchAllByData();
            return speseTot;
        }

        public decimal VisualizzaTotByCategoria(int id)
        {
            List<decimal> speseCategoria = speseRepo.GetByIdCat(id);
            decimal totale = 0;
            foreach(var item in speseCategoria)
            {
                totale += item;
            }
            return totale;
        }
    }
}
