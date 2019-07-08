using System.Collections.Generic;
using Byui.CourseAudits.Business.Model.AuditBaseClass;
using Byui.CourseAudits.Business.Model.AuditReporters;

namespace AirNomadAudits{
    public class DumbAudit : Audit
    {
        public DumbAudit(IAuditReporter auditReporter) : base(auditReporter)
        {
            
        }

        internal override List<AuditResult> ExecuteAudits(List<string> courseCodes)
        {
            var results =  new List<AuditResult>();
            foreach (var course in courseCodes) { 
                var result = new AuditResult();
                result.StartTime = new System.DateTime();
                var message = new AuditMessage();
                result.Messages.Add(message);
                if (course.StartsWith("1"))  {
                    //do something here
                }
                result.EndTime = new System.DateTime();
            }
            return results;
        }
    }

}