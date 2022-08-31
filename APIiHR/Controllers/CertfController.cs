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
    public class CertfController : ControllerBase
    {
        private ICertfManager _CertfManager;
        public CertfController(ICertfManager CertfManager)
        {
            _CertfManager = CertfManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_CertfManager.GetCertf());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_CertfManager.GetCertfByCode(id));
        }
        [Route("{id}/{tt}")]
        [HttpGet]
        public ObjectResult GetTop(string id,string tt)
        {
            return Ok(_CertfManager.GetCertfByCodeTop(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(CertfDAL ds)
        {
            var Certf_ds = CertfMapper.MapToCommon(ds);
            var result = _CertfManager.CreateCertf(Certf_ds);
            var Certf_dss = CertfMapper.MapToDto(result);
            return Ok(Certf_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, CertfDAL ds)
        {
            var dss = CertfMapper.MapToCommon(ds);
            var result = _CertfManager.UpdateCertf(id, dss);
            var obj = CertfMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _CertfManager.DeleteCertf(id);
            return Ok(id);
        }
    }
}
