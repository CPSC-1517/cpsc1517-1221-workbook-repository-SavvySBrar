using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class FormExample02Model : PageModel
    {
        public string FeedbackMessage { get; private set; }

        
        public void OnPost()
        {
            FeedbackMessage = "Your lucky numbers are:";
            var rand = new Random();
            var generatedNums = new List<int>();
            while (generatedNums.Count < 7)
            {
                var randomNum = rand.Next(1, 51);
                if (generatedNums.Contains(randomNum))
                {
                    generatedNums.Add(randomNum);
                }
            }
            generatedNums.Sort();
            FeedbackMessage = generatedNums.ToString();
        }
    }
}
