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
    public class SysuserempController : ControllerBase
    {
        private ISysuserempManager _SysuserempManager;
        public SysuserempController(ISysuserempManager SysuserempManager)
        {
            _SysuserempManager = SysuserempManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SysuserempManager.GetSysuseremp());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_SysuserempManager.GetSysuserempByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SysuserempDAL ds)
        {
            var Sysuseremp_ds = SysuserempMapper.MapToCommon(ds);
            var result = _SysuserempManager.CreateSysuseremp(Sysuseremp_ds);
            var Sysuseremp_dss = SysuserempMapper.MapToDto(result);
            return Ok(Sysuseremp_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SysuserempDAL ds)
        {
            var dss = SysuserempMapper.MapToCommon(ds);
            var result = _SysuserempManager.UpdateSysuseremp(id, dss);
            var obj = SysuserempMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SysuserempManager.DeleteSysuseremp(id);
            return Ok(id);
        }
    }
}
