using CMS1.Services.NeoFileAssociationModule;
using CMS1.Services.NeoFileModule;
using CMS1.Services.NeoFolderModule;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS1.Controllers
{
    public class complianceController : Controller
    {
        private readonly INeoFolderService neoFolderService;

        private readonly INeoFileService  neoFileService;

        private readonly INeoFileAssociationService  neoFileAssociationService;

        public complianceController(INeoFileAssociationService neoFileAssociationService,INeoFileService neoFileService,INeoFolderService neoFolderService)
        {
            this.neoFolderService = neoFolderService;

            this.neoFileService = neoFileService;

            this.neoFileAssociationService = neoFileAssociationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetFolders()
        {
            try
            {
                var folders = await neoFolderService.GetAll();

                return new JsonResult(folders);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<JsonResult> GetNeoFilesData()
        {
            try
            {
                var neofiles = await neoFileService.GetAll();

                return new JsonResult(neofiles);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }


        public async Task<JsonResult> GetAssociationData()
        {
            try
            {
                var neoFileAssociation = await neoFileAssociationService.GetAll();

                return new JsonResult(neoFileAssociation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

    }
}
