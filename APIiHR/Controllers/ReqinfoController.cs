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
    public class ReqinfoController : ControllerBase
    {
        private IReqinfoManager _ReqinfoManager;
        public ReqinfoController(IReqinfoManager ReqinfoManager)
        {
            _ReqinfoManager = ReqinfoManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_ReqinfoManager.GetReqinfo());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            return Ok(_ReqinfoManager.GetReqinfoByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(ReqinfoDAL ds)
        {
            var Reqinfo_ds = ReqinfoMapper.MapToCommon(ds);
            var result = _ReqinfoManager.CreateReqinfo(Reqinfo_ds);
            var Reqinfo_dss = ReqinfoMapper.MapToDto(result);
            return Ok(Reqinfo_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, ReqinfoDAL ds)
        {
            var dss = ReqinfoMapper.MapToCommon(ds);
            var result = _ReqinfoManager.UpdateReqinfo(id, dss);
            var obj = ReqinfoMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _ReqinfoManager.DeleteReqinfo(id);
            return Ok(id);
        }
    }
}
