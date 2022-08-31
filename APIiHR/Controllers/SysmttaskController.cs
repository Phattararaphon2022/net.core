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
    public class SysmttaskController : ControllerBase
    {
        private ISysmttaskManager _SysmttaskManager;
        public SysmttaskController(ISysmttaskManager SysmttaskManager)
        {
            _SysmttaskManager = SysmttaskManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SysmttaskManager.GetSysmttask());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_SysmttaskManager.GetSysmttaskByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SysmttaskDAL ds)
        {
            var Sysmttask_ds = SysmttaskMapper.MapToCommon(ds);
            var result = _SysmttaskManager.CreateSysmttask(Sysmttask_ds);
            var Sysmttask_dss = SysmttaskMapper.MapToDto(result);
            return Ok(Sysmttask_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SysmttaskDAL ds)
        {
            var dss = SysmttaskMapper.MapToCommon(ds);
            var result = _SysmttaskManager.UpdateSysmttask(id, dss);
            var obj = SysmttaskMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SysmttaskManager.DeleteSysmttask(id);
            return Ok(id);
        }
    }
}
