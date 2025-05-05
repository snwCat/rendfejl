using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;

namespace kliens_alkalmazas
{
    public partial class Form1 : Form
    {
        BindingList<Termek> termekek = new BindingList<Termek>();
        public Form1()
        {
            InitializeComponent();
        }

        private static Api apiHivas()
        {
            string url = "http://rendfejl1004.northeurope.cloudapp.azure.com:8080/";
            string kulcs = "1-2a4e381d-bc48-4455-ad82-1abf8140ec25";
            Api proxy = new Api(url, kulcs);
            return proxy;
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void buttonKeszlet_Click(object sender, EventArgs e)
        {

            labelAllapot.Text = "Betöltés folyamatban...";
            labelAllapot.ForeColor = Color.Blue;
            Refresh();

            try
            {
                Api proxy = apiHivas();
                var response_product = proxy.ProductsFindAll();

                if (response_product == null || response_product.Content == null || response_product.Content.Count == 0)
                {
                    labelAllapot.Text = "Nincs betölthető adat.";
                    return;
                }

                termekek.Clear();

                foreach (var product in response_product.Content)
                {
                    var keszlet = proxy.ProductInventoryFindForProduct(product.Bvin);

                    Termek termek = new Termek
                    {
                        Név = product.ProductName,
                        BeszerzésiÁr = product.SiteCost,
                        Raktáron = keszlet.Content[0].QuantityOnHand
                    };

                    termekek.Add(termek);
                }

                dataGridView1.DataSource = termekek;
                labelAllapot.Text = "Készlet betöltve.";
                labelAllapot.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                labelAllapot.Text = "Hiba történt: " + ex.Message;
                labelAllapot.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingList<Termek> Kereses = new BindingList<Termek>();

            string searchText = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView1.DataSource = termekek; // Reset to full list
                return;
            }

            var filtered = termekek.Where(t => t.Név != null && t.Név.ToLower().Contains(searchText)).ToList();

            Kereses = new BindingList<Termek>(filtered);
            dataGridView1.DataSource = Kereses;
        }

        private void buttonRiport_Click(object sender, EventArgs e)
        {
            var reportForm = new Kimutatas(termekek.ToList());
            reportForm.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (termekek.Count == 0)
            {
                MessageBox.Show("Nincs elérhető adat a jelentéshez.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Szöveges fájl (*.txt)|*.txt";
                sfd.FileName = "TermékJelentés.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("Termékjelentés - " + DateTime.Now.ToString("yyyy.MM.dd. HH:mm"));
                            sw.WriteLine("----------------------------------------------------");
                            sw.WriteLine($"Termékek száma: {termekek.Count}");
                            sw.WriteLine();

                            foreach (var t in termekek)
                            {
                                sw.WriteLine($"Név: {t.Név}");
                                sw.WriteLine($"Raktáron: {t.Raktáron}");
                                sw.WriteLine($"Beszerzési Ár: {t.BeszerzésiÁr:F2} Ft");
                            }
                        }

                        MessageBox.Show("Jelentés sikeresen elmentve!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt a jelentés mentésekor: " + ex.Message);
                    }
                }
            }
        }
    }
}