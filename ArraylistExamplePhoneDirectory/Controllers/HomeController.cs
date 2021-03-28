using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArraylistExamplePhoneDirectory.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArraylistExamplePhoneDirectory.Models;

namespace ArraylistExamplePhoneDirectory.Controllers
{

  
    public class HomeController : Controller
    {  /*public ArrayList memberList = new ArrayList();*/
        private readonly ILogger<HomeController> _logger;
        Manager m = new Manager();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           var aaa=  m.ListAll();
           return View();
        }
        [HttpPost]
        public IActionResult Add(ContactModel model)
        {
            m.Add(model);
           return RedirectToAction("Index");
        }

        [Route("Home/Remove/{id?}")]
        public IActionResult Remove(int id)
        {
            
            m.Remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult SortName()
        {
            var aaa = m.ListAll();
            return RedirectToAction("Index",aaa);
        }
        [Route("Home/Update/{id?}")]
        public IActionResult Update(int id)
        {
            var aaa = m.GetById(id);
            return View(aaa);

        }
        public IActionResult Edit(ContactModel model)
        {
            m.Update(model);

            return RedirectToAction("Index");

        }

        public IActionResult Search(string key)
        {
           
          var searcList= m.SearcList(key);
         
          return View(searcList);

        }



    }
}
