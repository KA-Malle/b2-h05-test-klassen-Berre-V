using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    internal class Speler
    {
        // Instantievariabelen
        private int _gezondheid;

        // Constructor
        public Speler()
        {
            Gezondheid = 0;
        }

        // Properties
        public int Gezondheid
        {
            get { return _gezondheid; }
            set { _gezondheid = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }



        // Methods
        public void Verplaats(int positieX, int positieY)
        {
            // Declaratie
            Random posX = new Random(); 
            Random posY = new Random();

            
            positieX = posX.Next(1, 501);
            positieY = posY.Next(1, 501);
        }

        public bool OntvangSchade1(int[] gezondheid) 
        {
            // Declaratie
            Random schd = new Random();

            // Controle of we de limiet niet overschrijden.
            if (gezondheid[1] - schd.Next(1, 11) <= 0)
            {
                IsLevend = false;
                return IsLevend;
            }
            else
            {
                gezondheid[1] -= schd.Next(1, 11);
                return IsLevend;
            }
            
        }

        public bool OntvangSchade2(int[] gezondheid)
        {
            // Declaratie
            Random schd = new Random();

            // Controle of we de limiet niet overschrijden.
            if (gezondheid[2] - schd.Next(1, 11) <= 0)
            {
                gezondheid[2] = 0;
                IsLevend = false;
                return IsLevend;
            }
            else
            {
                gezondheid[2] -= schd.Next(1, 11);
                return IsLevend;
            }

        }

        public void Genees1(int[] gezondheid)
        {
            // Declaratie
            Random genees = new Random();

            // Controle of we de limiet niet overschrijden.
            if (gezondheid[1] + genees.Next(1, 6) >= 100)
            {
                gezondheid[1] += genees.Next(1, 6);
            }
            else
            {
                gezondheid[1] = 100;
            }

        }

        public void Genees2(int[] gezondheid)
        {
            // Declaratie
            Random genees = new Random();

            // Controle of we de limiet niet overschrijden.
            if (gezondheid[2] + genees.Next(1, 6) >= 100)
            {
                gezondheid[2] += genees.Next(1, 6);
            }
            else
            {
                gezondheid[2] = 100;
            }

        }
    }
}
