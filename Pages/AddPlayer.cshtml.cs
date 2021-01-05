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

    public class AddPlayerModel : PageModel
    {

    [BindProperty]
    [Required(ErrorMessage = "Prašome irašyti žaidėjo vardą")]
    public string vardas { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "Prašome pasirinkti komandą")]
    public int komandaId { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "Prašome irašyti nuotraukos adresą")]
    public string fotoURL { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "Prašome pasirinkti pozicija")]
    public string pozicija { get; set; }

    private readonly IFantasyRepository _repository;

    public AddPlayerModel(IFantasyRepository repository)
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

            if (ModelState.IsValid)
            {
                Zaidejas zaidejas = new Zaidejas()
                {
                    GamesPlayer = 1,
                    KomandaID = komandaId,
                    Vardas = vardas,
                    FotoPath = fotoURL,
                    TotalPoints = 1,
                    TotalRebounds = 1,
                    TotalAssist = 1,
                    TotalBlocks = 1,
                    TotalTurnovers = 1,
                    TotalPersonalFouls = 1,
                    Kaina = 2000
                    };

                _repository.AddNewPlayer(zaidejas);
                    _repository.SaveChanges();

                    return RedirectToPage("/Index");
             }
            return Page();
        }
    }
}
