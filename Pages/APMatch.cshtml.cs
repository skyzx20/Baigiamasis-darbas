using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.Duomenu_baze;
using fantazijos_lyga.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace fantazijos_lyga.Pages
{
    public class APMatchModel : PageModel
    {
        public IEnumerable<Rungtynes> Rungtynes { get; set; }

        private readonly IFantasyRepository _repository;
        private readonly IRazorRenderService _renderService;

        public APMatchModel(IFantasyRepository repository, IRazorRenderService renderServices)
        {
            _repository = repository;
            _renderService = renderServices;
        }

        public IActionResult OnGet()
        {
            if (User.Claims.FirstOrDefault(item => item.Type == ClaimTypes.Role).Value != "1")
            {
                return RedirectToPagePermanent("Index");
            }

            return Page();
        }

        public PartialViewResult OnGetViewAllPartial()
        {
            Rungtynes = _repository.GetAllMatches();

            return new PartialViewResult
            {
                ViewName = "PartialView/_APMatchView",
                ViewData = new ViewDataDictionary<IEnumerable<Rungtynes>>(ViewData, Rungtynes)
            };
        }

        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
            {
                Rungtynes rungtynes = new Rungtynes();
                rungtynes.komanduList = new SelectList(_repository.GetAllKomandos().ToList(), nameof(Komanda.ID), nameof(Komanda.Pavadinimas));
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("PartialView/_APMatchCreateOrEdit", rungtynes) });
            }
            else
            {
                var match = _repository.GetAllMatches().FirstOrDefault(item => item.ID == id);
                match.komanduList = new SelectList(_repository.GetAllKomandos(), nameof(Komanda.ID), nameof(Komanda.Pavadinimas));
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("PartialView/_APMatchCreateOrEdit", match) });
            }
        }

        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Rungtynes rungtynes)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    if (rungtynes.HomeTeamID == rungtynes.AwayTeamID)
                    {
  
                    }
                    else
                    {
                        _repository.AddNewMatch(rungtynes);
                        _repository.SaveChanges();
                    }

                }
                else
                {
                    if(rungtynes.HomeTeamID == rungtynes.AwayTeamID)
                    {

                    }
                    else
                    {
                        _repository.UpdateRungtynes(rungtynes);
                        _repository.SaveChanges();
                    }

                }
                Rungtynes = _repository.GetAllMatches();
                var html = await _renderService.ToStringAsync("PartialView/_APMatchView", Rungtynes);
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("PartialView/_APMatchCreateOrEdit", rungtynes);
                return new JsonResult(new { isValid = false, html });
            }
        }

        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var match = _repository.GetAllMatches().FirstOrDefault(item => item.ID == id);
            _repository.DeleteMatch(match);
            _repository.SaveChanges();
            Rungtynes = _repository.GetAllMatches();
            var html = await _renderService.ToStringAsync("PartialView/_APMatchView", Rungtynes);
            return new JsonResult(new { isValid = true, html });
        }
    }
}
