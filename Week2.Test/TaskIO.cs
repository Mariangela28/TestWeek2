using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    class TaskIO
    {
        public static ArrayList RecuperoTaskDaFile()
        {
            ArrayList task = new ArrayList(); 
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "testo.txt");
            string line;
            try
            {
                using (StreamReader fileReader = File.OpenText(path))
                {
                    //leggo fino a quando trovo contenuto nel file
                    while ((line = fileReader.ReadLine()) != null)
                    {
                        string[] valoriTask = line.Split(";");
                        string descrizione = valoriTask[0];
                        DateTime dataScadenza = Convert.ToDateTime(valoriTask[1]);
                        LivelloImportanza livello = valoriTask[2];
                        TaskUtente t = new TaskUtente()
                        {
                            Descrizione = descrizione,
                            DataScadenza = dataScadenza,
                            Livello = livello
                        }; //ho creato un task
                        task.Add(t); //leggo una lista di elementi

                    }
                }//qui richiamiamo l'azione del garbage collection che renderà la risorsa di nuovo disponibile
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return task;
        }

        public static void SalvoTaskSuFile(ArrayList task)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "task.txt");
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    foreach (var objTaskUtente in task)
                    {
                        writer.WriteAsync(task.ToString());
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
