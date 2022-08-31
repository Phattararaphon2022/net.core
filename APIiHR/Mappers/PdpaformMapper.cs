using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class PdpaformMapper
    {
        public static Pdpaform MapToCommon(PdpaformDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Pdpaform
            {
               
                recid = obj.recid,
                pdpaform_createdate = obj.pdpaform_createdate,
                pdpaform_modifydate = obj.pdpaform_modifydate,
                pdpaform_worker_code = obj.pdpaform_worker_code,
                pdpaform_refidfileatt = obj.pdpaform_refidfileatt,
                pdpaform_refidapp = obj.pdpaform_refidapp,
                pdpaform_startappcode = obj.pdpaform_startappcode,
                pdpaform_emailadd = obj.pdpaform_emailadd,
                pdpaform_infotype1 = obj.pdpaform_infotype1,
                pdpaform_infotype2 = obj.pdpaform_infotype2,
                pdpaform_txdesc = obj.pdpaform_txdesc,
                pdpaform_person = obj.pdpaform_person,
                pdpaform_fname = obj.pdpaform_fname,
                pdpaform_lname = obj.pdpaform_lname,
                pdpaform_status = obj.pdpaform_status

            };
        }
        public static PdpaformDAL MapToDto(Pdpaform obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new PdpaformDAL
            {
                recid = obj.recid,
                pdpaform_createdate = obj.pdpaform_createdate,
                pdpaform_modifydate = obj.pdpaform_modifydate,
                pdpaform_worker_code = obj.pdpaform_worker_code,
                pdpaform_refidfileatt = obj.pdpaform_refidfileatt,
                pdpaform_refidapp = obj.pdpaform_refidapp,
                pdpaform_startappcode = obj.pdpaform_startappcode,
                pdpaform_emailadd = obj.pdpaform_emailadd,
                pdpaform_infotype1 = obj.pdpaform_infotype1,
                pdpaform_infotype2 = obj.pdpaform_infotype2,
                pdpaform_txdesc = obj.pdpaform_txdesc,
                pdpaform_person = obj.pdpaform_person,
                pdpaform_fname = obj.pdpaform_fname,
                pdpaform_lname = obj.pdpaform_lname,
                pdpaform_status = obj.pdpaform_status
            };
        }
    }
}
