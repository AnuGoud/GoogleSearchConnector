

using System.Collections.Generic;

namespace GoogleDriveSearchConnector.Models
{
    public class ErrorDetail
    {
        public List<InnerErrorDetail> Details { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }
}