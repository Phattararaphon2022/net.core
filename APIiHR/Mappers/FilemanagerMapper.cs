using APIiHR.Common;
using APIiHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Mappers
{
    public class FilemanagerMapper
    {
        public static Filemanager MapToCommon(FilemanagerDAL obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new Filemanager
            {
                filemanager_createdate = obj.filemanager_createdate,
                filemanager_modifydate = obj.filemanager_modifydate,
                filemanager_worker_code = obj.filemanager_worker_code,
                filemanager_filename = obj.filemanager_filename,
                filemanager_fileexten = obj.filemanager_fileexten,
                filemanager_filetype = obj.filemanager_filetype,
                filemanager_filepath = obj.filemanager_filepath,
                filemanager_status = obj.filemanager_status,
                filemanager_setsecu = obj.filemanager_setsecu,
                filemanager_setpass = obj.filemanager_setpass,
                filemanager_txdesc = obj.filemanager_txdesc,
                filemanager_module = obj.filemanager_module,
                filemanager_fileupload = obj.filemanager_fileupload
            };
        }
        public static FilemanagerDAL MapToDto(Filemanager obj)
        {
            if (obj == null)
            {
                return null;
            }
            return new FilemanagerDAL
            {

                filemanager_createdate = obj.filemanager_createdate,
                filemanager_modifydate = obj.filemanager_modifydate,
                filemanager_worker_code = obj.filemanager_worker_code,
                filemanager_filename = obj.filemanager_filename,
                filemanager_fileexten = obj.filemanager_fileexten,
                filemanager_filetype = obj.filemanager_filetype,
                filemanager_filepath = obj.filemanager_filepath,
                filemanager_status = obj.filemanager_status,
                filemanager_setsecu = obj.filemanager_setsecu,
                filemanager_setpass = obj.filemanager_setpass,
                filemanager_txdesc = obj.filemanager_txdesc,
                filemanager_module = obj.filemanager_module,
                filemanager_fileupload = obj.filemanager_fileupload
            };
        }
    }
}
