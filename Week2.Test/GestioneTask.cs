using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public static class GestioneTask
    {
        public static TaskUtente InserisciTask()
        {
            TaskUtente task = new TaskUtente();
            try
            {

                Console.WriteLine("Inserisci la descrizione");
                task.Descrizione = Console.ReadLine();
                //inserisco livello di importanza e data e faccio i controlli su queste
                Console.WriteLine("Inserisci la data di scandenza");
                //ho TryParse, faccio controllo inserimento
                Console.WriteLine("Inserisci livello di importanza");
                int[] values = new int[] { 0, 1, 2, 3 };
                foreach (int enumValue in values)
                {
                    Console.WriteLine(Enum.GetName(typeof(LivelloImportanza), enumValue));
                }

                //ci deve essere il blocco del controllo


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

                return task;
                
               
                
               
        

        public static TaskUtente CercaTask(ArrayList task)
        {
            Console.WriteLine("Cerca task inserendo la descrizione");
            string descrizione = Console.ReadLine();
                foreach (var objTaskUtente in task)
                {
                    if (task.Descrizione == descrizione) 
                    {
                        return task;
                    }

                }
                return null;



            }

        public static void StampaTask(ArrayList task)
        {
            foreach (var objTaskUtente in task)
        {
            Console.WriteLine(task);
        }

    }

       
        
        
        }
    }
}
