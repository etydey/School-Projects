using System;
using System.Windows.Forms;

namespace CSVErrorLog.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Declare Form objects.
        /// </summary>
        DisplayErrorLog displayLog;
        DisplayEmployeeData displayemployee;
        AddEmployeeData addEmployee;

        /// <summary>
        /// Declare string variable.
        /// </summary>
        string UserName;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string userName)
        {
            InitializeComponent();
            UserName = userName;
        }

        /// <summary>
        /// Create methods to load forms into the main form
        /// </summary>
        private void DisplayLogForm()
        {
            //try to execute in the try code block
            try
            {
                if (displayLog == null || displayLog.IsDisposed)
                {
                    displayLog = new DisplayErrorLog();
                    displayLog.MdiParent = this;
                }

                displayLog.Show();
                displayLog.BringToFront();
            }
            catch (Exception ex)
            {
                //Show the error message
                uxMessageLabel.Text = ex.Message;
                StartTimer();
            }
        }

        private void AddEmployeeForm()
        {
            //try to execute in the try code block
            try
            {
                if (addEmployee == null || addEmployee.IsDisposed)
                {
                    addEmployee = new AddEmployeeData(UserName);
                    addEmployee.MdiParent = this;
                }

                addEmployee.Show();
                addEmployee.BringToFront();
            }
            catch (Exception ex)
            {
                //Show the error message
                uxMessageLabel.Text = ex.Message;
                StartTimer();
            }
        }

        private void DisplayEmployeeForm()
        {
            //try to execute in the try code block
            try
            {
                if (displayemployee == null || displayemployee.IsDisposed)
                {
                    displayemployee = new DisplayEmployeeData(UserName);
                    displayemployee.MdiParent = this;
                }

                displayemployee.Show();
                displayemployee.BringToFront();
            }
            catch (Exception ex)
            {
                //Show the error message
                uxMessageLabel.Text = ex.Message;
                StartTimer();
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void uxMessageTimer_Tick(object sender, EventArgs e)
        {
            uxMessageTimer.Stop();
            uxMessageLabel.Text = "Ready";
        }

        public void StartTimer()
        {
            uxMessageTimer.Start();
        }


        private void uxDisplayLog_Click(object sender, EventArgs e)
        {
            DisplayLogForm();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeForm();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEmployeeForm();
        }

        private void uxAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm();
        }

        private void uxDisplayEmployee_Click(object sender, EventArgs e)
        {
            DisplayEmployeeForm();
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayLogForm();
        }
    }
}
