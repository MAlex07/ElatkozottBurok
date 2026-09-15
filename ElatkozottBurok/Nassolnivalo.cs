using System;

namespace ElatkozottBurok
{
    public class Nassolnivalo
    {
        private string nev;
        private int koffeinLoket;
        private int stressoldas;
        private int ar;

        public Nassolnivalo(string nev, int koffeinLoket, int stressoldas, int ar)
        {
            this.Nev = nev;
            this.koffeinLoket = koffeinLoket;
            this.stressoldas = stressoldas;
            this.ar = ar;
        }

        public string Nev { get => nev; set {

                if (nev == "" || nev == null)
                {
                    nev = "Ismeretlen nassolnivaló";
                }
                else
                {
                    nev = value;
                }
            } }
        public int KoffeinLoket { get => koffeinLoket; set {

                if (koffeinLoket < 0 || koffeinLoket > 50)
                {
                    koffeinLoket = 0;
                }
                else
                {
                    koffeinLoket = value;
                } 
            } }
        public int Stressoldas { get => stressoldas; set {

                if (stressoldas < 0 || stressoldas > 30)
                {
                    stressoldas = 0;
                }
                else
                {

                    stressoldas = value;
                }
            } }
        public int Ar { get => ar; set {

                if (ar < 100)
                {
                    ar = 100;
                }
                else
                {

                    ar = value;
                } 
            } }
    }
}