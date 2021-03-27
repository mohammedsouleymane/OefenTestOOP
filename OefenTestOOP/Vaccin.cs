using System;
using System.Collections.Generic;
using System.Text;

namespace OefenTestOOP
{
    class Vaccin
    {
        static public Vaccin DucpliceerVaccin (Vaccin original)
        {
            Vaccin copy = new Vaccin(original.Naam);
            copy.Oplossing = original.Oplossing;
            return copy;
        }
        public string Naam { get; set; }

        public Vaccin(string naam)
        {
            Naam = naam;
        }

        private int oplossing = -1;

        public int Oplossing
        {
            get { return oplossing; }
            set
            {
                if (oplossing >= -1)
                    oplossing = value;
            }
        }

        public int TryKillCode()
        {
            Random r = new Random();
            int num = -1;
            if (Oplossing == -1)
                return num = r.Next(1, 101);
            else
                return Oplossing;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Oplossing: {Oplossing}");
        }
    }
}
