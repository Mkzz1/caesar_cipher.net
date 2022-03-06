using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrCezaraProjekt
{
    internal interface SzyfrujZaszyfruj
    {
        string Szyfruj(params object[] args);
        string Zaszyfruj(params object[] args);
    }
}
