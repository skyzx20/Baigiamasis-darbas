using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Duomenu_baze
{
    public class RungtyniuStatistika
    {
        public int ID { get; set; }
        public string MIN { get; set; }
        public double PTS { get; set; }
        public int REB { get; set; }
        public int AST { get; set; }
        public int TOV { get; set; }
        public int BLK { get; set; }
        public int PF { get; set; }

        public double GautuTaskuKiekis { get; set; }

        public int ZaidejasID { get; set; }
        public Zaidejas Zaidejas { get; set; }

        public int RungtynesID { get; set; }
        public Rungtynes Rungtynes { get; set; }

    }
}
