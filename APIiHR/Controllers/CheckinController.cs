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
    public class CheckinController : ControllerBase
    {
        private ICheckinManager _CheckinManager;
        public CheckinController(ICheckinManager CheckinManager)
        {
            _CheckinManager = CheckinManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_CheckinManager.GetCheckin());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_CheckinManager.GetCheckinByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(CheckinDAL ds)
        {
            var Checkin_ds = CheckinMapper.MapToCommon(ds);
            var result = _CheckinManager.CreateCheckin(Checkin_ds);
            var Checkin_dss = CheckinMapper.MapToDto(result);
            return Ok(Checkin_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, CheckinDAL ds)
        {
            var dss = CheckinMapper.MapToCommon(ds);
            var result = _CheckinManager.UpdateCheckin(id, dss);
            var obj = CheckinMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _CheckinManager.DeleteCheckin(id);
            return Ok(id);
        }
    }
}
