
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

            var Processos = Process.GetProcesses();
            string fitxerProcessos = @"..\..\..\processos.txt";
            using (StreamWriter writter = new StreamWriter(fitxerProcessos))
            {
                foreach (var Process in Processos)
                {
                    writter.WriteLine(Process.ProcessName + " " + Process.Id);
                    Console.WriteLine(Process.ProcessName + " "+ Process.Id);

                }
            }
        }
    }
}
