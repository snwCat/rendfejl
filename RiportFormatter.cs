using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kliens_alkalmazas;

namespace TestProject2
{
    internal class RiportFormatter
    {
        public static string FormazottRiport(List<Termek> termekek)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Termékjelentés - " + DateTime.Now.ToString("yyyy.MM.dd. HH:mm"));
            sb.AppendLine("----------------------------------------------------");
            sb.AppendLine($"Termékek száma: {termekek.Count}");
            sb.AppendLine();

            foreach (var t in termekek)
            {
                sb.AppendLine($"Név: {t.Név}");
                sb.AppendLine($"Raktáron: {t.Raktáron}");
                sb.AppendLine($"Beszerzési Ár: {t.BeszerzésiÁr:F2} Ft");
            }

            return sb.ToString();
        }
    }
}
