using GestioneSpese.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Core.Interfaces
{
    public interface IBusinessLayer
    {
        bool AggiungiSpesa(Spesa nuovaSpesa);
        List<Spesa> VisualizzaSpese();
        bool ApprovaSpesa(int id);
        List<Spesa> VisualizzaByUtente(int id);
        decimal VisualizzaTotByCategoria(int id);
        List<Spesa> VisualizzaByData();
    }
}
