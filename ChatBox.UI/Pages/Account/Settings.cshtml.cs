using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatBox.UI.Pages.Account
{
    public class SettingsModel : PageModel
    {
        [BindProperty] public string NewUsername { get; set; } = "";

        [BindProperty] public string CurrentPassword { get; set; } = "";
        [BindProperty] public string NewPassword { get; set; } = "";

        public string Message { get; set; } = "";
        public string ErrorMessage { get; set; } = "";

        public void OnGet()
        {
        }

        public IActionResult OnPostChangeUsername()
        {
            if (string.IsNullOrWhiteSpace(NewUsername))
            {
                ErrorMessage = "New username cannot be empty.";
                return Page();
            }

            // UI-placeholder: här ska ni senare kalla BLL/Identity och uppdatera användarnamn
            Message = "Username change submitted (UI placeholder).";
            return Page();
        }

        public IActionResult OnPostChangePassword()
        {
            if (string.IsNullOrWhiteSpace(CurrentPassword) || string.IsNullOrWhiteSpace(NewPassword))
            {
                ErrorMessage = "Please enter current password and new password.";
                return Page();
            }

            // UI-placeholder: här ska ni senare kalla BLL/Identity och uppdatera lösenord
            Message = "Password change submitted (UI placeholder).";
            return Page();
        }

        public IActionResult OnPostDeleteAccount()
        {
            // UI-placeholder: här ska ni senare kalla BLL/Identity och ta bort användaren
            // Efter delete: tillbaka till login
            return RedirectToPage("/Account/Login");
        }
    }
}