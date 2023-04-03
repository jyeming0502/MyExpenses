using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Web;
using MyExpenses.Model;

namespace MyExpenses.Pages
{
    public class TransactionModel : PageModel
    {
        private readonly ILogger<TransactionModel> _logger;

        public TransactionModel(ILogger<TransactionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public int TransactionId { get; set; }

        public Account AccountName { get; set; }
        public DateTime TransactionDate { get; set; }

        public string TransactionDetail { get; set; }

        public Category CategoryName { get; set; }

        public string TransactionLocation { get; set; }

        public float TransactionAmount { get; set; }  

    }   
}