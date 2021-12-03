using GestioneSpese.Core;
using GestioneSpese.Core.Interfaces;
using GestioneSpese.Core.BusinessLayer;
using GestioneSpese.Core.MockRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestioneSpese.Core.Entities;

namespace GestioneSpese.Client
{
    internal class Menu
    {
        private static readonly IBusinessLayer mainBL = new BusinessLayer (new UtenteMockRepo(), new SpesaMockRepo(), new CategoriaMockRepo());
        public static void Start()
        {
            Console.WriteLine("Benvenuto in Gestione Spese ");

            bool mostra = true;
            do
            {
                Console.WriteLine("******MENU******");
                int scelta;
                Console.WriteLine("Scegli cosa fare:");

                Console.WriteLine("Digita 1 per aggiungere una spesa" +
                    "\nDigita 2 per approvare una spesa" +
                    "\nDigita 3 per visualizzare le spese passate" +
                    "\nDigita 4 per visualizzare le spese per utente" +
                    "\nDigita 5 per visualizzare il totale per categoria" +
                    "\nDigita 6 per visualizzare spese in ordine cronologico"+
                    "\nDigita 0 per uscire");

                while (!(int.TryParse(Console.ReadLine(), out scelta)))
                {
                    Console.WriteLine("Digita un intero");
                }
                switch (scelta)
                {
                    case 1:
                        AggiungiSpesa();
                        break;
                    case 2:
                        ApprovaSpesa();
                        break;
                    case 3:
                        VisualizzaSpeseMesePassato();
                        break;
                    case 4:
                        VisualizzaByUtente();
                        break;
                    case 5:
                        VisualizzaImportoTotale();
                        break;
                    case 6:
                        VisualizzaCronologico();
                        break;
                    case 0:
                        mostra = false;
                        break;
                }

            } while (mostra);
        }

        private static void VisualizzaCronologico()
        {
            Console.WriteLine("Le spese ordinate cronologicamente sono:");
            List<Spesa> speseTot = mainBL.VisualizzaByData();
            foreach(Spesa spesa in speseTot)
            {
                Console.WriteLine($"{spesa.ToString()}");
            }
        }

        private static void VisualizzaImportoTotale()
        {
            Console.WriteLine("Inserisci Id categoria di cui vuoi visualizzare l'importo totale delle spese");
            int id;
            while (!(int.TryParse(Console.ReadLine(), out id)))
            {
                Console.WriteLine("Inserisci un intero!");
            }
            decimal Totale = mainBL.VisualizzaTotByCategoria(id);
            Console.WriteLine($"Il totale delle spese è: {Totale} Euro");
        }

        private static void VisualizzaByUtente()
        {
            Console.WriteLine("Inserisci Id utente di cui vuoi visualizzare le spese");
            int id;
            while (!(int.TryParse(Console.ReadLine(), out id)))
            {
                Console.WriteLine("Inserisci un intero!");
            }
            List<Spesa> speseByUtente = mainBL.VisualizzaByUtente(id);
            if (speseByUtente.Count() == 0)
            {
                Console.WriteLine("Nessuna spesa trovata");
            }
            else
            {
                foreach(var item in speseByUtente)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void VisualizzaSpeseMesePassato()
        {
            List<Spesa> speseTot = mainBL.VisualizzaSpese();
            foreach (Spesa spesa in speseTot)
            {
                Console.WriteLine(spesa.ToString());
            }
        }

        private static void ApprovaSpesa()
        {
            Console.WriteLine("Inserisci id spesa da approvare");
            int id=int.Parse(Console.ReadLine());

            bool approvato= mainBL.ApprovaSpesa(id);
            if (approvato)
            {
                Console.WriteLine("Spesa approvata");
            }
            else
            {
                Console.WriteLine("La spesa era già stata approvata!");
            }
        }

        private static void AggiungiSpesa()
        {
            Spesa nuovaSpesa = new Spesa();
            int id;
            while(!(int.TryParse(Console.ReadLine(), out id)))
            {
               Console.WriteLine("Inserisci id spesa:");
            }
            nuovaSpesa.Id = id;
            Console.WriteLine("Inserisci descrizione spesa:");
            nuovaSpesa.Descrizione=Console.ReadLine();
            decimal cifra;
            while(!(decimal.TryParse(Console.ReadLine(),out cifra)))
            {
                Console.WriteLine("Inserisci importo spesa:");
            }
            nuovaSpesa.Importo = cifra;
            nuovaSpesa.Data = DateTime.Today;
            int idc, idu;
            while (!(int.TryParse(Console.ReadLine(), out idc)))
            {
                Console.WriteLine("Inserisci id categoria:");
            }
            nuovaSpesa.CategoriaId = idc;
            while (!(int.TryParse(Console.ReadLine(), out idu)))
            {
                Console.WriteLine("Inserisci id utente:");
            }
            nuovaSpesa.UtenteId= idu;
            
            if (mainBL.AggiungiSpesa(nuovaSpesa) == false)
            {
                Console.WriteLine("Spesa aggiunta");
            };
        }
    }
}

