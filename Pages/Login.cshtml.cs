using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using fantazijos_lyga.Data;
using fantazijos_lyga.db;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fantazijos_lyga.Pages
{
    public class LoginModel : PageModel
    {
        [Required(ErrorMessage = "Prašome įrašyti slapyvardį")]
        [BindProperty]
        public string Username { get; set; }

        [Required(ErrorMessage = "Prašome įrašyti slaptažodį")]
        [BindProperty]
        public string Password { get; set; }

        private readonly IFantasyRepository _repository;

        public LoginModel(IFantasyRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                User user = _repository.GetUserByUserName(Username);

                if (user == null)
                {
                    ModelState.AddModelError("UserDataInvalid", "Slapyvardis arba slaptažodis nėra tinkamas bandykite dar karta");
                    return Page();
                }

                if(user.Password != Password)
                {
                    ModelState.AddModelError("UserDataInvalid", "Slapyvardis arba slaptažodis nėra tinkamas bandykite dar karta");
                    return Page();
                }
                else
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Role, user.RoleID.ToString()),
                        new Claim("UserId", user.Id.ToString())
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                        IsPersistent = false,
                        RedirectUri = "/index"
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);
                    return RedirectToPage("/index");
                }
            }
            return Page();
            
        }

    }
}
