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
    public class SysmodulenoController : ControllerBase
    {
        private ISysmodulenoManager _SysmodulenoManager;
        public SysmodulenoController(ISysmodulenoManager SysmodulenoManager)
        {
            _SysmodulenoManager = SysmodulenoManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SysmodulenoManager.GetSysmoduleno());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_SysmodulenoManager.GetSysmodulenoByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SysmodulenoDAL ds)
        {
            var Sysmoduleno_ds = SysmodulenoMapper.MapToCommon(ds);
            var result = _SysmodulenoManager.CreateSysmoduleno(Sysmoduleno_ds);
            var Sysmoduleno_dss = SysmodulenoMapper.MapToDto(result);
            return Ok(Sysmoduleno_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SysmodulenoDAL ds)
        {
            var dss = SysmodulenoMapper.MapToCommon(ds);
            var result = _SysmodulenoManager.UpdateSysmoduleno(id, dss);
            var obj = SysmodulenoMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SysmodulenoManager.DeleteSysmoduleno(id);
            return Ok(id);
        }
    }
}
