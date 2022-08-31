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
    public class Sysmtapp_workerController : ControllerBase
    {
        private ISysmtapp_workerManager _Sysmtapp_workerManager;
        public Sysmtapp_workerController(ISysmtapp_workerManager Sysmtapp_workerManager)
        {
            _Sysmtapp_workerManager = Sysmtapp_workerManager;
        }

        
        [HttpGet("{id}/{app}")]
        public ObjectResult Getapp(int id,string app)
        {
            // return Ok(_Sysmtapp_workerManager.GetSysmtapp_workerByCodeApp(id));
            return Ok(
                _Sysmtapp_workerManager.GetSysmtapp_workerByCodeApp(id)
                );
        }



        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_Sysmtapp_workerManager.GetSysmtapp_worker());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(int id)
        {
            return Ok(_Sysmtapp_workerManager.GetSysmtapp_workerByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(Sysmtapp_workerDAL ds)
        {
            var Sysmtapp_worker_ds = Sysmtapp_workerMapper.MapToCommon(ds);
            var result = _Sysmtapp_workerManager.CreateSysmtapp_worker(Sysmtapp_worker_ds);
            var Sysmtapp_worker_dss = Sysmtapp_workerMapper.MapToDto(result);
            return Ok(Sysmtapp_worker_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, Sysmtapp_workerDAL ds)
        {
            var dss = Sysmtapp_workerMapper.MapToCommon(ds);
            var result = _Sysmtapp_workerManager.UpdateSysmtapp_worker(id, dss);
            var obj = Sysmtapp_workerMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _Sysmtapp_workerManager.DeleteSysmtapp_worker(id);
            return Ok(id);
        }
    }
}
