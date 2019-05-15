namespace Domain.OCP
{
    public class ClientBad
    {
        public void Reporter(User user, string ReportType) {
            var reportGeneration = new ReportGeneration();
            reportGeneration.ReportType = "CRS";
            reportGeneration.user = user;
            reportGeneration.GenerateReport();
        }
    }


    public class ReportGeneration
    {
        public string ReportType { get; set; }
        public User user { get; set; }

        public void GenerateReport()
        {
            if (ReportType == "CRS")
            {
                var reporter = new CrsReportGenerator();
                reporter.GenerateReport(user);
            } 
            else if (ReportType == "PDF")
            {
                var reporter = new PdfReportGenerator();
                reporter.GenerateReport(user);
            }
            else if (ReportType == "TXT")
            {
                var reporter = new PdfReportGenerator();
                reporter.GenerateReport(user);
            }
        }
    }

    public class CrsReportGenerator
    {
        public void GenerateReport(User user)
        {
            // Report generation with employee data in Crystal Report.
        }
    }

    public class PdfReportGenerator
    {
        public void GenerateReport(User user)
        {
            // Report generation with PDF generator

        }
    }

    public class TxtReportGenerator
    {
        void GenerateReport(User user)
        {
            // Report generation with smple text
        }
    }


}
