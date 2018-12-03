using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _1BlogVF.Controllers
{
    public class AppController : Controller
    {
        //the name of the action should match the name of the view we earlier created Index.chtml 
        public IActionResult Index()
        {
            //View() helper methpod is used to return the ViewResult, the Index.chtml page is rendereds and shown
            return View();
        }
    }
}