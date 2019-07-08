using System;
using System.Collections.Generic;
using System.Text;
using Byui.CourseAudits.Business.Model.AuditBaseClass;

namespace Byui.CourseAudits.Business.Model.AuditReporters
{
    public class AuditReporterNull : IAuditReporter
    {
        public void ReportAuditResults(List<AuditResult> auditResults)
        {

        }
    }
}
