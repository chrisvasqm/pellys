using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pellys.Data;
using Pellys.Models;

namespace Pellys.Controllers
{
    public class PartnerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PartnerController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            var partners = _context.Partners.ToList();

            return View(partners);
        }

        public IActionResult New()
        {
            var partner = new Partner();

            return View(partner);
        }
    }
}