using System;

namespace ElatkozottBurok
{
    public class Fejleszto
    {
        private string nev;
        private Munkakor munkakor;
        private int penz;
        private int koffeinszint;
        private int stresszSzint;
        private bool kiegve;
        private string kedvencSnack;

        public Fejleszto(string nev, Munkakor munkakor, int penz, int koffeinszint, int stresszSzint, bool kiegve, string kedvencSnack)
        {
            this.nev = nev;
            this.munkakor = munkakor;
            this.penz = penz;
            this.koffeinszint = koffeinszint;
            this.stresszSzint = stresszSzint;
            this.kiegve = kiegve;
            this.kedvencSnack = kedvencSnack;
        }

        public string Nev { get => nev; set => nev = value; }
        public Munkakor Munkakor { get => munkakor; set => munkakor = value; }
        public int Penz
        {
            get => penz; set
            {

                if (penz < 0)
                {
                    penz = 0;
                }
                else
                {

                    penz = value;
                }
            }
        }
        public int Koffeinszint
        {
            get => koffeinszint; set
            {

                if (koffeinszint < 0)
                {
                    koffeinszint = 0;
                }
                else if (koffeinszint > 100)
                {
                    koffeinszint = 100;
                    kiegve = true;
                }
                else
                {

                    koffeinszint = value;
                }
            }
        }
        public int StresszSzint
        {
            get => stresszSzint; set
            {

                if (stresszSzint < 0)
                {
                    stresszSzint = 0;
                }
                else if (stresszSzint > 100)
                {
                    stresszSzint = 100;
                    kiegve = true;
                }
                else
                {

                    stresszSzint = value;
                }
            }
        }
        public bool Kiegve
        {
            get { return kiegve; }
            private set { kiegve = value; }
        }
        public string KedvencSnack { get => kedvencSnack; set => kedvencSnack = value; }


        private void Dolgozik()
        {
            if(kiegve)
            {
                Console.WriteLine($"{nev} kimerült és nem tud dolgozni");
            }

            switch (Munkakor)
            {
                case Munkakor.Junior:
                    koffeinszint -= 25;
                    stresszSzint += 20;
                    break;
                case Munkakor.Senior:
                    koffeinszint -= 15;
                    stresszSzint += 10;
                    break;
                case Munkakor.DevOpsVarazslo:
                    koffeinszint -= 10;
                    stresszSzint += 25;
                    break;
            }

            if (koffeinszint <15)
            {
                Console.WriteLine($"{nev} agya lefagyott, koffeinre van szüksége!");
            }
        }
    }
}