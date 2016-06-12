using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przepisnik
{

   public enum Potrawa { PLACUSZKI_Z_JABŁKAMI, BUŁECZKI_CYNAMONOWE, FRITTATA_Z_SZYNKĄ, PLACKI_ZIEMNIACZANE , MUFFINY_JAJECZNE , BRUSCHETTA , OWOCE_ZAPIEKANE_POD_KRUSZONKĄ , SALSA_POMIDOROWA }
    public enum Sniadania { PLACUSZKI_Z_JABŁKAMI, BUŁECZKI_CYNAMONOWE }
    public enum Obiady { FRITTATA_Z_SZYNKĄ, PLACKI_ZIEMNIACZANE }
    public enum Kolacje { MUFFINY_JAJECZNE, BRUSCHETTA }
    public enum Przekaskii { OWOCE_ZAPIEKANE_POD_KRUSZONKĄ, SALSA_POMIDOROWA }

    class ListaZak : Class1
    {
        public Sniadania Sniadania { get; set; }
        public Obiady Obiady { get; set; }
        public Kolacje Kolacje { get; set; }
        public Przekaskii Przekasii { get; set; }

        public Potrawa Potrawa { get; set; }

        public ListaZak()  // konstruktor domyslny
        {
        }
        //public ListaZak(PoryDnia PoraDnia, Potrawa potrawa,Sniadania sniadania) : base(PoraDnia)
        public ListaZak(PoryDnia PoraDnia, Potrawa potrawa,  Sniadania sniadania, Obiady obiady, Kolacje kolacje, Przekaskii przekaskii) : base(PoraDnia)
        {//,Potrawa potrawa  Sniadania sniadania, Obiady obiady, Kolacje kolacje,Przekaskii przekaskii
            this.Sniadania = sniadania;
            this.Obiady = obiady;
            this.Kolacje = kolacje;
            this.Przekasii = przekaskii;
            this.Potrawa = potrawa;

        }

        

       
    }
}
