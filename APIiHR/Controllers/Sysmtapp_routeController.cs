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
    public class Sysmtapp_routeController : ControllerBase
    {
        private ISysmtapp_routeManager _Sysmtapp_routeManager;
        public Sysmtapp_routeController(ISysmtapp_routeManager Sysmtapp_routeManager)
        {
            _Sysmtapp_routeManager = Sysmtapp_routeManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_Sysmtapp_routeManager.GetSysmtapp_route());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            return Ok(_Sysmtapp_routeManager.GetSysmtapp_routeByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(Sysmtapp_routeDAL ds)
        {
            var Sysmtapp_route_ds = Sysmtapp_routeMapper.MapToCommon(ds);
            var result = _Sysmtapp_routeManager.CreateSysmtapp_route(Sysmtapp_route_ds);
            var Sysmtapp_route_dss = Sysmtapp_routeMapper.MapToDto(result);
            return Ok(Sysmtapp_route_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, Sysmtapp_routeDAL ds)
        {
            var dss = Sysmtapp_routeMapper.MapToCommon(ds);
            var result = _Sysmtapp_routeManager.UpdateSysmtapp_route(id, dss);
            var obj = Sysmtapp_routeMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _Sysmtapp_routeManager.DeleteSysmtapp_route(id);
            return Ok(id);
        }
    }
}
