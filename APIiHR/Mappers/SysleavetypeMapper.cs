using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class SysleavetypeMapper
    {
        public static Sysleavetype MapToCommon(SysleavetypeDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysleavetype
            {                
                sysleavetype_createdate = obj.sysleavetype_createdate,
                sysleavetype_txdesc = obj.sysleavetype_txdesc,
                sysleavetype_refpoli = obj.sysleavetype_refpoli,
                sysleavetype_comuser = obj.sysleavetype_comuser,
                sysleavetype_maxdays = obj.sysleavetype_maxdays,
                sysleavetype_refcode = obj.sysleavetype_refcode



            };
        }
        public static SysleavetypeDAL MapToDto(Sysleavetype obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new SysleavetypeDAL
            {
                sysleavetype_createdate = obj.sysleavetype_createdate,
                sysleavetype_txdesc = obj.sysleavetype_txdesc,
                sysleavetype_refpoli = obj.sysleavetype_refpoli,
                sysleavetype_comuser = obj.sysleavetype_comuser,
                sysleavetype_maxdays = obj.sysleavetype_maxdays,
                sysleavetype_refcode = obj.sysleavetype_refcode
            };
        }
    }
}
