namespace Domain.OCP
{
    public class ClientGood
    {
        private readonly IReportGeneration _reportGeneration;

        public ClientGood(IReportGeneration reportGeneration)
        {
            _reportGeneration = reportGeneration;
        }

        public void Reporter(User user)
        {
            _reportGeneration.GenerateReport(user);
        }
    }

    public class IReportGeneration
    {
        public virtual void GenerateReport(User user)
        {
            // From base
        }
    }

    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(User user)
        {
            // Generate crystal report.
        }
    }

    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(User user)
        {
            // Generate PDF report.
        }
    }
}
