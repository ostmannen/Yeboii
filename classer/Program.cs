using System;

namespace classer
{
    class Program
    {
        static void Main(string[] args)
        {
            boll braboll = new boll() {name = "inteMax, pris = 100.05f"};
            System.Console.WriteLine(braboll.name);
            System.Console.WriteLine(braboll.vikt);
            Console.ReadLine();
        }
    }
}
