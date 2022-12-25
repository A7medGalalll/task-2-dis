using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, num, i;
            Console.WriteLine("min");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("max");
            n2 = int.Parse(Console.ReadLine());
            
            for(num=n1;num<+n2;num++)
            {
                  int sum = 0;
                for(i=1;i<num;i++)
                {
                    if (num %i == 0)
                        sum = sum +i ;
                }
                if(sum== num &&num!=0)
                    Console.WriteLine(num);
            }
        }
    }
}
