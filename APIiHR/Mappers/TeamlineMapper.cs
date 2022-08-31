using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class TeamlineMapper
    {
        public static Teamline MapToCommon(TeamlineDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Teamline
            {
                teamline_modifydate = obj.teamline_modifydate,
                teamline_worker_code = obj.teamline_worker_code,
                teamline_namealian = obj.teamline_namealian,
                teamline_txdesc = obj.teamline_txdesc,
                teamline_status = obj.teamline_status,
                teamline_codemaster = obj.teamline_codemaster,
                teamline_level = obj.teamline_level,
                teamline_startdate = obj.teamline_startdate,
                teamline_enddate = obj.teamline_enddate,
               teamline_workermaster = obj.teamline_workermaster


            };
        }
        public static TeamlineDAL MapToDto(Teamline obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new TeamlineDAL
            {
                teamline_modifydate = obj.teamline_modifydate,
                teamline_worker_code = obj.teamline_worker_code,
                teamline_namealian = obj.teamline_namealian,
                teamline_txdesc = obj.teamline_txdesc,
                teamline_status = obj.teamline_status,
                teamline_codemaster = obj.teamline_codemaster,
                teamline_level = obj.teamline_level,
                teamline_startdate = obj.teamline_startdate,
                teamline_enddate = obj.teamline_enddate,
                teamline_workermaster = obj.teamline_workermaster
            };
        }
    }
}
