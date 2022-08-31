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
    public class SysmtappController : ControllerBase
    {
        private ISysmtappManager _SysmtappManager;
        public SysmtappController(ISysmtappManager SysmtappManager)
        {
            _SysmtappManager = SysmtappManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SysmtappManager.GetSysmtapp());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            return Ok(_SysmtappManager.GetSysmtappByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SysmtappDAL ds)
        {
            var Sysmtapp_ds = SysmtappMapper.MapToCommon(ds);
            var result = _SysmtappManager.CreateSysmtapp(Sysmtapp_ds);
            var Sysmtapp_dss = SysmtappMapper.MapToDto(result);
            return Ok(Sysmtapp_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SysmtappDAL ds)
        {
            var dss = SysmtappMapper.MapToCommon(ds);
            var result = _SysmtappManager.UpdateSysmtapp(id, dss);
            var obj = SysmtappMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SysmtappManager.DeleteSysmtapp(id);
            return Ok(id);
        }
    }
}
