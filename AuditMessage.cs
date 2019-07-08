using System;
using System.Collections.Generic;
using System.Text;

namespace Byui.CourseAudits.Business.Model.AuditBaseClass
{
    public class AuditMessage
    {
        public string AuditCode { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
    }
}
