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
    public class TeamlineController : ControllerBase
    {
        private ITeamlineManager _TeamlineManager;
        public TeamlineController(ITeamlineManager TeamlineManager)
        {
            _TeamlineManager = TeamlineManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_TeamlineManager.GetTeamline());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_TeamlineManager.GetTeamlineByCode(id));
        }
        [Route("{id}/{code}")]
        [HttpGet]
        public ObjectResult Get(string id,string code)
        {
            return Ok(_TeamlineManager.GetTeamlineByCodeWK(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(TeamlineDAL ds)
        {
            var Teamline_ds = TeamlineMapper.MapToCommon(ds);
            var result = _TeamlineManager.CreateTeamline(Teamline_ds);
            var Teamline_dss = TeamlineMapper.MapToDto(result);
            return Ok(Teamline_dss);
        }

       
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, TeamlineDAL ds)
        {
            var dss = TeamlineMapper.MapToCommon(ds);
            var result = _TeamlineManager.UpdateTeamline(id, dss);
            var obj = TeamlineMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _TeamlineManager.DeleteTeamline(id);
            return Ok(id);
        }
        [Route("{id}/{code}")]
        [HttpDelete]
        public ObjectResult DeleteByCode(int id)
        {
            _TeamlineManager.DeleteTeamlineByCode(id);
            return Ok(id);
        }
    }
}
