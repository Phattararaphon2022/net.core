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
    public class Sysinfo_contactController : ControllerBase
    {
        private ISysinfo_contactManager _Sysinfo_contactManager;
        public Sysinfo_contactController(ISysinfo_contactManager Sysinfo_contactManager)
        {
            _Sysinfo_contactManager = Sysinfo_contactManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_Sysinfo_contactManager.GetSysinfo_contact());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_Sysinfo_contactManager.GetSysinfo_contactByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(Sysinfo_contactDAL ds)
        {
            var Sysinfo_contact_ds = Sysinfo_contactMapper.MapToCommon(ds);
            var result = _Sysinfo_contactManager.CreateSysinfo_contact(Sysinfo_contact_ds);
            var Sysinfo_contact_dss = Sysinfo_contactMapper.MapToDto(result);
            return Ok(Sysinfo_contact_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, Sysinfo_contactDAL ds)
        {
            var dss = Sysinfo_contactMapper.MapToCommon(ds);
            var result = _Sysinfo_contactManager.UpdateSysinfo_contact(id, dss);
            var obj = Sysinfo_contactMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _Sysinfo_contactManager.DeleteSysinfo_contact(id);
            return Ok(id);
        }
    }
}
