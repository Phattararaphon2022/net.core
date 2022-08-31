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
    public class WorkflowtranController : ControllerBase
    {
        private IWorkflowtranManager _WorkflowtranManager;
        public WorkflowtranController(IWorkflowtranManager WorkflowtranManager)
        {
            _WorkflowtranManager = WorkflowtranManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_WorkflowtranManager.GetWorkflowtran());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            return Ok(_WorkflowtranManager.GetWorkflowtranByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(WorkflowtranDAL ds)
        {
            var Workflowtran_ds = WorkflowtranMapper.MapToCommon(ds);
            var result = _WorkflowtranManager.CreateWorkflowtran(Workflowtran_ds);
            var Workflowtran_dss = WorkflowtranMapper.MapToDto(result);
            return Ok(Workflowtran_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, WorkflowtranDAL ds)
        {
            var dss = WorkflowtranMapper.MapToCommon(ds);
            var result = _WorkflowtranManager.UpdateWorkflowtran(id, dss);
            var obj = WorkflowtranMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _WorkflowtranManager.DeleteWorkflowtran(id);
            return Ok(id);
        }
    }
}
