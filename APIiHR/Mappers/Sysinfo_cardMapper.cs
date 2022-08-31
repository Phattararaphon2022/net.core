using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class Sysinfo_cardMapper
    {
        public static Sysinfo_card MapToCommon(Sysinfo_cardDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysinfo_card
            {
                recid = obj.recid,
                sysinfo_card_createdate = obj.sysinfo_card_createdate,
                sysinfo_card_namealian = obj.sysinfo_card_namealian,
                sysinfo_card_worker_code = obj.sysinfo_card_worker_code,
                sysinfo_card_idnum = obj.sysinfo_card_idnum,
                sysinfo_card_expdate = obj.sysinfo_card_expdate,
                sysinfo_card_status = obj.sysinfo_card_status,
                sysinfo_card_from = obj.sysinfo_card_from,

                sysinfo_card_reftran = obj.sysinfo_card_reftran,
                sysinfo_card_refdim1 = obj.sysinfo_card_refdim1,
                sysinfo_card_refdimrec = obj.sysinfo_card_refdimrec

            };
        }
        public static Sysinfo_cardDAL MapToDto(Sysinfo_card obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysinfo_cardDAL
            {
                recid = obj.recid,
                sysinfo_card_createdate = obj.sysinfo_card_createdate,
                sysinfo_card_namealian = obj.sysinfo_card_namealian,
                sysinfo_card_worker_code = obj.sysinfo_card_worker_code,
                sysinfo_card_idnum = obj.sysinfo_card_idnum,
                sysinfo_card_expdate = obj.sysinfo_card_expdate,
                sysinfo_card_status = obj.sysinfo_card_status,
                sysinfo_card_from = obj.sysinfo_card_from

            };
        }
    }
}
