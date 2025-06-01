using DevExpress.XtraEditors;
using VitaPharm.Data;

namespace VitaPharm.Reports
{
    public partial class frmRevenueReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmRevenueReportViewer()
        {
            InitializeComponent();
            dateEditFrom.DateTime = new DateTime(DateTime.Today.Year, 1, 1);
            dateEditTo.DateTime = DateTime.Today;

            PreviewDefaultReport();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateEditFrom.DateTime.Date;
            DateTime toDate = dateEditTo.DateTime.Date;

            if (fromDate > toDate)
            {
                XtraMessageBox.Show("From date must be less than or equal to To date!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filterDesc = $"From {fromDate:dd/MM/yyyy} to {toDate:dd/MM/yyyy}";

            var report = new rptRevenueReport();
            string currentUser;
            using (var context = new PharmacyDbContext())
            {
                var emp = context.Employees.FirstOrDefault(e => e.EmployeeID == CurrentUser.EmployeeID);
                currentUser = emp?.EmployeeName ?? "Unknown";
            }
            report.LoadData(fromDate, toDate, filterDesc, currentUser);

            documentViewer.DocumentSource = report;
            report.CreateDocument();
        }

        private void PreviewDefaultReport()
        {
            DateTime fromDate = dateEditFrom.DateTime.Date;
            DateTime toDate = dateEditTo.DateTime.Date;

            string filterDesc = $"From {fromDate:dd/MM/yyyy} to {toDate:dd/MM/yyyy}";

            var report = new rptRevenueReport();
            string currentUser;
            using (var context = new PharmacyDbContext())
            {
                var emp = context.Employees.FirstOrDefault(e => e.EmployeeID == CurrentUser.EmployeeID);
                currentUser = emp?.EmployeeName ?? "Unknown";
            }
            report.LoadData(fromDate, toDate, filterDesc, currentUser);

            documentViewer.DocumentSource = report;
            report.CreateDocument();
        }
    }
}