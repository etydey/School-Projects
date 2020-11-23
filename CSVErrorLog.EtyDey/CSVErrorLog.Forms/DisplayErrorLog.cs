using System;
using System.Windows.Forms;
using CSVErrorLog.Utility;

namespace CSVErrorLog.Forms
{
    public partial class DisplayErrorLog : Form
    {
        /// <summary>
        /// Declare string variable.
        /// </summary>
        string UserName;


        public DisplayErrorLog()
        {
            InitializeComponent();
        }

        public DisplayErrorLog( string userName)
        {
            InitializeComponent();
            UserName = userName;
        }



        /// <summary>
        /// Create methods to display message in the message label of main form
        /// </summary>
        /// <param name="Message"></param>
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

        private void DisplayErrorList()
        {
            try
            {
                uxDisplayLog.DataSource = null;
                uxDisplayLog.DataSource = ErrorLogger.DisplayErrors();
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void uxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayErrorLog_Load(object sender, EventArgs e)
        {
            DisplayErrorList();
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayErrorList();
        }
    }
}
