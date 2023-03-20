using Microsoft.AspNetCore.Mvc;
using QuotationMVC.Models;
using System.Diagnostics;

namespace QuotationMVC.Controllers
{
    public class HomeController : Controller
    {        
        [HttpGet]
        public IActionResult Index()
        {
            Quotation quotation = new Quotation();
            quotation.SalesPrice = 0;
            quotation.DiscountPercent = 0;
            return View("Quotation", quotation);
        }
        [HttpPost] 
        public IActionResult Quotation(Quotation quotation)
        {

            return View("Quotation", quotation);
        }
    }
}