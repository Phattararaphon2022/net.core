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
    public class TeammasterController : ControllerBase
    {
        private ITeammasterManager _TeammasterManager;
        public TeammasterController(ITeammasterManager TeammasterManager)
        {
            _TeammasterManager = TeammasterManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_TeammasterManager.GetTeammaster());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_TeammasterManager.GetTeammasterByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(TeammasterDAL ds)
        {
            var Teammaster_ds = TeammasterMapper.MapToCommon(ds);
            var result = _TeammasterManager.CreateTeammaster(Teammaster_ds);
            var Teammaster_dss = TeammasterMapper.MapToDto(result);
            return Ok(Teammaster_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, TeammasterDAL ds)
        {
            var dss = TeammasterMapper.MapToCommon(ds);
            var result = _TeammasterManager.UpdateTeammaster(id, dss);
            var obj = TeammasterMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _TeammasterManager.DeleteTeammaster(id);
            return Ok(id);
        }
    }
}
