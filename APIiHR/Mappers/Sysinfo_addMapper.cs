using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class Sysinfo_addMapper
    {
        public static Sysinfo_add MapToCommon(Sysinfo_addDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysinfo_add
            {
                sysinfo_add_createdate = obj.sysinfo_add_createdate,
                sysinfo_add_namealian = obj.sysinfo_add_namealian,
                sysinfo_add_worker_code = obj.sysinfo_add_worker_code,
                sysinfo_add_moo = obj.sysinfo_add_moo,
                sysinfo_add_soi = obj.sysinfo_add_soi,
                sysinfo_add_road = obj.sysinfo_add_road,
                sysinfo_add_tambon = obj.sysinfo_add_tambon,
                sysinfo_add_amphur = obj.sysinfo_add_amphur,
                sysinfo_add_province = obj.sysinfo_add_province,
                sysinfo_add_addressno = obj.sysinfo_add_addressno,
                sysinfo_add_zipcode = obj.sysinfo_add_zipcode,
                sysinfo_add_status = obj.sysinfo_add_status,

                sysinfo_add_reftran = obj.sysinfo_add_reftran,
                 sysinfo_add_refdim1 = obj.sysinfo_add_refdim1,
                  sysinfo_add_refdimrec = obj.sysinfo_add_refdimrec

                /*
                 * 
                 * recid                       :number = 0;
            sysinfo_add_createdate      :Date = new Date()
            sysinfo_add_namealian       :string = ''
            sysinfo_add_worker_code     :string = ''
            sysinfo_add_moo             :string = ''
            sysinfo_add_soi             :string = ''
            sysinfo_add_road            :string = ''
            sysinfo_add_tambon          :string = ''
            sysinfo_add_amphur          :string = ''
            sysinfo_add_province        :string = ''
            sysinfo_add_addressno       :string = ''
            sysinfo_add_zipcode         :string = ''
            sysinfo_add_status          :string = ''
                 */

            };
        }
        public static Sysinfo_addDAL MapToDto(Sysinfo_add obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysinfo_addDAL
            {
                sysinfo_add_createdate = obj.sysinfo_add_createdate,
                sysinfo_add_namealian = obj.sysinfo_add_namealian,
                sysinfo_add_worker_code = obj.sysinfo_add_worker_code,
                sysinfo_add_moo = obj.sysinfo_add_moo,
                sysinfo_add_soi = obj.sysinfo_add_soi,
                sysinfo_add_road = obj.sysinfo_add_road,
                sysinfo_add_tambon = obj.sysinfo_add_tambon,
                sysinfo_add_amphur = obj.sysinfo_add_amphur,
                sysinfo_add_province = obj.sysinfo_add_province,
                sysinfo_add_addressno = obj.sysinfo_add_addressno,
                sysinfo_add_zipcode = obj.sysinfo_add_zipcode,
                sysinfo_add_status = obj.sysinfo_add_status
            };
        }
    }
}
