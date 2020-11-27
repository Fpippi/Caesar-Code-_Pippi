using CaesarCipherLibrary;
using System;


namespace Caesar_Code__Pippi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola:");
            string plaintext = Console.ReadLine();
            int key;
            CeasarCode ml;
            try
            {
                do
                {
                    Console.WriteLine("Inserisci la chiave:");
                    key = int.Parse(Console.ReadLine());
                } while (key < 0||key>25);
                ml = new CeasarCode(plaintext, key);
                Console.WriteLine($"IL testo cifrato è:{ml.CipherText}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
