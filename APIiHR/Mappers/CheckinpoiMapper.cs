using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class CheckinpoiMapper
    {
        public static Checkinpoi MapToCommon(CheckinpoiDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Checkinpoi
            {
                recid = obj.recid,
                checkinpoi_createdate = obj.checkinpoi_createdate,
                checkinpoi_modifydate = obj.checkinpoi_modifydate,
                checkinpoi_worker_code = obj.checkinpoi_worker_code,
                checkinpoi_code = obj.checkinpoi_code,
                checkinpoi_lat = obj.checkinpoi_lat,
                checkinpoi_lng = obj.checkinpoi_lng,
                checkinpoi_typeio = obj.checkinpoi_typeio

            };
        }
        public static CheckinpoiDAL MapToDto(Checkinpoi obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new CheckinpoiDAL
            {
                recid = obj.recid,
                checkinpoi_createdate = obj.checkinpoi_createdate,
                checkinpoi_modifydate = obj.checkinpoi_modifydate,
                checkinpoi_worker_code = obj.checkinpoi_worker_code,
                checkinpoi_code = obj.checkinpoi_code,
                checkinpoi_lat = obj.checkinpoi_lat,
                checkinpoi_lng = obj.checkinpoi_lng,
                checkinpoi_typeio = obj.checkinpoi_typeio
            };
        }
    }
}
