using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace kliens_alkalmazas
{
    public partial class Kimutatas : Form
    {
        public Kimutatas(List<Termek> termekek)
        {
            InitializeComponent();

            var highStockItems = termekek
            .Where(t => t.Raktáron > 0)
            .OrderByDescending(t => t.Raktáron)
            .Take(10)
            .Select(t => $"{t.Név}: {t.Raktáron} db")
            .ToList();
            
            labelMagas.Text = "Top 10 magas készlet:\n" + string.Join("\n", highStockItems);
            
            var lowStockItems = termekek
            .Where(t => t.Raktáron > 0)
            .OrderBy(t => t.Raktáron)
            .Take(10)
            .Select(t => $"{t.Név}: {t.Raktáron} db")
            .ToList();

            labelAlacsony.Text = "Top 10 alacsony készlet:\n" + string.Join("\n", lowStockItems);
        }

        private void Kimutatas_Load(object sender, EventArgs e)
        {

        }
    }
}
