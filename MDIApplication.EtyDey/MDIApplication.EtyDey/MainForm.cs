using System;
using System.Windows.Forms;

namespace MDIApplication.EtyDey
{
    public partial class MainForm : Form
    {
        //Declare Form objects.
        DataEntryForm frmDataEntry;
        DisplayDataForm frmDataDisplay;

        public MainForm()
        {
            InitializeComponent();
        }


        //Create methods to load forms into the main form
        private void CreateDataEntry()
        {
            //try to execute in the try code block
            try
            {
                if (frmDataEntry == null || frmDataEntry.IsDisposed)
                {
                    frmDataEntry = new DataEntryForm();
                    frmDataEntry.MdiParent = this;
                }

                frmDataEntry.Show();
                frmDataEntry.BringToFront();
            }
            catch(Exception ex)
            {
                //Show the error message
                uxMessageLabel.Text = ex.Message;
                StartTimer();
            }
        }

        private void CreateDataDisplay()
        {
            //try to execute in the try code block
            try
            {
                if (frmDataDisplay == null || frmDataDisplay.IsDisposed)
                {
                    frmDataDisplay = new DisplayDataForm();
                    frmDataDisplay.MdiParent = this;
                }

                frmDataDisplay.Show();
                frmDataDisplay.BringToFront();
            }
            catch(Exception ex)
            {
                //Show the error message
                uxMessageLabel.Text = ex.Message;
                StartTimer();
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDataEntry();
        }

        private void dataDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDataDisplay();
        }

        private void uxDataEntryButton_Click(object sender, EventArgs e)
        {
            CreateDataEntry();
        }

        private void uxDataDisplayButton_Click(object sender, EventArgs e)
        {
            CreateDataDisplay();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpAbout frmAbout = new HelpAbout();
            frmAbout.ShowDialog();
        }

        private void uxMsgTimer_Tick(object sender, EventArgs e)
        {
            uxMessageTimer.Stop();
            uxMessageLabel.Text = "Ready";
        }
        public void StartTimer()
        {
            uxMessageTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeList.AddTestData();
            }
            catch(Exception ex)
            {
                uxMessageLabel.Text = ex.Message;
                StartTimer();
            }
        }
    }
}
