namespace Playground
{
    public partial class ExcelDataForm : Form
    {
        public ExcelDataForm()
        {
            InitializeComponent();
            var service = new ExcelExportService();

            var jobs = service.ImportJobLog(@"C:\Users\Chris\OneDrive\Iron Horse\Job Management\Job_log\Job log.xlsx");
            dataGridView1.DataSource = jobs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dataGridView1.Rows[e.RowIndex].Selected = true;

            var selectedJob = (JobLogExcelModel)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            MessageBox.Show($"Selected Job: {selectedJob.JobNumber}");
        }
    }
}
