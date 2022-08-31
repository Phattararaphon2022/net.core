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
    public class SysleavetypeController : ControllerBase
    {
        private ISysleavetypeManager _SysleavetypeManager;
        public SysleavetypeController(ISysleavetypeManager SysleavetypeManager)
        {
            _SysleavetypeManager = SysleavetypeManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_SysleavetypeManager.GetSysleavetype());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            return Ok(_SysleavetypeManager.GetSysleavetypeByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(SysleavetypeDAL ds)
        {
            var Sysleavetype_ds = SysleavetypeMapper.MapToCommon(ds);
            var result = _SysleavetypeManager.CreateSysleavetype(Sysleavetype_ds);
            var Sysleavetype_dss = SysleavetypeMapper.MapToDto(result);
            return Ok(Sysleavetype_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, SysleavetypeDAL ds)
        {
            var dss = SysleavetypeMapper.MapToCommon(ds);
            var result = _SysleavetypeManager.UpdateSysleavetype(id, dss);
            var obj = SysleavetypeMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _SysleavetypeManager.DeleteSysleavetype(id);
            return Ok(id);
        }
    }
}
