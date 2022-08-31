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
    public class Sysmttask_linechkController : ControllerBase
    {
        private ISysmttask_linechkManager _Sysmttask_linechkManager;
        public Sysmttask_linechkController(ISysmttask_linechkManager Sysmttask_linechkManager)
        {
            _Sysmttask_linechkManager = Sysmttask_linechkManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_Sysmttask_linechkManager.GetSysmttask_linechk());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_Sysmttask_linechkManager.GetSysmttask_linechkByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(Sysmttask_linechkDAL ds)
        {
            var Sysmttask_linechk_ds = Sysmttask_linechkMapper.MapToCommon(ds);
            var result = _Sysmttask_linechkManager.CreateSysmttask_linechk(Sysmttask_linechk_ds);
            var Sysmttask_linechk_dss = Sysmttask_linechkMapper.MapToDto(result);
            return Ok(Sysmttask_linechk_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, Sysmttask_linechkDAL ds)
        {
            var dss = Sysmttask_linechkMapper.MapToCommon(ds);
            var result = _Sysmttask_linechkManager.UpdateSysmttask_linechk(id, dss);
            var obj = Sysmttask_linechkMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _Sysmttask_linechkManager.DeleteSysmttask_linechk(id);
            return Ok(id);
        }
    }
}
