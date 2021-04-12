using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neoluyorla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable h = new Hashtable();
            //h.Add("Car", "Araba");
            //h.Add("house", "Ev");

            //h.Add("cars", "araba");
            //h.Add("carp", "arabax");

            //bool kontrol1 = h.Contains("house");
            //bool kontrol2 = h.Contains("door");

            //bool kontrol3 = h.ContainsKey("house");
            //bool kontrol4 = h.ContainsValue("arabax");

            //h["house"] = "villa";


            //h.Remove("cars");
            //int koleksiyonIcindekiToplamDeger = h.Count;
            //h.Clear();
            

            string j = string.Empty;
            Hashtable q = new Hashtable();
            int m = 0;
            do
            {
                Console.WriteLine("yeni kayıt eklemek istiyormusunuz E/H");
                String J = Console.ReadLine();

                switch (J)
                {
                    case ("E"):
                        Console.WriteLine("eklemek istediğiniz key değeri lütfen giriniz");
                        string y = string.Empty;
                         y = Console.ReadLine();
                        Console.WriteLine("eklemek istediğiniz ana değeri lütfen giriniz");
                        string o = Console.ReadLine();
                        o = Console.ReadLine();
                        if (q.Contains(y))
                        {
                            Console.WriteLine("bu değer önceden sistemimizde var saten");
                        }
                        else

                            q.Add(m, o);

                        break;
                              

                    default:
                        break;
                }

            } while (j != "H");
            {
                foreach (string item in q)
                {
                    Console.WriteLine(q);

                }
            }
        }   
    }
}
