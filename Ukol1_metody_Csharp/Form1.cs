using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol1_metody_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double obsah(double a)
        {
            double vysledek = a * a;
            return vysledek;
        }

        private double obsah(double a, double b)
        {
            double vysledek = a * b;
            return vysledek;
        }

        private double objem(double a, double b, double c)
        {
            double vysledek = a * b * c;
            return vysledek;
        }

        private double objem(double a)
        {
            double vysledek = a * a * a;
            return vysledek;
        }

        private void obsah_ctverce_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(strana_ctverce.Text);
                double vysledek = obsah(a);

                MessageBox.Show("Obsah čtverce je " + vysledek + " m2", "Výsledek");
            }
            catch
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
        } 

        private void obsah_obdelniku_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(strana_a.Text);
                double b = Convert.ToDouble(strana_b.Text);
                double vysledek = obsah(a, b);

                MessageBox.Show("Obsah obdélníku je " + vysledek + " m2", "Výsledek");
            }
            catch
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
        }

        private void objem_kvadru_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(strana_a2.Text);
                double b = Convert.ToDouble(strana_b2.Text);
                double c = Convert.ToDouble(strana_c2.Text);
                double vysledek = objem(a, b, c);

                MessageBox.Show("Objem kvádru je " + vysledek + " m3", "Výsledek");
            }
            catch
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
        }

        private void objem_krychle_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(strana_krychle.Text);
                double vysledek = objem(a);

                MessageBox.Show("Objem krychle je " + vysledek + " m3", "Výsledek");
            }
            catch
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
        }
    }
}
