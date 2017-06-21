using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace nd.Controllers
{
    public class DatabaseController : Controller
    {
        [HttpPost]
        public IActionResult Index(OpenDatabaseModel openDatabaseModel)
        {            
            return View(new DatabaseObjectsModel(openDatabaseModel.DatabaseServer));
        }
    }
}