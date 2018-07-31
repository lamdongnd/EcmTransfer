using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpbank.Core.Model.SystemDb
{
    public class UploadHistory
    {
        public int ID { get; set; }
        public string QrCode { get; set; }
        public string RefNo { get; set; }
        public string ProductType { get; set; }
        public string FileName { get; set; }
        public string FolderId { get; set; }
        public string Branch { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}