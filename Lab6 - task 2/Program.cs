using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6___task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string strwithoutspaces = str.Replace(" ", "");
            string str2 = "";
            foreach (char c in strwithoutspaces)
            {
                str2 = c + str2;
            }
            if (string.Compare(strwithoutspaces, str2) == 0)
            {
                Console.WriteLine("Вы ввели палиндром");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey(); 
        }
    }
}
