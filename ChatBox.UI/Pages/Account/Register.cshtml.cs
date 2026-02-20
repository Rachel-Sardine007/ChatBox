using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatBox.UI.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty] public string Username { get; set; } = "";
        [BindProperty] public string Password { get; set; } = "";

        public string ErrorMessage { get; set; } = "";

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Fyll i både användarnamn och lösenord.";
                return Page();
            }

            // UI-placeholder: här ska ni senare kalla BLL/Identity och skapa användaren

            // Efter register: tillbaka till login
            return RedirectToPage("/Account/Login");
        }
    }
}