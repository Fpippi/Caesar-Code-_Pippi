using CaesarCipherLibrary;
using System;


namespace Caesar_Code__Pippi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pippo");
            CeasarCode cc = new CeasarCode("Pippo" , 5);
            Console.WriteLine(cc.CipherText);
            Console.ReadLine();
        }

        
    }
}
