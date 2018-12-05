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
            var partner = _context.Partners.Find(id);

            if (partner == null)
                return Json("0");

            try
            {
                _context.Partners.Remove(partner);
                _context.SaveChanges();
                return Json("1");
            }
            catch (Exception ex)
            {
                return Json(ex.InnerException);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Partner partner)
        {
            if (!ModelState.IsValid)
            {
                var model = new Partner();

                return View("New", model);
            }

            if (partner.PartnerId == 0)
                _context.Partners.Add(partner);
            else
            {
                var partnerInDb = _context.Partners.Single(m => m.PartnerId == partner.PartnerId);

                partnerInDb.PartnerName = partner.PartnerName;
                partnerInDb.PartnerAddress = partner.PartnerAddress;
                partnerInDb.PartnerTelephone = partner.PartnerTelephone;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Partner");
        }
    }
}