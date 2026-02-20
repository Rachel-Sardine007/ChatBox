using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatBox.UI.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // TODO: När ni använder Identity ska ni skriva:
            // await _signInManager.SignOutAsync();

            // UI-placeholder: bara redirecta till startsidan
            return RedirectToPage("/Index");
        }
    }
}