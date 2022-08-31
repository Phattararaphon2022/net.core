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
    public class ReqleaveManager : IReqleaveManager
    {
        private IReqleaveDataAccess _ReqleaveDataAccess;
        public ReqleaveManager(IReqleaveDataAccess ReqleaveDataAccess)
        {
            _ReqleaveDataAccess = ReqleaveDataAccess;
        }

        public Reqleave CreateReqleave(Reqleave obj)
        {
            return _ReqleaveDataAccess.CreateReqleave(obj);
        }

        public void DeleteReqleave(int code)
        {
            _ReqleaveDataAccess.DeleteReqleave(code);
        }

        public List<Reqleave> GetReqleave()
        {
            return _ReqleaveDataAccess.GetReqleave();
        }

        public List<Reqleave> GetReqleaveByCode(string code)
        {
            return _ReqleaveDataAccess.GetReqleaveByCode(code);
        }

        public Reqleave UpdateReqleave(int id, Reqleave obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _ReqleaveDataAccess.UpdateReqleave(obj);
        }
    }
}
