using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatBox.UI.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; } = "";
        
        [BindProperty] 
        public string Password { get; set; } = "";

        public string ErrorMessage { get; set; } = "";

        public void OnGet()
        {
            // När sidan öppnas (GET) - inget behövs just nu
        }

        public IActionResult OnPost()
        {
            // När man klickar på Login (POST)
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Fyll i både användarnamn och lösenord.";
                return Page();
            }

            // UI-placeholder: här ska ni senare kalla BLL/Identity för riktig login

            // Efter "login" - gå till chatten
            return RedirectToPage("/Messages/Chat");
        }
    }
}