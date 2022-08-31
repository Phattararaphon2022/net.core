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
    public class WorkflowtranlogController : ControllerBase
    {
        private IWorkflowtranlogManager _WorkflowtranlogManager;
        public WorkflowtranlogController(IWorkflowtranlogManager WorkflowtranlogManager)
        {
            _WorkflowtranlogManager = WorkflowtranlogManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_WorkflowtranlogManager.GetWorkflowtranlog());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_WorkflowtranlogManager.GetWorkflowtranlogByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(WorkflowtranlogDAL ds)
        {
            var Workflowtranlog_ds = WorkflowtranlogMapper.MapToCommon(ds);
            var result = _WorkflowtranlogManager.CreateWorkflowtranlog(Workflowtranlog_ds);
            var Workflowtranlog_dss = WorkflowtranlogMapper.MapToDto(result);
            return Ok(Workflowtranlog_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, WorkflowtranlogDAL ds)
        {
            var dss = WorkflowtranlogMapper.MapToCommon(ds);
            var result = _WorkflowtranlogManager.UpdateWorkflowtranlog(id, dss);
            var obj = WorkflowtranlogMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _WorkflowtranlogManager.DeleteWorkflowtranlog(id);
            return Ok(id);
        }
    }
}
