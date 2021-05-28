using System;
using System.Collections;

namespace Week2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList task = new ArrayList();
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();
                switch (scelta)
                {
                    case 1:
                        //inserimento nuovo task
                        TaskUtente taskDaAggiungere = GestioneTask.InserisciTask();
                        task.Add(taskDaAggiungere);
                        break;
                    case 2:
                        //visualizzo task
                        GestioneTask.StampaTask(task);
                        break;
                    case 3:
                        //recupero da file
                        TaskIO.RecuperoTaskDaFile();
                        break;
                    case 4:
                        //salvataggio su file
                        TaskIO.SalvoTaskSuFile(task);
                        break;
                    case 5:
                        //elimino task
                        TaskUtente taskDaCancellare = GestioneTask.CercaTask(task);
                        //gestisco eccezioni
                        try
                        {
                            task.Remove(taskDaCancellare);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Task non trovato");

                        }

                        break;
                    case 6:
                        //TODO: seleziona importanza
                        break;
                    case 0: 
                        break;
                    default: //per uscire dal ciclo
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;

                }

            }

        }

        public static int SchermoMenu()
        {
            Console.WriteLine("1. Inserisci task");
            Console.WriteLine("2. Stampa task");
            Console.WriteLine("3. Recupera task da file");
            Console.WriteLine("4. Salva task su File");
            Console.WriteLine("5. Elimina task");
            Console.WriteLine("6. Scegli importanza");
            Console.WriteLine("7. Per uscire");
            int scelta = 0;
            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Inserisci un numero corretto");
                scelta = 0;
            }
            return scelta;
        }
    }
}
