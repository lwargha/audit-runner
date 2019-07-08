using System;
using System.Collections.Generic;
using System.Text;
using Byui.CourseAudits.Business.Model.AuditReporters;

namespace Byui.CourseAudits.Business.Model.AuditBaseClass
{
    public abstract class Audit
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        private readonly IAuditReporter _auditReporter;

        public List<AuditResult> RunAudits(List<string> courseCodes)
        {
           var auditResults = ExecuteAudits(courseCodes);
            _auditReporter?.ReportAuditResults(auditResults);

            return auditResults;
        }
        internal abstract List<AuditResult> ExecuteAudits(List<string> courseCodes);

        protected Audit(IAuditReporter auditReporter)
        {
            _auditReporter = auditReporter;
        }
    }
}
