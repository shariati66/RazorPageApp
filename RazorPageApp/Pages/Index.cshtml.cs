using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RazorPageApp.Context;
using RazorPageApp.Models;

namespace RazorPageApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RazorPageAppContext _db;
        public IEnumerable<Operator> operators { get; set; }=new List<Operator>();
        
        public IndexModel(ILogger<IndexModel> logger, RazorPageAppContext db)
        {
            _logger = logger;
            _db = db;
           
        }
        
        public void OnGet()
        {
            operators = _db.Operator;
        }
       
        
    }
}
