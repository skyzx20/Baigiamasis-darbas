using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace fantazijos_lyga.Pages
{
    public class RegisterModel : PageModel
    {
        [Required(ErrorMessage = "Prašome įrašyti slapyvardį")]
        [BindProperty]
        public string Username { get; set; }

        [Required(ErrorMessage = "Prašome įrašyti el. pašto adresą")]
        [BindProperty]
        [EmailAddress(ErrorMessage = "Netinkamas el. pašto formatas")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prašome įrašyti slaptažodį")]
        [BindProperty]
        public string Password { get; set; }

        [Required(ErrorMessage = "Prašome pakartokite slaptažodį")]
        [BindProperty]
        public string PasswordRepeat { get; set; }

        private readonly IFantasyRepository _repository;

        public RegisterModel(IFantasyRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            User useris = new User() { Username = Username, Password = Password, Email = Email,RoleID=2};
            User usernameCheck = _repository.GetUserByUserName(Username);
            User emailCheck = _repository.GetUserByEmail(Email);
            _repository.AddNewUser(useris);
            

            if (ModelState.IsValid)
            {
                if (usernameCheck != null)
                {
                    ModelState.AddModelError("UserDataInvalid", "Toks vartotojas jau egzistuoja");
                    return Page();
                }

                if (emailCheck != null)
                {
                    ModelState.AddModelError("UserDataInvalid", "Vartotojas su tokiu el. Pašto adresu jau egzistuoja");
                    return Page();
                }

                if (Password != PasswordRepeat)
                {
                    ModelState.AddModelError("UserDataInvalid", "Slaptazodziai nesutampa");
                    return Page();
                }

                else
                {
                    _repository.SaveChanges();
                    return RedirectToPage("/Login");
                }
            }
            return Page();
        }

    }
}



