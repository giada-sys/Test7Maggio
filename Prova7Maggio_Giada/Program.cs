using Prova7Maggio_Giada.FileWatcher;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prova7Maggio_Giada
{
    class Program
    {
        static void Main(string[] args)
        {
            EventoFile();

        }



        public static void EventoFile()
        {
            FileSystemWatcher fsw = new FileSystemWatcher();

            //Specifico la directory dove voglio salvare il file
            fsw.Path = @"C:\Users\giada.lomasti\source\repos\ACCADEMY\PrimaSettimana\Prova7Maggio_Giada\ListaSpesa";

            fsw.Filter = "spesa.txt";

            //Enum- filtro della notifica che si attiva quando
            //cambiano il nome oppure ...
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastAccess;

            //Abilito le notifiche
            fsw.EnableRaisingEvents = true;

            //Multicast delegate -> alla creazione del file viene gestito l'evento
            fsw.Created += GestioneEvento.HandleNewTextFile;

            Console.WriteLine("Inserisci q per chiudere il programma");
            while (Console.Read() != 'q') ;
        }
    }
}
