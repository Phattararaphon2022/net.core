using APIiHR.Business.Managers.Interfaces;
using APIiHR.Mappers;
using APIiHR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;




namespace APIiHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilemanagerController : ControllerBase
    {
        private IFilemanagerManager _FilemanagerManager;
        private readonly string AppDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Filemanager");
        public FilemanagerController(IFilemanagerManager FilemanagerManager)
        {
            _FilemanagerManager = FilemanagerManager;
        }
        /* download file start
         */
        
        /*
        
         * end download file */

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_FilemanagerManager.GetFilemanager());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> DownloadFile(int id)
        {
            if (!Directory.Exists(AppDirectory))
                Directory.CreateDirectory(AppDirectory);

            
            var filee = _FilemanagerManager.GetFilemanagerByCode(id).Select(n=> new FileRecord
            {
                ContentType = n.filemanager_filetype,
                FileFormat = n.filemanager_fileexten,
                FileName = n.filemanager_filename,
                FilePath = n.filemanager_filepath
            }).ToList();
            var path = Path.Combine(AppDirectory, filee?[0].FilePath);
            var memory = new MemoryStream();
            using(var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var contentType = "APPLICATION/otet-stream";
            var fileName = Path.GetFileName(path);
            return File(memory, contentType, fileName);
        }
        /*
        [Route("{id}")]
        [HttpGet]        
        public ObjectResult Get(int id)
        {
            return Ok(_FilemanagerManager.GetFilemanagerByCode(id));
        }
        */

        [Route("")]
        [HttpPost]
        //[Consumes("multipart/form-data")]
        public async Task<HttpResponseMessage> PostAsync([FromForm] FileModel model)
        {
          //  try
         //   {
                FileRecord file = await SaveFileAsync(model.Myfile);

                if (!string.IsNullOrEmpty(file.FilePath))
                {
                    file.AltText = model.AltText;
                    file.Description = model.Description;
                    file.worker_code = model.worker_code;
                    file.module_form = model.module_form;
                    file.namefileupload = model.namefileupload;
                    //Save to Inmemory object
                    //fileDB.Add(file);
                    //Save to SQL Server DB
                    SaveToDB(file);
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        /*
         //   catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message),
                };
            }
        
        }
    */
        private async Task<FileRecord> SaveFileAsync(IFormFile myFile)
        {
            FileRecord file = new FileRecord();
            if (myFile != null)
            {
                if (!Directory.Exists(AppDirectory))
                    Directory.CreateDirectory(AppDirectory);

                var fileName = DateTime.Now.Ticks.ToString() + Path.GetExtension(myFile.FileName);
                var path = Path.Combine(AppDirectory, fileName);

               // file.Id = fileDB.Count() + 1;
                file.FilePath = path;
                file.FileName = fileName;                
                file.FileFormat = Path.GetExtension(myFile.FileName);
                file.ContentType = myFile.ContentType;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await myFile.CopyToAsync(stream);
                }

                return file;
            }
            return file;
        }
        private void SaveToDB(FileRecord record)
        {
            if (record == null)
                throw new ArgumentNullException($"{nameof(record)}");

            FilemanagerDAL fileData = new FilemanagerDAL();


            //fileData.FilePath = record.FilePath;
            //fileData.FileName = record.FileName;
            //fileData.FileExtension = record.FileFormat;
            //fileData.MimeType = record.ContentType;

            fileData.filemanager_filepath = record.FilePath;
            fileData.filemanager_filename = record.FileName;
            fileData.filemanager_filetype = record.FileFormat;
            fileData.filemanager_fileexten = record.ContentType;
            fileData.filemanager_worker_code = record.worker_code;
            fileData.filemanager_status = 0;
            fileData.filemanager_txdesc = record.Description;
            fileData.filemanager_module = record.module_form;
            fileData.filemanager_fileupload = record.namefileupload;

            Console.WriteLine(fileData.filemanager_filename);

            var Filemanager_ds = FilemanagerMapper.MapToCommon(fileData);
            var result = _FilemanagerManager.CreateFilemanager(Filemanager_ds);
            var Filemanager_dss = FilemanagerMapper.MapToDto(result);


            //return Ok(Filemanager_dss);
            //dBContext.FileData.Add(fileData);
            //dBContext.SaveChanges();
        }
        /*
        public ObjectResult Create(FilemanagerDAL ds)
        {
            var Filemanager_ds = FilemanagerMapper.MapToCommon(ds);
            var result = _FilemanagerManager.CreateFilemanager(Filemanager_ds);
            var Filemanager_dss = FilemanagerMapper.MapToDto(result);
            return Ok(Filemanager_dss);
        }
        */
       

        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, FilemanagerDAL ds)
        {
            var dss = FilemanagerMapper.MapToCommon(ds);
            var result = _FilemanagerManager.UpdateFilemanager(id, dss);
            var obj = FilemanagerMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _FilemanagerManager.DeleteFilemanager(id);
            return Ok(id);
        }
    }
}
