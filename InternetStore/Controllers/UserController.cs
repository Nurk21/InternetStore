using InternetStore.Common.Models;
using InternetStore.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetStore.Controllers
{
    public class UserController : Controller
    {
        UnitOfWork unitOfWork;
        public UserController()
        {
            unitOfWork = new UnitOfWork();
        }
        //public ActionResult Index()
        //{
        //    var books = unitOfWork.Books.GetAll();
        //    return View();
        //}

        //public ActionResult Create()
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<ActionResult> Create(User u)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.Users.AddAsync(u);
                unitOfWork.Save();
                //return RedirectToAction("Index");
            }
            return View(u);
        }

        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await unitOfWork.Users.DeleteByIdAsync(id);
            
            return View();
        }

        //[HttpPost]
        //public ActionResult Edit(Book b)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        unitOfWork.Books.Update(b);
        //        unitOfWork.Save();
        //        return RedirectToAction("Index");
        //    }
        //    return View(b);
        //}

        //public ActionResult Delete(int id)
        //{
        //    unitOfWork.Books.Delete(id);
        //    unitOfWork.Save();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}
