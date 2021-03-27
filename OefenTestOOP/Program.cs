using System;
using System.Collections.Generic;

namespace OefenTestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vaccin[] vaccins = new Vaccin[3];
            for (int i = 0; i < vaccins.Length; i++)
            {
                vaccins[i] = new Vaccin($"Vaccin{i+1}");
            }

            Virus virus = new Virus();
            int j = 0;

            bool possibleCure = virus.TryVaccin(vaccins[j % 3]);
            while (!possibleCure && virus.DoomCountdown > 0)
            {
                possibleCure = virus.TryVaccin(vaccins[j % 3]);
                if (!possibleCure)
                    j++;
            }

            if (possibleCure)
            {
                Vaccin werkende = Vaccin.DucpliceerVaccin(vaccins[j % 3]);
                werkende.ToonInfo();
            }

        }
    }
}
