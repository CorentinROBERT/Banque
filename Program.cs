using System;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Client coco = new Client(1500f, "Coco");
            Client nono = new Client(10, "Nono");
            Client toto = new Client();
            Client tata = new Client();
            Console.WriteLine(toto.Equals(tata));
        }
    }
}
