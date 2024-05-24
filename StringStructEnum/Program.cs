using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStructEnum
{
    internal class Program
    {
        
            static void Main(string[] args)
        {
            // strings are immutable, when concatenating a new object is created in memory deleting the old one and assigning it to our variable
            /*
            string a = "ciao";
            string b = "ci";
            b += "ao";
            Console.WriteLine(a == b);
            Console.WriteLine((object)b == (object)a);
            Console.Read();
            */
            string a = "Marco";
            //char c = a[2];
            foreach (char x in a) {
                Console.WriteLine(x);
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
            StringBuilder elenco = new StringBuilder();
            int[] age = new int[] { 22, 33, 11, 45, 12, 13 };
            string[] names = new string[] { "Claudio", "Giorgio", "Emanuele", "Eleonora", "Filippo", "Lorenzo" };
            elenco.Append("Name Age :\n");
            for (int i = 0; i < names.Length; i++)
            {
                elenco.AppendFormat("{0} {1}\n", names[i], age[i]);
            }
            Console.WriteLine(elenco);

            
            

            Console.Read();
        }
    }
}
