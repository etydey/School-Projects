using System;
using System.Windows.Forms;
using CSVErrorLog.Domain;
using CSVErrorLog.Utility;

namespace CSVErrorLog.Forms
{
    public partial class DisplayEmployeeData : Form
    {

        /// <summary>
        /// Declare string variable.
        /// </summary>
        string UserName;


        public DisplayEmployeeData()
        {
            InitializeComponent();
        }

        public DisplayEmployeeData(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void DisplayMessage(string Message)
        {
            //At first, get the mdi parent reference
            MainForm Parent = (MainForm)this.MdiParent;

            //Then, Send error message back to the main form, display in the status strip label and set timer
            Parent.uxMessageLabel.Text = Message;
            Parent.StartTimer();

            //Finally, write this error in the error log file
            ErrorLogger.Log(UserName + "(" + DateTime.Today.ToLongDateString() + ")" + Message);
        }

        private void LoadEmployeeList()
        {
            try
            {
                uxEmployeeList.DataSource = null;
                uxEmployeeList.DataSource = Employee.GetAll(UserName);
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
            
        }

        private void uxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayEmployeeData_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }
    }
}
