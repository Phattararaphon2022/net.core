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
    public class Sysinfo_cardController : ControllerBase
    {
        private ISysinfo_cardManager _Sysinfo_cardManager;
        public Sysinfo_cardController(ISysinfo_cardManager Sysinfo_cardManager)
        {
            _Sysinfo_cardManager = Sysinfo_cardManager;
        }

        [Route("")]
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(_Sysinfo_cardManager.GetSysinfo_card());
        }

        [Route("{id}")]
        [HttpGet]
        public ObjectResult Get(string id)
        {
            return Ok(_Sysinfo_cardManager.GetSysinfo_cardByCode(id));
        }

        [Route("")]
        [HttpPost]
        public ObjectResult Create(Sysinfo_cardDAL ds)
        {
            var Sysinfo_card_ds = Sysinfo_cardMapper.MapToCommon(ds);
            var result = _Sysinfo_cardManager.CreateSysinfo_card(Sysinfo_card_ds);
            var Sysinfo_card_dss = Sysinfo_cardMapper.MapToDto(result);
            return Ok(Sysinfo_card_dss);
        }
        [Route("{id}")]
        [HttpPut]
        public ObjectResult Update(int id, Sysinfo_cardDAL ds)
        {
            var dss = Sysinfo_cardMapper.MapToCommon(ds);
            var result = _Sysinfo_cardManager.UpdateSysinfo_card(id, dss);
            var obj = Sysinfo_cardMapper.MapToDto(result);

            return Ok(obj);
        }

        [Route("{id}")]
        [HttpDelete]
        public ObjectResult Delete(int id)
        {
            _Sysinfo_cardManager.DeleteSysinfo_card(id);
            return Ok(id);
        }
    }
}
