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
    public class Sysmttask_lineController : ControllerBase
    {
        private ISysmttask_lineManager _Sysmttask_lineManager;
        public Sysmttask_lineController(ISysmttask_lineManager Sysmttask_lineManager)
        {
            _Sysmttask_lineManager = Sysmttask_lineManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_Sysmttask_lineManager.GetSysmttask_line());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_Sysmttask_lineManager.GetSysmttask_lineByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(Sysmttask_lineDAL ds)
        {
            var Sysmttask_line_ds = Sysmttask_lineMapper.MapToCommon(ds);
            var result = _Sysmttask_lineManager.CreateSysmttask_line(Sysmttask_line_ds);
            var Sysmttask_line_dss = Sysmttask_lineMapper.MapToDto(result);
            return Ok(Sysmttask_line_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, Sysmttask_lineDAL ds)
        {
            var dss = Sysmttask_lineMapper.MapToCommon(ds);
            var result = _Sysmttask_lineManager.UpdateSysmttask_line(id, dss);
            var obj = Sysmttask_lineMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _Sysmttask_lineManager.DeleteSysmttask_line(id);
            return Ok(id);
        }
    }
}
