using APIiHR.Common;
using APIiHR.DataAccess.DatabaseContexts;
using APIiHR.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIiHR.DataAccess.Repositories.Implementations
{
    public class FilemanagerRespository : IFilemanagerRespository
    {
        private DbFilemanagerContext _DbFilemanagerContext;
        public FilemanagerRespository(DbFilemanagerContext dbFilemanagerContext)
        {
            _DbFilemanagerContext = dbFilemanagerContext;
        }
        public Filemanager CreateFilemanager(Filemanager obj)
        {
            obj.recid = new int();
            obj.filemanager_createdate = DateTime.Now;
            obj.filemanager_modifydate = DateTime.Now;
            
            _DbFilemanagerContext.FilemanagerTable.Add(obj);
            _DbFilemanagerContext.SaveChanges();
            return obj;
        }

        public void DeleteFilemanager(int id)
        {

            var items = _DbFilemanagerContext.FilemanagerTable.Where(item => item.recid == id);

            if (items.Any())
            {
                _DbFilemanagerContext.Remove(items.First());
                _DbFilemanagerContext.SaveChanges();
            }
        }

        public List<Filemanager> GetFilemanager()
        {
            return _DbFilemanagerContext.FilemanagerTable.ToList();
        }
        public List<Filemanager> GetFilemanagerByCode(int code)
        {
            var items = _DbFilemanagerContext.FilemanagerTable.Where(item => item.recid == code);
            if (items.Any())
            {
                return items.ToList();
            }
            return null;
        }
        public Filemanager UpdateFilemanager(Filemanager obj)
        {
            var items = _DbFilemanagerContext.FilemanagerTable.Where(item => item.recid == obj.recid);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var Filemanager = items.FirstOrDefault();

                Filemanager.filemanager_modifydate = DateTime.Now;
                Filemanager.filemanager_worker_code = obj.filemanager_worker_code;
                Filemanager.filemanager_filename = obj.filemanager_filename;
                Filemanager.filemanager_fileexten = obj.filemanager_fileexten;
                Filemanager.filemanager_filetype = obj.filemanager_filetype;
                Filemanager.filemanager_filepath = obj.filemanager_filepath;
                Filemanager.filemanager_status = obj.filemanager_status;
                Filemanager.filemanager_setsecu = obj.filemanager_setsecu;
                Filemanager.filemanager_setpass = obj.filemanager_setpass;
                Filemanager.filemanager_txdesc = obj.filemanager_txdesc;
                Filemanager.filemanager_module = obj.filemanager_module;
                Filemanager.filemanager_fileupload = obj.filemanager_fileupload;

            _DbFilemanagerContext.SaveChanges();

            return Filemanager;
        }
    }
}
