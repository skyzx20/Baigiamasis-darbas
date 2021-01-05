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
    public class AddTeamModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Prašome pasirinkti namu komanda")]
        public int HomeTeam { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Prašome pasirinkti isvykos komanda")]
        public int AwayTeam { get; set; }

        [BindProperty]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Prašome irašyti rungtynių data")]
        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }

        private readonly IFantasyRepository _repository;

        public AddTeamModel(IFantasyRepository repository)
        {
            _repository = repository;
            displayData = _repository.GetKomandos();
        }

        public IEnumerable<Komanda> displayData { get; set; }
        public IActionResult OnGet()
        {
            if (User.Claims.FirstOrDefault(item => item.Type == ClaimTypes.Role).Value != "1")
            {
                return RedirectToPagePermanent("Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            Rungtynes dateCheck = _repository.GetMatchByDate(date);
            if (ModelState.IsValid)
            {
                if(dateCheck != null)
                {
                    ModelState.AddModelError("UserDataInvalid", "Tokios rungtynės jau yra sukurtos");
                    return Page();
                }

                Rungtynes match = new Rungtynes() { HomeTeamID = HomeTeam, AwayTeamID = AwayTeam, StartDate = date };

                if (HomeTeam == AwayTeam)
                {
                    ModelState.AddModelError("UserDataInvalid", "Tos pačios komandos žaisti negali");
                    return Page();
                }

                else
                {
                    _repository.AddNewMatch(match);
                    _repository.SaveChanges();

                    return RedirectToPage("/Index");
                }
            }
            return Page();
        }
    }
}
