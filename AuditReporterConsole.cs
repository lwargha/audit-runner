using System;
using System.Collections.Generic;
using System.Text;
using Byui.CourseAudits.Business.Model.AuditBaseClass;

namespace Byui.CourseAudits.Business.Model.AuditReporters
{
    public class AuditReporterConsole : IAuditReporter
    {
        public void ReportAuditResults(List<AuditResult> auditResults)
        {
            foreach (var auditResult in auditResults)
            {
                Console.WriteLine($"{auditResult.AuditCode} {auditResult.CourseCode} {auditResult.AuditStatus}");
            }
        }
    }
}
