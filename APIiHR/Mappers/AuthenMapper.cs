using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace APIiHR.Mappers
{
    public class AuthenMapper
    {
        public static Authen MapToCommon(AuthenDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Authen
            {
                CompID = obj.CompID,
                //   EmpID = obj.EmpID,
                UserName = obj.UserName,
                Pwd = obj.Pwd,
                UserType = obj.UserType,
                //     NameT = obj.NameT,
                //  NameE = obj.NameE,
            };
        }
        public static AuthenDAL MapToDto(Authen obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new AuthenDAL
            {
                CompID = obj.CompID,
                //     EmpID = obj.EmpID,
                UserName = obj.UserName,
                Pwd = obj.Pwd,
                UserType = obj.UserType,
                //   NameT = obj.NameT,
                //   NameE = obj.NameE,
            };
        }
    }
}
