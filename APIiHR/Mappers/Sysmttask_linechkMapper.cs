using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class Sysmttask_linechkMapper
    {
        public static Sysmttask_linechk MapToCommon(Sysmttask_linechkDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmttask_linechk
            {
                sysmttask_linechk_namealian = obj.sysmttask_linechk_namealian,
                sysmttask_linechk_txdesc = obj.sysmttask_linechk_txdesc,
                sysmttask_linechk_status = obj.sysmttask_linechk_status,
                sysmttask_linechk_code = obj.sysmttask_linechk_code,
                sysmttask_linechk_level = obj.sysmttask_linechk_level,
                sysmttask_linechk_refidmaster = obj.sysmttask_linechk_refidmaster,
                sysmttask_linechk_refcodemaster = obj.sysmttask_linechk_refcodemaster,
                sysmttask_linechk_refrecid = obj.sysmttask_linechk_refrecid,
                sysmttask_linechk_worker_code = obj.sysmttask_linechk_worker_code

            };
        }
        public static Sysmttask_linechkDAL MapToDto(Sysmttask_linechk obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmttask_linechkDAL
            {
                sysmttask_linechk_namealian = obj.sysmttask_linechk_namealian,
                sysmttask_linechk_txdesc = obj.sysmttask_linechk_txdesc,
                sysmttask_linechk_status = obj.sysmttask_linechk_status,
                sysmttask_linechk_code = obj.sysmttask_linechk_code,
                sysmttask_linechk_level = obj.sysmttask_linechk_level,
                sysmttask_linechk_refidmaster = obj.sysmttask_linechk_refidmaster,
                sysmttask_linechk_refcodemaster = obj.sysmttask_linechk_refcodemaster,
                sysmttask_linechk_refrecid = obj.sysmttask_linechk_refrecid,
                sysmttask_linechk_worker_code = obj.sysmttask_linechk_worker_code
            };
        }
    }
}
