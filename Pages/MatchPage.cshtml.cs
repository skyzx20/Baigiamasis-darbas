using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.Duomenu_baze;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace fantazijos_lyga.Pages
{
    public class MatchPageModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public int RungtyniuID { get; set; }


        public Rungtynes Rungtynes { get; set; }

        public Zaidejas zaidejas { get; set; }

        public NaudotojoPick NaudotojoPick { get; set; }

        private readonly IFantasyRepository _repository;

        public MatchPageModel(IFantasyRepository repository)
        {
            _repository = repository;
        }

        public double CalculateAvg(double up, double down)
        {
            try
            {
                return (up / down);
            }
            catch
            {
                return 0;
            }
        }

        public IActionResult OnGet()
        {
            Rungtynes = _repository.GetRungtynesByRungtynesID(RungtyniuID);

            if(Rungtynes.StartDate <= DateTime.Now)
            {
                return new RedirectToPageResult("Index");
            }

            try
            {
                NaudotojoPick = _repository.GetNaudotojoPickByUserId(Convert.ToInt32(User.Claims.FirstOrDefault(item => item.Type == "UserId").Value)).FirstOrDefault(item => item.RungtynesID == RungtyniuID);
            }
            catch {}

            return Page();
        }

        public IActionResult OnPostAddingUserPicks(int userId, string firstPlayerPick, string secondPlayerPick, string thirdPlayerPick, string forthPlayerPick, string fifthPlayerPick,int leftMoney)
        {
            NaudotojoPick naudotojoPicks = _repository.GetNaudotojoPickByUserId(userId).FirstOrDefault(item => item.RungtynesID == RungtyniuID);

            Zaidejas firstPick = _repository.GetZaidejasIdByName(firstPlayerPick);
            Zaidejas secondPick = _repository.GetZaidejasIdByName(secondPlayerPick);
            Zaidejas thirdPick = _repository.GetZaidejasIdByName(thirdPlayerPick);
            Zaidejas forthPick = _repository.GetZaidejasIdByName(forthPlayerPick);
            Zaidejas fifthPick = _repository.GetZaidejasIdByName(fifthPlayerPick);

            NaudotojoPick naudotojoPick = new NaudotojoPick();

            if (naudotojoPicks != null)
            {
                naudotojoPick = naudotojoPicks;
            }

            naudotojoPick.UserId = userId;
            naudotojoPick.ZaidejasPirmasID = firstPick.ID;
            naudotojoPick.ZaidejasAntrasID = secondPick.ID;
            naudotojoPick.ZaidejasTreciasID = thirdPick.ID;
            naudotojoPick.ZaidejasKetvirtasID = forthPick.ID;
            naudotojoPick.ZaidejasPenktasID = fifthPick.ID;
            naudotojoPick.TotalPoints = 0;
            naudotojoPick.likoPinigu = leftMoney;
            naudotojoPick.RungtynesID = RungtyniuID;

            if(10000 - (firstPick.Kaina + secondPick.Kaina + thirdPick.Kaina + forthPick.Kaina + fifthPick.Kaina) != leftMoney)
            {
                return BadRequest("To daryti negalima");
            }
       
            if (naudotojoPicks != null)
                    _repository.UpdateNaudotojoPick(naudotojoPick);
            else
                _repository.AddUserPicks(naudotojoPick);
            _repository.SaveChanges();

            return new OkResult();
        }
    }
}
