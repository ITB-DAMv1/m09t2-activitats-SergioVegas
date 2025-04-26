
using System.Diagnostics;
using System.IO;
using System.Threading;
using static System.Net.WebRequestMethods;
namespace T2_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Exercici 2
            //Realitza un programa que imprimeixi per pantalla tots el nom i el PID (Process ID) que estan en execució de la màquina que estàs fent servir. Guarda aquesta llista en un arxiu de text.
            //Exercici2();

            //Exercici 3
            //Executa un programa browser (Edge, Chrome, Firefox). Fent servir la classe ProcessThread i amb del programa anterior crea un mètode que llista els fils que té el browser i imprimeix el seu ID, hora d’inici i prioritat. Si obres més d’una pestanya, s’obren nous fils? Explica que succeix.
            //Exercici3();

            //Exercici5
            // Crea un programa amb 5 fils que escriuen per consola: $“Hola! Soc el fil número { numeroFil}”
            //Exercici5

            //Exercici6
            //Realitza un programa que emuli una carrera de camells. Cada camell és un thread diferent. Els camells han de comptar de 0 a 100. A cada comptatge escriu per consola el número de camell i el número pel qual va, a més a més descansarà X milisegons. X serà un número aleatori  a cada cicle d’entre dos valors. Els dos valors són paràmetres diferents entre els camells.

            Exercici6();
        }
        public static void Exercici6()
        {
            int rounds = 100;
            int numberCamels = 3;

            Thread[] threads = new Thread[numberCamels];
            for (int i = 0; i < numberCamels; i++)
            {
                Camel newCamel = new Camel(i);
                threads[i] = new Thread(newCamel.Run);
                threads[i].Start();
            }
        }
        public static void Exercici5()
        {
            //a) Executa els 5 fils  i comprova l’ordre que s’imprimeix. Quin és? i per què es aquest ordre?
            Thread th1 = new Thread(() => { Console.WriteLine("Hola! Soc el fil número 1"); });
            Thread th2 = new Thread(() => { Console.WriteLine("Hola! Soc el fil número 2"); });
            Thread th3 = new Thread(() => { Console.WriteLine("Hola! Soc el fil número 3"); });
            Thread th4 = new Thread(() => { Console.WriteLine("Hola! Soc el fil número 4"); });
            Thread th5 = new Thread(() => { Console.WriteLine("Hola! Soc el fil número 5"); });
            
            th1.Start();         
            th2.Start();          
            th3.Start();           
            th4.Start();
            th5.Start();
            //b)Fes servir la funció .Sleep() per mirar de fer que les tasques s’executin en ordre invers.
            Thread th1S = new Thread(() => { Thread.Sleep(400); Console.WriteLine("Hola! Soc el fil número 1"); });
            Thread th2S = new Thread(() => { Thread.Sleep(300); Console.WriteLine("Hola! Soc el fil número 2"); });
            Thread th3S = new Thread(() => { Thread.Sleep(200); Console.WriteLine("Hola! Soc el fil número 3"); });
            Thread th4S = new Thread(() => { Thread.Sleep(100); Console.WriteLine("Hola! Soc el fil número 4"); });
            Thread th5S = new Thread(() => {Console.WriteLine("Hola! Soc el fil número 5"); });

            th1S.Start();
            th2S.Start();
            th3S.Start();
            th4S.Start();
            th5S.Start();

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
        public static void Exercici3()
        {
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
    }
}
