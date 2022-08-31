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
    public class ReqattdDataAccess : IReqattdDataAccess
    {
        private IReqattdRespository _ReqattdRespository;
        public ReqattdDataAccess(IReqattdRespository ReqattdRepository)
        {
            _ReqattdRespository = ReqattdRepository;
        }
        public Reqattd CreateReqattd(Reqattd obj)
        {
            return _ReqattdRespository.CreateReqattd(obj);
        }

        public void DeleteReqattd(int code)
        {
            _ReqattdRespository.DeleteReqattd(code);
        }

        public List<Reqattd> GetReqattd()
        {
            return _ReqattdRespository.GetReqattd();
        }

        public List<Reqattd> GetReqattdByCode(string code)
        {
            return _ReqattdRespository.GetReqattdByCode(code);

        }

        public Reqattd UpdateReqattd(Reqattd obj)
        {
            return _ReqattdRespository.UpdateReqattd(obj);
        }
    }
}
