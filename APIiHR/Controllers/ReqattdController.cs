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
    public class ReqattdController : ControllerBase
    {
        private IReqattdManager _ReqattdManager;
        public ReqattdController(IReqattdManager ReqattdManager)
        {
            _ReqattdManager = ReqattdManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_ReqattdManager.GetReqattd());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_ReqattdManager.GetReqattdByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(ReqattdDAL ds)
        {
            var Reqattd_ds = ReqattdMapper.MapToCommon(ds);
            var result = _ReqattdManager.CreateReqattd(Reqattd_ds);
            var Reqattd_dss = ReqattdMapper.MapToDto(result);
            return Ok(Reqattd_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, ReqattdDAL ds)
        {
            var dss = ReqattdMapper.MapToCommon(ds);
            var result = _ReqattdManager.UpdateReqattd(id, dss);
            var obj = ReqattdMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _ReqattdManager.DeleteReqattd(id);
            return Ok(id);
        }
    }
}
