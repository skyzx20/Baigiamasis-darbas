using fantazijos_lyga.db;
using fantazijos_lyga.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Duomenu_baze
{
    public class Komanda
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Prašome įrašyti komandos pavadinimą")]
        public string Pavadinimas { get; set; }

        [Required(ErrorMessage = "Prašome įrašyti komandos sutrumpinimą")]
        public string ShortName { get; set; }

        [Required(ErrorMessage = "Prašome įrašyti komandos logotipo nuorodą")]
        public string Logo { get; set; }
        public RegionEnum Region { get; set; }

        public List<Zaidejas> Zaidejai { get; set; }

        public List<Rungtynes> HomeTeamList { get; set; }
        public List<Rungtynes> AwayTeamList { get; set; }

        [NotMapped]
        public SelectList regionoList { get; set; }

    }
}
