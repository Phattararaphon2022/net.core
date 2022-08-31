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
    public class ReqotManager : IReqotManager
    {
        private IReqotDataAccess _ReqotDataAccess;
        public ReqotManager(IReqotDataAccess ReqotDataAccess)
        {
            _ReqotDataAccess = ReqotDataAccess;
        }

        public Reqot CreateReqot(Reqot obj)
        {
            return _ReqotDataAccess.CreateReqot(obj);
        }

        public void DeleteReqot(int code)
        {
            _ReqotDataAccess.DeleteReqot(code);
        }

        public List<Reqot> GetReqot()
        {
            return _ReqotDataAccess.GetReqot();
        }

        public List<Reqot> GetReqotByCode(string code)
        {
            return _ReqotDataAccess.GetReqotByCode(code);
        }

        public Reqot UpdateReqot(int id, Reqot obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _ReqotDataAccess.UpdateReqot(obj);
        }
    }
}
