using Domain;

namespace BusinessLogic
{
    public interface IReportBuilder
    {
        AuditorsReport CreateAuditorsReport();
        IList<Report> CreateReports();
        SpecialReport CreateSpecialReports();
    }
}
