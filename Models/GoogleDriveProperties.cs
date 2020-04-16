

using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace GoogleDriveSearchConnector.Models
{
    public class GoogleDriveProperties
    {
        public int RowID { get; set; }
       // public string FileID { get; set; }
        public string FileName { get; set; }
        public string Owner { get; set; }
       // public string OwnerEmail { get; set; }
        public string LastModifyingUser { get; set; }
       // public string LastModifyingUserEmail { get; set; }
        //public DateTime CreatedTime { get; set; }
        //public DateTime ModifiedTime { get; set; }
        //public string Size { get; set; }
        //public Uri FilePath { get; set; }
    }

}