using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kliens_alkalmazas;

namespace TestProject2
{
    internal class TermekHelper
    {
        public static Termek LegdragabbKeszleten(List<Termek> termekek)
        {
            return termekek
                .Where(t => t.Raktáron > 0)
                .OrderByDescending(t => t.BeszerzésiÁr)
                .FirstOrDefault();
        }

        public static Termek LegolcsobbKeszleten(List<Termek> termekek)
        {
            return termekek
                .Where(t => t.Raktáron > 0)
                .OrderBy(t => t.BeszerzésiÁr)
                .FirstOrDefault();
        }
    }
}
