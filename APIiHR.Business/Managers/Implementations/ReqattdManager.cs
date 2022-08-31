using APIiHR.Business.Managers.Interfaces;
using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Implementations
{
    public class ReqattdManager : IReqattdManager
    {
        private IReqattdDataAccess _ReqattdDataAccess;
        public ReqattdManager(IReqattdDataAccess ReqattdDataAccess)
        {
            _ReqattdDataAccess = ReqattdDataAccess;
        }

        public Reqattd CreateReqattd(Reqattd obj)
        {
            return _ReqattdDataAccess.CreateReqattd(obj);
        }

        public void DeleteReqattd(int code)
        {
            _ReqattdDataAccess.DeleteReqattd(code);
        }

        public List<Reqattd> GetReqattd()
        {
            return _ReqattdDataAccess.GetReqattd();
        }

        public List<Reqattd> GetReqattdByCode(string code)
        {
            return _ReqattdDataAccess.GetReqattdByCode(code);
        }

        public Reqattd UpdateReqattd(int id, Reqattd obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _ReqattdDataAccess.UpdateReqattd(obj);
        }
    }
}
