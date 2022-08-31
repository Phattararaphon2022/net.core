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
    public class AuthenController : ControllerBase
    {
        private IAuthenManager _IAuthenManager;
        public AuthenController(IAuthenManager AuthenManager)
        {
            _IAuthenManager = AuthenManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_IAuthenManager.GetAuthen());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_IAuthenManager.GetAuthenByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(AuthenDAL ds)
        {
            var Authen_ds = AuthenMapper.MapToCommon(ds);
            var result = _IAuthenManager.CreateAuthen(Authen_ds);
            var Authen_dss = AuthenMapper.MapToDto(result);
            return Ok(Authen_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, AuthenDAL ds)
        {
            var dss = AuthenMapper.MapToCommon(ds);
            var result = _IAuthenManager.UpdateAuthen(id, dss);
            var obj = AuthenMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _IAuthenManager.DeleteAuthen(id);
            return Ok(id);
        }
    }
}
