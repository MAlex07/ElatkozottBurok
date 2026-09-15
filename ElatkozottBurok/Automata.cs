using System;
using System.Collections.Generic;
using System.Linq;

namespace ElatkozottBurok
{
    public class Automata
    {
        private int keszpenzKassza;
        private List<Nassolnivalo> keszlet;
        private bool elakadva;

        public Automata(int keszpenzKassza, List<Nassolnivalo> készlet, bool elakadva)
        {
            this.keszpenzKassza = keszpenzKassza;
            this.keszlet = készlet;
            this.elakadva = elakadva;
        }

        public int KeszpenzKassza { get => keszpenzKassza; set => keszpenzKassza = value; }
        public List<Nassolnivalo> Keszlet { get => keszlet; set => keszlet = value; }
        public bool Elakadva { get => elakadva; set => elakadva = value; }


        private void Feltolt(List<Nassolnivalo> nassolnivalos)
        {
            Keszlet.AddRange(nassolnivalos);
        }

        //private Nassolnivalo Vasarlas(string termekNev, Fejleszto vasarlo)
        //{
        //    if (elakadva)
        //    {
        //        Fejleszto fejleszto.stresszSzint += 15;
        //    }
        //}
        

        
    }
}
