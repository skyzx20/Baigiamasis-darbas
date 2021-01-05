using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.Duomenu_baze;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fantazijos_lyga.Pages
{
    public class WinnerPageModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int RungtyniuID { get; set; }

        public Rungtynes Rungtynes { get; set; }
        public List<NaudotojoPick> NaudotojoPicks { get; set; }

        private readonly IFantasyRepository _repository;

        public WinnerPageModel(IFantasyRepository fantasyRepository)
        {
            _repository = fantasyRepository;
        }

        public IActionResult OnGet()
        {
            Rungtynes = _repository.GetRungtynesByRungtynesID(RungtyniuID);
            NaudotojoPicks = _repository.GetNaudotojoPicksByRungtyniuId(RungtyniuID).ToList();

            if(Rungtynes == null || Rungtynes.RungtyniuStatistikos == null || Rungtynes?.RungtyniuStatistikos?.Count == 0)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
