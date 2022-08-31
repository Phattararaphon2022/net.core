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
    public class ReqchgshiftController : ControllerBase
    {
        private IReqchgshiftManager _ReqchgshiftManager;
        public ReqchgshiftController(IReqchgshiftManager ReqchgshiftManager)
        {
            _ReqchgshiftManager = ReqchgshiftManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_ReqchgshiftManager.GetReqchgshift());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_ReqchgshiftManager.GetReqchgshiftByCode(id));
        }
        [Route("")]
        [HttpPost]
        public ObjectResult Create(ReqchgshiftDAL ds)
        {
            var Reqchgshift_ds = ReqchgshiftMapper.MapToCommon(ds);
            var result = _ReqchgshiftManager.CreateReqchgshift(Reqchgshift_ds);
            var Reqchgshift_dss = ReqchgshiftMapper.MapToDto(result);
            return Ok(Reqchgshift_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, ReqchgshiftDAL ds)
        {
            var dss = ReqchgshiftMapper.MapToCommon(ds);
            var result = _ReqchgshiftManager.UpdateReqchgshift(id, dss);
            var obj = ReqchgshiftMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _ReqchgshiftManager.DeleteReqchgshift(id);
            return Ok(id);
        }
    }
}
