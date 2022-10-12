using Microsoft.Ajax.Utilities;
using sep10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sep10.Controllers
{
    public class BookController : Controller
    {
        
        
        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            NewLibraryEntities context = new NewLibraryEntities();
            List<Book> BookList = context.Books.ToList();
            return View(BookList);
        }

       
        public ActionResult Changereturndate(int id)
        {
            NewLibraryEntities context = new NewLibraryEntities();
            List<Book> BookList = context.Books.ToList();
            Book foundData = BookList.Find(Book => Book.book_no== id);


            return View(foundData);
        }

        [HttpPost]
        public ActionResult Changereturndate(int id, Book Model)
        {
            NewLibraryEntities context = new NewLibraryEntities();
            List<Book> BookList = context.Books.ToList();
            Book foundData = BookList.Find(Book => Book.book_no == id);
            BookList.Remove(foundData);
            BookList.Add(Model);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
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

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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
