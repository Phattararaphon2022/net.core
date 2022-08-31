using APIiHR.Business.Managers.Interfaces;
using APIiHR.Mappers;
using APIiHR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUpload2Controller : ControllerBase
    {
        private IFilemanagerManager _FilemanagerManager;
        public FileUpload2Controller(IFilemanagerManager FilemanagerManager)
        {
            _FilemanagerManager = FilemanagerManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_FilemanagerManager.GetFilemanager());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            return Ok(_FilemanagerManager.GetFilemanagerByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(FilemanagerDAL ds)
        {
            var Filemanager_ds = FilemanagerMapper.MapToCommon(ds);
            var result = _FilemanagerManager.CreateFilemanager(Filemanager_ds);
            var Filemanager_dss = FilemanagerMapper.MapToDto(result);
            return Ok(Filemanager_dss);
        }
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
