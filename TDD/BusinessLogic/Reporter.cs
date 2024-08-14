using Domain;

namespace BusinessLogic
{
    public class Reporter
    {
        public IReportBuilder ReportBuilder { get; }
        public IReportSender ReportSender { get; }
        public Reporter(IReportBuilder reportBuilder, IReportSender reportSender)
        {
            ReportBuilder = reportBuilder;
            ReportSender = reportSender;
        }

        

        public int SendReports()
        {
            IList<Report> reports = ReportBuilder.CreateReports();

            if (reports.Count == 0)
                ReportSender.Send(ReportBuilder.CreateSpecialReports());

            for(int i = 0; i < reports.Count(); i++)
            {
                ReportSender.Send(reports[i]);

                if(i % 2 == 0)
                {
                    ReportSender.Send(ReportBuilder.CreateAuditorsReport());
                }
            }

            return reports.Count();
        }
    }
}
