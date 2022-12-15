using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Domain;
using DataAccess;

namespace KitmEshop.Controllers
{
    public class ReviewController : Controller
    {
        private readonly EshopContext _db;

        public ReviewController(EshopContext db)
        {
            _db = db;
        }

        public IActionResult Add(Guid id)
        {
            var review = new Review();
            review.Product = _db.Products.FirstOrDefault(p => p.Id == id);
            
            return View(review);
        }

        [HttpPost]
        public IActionResult Add([Bind("ReviewText", "ProductId")] Review model)
        {
            var newReview = new Review();
            newReview.Product = _db.Products.FirstOrDefault(p => p.Id == model.ProductId);
            newReview.ReviewText = model.ReviewText;
          

            _db.Reviews.Add(newReview);
            _db.SaveChanges();

            // save to DB
            return RedirectToAction("Index", "Home", new { ReviewAdded = true });
        }
    }
}
