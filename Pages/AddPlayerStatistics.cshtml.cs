using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.db;
using fantazijos_lyga.Duomenu_baze;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace fantazijos_lyga.Pages
{
    public class AddPlayerStatisticsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int RungtyniuID { get; set; }

        [BindProperty]
        public List<string> Vardas { get; set; }

        [BindProperty]
        [RegularExpression(@"[0-9][0-9]?[0-9]?:[0-5][0-9]", ErrorMessage = "Netinkamas laiko formatas")]
        public List<string> Minutes { get; set; }

        [BindProperty]
        public List<int> Points { get; set; }

        [BindProperty]
        public List<int> Rebounds { get; set; }

        [BindProperty]
        public List<int> Assists { get; set; }

        [BindProperty]
        public List<int> Turnovers { get; set; }

        [BindProperty]
        public List<int> Blocks { get; set; }

        [BindProperty]
        public List<int> PersonalFouls { get; set; }

        [BindProperty]
        public int HomeScore { get; set; }

        [BindProperty]
        public int AwayScore { get; set; }

        public Rungtynes Rungtynes { get; set; }

        private readonly IFantasyRepository _repository;

        public AddPlayerStatisticsModel(IFantasyRepository repository)
        {
            _repository = repository;
        }
        public IActionResult OnGet()
        {
            Rungtynes = _repository.GetRungtynesByRungtynesID(RungtyniuID);
            if (User.Claims.FirstOrDefault(item => item.Type == ClaimTypes.Role).Value != "1")
            {
                return RedirectToPagePermanent("Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            List<Zaidejas> zaidejuListas = new List<Zaidejas>();

            for (int i = 0; i < Points.Count; i++)
            {
                Zaidejas zaidejas = _repository.GetZaidejasIdByName(Vardas[i]);

                RungtyniuStatistika rungtyniuStatistika = new RungtyniuStatistika()
                {
                    ZaidejasID = zaidejas.ID,
                    MIN = Minutes[i],
                    PTS = Points[i],
                    REB = Rebounds[i],
                    AST = Assists[i],
                    TOV = Turnovers[i],
                    BLK = Blocks[i],
                    PF = PersonalFouls[i],
                    RungtynesID = RungtyniuID,
                    GautuTaskuKiekis = (Points[i] * 2) + (Rebounds[i] * 3) + (Assists[i] * 3) - (Turnovers[i] * 2) - (PersonalFouls[i] * 3)
                };

                if(Convert.ToInt32(rungtyniuStatistika.MIN.Split(":")[0]) != 0 || Convert.ToInt32(rungtyniuStatistika.MIN.Split(":")[1]) != 0)
                {
                    zaidejas.TotalPoints += Points[i];
                    zaidejas.TotalRebounds += Rebounds[i];
                    zaidejas.TotalAssist += Assists[i];
                    zaidejas.TotalTurnovers += Turnovers[i];
                    zaidejas.TotalBlocks += Blocks[i];
                    zaidejas.TotalPersonalFouls += PersonalFouls[i];
                    zaidejas.GamesPlayer += 1;
                    zaidejas.Kaina =
                        (((double)(zaidejas.TotalPoints / zaidejas.GamesPlayer) +
                        (double)(zaidejas.TotalAssist / zaidejas.GamesPlayer) +
                        (double)(zaidejas.TotalRebounds / zaidejas.GamesPlayer) +
                        (double)(zaidejas.TotalBlocks / zaidejas.GamesPlayer) -
                        (double)(zaidejas.TotalPersonalFouls / zaidejas.GamesPlayer) -
                        (double)(zaidejas.TotalTurnovers / zaidejas.GamesPlayer)) * 100);
                }

                _repository.UpdateZaidejas(zaidejas);
                _repository.AddPlayerStatistic(rungtyniuStatistika);
            }
                
            Rungtynes newRungtynes = _repository.GetRungtynesByRungtynesID(RungtyniuID);
            newRungtynes.HomeTeamScore = HomeScore;
            newRungtynes.AwayTeamScore = AwayScore;
            _repository.UpdateRungtynes(newRungtynes);

            _repository.SaveChanges();
             return RedirectToPagePermanent("Index");
        }

    }
}
