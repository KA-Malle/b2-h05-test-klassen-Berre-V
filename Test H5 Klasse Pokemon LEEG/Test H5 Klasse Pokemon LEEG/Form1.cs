using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        private Speler speler;
        public Form1()
        {
            InitializeComponent();
            speler = new Speler();
        }

        // Constructor aanspreken van de klasse
        Speler _speler = new Speler();

        // Globale variabelen
        int[]  gezondheid;


        private void Form1_Load(object sender, EventArgs e)
        {
            // labels juist zetten
            labelGezondheid1.Text += gezondheid[1].ToString();
            labelGezondheid2.Text += gezondheid[2].ToString();
        }

        private void buttonValAan1_Click(object sender, EventArgs e)
        {
            speler.OntvangSchade2(gezondheid);
        }

        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            speler.OntvangSchade1(gezondheid);
        }

        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            speler.Genees1(gezondheid);   
        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            speler.Genees2(gezondheid);
        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            // Declaratie.
            int posX = 0, posY = 0;
            speler.Verplaats(posX, posY);
            MessageBox.Show("", "");
        }
    }
}
