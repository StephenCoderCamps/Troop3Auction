using Auction.Models;
using Auction.Views.Bids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auction.Controllers
{
    public class BidsController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Bids
        public ActionResult Index()
        {
            return View();
        }


        // GET: Bids/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bids/Create
        public ActionResult BidOnItem(int id)
        {
            var vm = new BidOnItemVM
            {
                Item = _db.Items.Find(id)
            };
            return View(vm);
        }

        // POST: Bids/Create
        [HttpPost]
        public ActionResult BidOnItem(int id, Bid bid)
        {
            var original = _db.Items.Find(id);
            if (ModelState.IsValid) {
                original.Bids.Add(bid);
                original.NumberOfBids = (from n in _db.Bids where n.Item.Id == id select n).Count()+1;
                _db.SaveChanges();
                return RedirectToAction("Index","Items");
            }
            var vm = new BidOnItemVM
            {
                Item = original
            };

            return View(vm);

        }

        // GET: Bids/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bids/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bids/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bids/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
