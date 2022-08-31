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
    public class ReqotDataAccess : IReqotDataAccess
    {
        private IReqotRespository _ReqotRespository;
        public ReqotDataAccess(IReqotRespository ReqotRepository)
        {
            _ReqotRespository = ReqotRepository;
        }
        public Reqot CreateReqot(Reqot obj)
        {
            return _ReqotRespository.CreateReqot(obj);
        }

        public void DeleteReqot(int code)
        {
            _ReqotRespository.DeleteReqot(code);
        }

        public List<Reqot> GetReqot()
        {
            return _ReqotRespository.GetReqot();
        }

        public List<Reqot> GetReqotByCode(string code)
        {
            return _ReqotRespository.GetReqotByCode(code);

        }

        public Reqot UpdateReqot(Reqot obj)
        {
            return _ReqotRespository.UpdateReqot(obj);
        }
    }
}
