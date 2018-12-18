using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau__liste___4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string> {"Carottes", "Oignons", "Pommes de terre", "Salade", "Tomate"};
            for (int indice = 0; indice < shopping.Count; indice++)
            {
                Console.WriteLine(shopping[indice]);
            }

            /*List<string> shopping1 = new List<string>();
            shopping1.Add("Carottes");
            shopping1.Add("Oignons");
            shopping1.Add("Pomme de terre");
            shopping1.Add("Salade");
            shopping1.Add("Tomate");
            shopping1.Add("kebab");*/

            



        }
    }
}
