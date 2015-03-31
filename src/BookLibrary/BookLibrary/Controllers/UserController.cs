using BookLibrary.DataAccess.Concrete;
using BookLibrary.DataAccess.Concrete.Interface;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class UserController : Controller
    {
        private IUnityOfWork unityOfWork;

        public UserController(IUnityOfWork unityofWork)
        {
            this.unityOfWork = unityofWork;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
    }
}