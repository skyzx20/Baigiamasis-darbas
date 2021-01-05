using fantazijos_lyga.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Duomenu_baze
{
    public class NaudotojoPick
    {
        public int ID { get; set; }
        public double TotalPoints { get; set; }

        public int ZaidejasPirmasID { get; set; }
        public int ZaidejasAntrasID { get; set; }
        public int ZaidejasTreciasID { get; set; }
        public int ZaidejasKetvirtasID { get; set; }

        public int ZaidejasPenktasID { get; set; }

        public int likoPinigu { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public Zaidejas ZaidejasPirmas { get; set; }
        public Zaidejas ZaidejasAntras { get; set; }
        public Zaidejas ZaidejasTrecias{ get; set; }
        public Zaidejas ZaidejasKetvirtas { get; set; }
        public Zaidejas ZaidejasPenktas { get; set; }

        public int RungtynesID { get; set; }
        public Rungtynes Rungtynes { get; set; }

    }
}
