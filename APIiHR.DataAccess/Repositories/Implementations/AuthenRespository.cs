using APIiHR.Common;
using APIiHR.DataAccess.DatabaseContexts;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APIiHR.DataAccess.Repositories.Implementations
{
    public class AuthenRespository : IAuthenRespository
    {
        private tbMTWebUserContext _tbMTWebUserContext;
        private tbMTEmpMainContext _tbMTEmpMainContext;
        public AuthenRespository(tbMTWebUserContext tbMTWebUserContext, tbMTEmpMainContext  tbMTEmpMainContext)
        {
            _tbMTWebUserContext = tbMTWebUserContext;
            _tbMTEmpMainContext = tbMTEmpMainContext;
        }
        public Authen CreateAuthen(Authen obj)
        {
            _tbMTWebUserContext.tbMTWebUser.Add(obj);
            _tbMTWebUserContext.SaveChanges();
            return obj;
        }

        public void DeleteAuthen(int id)
        {

            var items = _tbMTWebUserContext.tbMTWebUser.Where(item => item.CompID == id.ToString());

            if (items.Any())
            {
                _tbMTWebUserContext.Remove(items.First());
                _tbMTWebUserContext.SaveChanges();
            }
        }

        public List<Authen> GetAuthen()

        {
            var User = (from U in _tbMTWebUserContext.tbMTWebUser 
                        where U.UserName == "10026" && U.CompID =="1000" 
                        select new {
                            CompID = U.CompID, 
                            UserName = U.UserName, 
                            UserType = U.UserType, 
                            Pwd=U.Pwd 
                        }).ToList();
            var Emp = (from M in _tbMTEmpMainContext.tbMTEmpMain 
                       where M.EmpID == "10026" && M.CompID =="1000" 
                       select new {
                           EmpID=M.EmpID, 
                           NameT = M.EmpFNameT+" "+M.EmpLNameT, 
                           NameE = M.EmpFName+" "+M.EmpLName 
                       }).ToList();
            List<Authen> Result = User.Join(Emp, x => x.UserName, y => y.EmpID,
                      (x, y) => new Authen
                      {
                          CompID = x.CompID,
                          EmpID = y.EmpID,
                          Pwd = x.Pwd,
                          UserName = x.UserName,
                          UserType = x.UserType,
                          NameT = y.NameT,
                          NameE = y.NameE,
                      }).ToList();


            return Result;
        }
        public List<Authen> GetAuthenByCode(string code)
        {
            var items = _tbMTWebUserContext.tbMTWebUser.Where(item => item.CompID == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Authen UpdateAuthen(Authen obj)
        {
            var items = _tbMTWebUserContext.tbMTWebUser.Where(item => item.CompID == obj.CompID);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Authen = items.FirstOrDefault();

            Authen.UserName = obj.UserName;
            Authen.Pwd = obj.Pwd;
            Authen.CompID = obj.CompID;
            // Authen.EmpID = obj.EmpID;
            // Authen.NameE = obj.NameE;
            // Authen.NameT = obj.NameT;
            Authen.UserType = obj.UserType;

            _tbMTWebUserContext.SaveChanges();
            return Authen;
        }
    }
}
