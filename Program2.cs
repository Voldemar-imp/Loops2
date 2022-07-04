using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalOperatorsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            bool areYouStaying = true;
            string yourOrder;   
            int numberOfOrders = 0;

            Console.WriteLine("Добро пожаловать в бар!");
            Console.WriteLine("Сделайте заказ официанту!");
            Console.WriteLine("Или скажите exit, чтобы покинуть бар!");

            while (areYouStaying)
            {
                Console.Write("К вам подходит официант и спашивет: чего жалаете? ");
                yourOrder = Console.ReadLine();
                if (yourOrder == "exit")
                {
                    areYouStaying = false;                    
                    continue;
                }
                Console.WriteLine("Вам приносят: " + yourOrder);
                numberOfOrders ++;
            }                    
            Console.WriteLine("Вы сделали " + numberOfOrders + " заказов.");
            Console.WriteLine("Приходите ещё!");
        }
    }
}
