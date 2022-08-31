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
    public class SyslocationController : ControllerBase
    {
        private ISyslocationManager _SyslocationManager;
        public SyslocationController(ISyslocationManager SyslocationManager)
        {
            _SyslocationManager = SyslocationManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SyslocationManager.GetSyslocation());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_SyslocationManager.GetSyslocationByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SyslocationDAL ds)
        {
            var Syslocation_ds = SyslocationMapper.MapToCommon(ds);
            var result = _SyslocationManager.CreateSyslocation(Syslocation_ds);
            var Syslocation_dss = SyslocationMapper.MapToDto(result);
            return Ok(Syslocation_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SyslocationDAL ds)
        {
            var dss = SyslocationMapper.MapToCommon(ds);
            var result = _SyslocationManager.UpdateSyslocation(id, dss);
            var obj = SyslocationMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SyslocationManager.DeleteSyslocation(id);
            return Ok(id);
        }
    }
}
