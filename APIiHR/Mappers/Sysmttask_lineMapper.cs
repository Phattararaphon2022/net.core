using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class Sysmttask_lineMapper
    {
        public static Sysmttask_line MapToCommon(Sysmttask_lineDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmttask_line
            {
                recid = obj.recid,
                sysmttask_line_namealian = obj.sysmttask_line_namealian,
                sysmttask_line_txdesc = obj.sysmttask_line_txdesc,
                sysmttask_line_status = obj.sysmttask_line_status,
                sysmttask_line_code = obj.sysmttask_line_code,
                sysmttask_line_level = obj.sysmttask_line_level,
                sysmttask_line_refidmaster = obj.sysmttask_line_refidmaster,
                sysmttask_line_refcodemaster = obj.sysmttask_line_refcodemaster,
                sysmttask_line_refrecid = obj.sysmttask_line_refrecid

            };
        }
        public static Sysmttask_lineDAL MapToDto(Sysmttask_line obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Sysmttask_lineDAL
            {
                recid = obj.recid,
                sysmttask_line_namealian = obj.sysmttask_line_namealian,
                sysmttask_line_txdesc = obj.sysmttask_line_txdesc,
                sysmttask_line_status = obj.sysmttask_line_status,
                sysmttask_line_code = obj.sysmttask_line_code,
                sysmttask_line_level = obj.sysmttask_line_level,
                sysmttask_line_refidmaster = obj.sysmttask_line_refidmaster,
                sysmttask_line_refcodemaster = obj.sysmttask_line_refcodemaster,
                sysmttask_line_refrecid = obj.sysmttask_line_refrecid
            };
        }
    }
}
