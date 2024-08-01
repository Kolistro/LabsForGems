using Moq;
using System.Collections.Generic;
using BusinessLogic;
using Domain;


namespace Tests
{
    public class ReporterTests
    {
        private readonly Mock<IReportBuilder> reportBuilder;
        private readonly Mock<IReportSender> reportSender;
        private readonly Reporter reporter;

        public ReporterTests()
        {
            reportBuilder = new Mock<IReportBuilder>();
            reportSender = new Mock<IReportSender>();
            reporter = new Reporter(reportBuilder.Object, reportSender.Object);
        }

        // 1. После отправки всех отчётов, нужно вывести в консоль количество отправленных.
        [Fact]
        public void ReturnCountOfSentReports()
        {
            // задаем поведение для интерфейса IReportBuilder
            reportBuilder.Setup(m => m.CreateReports())
                .Returns(new List<Report>
                {
                    new Report(),
                    new Report()
                });

            var reportCount = reporter.SendReports();
            Assert.Equal(2, reportCount);
        }

        // 2. Каждый день должны рассылаться все отчёты, сформированные по определенному шаблону.
        //    Шаблон может быть изменен в любое время.
        [Fact]
        public void SendAllReports()
        {
            // данные (arrange)
            reportBuilder.Setup(m => m.CreateReports())
                .Returns(new List<Report>
                {
                    new Report(),
                    new Report()
                });

            // после написания 4 теста, пришлось добавить эту строчку.
            reportBuilder.Setup(m => m.CreateAuditorsReport())
                .Returns(new AuditorsReport());

            // действие (act)
            reporter.SendReports();

            // проверка (assert)
            reportSender.Verify(m => m.Send(It.IsAny<Report>()), Times.Exactly(3));
        }

        // 3. Если ни одного отчета не сформировано, то отправляем сообщение руководству о том, что отчетов нет.
        [Fact]
        public void SendSpecialReportToAdministratorIfNoReportsCreated()
        {
            reportBuilder.Setup(m => m.CreateReports())
                .Returns(new List<Report>());

            reportBuilder.Setup(m => m.CreateSpecialReports())
                .Returns(new SpecialReport());

            reporter.SendReports();

            reportSender.Verify(m => m.Send(It.IsAny<SpecialReport>()), Times.Once());
        }

        // 4. Каждый второй сформированный отчет нужно отправлять еще и аудиторам.
        // ** Тест, который нужно было написать самостоятельно
        [Fact]
        public void SendEverySecondReportToAuditors()
        {
            reportBuilder.Setup(m => m.CreateReports())
                .Returns(new List<Report>
                {
                    new Report(),
                    new Report(),
                    new Report(),
                    new Report()
                });

            reportBuilder.Setup(m => m.CreateAuditorsReport())
                .Returns(new AuditorsReport());

            reporter.SendReports();

            reportSender.Verify(m => m.Send(It.IsAny<AuditorsReport>()), Times.Exactly(2));
        }
    }
}
