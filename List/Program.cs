using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //Benim bir listeye ihtiyacım var
            var list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
