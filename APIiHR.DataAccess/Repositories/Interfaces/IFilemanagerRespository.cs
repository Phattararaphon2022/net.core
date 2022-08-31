using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Interfaces
{
    public interface IFilemanagerRespository
    {
        List<Filemanager> GetFilemanager();
        List<Filemanager> GetFilemanagerByCode(int code);

        Filemanager CreateFilemanager(Filemanager obj);

        Filemanager UpdateFilemanager(Filemanager obj);

        void DeleteFilemanager(int id);
    }
}
