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
    public class Zaidejas
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Prašome įrašyti vardą")]
        public string Vardas { get; set; }
        public double Kaina { get; set; }
        [Required(ErrorMessage = "Prašome įrašyti nuotraukos adresą")]
        public string FotoPath { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti skaičių")]
        public int TotalPoints { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti skaičių")]
        public int TotalRebounds { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti skaičių")]
        public int TotalAssist {get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti skaičių")]
        public int TotalBlocks { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti skaičių")]
        public int TotalTurnovers { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti skaičių")]
        public int TotalPersonalFouls { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Įveskite teigiama skaičių")]
        [Required(ErrorMessage = "Prašome įrašyti skaičių")]
        public int GamesPlayer { get; set; }
        public PositionEnum Position { get; set; }

        public int KomandaID { get; set; }
        public Komanda Komanda { get; set; }

        public List<RungtyniuStatistika> RungtyniuStatistikos { get; set; }
        public List<NaudotojoPick> PirmoZaidejoList { get; set; }
        public List<NaudotojoPick> AntroZaidejoList { get; set; }

        public List<NaudotojoPick> TrecioZaidejoList { get; set; }
        public List<NaudotojoPick> KetvirtoZaidejoList { get; set; }

        public List<NaudotojoPick> PenktoZaidejoList { get; set; }

        [NotMapped]
        public SelectList komanduList { get; set; }

        [NotMapped]
        public SelectList pozicijuList { get; set; }

    }
}
