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
    public class Sysinfo_add2Controller : ControllerBase
    {
        private ISysinfo_addManager _Sysinfo_addManager;
        public Sysinfo_add2Controller(ISysinfo_addManager Sysinfo_addManager)
        {
            _Sysinfo_addManager = Sysinfo_addManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_Sysinfo_addManager.GetSysinfo_add());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_Sysinfo_addManager.GetSysinfo_addByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(Sysinfo_addDAL ds)
        {
            var Sysinfo_add_ds = Sysinfo_addMapper.MapToCommon(ds);
            var result = _Sysinfo_addManager.CreateSysinfo_add(Sysinfo_add_ds);
            var Sysinfo_add_dss = Sysinfo_addMapper.MapToDto(result);
            return Ok(Sysinfo_add_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, Sysinfo_addDAL ds)
        {
            var dss = Sysinfo_addMapper.MapToCommon(ds);
            var result = _Sysinfo_addManager.UpdateSysinfo_add(id, dss);
            var obj = Sysinfo_addMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _Sysinfo_addManager.DeleteSysinfo_add(id);
            return Ok(id);
        }
    }
}
