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
    public class FilemanagerManager : IFilemanagerManager
    {
        private IFilemanagerDataAccess _FilemanagerDataAccess;
        public FilemanagerManager(IFilemanagerDataAccess FilemanagerDataAccess)
        {
            _FilemanagerDataAccess = FilemanagerDataAccess;
        }

        public Filemanager CreateFilemanager(Filemanager obj)
        {
            return _FilemanagerDataAccess.CreateFilemanager(obj);
        }

        public void DeleteFilemanager(int code)
        {
            _FilemanagerDataAccess.DeleteFilemanager(code);
        }

        public List<Filemanager> GetFilemanager()
        {
            return _FilemanagerDataAccess.GetFilemanager();
        }

        public List<Filemanager> GetFilemanagerByCode(int code)
        {
            return _FilemanagerDataAccess.GetFilemanagerByCode(code);
        }

        public Filemanager UpdateFilemanager(int id, Filemanager obj)
        {
            Console.WriteLine(id);
            obj.recid = id;
            return _FilemanagerDataAccess.UpdateFilemanager(obj);
        }
    }
}
