using System;

namespace CaesarCipherLibrary
{
    public abstract class CaesarBase
    {

        protected int Key { get; set; }

        private char Cipher(char ch)
        {
            if (!char.IsLetter(ch))
                return ch;
            char offser;

            if (char.IsUpper(ch))
            {
                offser = 'A';
            }
            else
            {
                offser = 'a';
            }
            return (char)(((ch - offser + Key) % 26) + offser);

        }

        protected string Dowork(string m)
        {
            string message = string.Empty;
            foreach (char ch in m)
            {
                message += Cipher(ch);
            }
            return message;
        }

    }
}
