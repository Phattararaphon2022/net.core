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
    public class CheckinpoiController : ControllerBase
    {
        private ICheckinpoiManager _CheckinpoiManager;
        public CheckinpoiController(ICheckinpoiManager CheckinpoiManager)
        {
            _CheckinpoiManager = CheckinpoiManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_CheckinpoiManager.GetCheckinpoi());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_CheckinpoiManager.GetCheckinpoiByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(CheckinpoiDAL ds)
        {
            var Checkinpoi_ds = CheckinpoiMapper.MapToCommon(ds);
            var result = _CheckinpoiManager.CreateCheckinpoi(Checkinpoi_ds);
            var Checkinpoi_dss = CheckinpoiMapper.MapToDto(result);
            return Ok(Checkinpoi_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, CheckinpoiDAL ds)
        {
            var dss = CheckinpoiMapper.MapToCommon(ds);
            var result = _CheckinpoiManager.UpdateCheckinpoi(id, dss);
            var obj = CheckinpoiMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _CheckinpoiManager.DeleteCheckinpoi(id);
            return Ok(id);
        }
    }
}
