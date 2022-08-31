using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class CertfMapper
    {
        public static Certf MapToCommon(CertfDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Certf
            {
               
                certf_createdate = obj.certf_createdate,
                certf_modifydate = obj.certf_modifydate,
                certf_worker_code = obj.certf_worker_code,
                certf_reffile = obj.certf_reffile,
                certf_expdate = obj.certf_expdate,
                certf_repdate = obj.certf_repdate,
                certf_txdesc = obj.certf_txdesc,
                certf_name = obj.certf_name

            };
        }
        public static CertfDAL MapToDto(Certf obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new CertfDAL
            {
                certf_createdate = obj.certf_createdate,
                certf_modifydate = obj.certf_modifydate,
                certf_worker_code = obj.certf_worker_code,
                certf_reffile = obj.certf_reffile,
                certf_expdate = obj.certf_expdate,
                certf_repdate = obj.certf_repdate,
                certf_txdesc = obj.certf_txdesc,
                certf_name = obj.certf_name
            };
        }
    }
}
