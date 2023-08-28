
using Microsoft.AspNetCore.Mvc;

using RequestMail.Models;
using System.Text;

namespace RequestMail.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact model)
        {

            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Ad & Soyad : " + model.Ad +"  "+ model.Soyad);
                body.AppendLine("Çalışma Lokasyonu : " + model.Lokasyon);
                body.AppendLine("Bağlı Olduğu Direktörlük : " + model.Direktor);
                body.AppendLine("Şirket : " + model.Sirket);
                body.AppendLine("Talep : " + model.Talep);
                Mail.MailSender(body.ToString());
                ViewBag.Success = true;
            }
            return View();
        }
    }
}
