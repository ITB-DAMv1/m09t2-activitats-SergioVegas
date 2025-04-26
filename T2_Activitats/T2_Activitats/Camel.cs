using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Activitats
{
    public class Camel
    {
        public int Number {  get; set; }
        public Random Rest { get; set; } = new Random();
        public int MinRangRest { get; set; } = 1;
        public int MaxRangRest { get; set; } = 100;

        public Camel(int camelNumber)
        {
            this.Number = camelNumber;
        }
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"El camell numero {Number}, va per la volta {i}!");
                Thread.Sleep(Rest.Next(MinRangRest,MaxRangRest));
            }
            Console.WriteLine($"El camell {Number} ha acabat!");
        }
    }
}
