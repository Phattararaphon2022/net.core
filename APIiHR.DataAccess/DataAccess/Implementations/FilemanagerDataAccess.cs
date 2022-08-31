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
    public class FilemanagerDataAccess : IFilemanagerDataAccess
    {
        private IFilemanagerRespository _FilemanagerRespository;
        public FilemanagerDataAccess(IFilemanagerRespository FilemanagerRepository)
        {
            _FilemanagerRespository = FilemanagerRepository;
        }
        public Filemanager CreateFilemanager(Filemanager obj)
        {
            return _FilemanagerRespository.CreateFilemanager(obj);
        }

        public void DeleteFilemanager(int code)
        {
            _FilemanagerRespository.DeleteFilemanager(code);
        }

        public List<Filemanager> GetFilemanager()
        {
            return _FilemanagerRespository.GetFilemanager();
        }

        public List<Filemanager> GetFilemanagerByCode(int code)
        {
            return _FilemanagerRespository.GetFilemanagerByCode(code);

        }

        public Filemanager UpdateFilemanager(Filemanager obj)
        {
            return _FilemanagerRespository.UpdateFilemanager(obj);
        }
    }
}
