using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ImageUploader.Models;
using ImageUploader.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ImageUploader.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataSource datasrc;
        private readonly string heading;
        private readonly IWebHostEnvironment env;

        #region Constructor
        
        // Using DI to Inject, ConfigData, Repository & Environment.
        
        public HomeController(IDataSource DataSrc, IOptions<ConfigData> myOptions, IWebHostEnvironment environment)
        {
            //Fetching the desired DataSource Object.
            datasrc = DataSrc;
            env = environment;
            heading = myOptions.Value.Heading;

        }

        #endregion

        // Uploaded File table.
        public IActionResult ImageInventory(string SearchString)
        {
            var imagelist = new List<UploadedImage>();
            //Fetch Uploaded Image Data.
            var path = Path.Combine(env.WebRootPath, "uploads");
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] files = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();


            if (!string.IsNullOrEmpty(SearchString))
            {
                var searchfile = files.Where(s => s.Name.ToLower().Contains(SearchString.ToLower())).ToList();

                foreach (var file in searchfile)
                {
                    imagelist.Add(new UploadedImage(file.Name, file.CreationTime));
                }
                ViewBag.ImageList = imagelist;
            }
            else
            {


                foreach (FileInfo file in files)
                {
                    imagelist.Add(new UploadedImage(file.Name, file.CreationTime));
                }

                ViewBag.ImageList = imagelist;
            }


            return View();
        }

        //Landing Page.
        public IActionResult Index()
        {
            ViewBag.Heading = heading;
            

            return View();
        }

        // Uploaded Image Action Method.

        [HttpPost]
        public  IActionResult Index(IFormFile file)
        {
            var imagelist = new List<UploadedImage>();
            //Fetch Uploaded Image Data.
            var path = Path.Combine(env.WebRootPath, "uploads");
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] files = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();


            #region Upload File
            try
            {

                var uploads = Path.Combine(env.WebRootPath, "uploads");
                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                    {
                        file.CopyToAsync(fileStream);
                    }
                }

                

                ViewBag.Message = "Image Uploaded Successfully!!!";


            }
            catch(Exception ex)
            {
                //Error.
            }
       
            #endregion

            

            return View();
        }
    }
}
