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
    public class WorkflowmasterController : ControllerBase
    {
        private IWorkflowmasterManager _WorkflowmasterManager;
        public WorkflowmasterController(IWorkflowmasterManager WorkflowmasterManager)
        {
            _WorkflowmasterManager = WorkflowmasterManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_WorkflowmasterManager.GetWorkflowmaster());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_WorkflowmasterManager.GetWorkflowmasterByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(WorkflowmasterDAL ds)
        {
            var Workflowmaster_ds = WorkflowmasterMapper.MapToCommon(ds);
            var result = _WorkflowmasterManager.CreateWorkflowmaster(Workflowmaster_ds);
            var Workflowmaster_dss = WorkflowmasterMapper.MapToDto(result);
            return Ok(Workflowmaster_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, WorkflowmasterDAL ds)
        {
            var dss = WorkflowmasterMapper.MapToCommon(ds);
            var result = _WorkflowmasterManager.UpdateWorkflowmaster(id, dss);
            var obj = WorkflowmasterMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
           
            _WorkflowmasterManager.DeleteWorkflowmaster(id);
            return Ok(id);
        }


    }
}
