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
    public class SyslogininfoController : ControllerBase
    {
        private ISyslogininfoManager _SyslogininfoManager;
        public SyslogininfoController(ISyslogininfoManager SyslogininfoManager)
        {
            _SyslogininfoManager = SyslogininfoManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SyslogininfoManager.GetSyslogininfo());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_SyslogininfoManager.GetSyslogininfoByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SyslogininfoDAL ds)
        {
            var Syslogininfo_ds = SyslogininfoMapper.MapToCommon(ds);
            var result = _SyslogininfoManager.CreateSyslogininfo(Syslogininfo_ds);
            var Syslogininfo_dss = SyslogininfoMapper.MapToDto(result);
            return Ok(Syslogininfo_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SyslogininfoDAL ds)
        {
            var dss = SyslogininfoMapper.MapToCommon(ds);
            var result = _SyslogininfoManager.UpdateSyslogininfo(id, dss);
            var obj = SyslogininfoMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SyslogininfoManager.DeleteSyslogininfo(id);
            return Ok(id);
        }
    }
}
