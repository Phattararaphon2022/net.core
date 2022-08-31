using APIiHR.Business.Managers.Interfaces;
using APIiHR.Mappers;
using APIiHR.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ReqleaveController : ControllerBase
    {
        private IReqleaveManager _ReqleaveManager;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;


        public ReqleaveController(IReqleaveManager ReqleaveManager, IConfiguration configuration, IWebHostEnvironment env)
        {
            _ReqleaveManager = ReqleaveManager;

            _configuration = configuration;
            _env = env;
        }

       

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_ReqleaveManager.GetReqleave());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_ReqleaveManager.GetReqleaveByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(ReqleaveDAL ds)
        {
            var Reqleave_ds = ReqleaveMapper.MapToCommon(ds);
            var result = _ReqleaveManager.CreateReqleave(Reqleave_ds);
            var Reqleave_dss = ReqleaveMapper.MapToDto(result);
            return Ok(Reqleave_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, ReqleaveDAL ds)
        {
            var dss = ReqleaveMapper.MapToCommon(ds);
            var result = _ReqleaveManager.UpdateReqleave(id, dss);
            var obj = ReqleaveMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _ReqleaveManager.DeleteReqleave(id);
            return Ok(id);
        }

       
    }
}
