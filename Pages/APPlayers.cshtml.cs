using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.Duomenu_baze;
using fantazijos_lyga.Enums;
using fantazijos_lyga.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace fantazijos_lyga.Pages
{
    public class APPlayersModel : PageModel
    {
        public IEnumerable<Zaidejas> Zaidejas { get; set; }

        private readonly IFantasyRepository _repository;
        private readonly IRazorRenderService _renderService;

        public APPlayersModel(IFantasyRepository repository, IRazorRenderService renderServices)
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
            Zaidejas = _repository.GetAllZaidejai();

            return new PartialViewResult
            {
                ViewName = "PartialView/_APPlayersView",
                ViewData = new ViewDataDictionary<IEnumerable<Zaidejas>>(ViewData, Zaidejas)
            };
        }

        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
            {
                Zaidejas zaidejas = new Zaidejas();
                zaidejas.komanduList = new SelectList(_repository.GetAllKomandos().ToList(), nameof(Komanda.ID), nameof(Komanda.Pavadinimas));
                zaidejas.pozicijuList = new SelectList(Enum.GetValues(typeof(PositionEnum)));
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("PartialView/_APPlayersCreateOrEdit", zaidejas) });
            }
            else
            {
                var zaidejas = _repository.GetZaidejai().FirstOrDefault(item => item.ID == id);
                zaidejas.pozicijuList = new SelectList(Enum.GetValues(typeof(PositionEnum)));
                zaidejas.komanduList = new SelectList(_repository.GetAllKomandos(), nameof(Komanda.ID), nameof(Komanda.Pavadinimas));
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("PartialView/_APPlayersCreateOrEdit", zaidejas) });
            }
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

        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Zaidejas zaidejas)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    var req = (HttpWebRequest)HttpWebRequest.Create(zaidejas.FotoPath);
                    req.Method = "HEAD";
                    using (var resp = req.GetResponse())
                    {
                     if (resp.ContentType.ToLower(CultureInfo.InvariantCulture).StartsWith("image/") != true)
                     {
                         zaidejas.FotoPath = "https://www.nba.com/stats/media/img/no-headshot_small.png";
                     }
                    
                    }

                    if (zaidejas.GamesPlayer == 0)
                    {
                        zaidejas.Kaina = 2000;
                    }
                    else
                    {
                        zaidejas.Kaina = 100 * (CalculateAvg(zaidejas.TotalPoints, zaidejas.GamesPlayer) + CalculateAvg(zaidejas.TotalAssist, zaidejas.GamesPlayer) + CalculateAvg(zaidejas.TotalBlocks, zaidejas.GamesPlayer) + CalculateAvg(zaidejas.TotalRebounds, zaidejas.GamesPlayer) - CalculateAvg(zaidejas.TotalTurnovers, zaidejas.GamesPlayer) - CalculateAvg(zaidejas.TotalPersonalFouls, zaidejas.GamesPlayer));
                    } 
                    _repository.AddZaidejas(zaidejas);
                    _repository.SaveChanges();
                }

                else
                {
                       _repository.UpdateZaidejas(zaidejas);
                        _repository.SaveChanges();

                }
                Zaidejas = _repository.GetAllZaidejai();
                var html = await _renderService.ToStringAsync("PartialView/_APPlayersView", Zaidejas);
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("PartialView/_APPlayersCreateOrEdit", zaidejas);
                return new JsonResult(new { isValid = false, html });
            }
        }

        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var zaidejas = _repository.GetZaidejai().FirstOrDefault(item => item.ID == id);
            _repository.DeleteZaidejas(zaidejas);
            _repository.SaveChanges();
            Zaidejas = _repository.GetAllZaidejai();
            var html = await _renderService.ToStringAsync("PartialView/_APPlayersView", Zaidejas);
            return new JsonResult(new { isValid = true, html });
        }
    }
}
