using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            Console.WriteLine("Informe o número que deseja a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe quantas vezes deseja saber o resultado: ");
            int vez = int.Parse(Console.ReadLine());
            


            while(cont <= vez)
            {
                int res = num * cont;
                Console.WriteLine(num + "x" + cont + "=" + res);
                cont ++;
            }
            
            Console.ReadKey();
        }
    }
}
