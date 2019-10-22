using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace Vid_Pic_Sorter
{
    #
    class Picture
    {
        #region Properties
        public FileAttributes PictureName { get; set; }
        public DateTime dateTime { get; set; }
        public FileExtensionsAttribute FileType { get; set; }
        public FileExtensionsAttribute FileSize { get; set; }
        public Directory Source { get; set; }
        public Directory Destination { get; set; }
        #endregion
    }
}
