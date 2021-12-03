using GestioneSpese.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Core.MockRepositories
{
    public class InMemoryStorage
    {
        public static List<Utente> utenti = new List<Utente>()
        {
            new Utente{Id=1, Nome="Maria", Cognome="Bianchi"},
            new Utente{Id=2, Nome="Davide", Cognome="Rossi"},
            new Utente{Id =3, Nome="Anna", Cognome ="Verdi"}
        };

        public static  List<Categoria> categorie = new List<Categoria>()
        {
            new Categoria{Id=1, Nome="Alimenti"},
            new Categoria {Id=2, Nome="Abbigliamento"},
            new Categoria{Id =3, Nome="Elettronica"}
        };

        public static List<Spesa> spese = new List<Spesa>()
        {
            new Spesa{Id=1, Descrizione="Latte", Importo= 20, Data=new DateTime(2021,11,20), Approvato=false, UtenteId=1, CategoriaId=1},
            new Spesa{Id=2, Descrizione="Cappotto", Importo= 120, Data= new DateTime(2021,11,28), Approvato=true, CategoriaId=2, UtenteId=2},
            new Spesa{Id=3, Descrizione="Aspirapolvere", Importo=300, Data= new DateTime(2021,12,01), Approvato=true, UtenteId = 3, CategoriaId=3},
            new Spesa{Id=4, Descrizione="Verdure", Importo= 30, Data=new DateTime(2021,11,20), Approvato=true, UtenteId=1, CategoriaId=1},
            new Spesa{Id=5, Descrizione="Scarpe", Importo= 120, Data= new DateTime(2021,11,22), Approvato=true, CategoriaId=2, UtenteId=2},
            new Spesa{Id=6, Descrizione="Auricolari", Importo=40, Data= new DateTime(2021,11,15), Approvato=true, UtenteId = 3, CategoriaId=3},
            new Spesa{Id=7, Descrizione="Hotel", Importo= 200, Data= new DateTime(2021,09,22), Approvato=true, CategoriaId=2, UtenteId=2},
            new Spesa{Id=8, Descrizione="Smartphone", Importo=300, Data= new DateTime(2021,08,15), Approvato=false, UtenteId = 3, CategoriaId=3},
        };
    }
}
