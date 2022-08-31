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
    public class PdpaformController : ControllerBase
    {
        private IPdpaformManager _PdpaformManager;
        public PdpaformController(IPdpaformManager PdpaformManager)
        {
            _PdpaformManager = PdpaformManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_PdpaformManager.GetPdpaform());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_PdpaformManager.GetPdpaformByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(PdpaformDAL ds)
        {
            var Pdpaform_ds = PdpaformMapper.MapToCommon(ds);
            var result = _PdpaformManager.CreatePdpaform(Pdpaform_ds);
            var Pdpaform_dss = PdpaformMapper.MapToDto(result);
            return Ok(Pdpaform_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, PdpaformDAL ds)
        {
            var dss = PdpaformMapper.MapToCommon(ds);
            var result = _PdpaformManager.UpdatePdpaform(id, dss);
            var obj = PdpaformMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _PdpaformManager.DeletePdpaform(id);
            return Ok(id);
        }
    }
}
