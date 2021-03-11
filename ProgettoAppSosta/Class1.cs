using System;

namespace ProgettoAppSosta
{
    public class Gestione
    {
        public static double tariffaA(int ore, double costoTariffa)
        {
            double costoTot = 15;
            return costoTot;
        }
        public static double tariffaB(int ore, double costoTariffa)
        {
            double costoTot = ore * costoTariffa;
            return costoTot;
        }
        public static double tariffaC(int ore,double costoTariffa)
        {
            double costoTot = 0;
            if (ore==1)
            {
                costoTot = 0;
            }
            else
            {
                costoTot = (ore - 1) * costoTariffa;
            }
            return costoTot;
        }
           
        
    }
}
