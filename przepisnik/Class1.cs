using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przepisnik
{
    public enum PoryDnia { Sniadanie, Obiad, Kolacja, Przekaski }

    public class Class1 
    {
        public PoryDnia Poradnia { get; set; }
       
        public Class1() { }

        public Class1(PoryDnia PoraDnia)
        {
            this.Poradnia = Poradnia;
        }
    }

}
