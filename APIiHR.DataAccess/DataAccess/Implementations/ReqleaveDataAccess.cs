using APIiHR.Common;
using APIiHR.DataAccess.DataAccess.Interfaces;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.DataAccess.Implementations
{
    public class ReqleaveDataAccess : IReqleaveDataAccess
    {
        private IReqleaveRespository _ReqleaveRespository;
        public ReqleaveDataAccess(IReqleaveRespository ReqleaveRepository)
        {
            _ReqleaveRespository = ReqleaveRepository;
        }
        public Reqleave CreateReqleave(Reqleave obj)
        {
            return _ReqleaveRespository.CreateReqleave(obj);
        }

        public void DeleteReqleave(int code)
        {
            _ReqleaveRespository.DeleteReqleave(code);
        }

        public List<Reqleave> GetReqleave()
        {
            return _ReqleaveRespository.GetReqleave();
        }

        public List<Reqleave> GetReqleaveByCode(string code)
        {
            return _ReqleaveRespository.GetReqleaveByCode(code);

        }

        public Reqleave UpdateReqleave(Reqleave obj)
        {
            return _ReqleaveRespository.UpdateReqleave(obj);
        }
    }
}
