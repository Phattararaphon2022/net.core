using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class TeammasterMapper
    {
        public static Teammaster MapToCommon(TeammasterDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Teammaster
            {
                teammaster_worker_code = obj.teammaster_worker_code,
                teammaster_namealian = obj.teammaster_namealian,
                teammaster_txdesc = obj.teammaster_txdesc,
                teammaster_status = obj.teammaster_status,
                teammaster_code = obj.teammaster_code

            };
        }
        public static TeammasterDAL MapToDto(Teammaster obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new TeammasterDAL
            {
                teammaster_worker_code = obj.teammaster_worker_code,
                teammaster_namealian = obj.teammaster_namealian,
                teammaster_txdesc = obj.teammaster_txdesc,
                teammaster_status = obj.teammaster_status,
                teammaster_code = obj.teammaster_code
            };
        }
    }
}
