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
    public class ReqinfoManager : IReqinfoManager
    {
        private IReqinfoDataAccess _ReqinfoDataAccess;
        public ReqinfoManager(IReqinfoDataAccess ReqinfoDataAccess)
        {
            _ReqinfoDataAccess = ReqinfoDataAccess;
        }

        public Reqinfo CreateReqinfo(Reqinfo obj)
        {
            return _ReqinfoDataAccess.CreateReqinfo(obj);
        }

        public void DeleteReqinfo(int code)
        {
            _ReqinfoDataAccess.DeleteReqinfo(code);
        }

        public List<Reqinfo> GetReqinfo()
        {
            return _ReqinfoDataAccess.GetReqinfo();
        }

        public List<Reqinfo> GetReqinfoByCode(int code)
        {
            return _ReqinfoDataAccess.GetReqinfoByCode(code);
        }

        public Reqinfo UpdateReqinfo(int id, Reqinfo obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _ReqinfoDataAccess.UpdateReqinfo(obj);
        }
    }
}
