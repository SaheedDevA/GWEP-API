﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.Lib.Models.Entities
{
    public class FileUpload : BaseEntity
    {
        public string filePath { get; set; }
        public string fileName { get; set; }
        public string Name { get; set; }

    }
}
