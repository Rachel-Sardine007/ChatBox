using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ChatBox.UI.Pages.Messages
{
    public class ChatModel : PageModel
    {
        [BindProperty] public string Text { get; set; } = "";

        public string ErrorMessage { get; set; } = "";

        // Placeholder-lista (sen fyller BLL denna)
        public List<MessageDto> Messages { get; set; } = new();

        public void OnGet()
        {
            // Lämna listan tom tills någon skriver i chatten
            Messages = new List<MessageDto>();

        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                ErrorMessage = "Message cannot be empty.";
                return Page();
            }

            // UI placeholder: i riktig version sparar ni via BLL här
            // Efter POST: refresh sidan (PRG pattern)
            return RedirectToPage();
        }

        public class MessageDto
        {
            public string Username { get; set; } = "";
            public string Text { get; set; } = "";
            public bool IsMine { get; set; }
        }
    }
}