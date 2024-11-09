using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using RazorPageApp.Context;
using RazorPageApp.Models;

namespace RazorPageApp.Pages
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly RazorPageAppContext _db;

        public CreateModel(RazorPageAppContext db)
        {
            _db = db;
        }

        public Operator Operator { get; set; }


        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Add(Operator);
            _db.SaveChanges();
            return RedirectToPage(nameof(Index));
        }
    }
}
