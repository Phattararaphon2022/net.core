using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileInfoController : ControllerBase
    {
        private IHostingEnvironment _hostEnv;
        public FileInfoController(IHostingEnvironment env)
        {
            _hostEnv = env;
        }
        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            var uploads = Path.Combine(_hostEnv.ContentRootPath, "FileInfo");
            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }
            if(file.Length > 0)
            {
                var filePath = Path.Combine(uploads, file.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            return Ok();
        }
        [HttpGet]
        [Route("files")]
        public IActionResult Files()
        {
            var result = new List<string>();
            var uploads = Path.Combine(_hostEnv.ContentRootPath, "FileInfo");
            if (Directory.Exists(uploads))
            {
                var provider = _hostEnv.ContentRootFileProvider;
                foreach(string filename in Directory.GetFiles(uploads))
                {
                    var fileInfo = provider.GetFileInfo(filename);
                    result.Add(fileInfo.Name);
                }
            }
            return Ok(result);
        }
        [HttpGet]
        [Route("download")]
        public async Task<IActionResult> Download([FromQuery] string file)
        {
            var uploads = Path.Combine(_hostEnv.ContentRootPath, "FileInfo");
            var filePath = Path.Combine(uploads, file);
            if (!System.IO.File.Exists(filePath))
                return NotFound();
                var memory = new MemoryStream();
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                }
                memory.Position = 0;
                return File(memory, GetContentType(filePath), file);
        }
        private string GetContentType(string path)
        {
            var provider = new FileExtensionContentTypeProvider();
            string contentType;
            if(!provider.TryGetContentType(path, out contentType))
            {
                contentType = "application/octet-stream";
            }
            return contentType;
        }
    }
}
