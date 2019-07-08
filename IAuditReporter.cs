using System.Collections.Generic;
using Byui.CourseAudits.Business.Model.AuditBaseClass;

namespace Byui.CourseAudits.Business.Model.AuditReporters
{
    public interface IAuditReporter
    {
        void ReportAuditResults(List<AuditResult> auditResults);
    }
}