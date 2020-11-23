using System;
using System.Windows.Forms;
using CSVErrorLog.Domain;
using CSVErrorLog.Utility;

namespace CSVErrorLog.Forms
{
    public partial class AddEmployeeData : Form
    {
        /// <summary>
        /// Declare string variable.
        /// </summary>
        string UserName;

        public AddEmployeeData()
        {
            InitializeComponent();
            uxDepartmentCombo.SelectedIndex = 0;
        }

        public AddEmployeeData(string username)
        {
            InitializeComponent();
            uxDepartmentCombo.SelectedIndex = 0;
            UserName = username;
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



        private void uxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate the First Name field
                if (Validator.IsEmpty(uxFirstName.Text))
                {
                    //Call display message method
                    DisplayMessage("First Name cannot be empty");
                    uxFirstName.Focus();
                    return;
                }
                else if (!Validator.IsAlpha(uxFirstName.Text))
                {
                    DisplayMessage("First Name can only contain letters and first letter must be capital.");
                    uxFirstName.Focus();
                    return;
                }

                //Validate the Last Name field
                if (Validator.IsEmpty(uxLastName.Text))
                {
                    //Call display message method
                    DisplayMessage("Last Name cannot be empty");
                    uxLastName.Focus();
                    return;
                }
                else if (!Validator.IsAlpha(uxLastName.Text))
                {
                    DisplayMessage("Last Name can only contain letters and first letter must be capital.");
                    uxLastName.Focus();
                    return;
                }

                
                //Validate the phone number field
                if (Validator.IsEmpty(uxPhone.Text))
                {
                    //Call display message method
                    DisplayMessage("Phone Number Required!");
                    uxPhone.Focus();
                    return;
                }
                else if (!Validator.IsPhoneFormat(uxPhone.Text))
                {
                    DisplayMessage("Invalid Phone number! Use xxx-xxxx format for phone number.");
                    uxPhone.Focus();
                    return;
                }


                Employee emp = new Employee(uxFirstName.Text, uxLastName.Text, uxDepartmentCombo.SelectedItem.ToString(), uxPhone.Text);
                Employee.Add(emp, UserName);

                DisplayMessage("Employee added successfully.");

                uxFirstName.Clear();
                uxLastName.Clear();
                uxPhone.Clear();
                uxDepartmentCombo.SelectedIndex = 0;
                uxFirstName.Focus();
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
                uxFirstName.Focus();
            }
        }
    }
}
