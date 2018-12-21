using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwesomeShop.Models;

namespace AwesomeShop.Controllers
{
    public class ItemController : Controller
    {
        private AwesomeContext context = new AwesomeContext();

        // GET: Item
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item item, HttpPostedFileBase photo)
        {

            item.CreatedDate = DateTime.Today;
            if (ModelState.IsValid)
            {
                //Reading the photo
                item.ImageMimeType = photo.ContentType;
                item.ItemPhoto = new byte [photo.ContentLength];
                photo.InputStream.Read(item.ItemPhoto, 0, photo.ContentLength);

                context.Items.Add(item);
                context.SaveChanges();
                return RedirectToAction("Create");
            }
            return View("Create", item);
        }
    }
}