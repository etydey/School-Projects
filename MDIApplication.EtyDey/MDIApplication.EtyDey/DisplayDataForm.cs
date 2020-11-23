using System;
using System.Windows.Forms;

namespace MDIApplication.EtyDey
{
    public partial class DisplayDataForm : Form
    {
        //Declare variable for indexing and counting
        int index = 0;
        int count = 0;

        public DisplayDataForm()
        {
            InitializeComponent();
        }

        private void SetEmployeeData(int index)
        {
            try
            {
                count= EmployeeList.GetEmployees().Count;

                //set value into the control box
                uxFirstName.Text = EmployeeList.GetEmployees()[index].FirstName;
                uxLastName.Text = EmployeeList.GetEmployees()[index].LastName;
                uxCity.Text = EmployeeList.GetEmployees()[index].City;
                uxEmail.Text = EmployeeList.GetEmployees()[index].Email;
                uxPhoneNumber.Text = EmployeeList.GetEmployees()[index].PhoneNumber;
                uxSalary.Text = EmployeeList.GetEmployees()[index].Salary.ToString("c");
                uxDepartment.Text = EmployeeList.GetEmployees()[index].Department;

                //show that record number
                uxRecordNumber.Text = (int)decimal.Add(index , 1) + " of " + count;
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void DisplayMessage(string ex)
        {
            //At first, get the mdi parent reference
            MainForm Parent = (MainForm)this.MdiParent;

            //Then, Send error message back to the main form, display in the status strip label and set timer
            Parent.uxMessageLabel.Text = ex;
            Parent.StartTimer();
        }

        private void DisplayDataForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetEmployeeData(index);

                uxFirstButton.Enabled = false;
                uxPreviousButton.Enabled = false;

                if (count > 1)
                {
                    uxNextButton.Enabled = true;
                    uxLastButton.Enabled = true;
                }
                else
                {
                    uxNextButton.Enabled = false;
                    uxLastButton.Enabled = false;
                }
                
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void uxNextButton_Click(object sender, EventArgs e)
        {
            try
            {
                index++;

                SetEmployeeData(index);

                if (index == (int)decimal.Subtract(count, 1))
                {
                    uxNextButton.Enabled = false;
                    uxLastButton.Enabled = false;
                    uxFirstButton.Enabled = true;
                    uxPreviousButton.Enabled = true;
                }
                else
                {
                    uxNextButton.Enabled = true;
                    uxLastButton.Enabled = true;
                    uxFirstButton.Enabled = true;
                    uxPreviousButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }

        }

        private void uxLastButton_Click(object sender, EventArgs e)
        {
            try
            {
                index = (int)decimal.Subtract(count ,1);

                SetEmployeeData(index);

                uxNextButton.Enabled = false;
                uxLastButton.Enabled = false;

                if (count > 1)
                {
                    uxFirstButton.Enabled = true;
                    uxPreviousButton.Enabled = true;
                }
                else
                {
                    uxFirstButton.Enabled = false;
                    uxPreviousButton.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void uxFirstButton_Click(object sender, EventArgs e)
        {
            try
            {
                index = 0;

                SetEmployeeData(index);

                uxFirstButton.Enabled = false;
                uxPreviousButton.Enabled = false;

                if (count > 1)
                {
                    uxNextButton.Enabled = true;
                    uxLastButton.Enabled = true;
                }
                else
                {
                    uxNextButton.Enabled = false;
                    uxLastButton.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void uxPreviousButton_Click(object sender, EventArgs e)
        {
            try
            {
                index--;

                SetEmployeeData(index);

                if (index == 0)
                {
                    uxNextButton.Enabled = true;
                    uxLastButton.Enabled = true;
                    uxFirstButton.Enabled = false;
                    uxPreviousButton.Enabled = false;
                }
                else
                {
                    uxNextButton.Enabled = true;
                    uxLastButton.Enabled = true;
                    uxFirstButton.Enabled = true;
                    uxPreviousButton.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private void uxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
