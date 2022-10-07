using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class FormExample01Model : PageModel
    {
        public string FeedbackMessage { get; set; }
        public void OnGet()
        {
            FeedbackMessage = "This was with a get";
        }
        public void OnPost()
        {
            FeedbackMessage = "this was big submitted";
        }
    }
}
