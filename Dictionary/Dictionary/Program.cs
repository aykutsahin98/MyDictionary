using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string, int> urunler = new MyList<string, int>();
            urunler.Add("Elma", 8);
            urunler.Add("Portakal", 2);
            urunler.Add("Meyveli Yoğurt", 5);
            urunler.Add("Pizza", 10);

            foreach (var key in urunler.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in urunler.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
