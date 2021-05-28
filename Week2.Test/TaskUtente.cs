using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public enum LivelloImportanza
    {
        Basso,
        Medio,
        Alto
    }
    public class TaskUtente
    {
        public String Descrizione { get; set; }
        public DateTime DataScadenza { get; set; } 
        public LivelloImportanza Livello { get; set; }
    }

    //TODO: gestione della data di scadenza, deve essere posteriore o uguale alla data di inserimento 
    //TODO: filtrare i task per importanza
    //posso fare entrambi in GestioneTask
}
