using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Core.Entities
{
    public class Spesa
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descrizione { get; set; }
        public decimal Importo { get; set; }
        public bool Approvato { get; set; }=false; //valore default
        public int CategoriaId { get; set; }
        public int UtenteId { get; set; }
        public Spesa()
        {

        }

        public override string ToString()
        {
            return $"Id spesa: {Id} -- Descrizione: {Descrizione} -- Categoria: {CategoriaId} -- Utente: {UtenteId} -- Approvato: {Approvato} -- Data: {Data}";
        }
    }
}
