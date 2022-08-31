using APIiHR.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.Business.Managers.Interfaces
{
    public interface IFilemanagerManager
    {
        List<Filemanager> GetFilemanager();
        List<Filemanager> GetFilemanagerByCode(int code);
        Filemanager CreateFilemanager(Filemanager obj);
        Filemanager UpdateFilemanager(int id, Filemanager obj);
        void DeleteFilemanager(int code);
    }
}
