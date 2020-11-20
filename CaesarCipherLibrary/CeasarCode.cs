using System;
using System.Collections.Generic;
using System.Text;


namespace CaesarCipherLibrary
{
   public class CeasarCode:CaesarBase
    {
        public string CipherText { get; set; }
        public CeasarCode(string message,int key)
        {
            Key = key;
            CipherText = Dowork(message);
        }
    }
}
