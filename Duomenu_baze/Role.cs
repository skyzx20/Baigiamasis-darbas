using fantazijos_lyga.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Duomenu_baze
{
    public class Role
    {
        public int ID { get; set; }
        public string Pavadinimas { get; set; }

        public List<User> Users { get; set; }
    }
}
