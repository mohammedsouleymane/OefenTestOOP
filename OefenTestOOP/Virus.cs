using System;
using System.Collections.Generic;
using System.Text;

namespace OefenTestOOP
{
    class Virus
    {
        public Virus()
        {
            Random r = new Random();
            DoomCountdown = r.Next(11, 20);
            killCode = r.Next(1,99);
            Naam = $"{(char)r.Next('A', 'Z' + 1)}{(char)r.Next('A', 'Z' + 1)}{(char)r.Next('A', 'Z' + 1)}{r.Next(1, 99)}";
        }
        public string Naam { get; set; }

        private int doomCountdown;

        public int DoomCountdown
        {
            get
            {
                return doomCountdown;
            }
            private set
            {
                if (value <= 0)
                    Console.WriteLine($"Game over {Naam}");
                doomCountdown = value;
            }
        }

        private int killCode;

        public bool TryVaccin(Vaccin vaccin)
        {
            if (vaccin.TryKillCode() == killCode)
            {
                vaccin.Oplossing = killCode;
                return true;
            }
            DoomCountdown--;
            return false;
        }
    }
}
