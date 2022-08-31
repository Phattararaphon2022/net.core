using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIiHR.Models
{
    public class FileModel
    {
        public IFormFile Myfile { get; set; }
        public string AltText { get; set; }
        public string Description { get; set; }
        public string worker_code { get; set; }
        public string module_form { get; set; }
        public string namefileupload { get; set; }

    }
}
