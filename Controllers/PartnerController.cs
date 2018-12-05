using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pellys.Data;
using Pellys.Models;

namespace Pellys.Controllers
{
    [Authorize]
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
            return View();
        }

        public IActionResult GetPartner()
        {
            var partners = _context.Partners.ToList();
            
            return Json(partners);
        }


        public IActionResult New()
        {
            var partner = new Partner();

            return View(partner);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Partner partner = _context.Partners.Find(id);
            if (partner == null)
                return Json("0");
            else
            {
                try
                {
                    _context.Partners.Remove(partner);
                    _context.SaveChanges();
                    return Json("1");
                }
                catch(Exception ex)
                {
                    return Json(ex.InnerException);
                }
            }
        }

    }
}