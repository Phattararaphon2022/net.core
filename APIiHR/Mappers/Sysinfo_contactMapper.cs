using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class Sysinfo_contactMapper
    {
        public static Sysinfo_contact MapToCommon(Sysinfo_contactDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysinfo_contact
            {
                recid = obj.recid,
                sysinfo_contact_createdate = obj.sysinfo_contact_createdate,
                sysinfo_contact_modifydate = obj.sysinfo_contact_modifydate,
                sysinfo_contact_worker_code = obj.sysinfo_contact_worker_code,
                sysinfo_contact_name = obj.sysinfo_contact_name,
                sysinfo_contact_mobile = obj.sysinfo_contact_mobile,
                sysinfo_contact_tel = obj.sysinfo_contact_tel,
                sysinfo_contact_address = obj.sysinfo_contact_address,
                sysinfo_contact_status = obj.sysinfo_contact_status,

                sysinfo_contact_reftran = obj.sysinfo_contact_reftran,
                sysinfo_contact_refdim1 = obj.sysinfo_contact_refdim1,
                sysinfo_contact_refdimrec = obj.sysinfo_contact_refdimrec

            };
        }
        public static Sysinfo_contactDAL MapToDto(Sysinfo_contact obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysinfo_contactDAL
            {
                recid = obj.recid,
                sysinfo_contact_createdate = obj.sysinfo_contact_createdate,
                sysinfo_contact_modifydate = obj.sysinfo_contact_modifydate,
                sysinfo_contact_worker_code = obj.sysinfo_contact_worker_code,
                sysinfo_contact_name = obj.sysinfo_contact_name,
                sysinfo_contact_mobile = obj.sysinfo_contact_mobile,
                sysinfo_contact_tel = obj.sysinfo_contact_tel,
                sysinfo_contact_address = obj.sysinfo_contact_address,
                sysinfo_contact_status = obj.sysinfo_contact_status
            };
        }
    }
}
