namespace DayOneApp
{
    public partial class frmDayOne : Form
    {
        public string URLSource = "https://dayone.me/";

        public frmDayOne()
        {
            InitializeComponent();
        }

        public void frmDayOne_Load(object sender, EventArgs e)
        {
            // Load the current date
            this.vwMain.Source = new Uri(this.URLSource);
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reload the current date
            this.vwMain.Source = new Uri(this.URLSource);
            this.vwMain.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void frmDayOne_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
