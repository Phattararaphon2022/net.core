using APIiHR.Business.Managers.Interfaces;
using APIiHR.Mappers;
using APIiHR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysfileessController : ControllerBase
    {
        private ISysfileessManager _SysfileessManager;
        public SysfileessController(ISysfileessManager SysfileessManager)
        {
            _SysfileessManager = SysfileessManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SysfileessManager.GetSysfileess());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            
            return Ok(_SysfileessManager.GetSysfileessByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SysfileessDAL ds)
        {
            var Sysfileess_ds = SysfileessMapper.MapToCommon(ds);
            var result = _SysfileessManager.CreateSysfileess(Sysfileess_ds);
            var Sysfileess_dss = SysfileessMapper.MapToDto(result);
            return Ok(Sysfileess_dss);
        }


        [Route("save")]
        [HttpPost]
        public string savedata(SysfileessDAL ds)
        {
           
            var st = ds.sysfileess_filename;

            return "save data ok";
        }


        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SysfileessDAL ds)
        {
            var dss = SysfileessMapper.MapToCommon(ds);
            var result = _SysfileessManager.UpdateSysfileess(id, dss);
            var obj = SysfileessMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SysfileessManager.DeleteSysfileess(id);
            return Ok(id);
        }
    }
}
