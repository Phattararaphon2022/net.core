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
    public class ReqinfoDataAccess : IReqinfoDataAccess
    {
        private IReqinfoRespository _ReqinfoRespository;
        public ReqinfoDataAccess(IReqinfoRespository ReqinfoRepository)
        {
            _ReqinfoRespository = ReqinfoRepository;
        }
        public Reqinfo CreateReqinfo(Reqinfo obj)
        {
            return _ReqinfoRespository.CreateReqinfo(obj);
        }

        public void DeleteReqinfo(int code)
        {
            _ReqinfoRespository.DeleteReqinfo(code);
        }

        public List<Reqinfo> GetReqinfo()
        {
            return _ReqinfoRespository.GetReqinfo();
        }

        public List<Reqinfo> GetReqinfoByCode(int code)
        {
            return _ReqinfoRespository.GetReqinfoByCode(code);

        }

        public Reqinfo UpdateReqinfo(Reqinfo obj)
        {
            return _ReqinfoRespository.UpdateReqinfo(obj);
        }
    }
}
