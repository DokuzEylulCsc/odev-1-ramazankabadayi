using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    public abstract class Asker
    {

        public Asker()
        {
            hayattaMi = true;
            saglikMiktari = 100;
        }

        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } }

        
        public abstract void HaraketEt();

        public abstract void Bekle();

        public abstract void Ates_Et();

      
        public bool hayattaMi { get; set; }

        public int saglikMiktari { get; set; }



    }
}
