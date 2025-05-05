using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kliens_alkalmazas;

namespace TestProject2
{
    internal class TermekKeresesHelper
    {
        public static List<Termek> Kereses(List<Termek> termekek, string keresoszo)
        {
            return termekek
                .Where(t => t.Név != null && t.Név.ToLower().Contains(keresoszo.ToLower()))
                .ToList();
        }
    }
}
