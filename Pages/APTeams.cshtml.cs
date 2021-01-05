using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.Duomenu_baze;
using fantazijos_lyga.Enums;
using fantazijos_lyga.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace fantazijos_lyga.Pages
{
    public class APTeamsModel : PageModel
    {
        public IEnumerable<Komanda> Komandos { get; set; }

        private readonly IFantasyRepository _repository;
        private readonly IRazorRenderService _renderService;

        public APTeamsModel(IFantasyRepository repository, IRazorRenderService renderServices)
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
            Komandos = _repository.GetAllKomandos();

            return new PartialViewResult
            {
                ViewName = "PartialView/_APTeamsView",
                ViewData = new ViewDataDictionary<IEnumerable<Komanda>>(ViewData, Komandos)
            };
        }

        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
            {
                Komanda komanda = new Komanda()
                { 
                    regionoList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(Enum.GetValues(typeof(RegionEnum)))
                };
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("PartialView/_APTeamsCreateOrEdit", komanda) });
            }
            else
            {
                var komanda = _repository.GetKomandos().FirstOrDefault(item => item.ID == id);
                komanda.regionoList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(Enum.GetValues(typeof(RegionEnum)));
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("PartialView/_APTeamsCreateOrEdit", komanda) });
            }
        }

        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Komanda komanda)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {

                    _repository.AddKomanda(komanda);
                    _repository.SaveChanges();
                }
                else
                {
                    _repository.UpdateKomanda(komanda);
                    _repository.SaveChanges();
                }
                Komandos = _repository.GetAllKomandos();
                var html = await _renderService.ToStringAsync("PartialView/_APTeamsView", Komandos);
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("PartialView/_APTeamsCreateOrEdit", komanda);
                return new JsonResult(new { isValid = false, html });
            }
        }

        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var komanda = _repository.GetKomandos().FirstOrDefault(item => item.ID == id);
            _repository.DeleteKomanda(komanda);
            _repository.SaveChanges();
            Komandos = _repository.GetAllKomandos();
            var html = await _renderService.ToStringAsync("PartialView/_APTeamsView", Komandos);
            return new JsonResult(new { isValid = true, html });
        }
    }
}
