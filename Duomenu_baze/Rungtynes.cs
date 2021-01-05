using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Duomenu_baze
{
    public class Rungtynes
    {
        public int ID { get; set; }

        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti rezultatą")]
        public int HomeTeamScore { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti rezultatą")]
        public int AwayTeamScore { get; set; }

        public DateTime StartDate { get; set;}

        public List<RungtyniuStatistika> RungtyniuStatistikos { get; set; }

        public List<NaudotojoPick> NaudotojoPicks { get; set; }

        public Komanda HomeTeam { get; set; }
        public Komanda AwayTeam { get; set; }

        [NotMapped]
        public SelectList komanduList { get; set; }


    }
}
