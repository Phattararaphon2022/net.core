using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class CheckinMapper
    {
        public static Checkin MapToCommon(CheckinDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Checkin
            {
                
                checkin_createdate = obj.checkin_createdate,
                checkin_modifydate = obj.checkin_modifydate,
                checkin_datestart = obj.checkin_datestart,
                checkin_datestartstamp = obj.checkin_datestartstamp,
                checkin_dateend = obj.checkin_dateend,
                checkin_dateendstamp = obj.checkin_dateendstamp,
                checkin_worker_code = obj.checkin_worker_code,
                checkin_status = obj.checkin_status,
                checkin_txdesc = obj.checkin_txdesc,
                checkin_mastercode = obj.checkin_mastercode,
                checkin_dim1 = obj.checkin_dim1,
                checkin_level = obj.checkin_level


            };
        }
        public static CheckinDAL MapToDto(Checkin obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new CheckinDAL
            {
                
                checkin_createdate = obj.checkin_createdate,
                checkin_modifydate = obj.checkin_modifydate,
                checkin_datestart = obj.checkin_datestart,
                checkin_datestartstamp = obj.checkin_datestartstamp,
                checkin_dateend = obj.checkin_dateend,
                checkin_dateendstamp = obj.checkin_dateendstamp,
                checkin_worker_code = obj.checkin_worker_code,
                checkin_status = obj.checkin_status,
                checkin_txdesc = obj.checkin_txdesc
            };
        }
    }
}
