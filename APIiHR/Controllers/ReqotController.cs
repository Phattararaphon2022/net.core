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
    public class ReqotController : ControllerBase
    {
        private IReqotManager _ReqotManager;
        public ReqotController(IReqotManager ReqotManager)
        {
            _ReqotManager = ReqotManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_ReqotManager.GetReqot());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_ReqotManager.GetReqotByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(ReqotDAL ds)
        {
            var Reqot_ds = ReqotMapper.MapToCommon(ds);
            var result = _ReqotManager.CreateReqot(Reqot_ds);
            var Reqot_dss = ReqotMapper.MapToDto(result);
            return Ok(Reqot_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, ReqotDAL ds)
        {
            var dss = ReqotMapper.MapToCommon(ds);
            var result = _ReqotManager.UpdateReqot(id, dss);
            var obj = ReqotMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _ReqotManager.DeleteReqot(id);
            return Ok(id);
        }
    }
}
