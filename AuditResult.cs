using System;
using System.Collections.Generic;
using System.Text;
using Byui.CourseAudits.Business.Model.AuditBaseClass;

namespace Byui.CourseAudits.Business.Model.AuditBaseClass
{
    public class AuditResult
    {
        public string AuditCode { get; set; }
        public string CourseCode { get; set; }
        public string AuditStatus => GetAuditStatus();
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<AuditMessage> Messages { get; set; }
        private string GetAuditStatus()
        {
            return "TODO calculate status";
        }
    }
}
