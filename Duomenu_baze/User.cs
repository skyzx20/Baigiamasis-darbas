using fantazijos_lyga.Duomenu_baze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.db
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public int RoleID { get; set; }
        public Role Role { get; set; }

        public List<NaudotojoPick> NaudotojoPicks { get; set; }
    }
}
