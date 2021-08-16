using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class CkEditor4DemoController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CkEditor4DemoController(IWebHostEnvironment webHostEnvironment)      // (IHostingEnvironment environment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string editor)
        {

            ViewBag.EditorText = editor;
            return View();
        }

        public IActionResult PostWrite()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostWrite(string title, string editor)
        {
            ViewBag.EditorText = $"{title}<hr />{editor}";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(ICollection<IFormFile> upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            string imgPath = "";
            string msg = "";
            string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "files");

            try
            {
                foreach(var file in upload)
                {
                    if (file != null && file.Length > 0)
                    {
                        var fileName = Path.GetFileName(DateTime.Now.ToString("yyyyMMdd_HHMMssff")
                            + "_"
                            + ContentDispositionHeaderValue.Parse(
                                file.ContentDisposition).FileName.ToString().Replace("\"", "").Trim()
                            );
                        
                        using (var fileStream = new FileStream(Path.Combine(uploadFolder, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }
                        imgPath = Url.Content("/files/" + fileName);
                        msg = "이미지가 정상적으로 업로드 되었습니다.";
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "오류가 발생했습니다. 오류메시지: " + ex.Message;
            }

            string r = $"<script>window.parent.CKEDITOR.tools.callFunction({CKEditorFuncNum}, \"{imgPath}\", \"{msg}\");</script>";

            return Content(r, "text/html");
        }
    }
}
