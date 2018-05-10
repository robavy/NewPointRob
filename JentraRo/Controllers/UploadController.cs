using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using JentraRo.Models;

namespace JentraRo.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Upload()
        {

            if (Request.Files != null && Request.Files.Count > 0)
            {
                try
                {
                    foreach (string upload in Request.Files)
                    {
                        if (Request.Files[upload].FileName != "")
                        {
                            string path = AppDomain.CurrentDomain.BaseDirectory + "/App_Data/uploads/";
                            string filename = Path.GetFileName(Request.Files[upload].FileName);
                            Request.Files[upload].SaveAs(Path.Combine(path, filename));

                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {

            }

            return View();
        }
    }

}