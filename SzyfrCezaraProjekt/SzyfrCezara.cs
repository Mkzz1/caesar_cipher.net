using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrCezaraProjekt
{
    internal class SzyfrCezara : SzyfrujZaszyfruj
    {
        public string Szyfruj(params object[] args)
        {
            if (args.Length == 2)
            {
                string text = (string)args[0];
                int shift = (int)args[1];

                return Szyfruj(text, shift);
            }
            return String.Empty;
        }

        public string Zaszyfruj(params object[] args)
        {
            if (args.Length == 2)
            {
                string text = (string)args[0];
                int shift = (int)args[1];

                return Rozszyfruj(text, shift);
            }
            return String.Empty;
        }

        private string Szyfruj(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            string alfabet = "aąbcćdeęfghijklłmnńoóprsśtuwxyzźżAĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUWXYZŹŻ0123456789 ";
            int offset = alfabet.Length;

            foreach(char c in text)
            {
                char oldChar = c;
                int oldCharIdx = alfabet.IndexOf(c);

                int newCharIdx = (oldCharIdx + shift + offset) % offset;

                char newChar = alfabet[newCharIdx];
                result.Append(newChar);
            }

            return result.ToString();
        }

        private string Rozszyfruj(string text, int shift)
        {
            return Szyfruj(text, shift * -1);
        }
    }
}
