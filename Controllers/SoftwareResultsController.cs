using ImaginarySoftwareCompany.Helpers;
using ImaginarySoftwareCompany.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImaginarySoftwareCompany.Controllers
{
    public class SoftwareResultsController : Controller
    {
        [HttpPost]
        public IActionResult RetrieveNewerSoftwareVersions(VersionManager currentSoftware)
        {
            if (ModelState.IsValid)
            {
                //Get list of results
                VersionManager resultManager = new VersionManager();
                resultManager.SoftwareVersions = SoftwareManager.GetSuccessiveSoftwareVersions(currentSoftware);
                resultManager.Version = currentSoftware.Version;
                return View("~/Views/Home/SoftwareSearch.cshtml", resultManager);
            }
            else
            {
                return View("~/Views/Home/SoftwareSearch.cshtml");
            }

        }
    }
}
