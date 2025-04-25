
using System.Diagnostics;
using System.IO;
namespace T2_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Exercici 2
            //Realitza un programa que imprimeixi per pantalla tots el nom i el PID (Process ID) que estan en execució de la màquina que estàs fent servir. Guarda aquesta llista en un arxiu de text.
            Exercici2();

            //Exercici 3
            //Executa un programa browser (Edge, Chrome, Firefox). Fent servir la classe ProcessThread i amb del programa anterior crea un mètode que llista els fils que té el browser i imprimeix el seu ID, hora d’inici i prioritat. Si obres més d’una pestanya, s’obren nous fils? Explica que succeix.

            Console.WriteLine("Insereix el codi que ha sortit en el exercici 2 que tingui com a nom chrome:");
            int processId = int.Parse(Console.ReadLine()); 
            try
            {
                Process chrome = Process.GetProcessById(processId);
                ProcessThreadCollection collectionChrome = chrome.Threads;

                foreach (ProcessThread thread in collectionChrome)
                {
                    Console.WriteLine($"Numero de processos totals: {collectionChrome.Count}");
                    Console.WriteLine($" Id: {thread.Id}, hora d'inici: {thread.StartTime} i prioritat: {thread.CurrentPriority}");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public static void Exercici2()
        {
            var Processos = Process.GetProcesses();
            string fitxerProcessos = @"..\..\..\processos.txt";
            using (StreamWriter writter = new StreamWriter(fitxerProcessos))
            {
                foreach (var Process in Processos)
                {
                    writter.WriteLine(Process.ProcessName + " " + Process.Id);
                    Console.WriteLine(Process.ProcessName + " " + Process.Id);
                }
                Console.WriteLine();
            }
        }
    }
}
