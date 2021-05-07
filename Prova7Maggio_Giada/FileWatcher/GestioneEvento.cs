using Prova7Maggio_Giada.Factory;
using Prova7Maggio_Giada.Factory.Entita;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7Maggio_Giada.FileWatcher
{
    public class GestioneEvento
    {
        public static List<Spesa> _List = new List<Spesa>();
        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {

            LetturaFile(e);
            ApprovazioneSpesa();
            CalcoloRimborso();
            ScritturaFile();

        }

        private static void ScritturaFile()
        {
            using StreamWriter writer = File.CreateText(@"C:\Users\giada.lomasti\source\repos\ACCADEMY\PrimaSettimana\Prova7Maggio_Giada\ListaSpesa\spese_elaborate.txt");
           
                foreach(Spesa s in _List)
                {
                if (s.Approvazione)
                    writer.WriteLine($"{s.DataSpesa.ToShortDateString()};{s.Descrizione};APPROVATA;{s.Categoria};{s.Rimborso}");
                else
                    writer.WriteLine($"{s.DataSpesa.ToShortDateString()};{s.Descrizione};RESPINTA;-;-");
                }
            
        }

        private static void CalcoloRimborso()
        {
            foreach(Spesa s in _List)
            {
                if (s.Approvazione)
                {
                    ICategoria categoria= CategoriaFactory.FactoryCategoria(s.Categoria);
                    s.Rimborso= categoria.Sconto(s.Importo);
                    //Console.WriteLine($"Il rimborso di {s.Importo} è {s.Rimborso}");
                }
            }

        }

        public static void LetturaFile(FileSystemEventArgs e)
        {
            //Lettura del file
            using StreamReader reader = File.OpenText(e.FullPath);
            string riga = "";
            while ((riga = reader.ReadLine()) != null)
            {
                Spesa spesa = new Spesa();
                string[] parti = riga.Split(";");

                spesa.DataSpesa = DateTime.Parse(parti[0]);
                spesa.Categoria = parti[1];
                spesa.Descrizione = parti[2];
                spesa.Importo = decimal.Parse(parti[3]);

                _List.Add(spesa);

            }

            Console.WriteLine("-----Lettura file completata-----");
        }
        public static void ApprovazioneSpesa()
        {
            var manager = new ManagerHandler();
            var operationManager = new OManagerHandler();
            var ceoManager = new CEOHandler();

            manager.SetNext(operationManager).SetNext(ceoManager);

            foreach (Spesa s in GestioneEvento._List)
            {
                var result = manager.Handle(s.Importo);
                if (result == null)
                {
                    Console.WriteLine("Spesa non approvata (importo > 2500");
                    s.Approvazione = false;
                }
                else
                {
                    Console.WriteLine($"Spesa approvata da {result}");
                    s.Approvazione = true;
                }
            }
        }
    }
}
