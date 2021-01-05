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
    public class AddStatisticsModel : PageModel
    {

        public int RungtyniuID { get; set; }

        private readonly IFantasyRepository _repository;

        public AddStatisticsModel(IFantasyRepository repository)
        {
            _repository = repository;
            displayData = _repository.GetKomandos();
            matches = _repository.GetAllMatches();
        }

        public IEnumerable<Komanda> displayData { get; set; }
        public IEnumerable<Rungtynes> matches { get; set; }
        public IActionResult OnGet()
        {
            if (User.Claims.FirstOrDefault(item => item.Type == ClaimTypes.Role).Value != "1")
            {
                return RedirectToPagePermanent("Index");
            }

            return Page();
        }
    }
}
