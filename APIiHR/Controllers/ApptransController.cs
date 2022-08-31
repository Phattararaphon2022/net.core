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
    public class ApptransController : ControllerBase
    {
        private IApptransManager _ApptransManager;
        public ApptransController(IApptransManager ApptransManager)
        {
            _ApptransManager = ApptransManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_ApptransManager.GetApptrans());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_ApptransManager.GetApptransByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(ApptransDAL ds)
        {
            var Apptrans_ds = ApptransMapper.MapToCommon(ds);
            var result = _ApptransManager.CreateApptrans(Apptrans_ds);
            var Apptrans_dss = ApptransMapper.MapToDto(result);
            return Ok(Apptrans_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, ApptransDAL ds)
        {
            var dss = ApptransMapper.MapToCommon(ds);
            var result = _ApptransManager.UpdateApptrans(id, dss);
            var obj = ApptransMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _ApptransManager.DeleteApptrans(id);
            return Ok(id);
        }
    }
}
