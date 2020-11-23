using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication.EtyDey
{
    public partial class DataEntryForm : Form
    {
        Employee employee;
        public DataEntryForm()
        {
            InitializeComponent();
            //employee = new Employee();
        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {
            uxDepartmentCombo.DataSource = null;
            uxDepartmentCombo.DataSource = Enum.GetValues(typeof(Department));
        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate the First Name field
                if (uxFirstName.Text.Length==0)
                {
                    //Call display message method
                    DisplayMessage("First Name cannot be blank");
                    uxFirstName.Focus();
                    return;
                }
                else if(!Validation.IsAllLetters(uxFirstName.Text))
                {
                    DisplayMessage("First Name must be only letters.");
                    uxFirstName.Focus();
                    return;
                }


                //Validate the Last Name field
                if (uxLastName.Text.Length==0)
                {
                    DisplayMessage("Last Name cannot be blank");
                    uxLastName.Focus();
                    return;
                }
                else if (!Validation.IsAllLetters(uxLastName.Text))
                {
                    DisplayMessage("Last Name must be only letters.");
                    uxLastName.Focus();
                    return;
                }


                //Validate the City field
                if (uxCity.Text.Length == 0)
                {
                    DisplayMessage("City cannot be blank");
                    uxCity.Focus();
                    return;
                }
                else if (!Validation.IsAllLetters(uxCity.Text))
                {
                    DisplayMessage("City must be only letters.");
                    uxCity.Focus();
                    return;
                }

                //validate the Email field
                if(uxEmail.Text.Length==0)
                {
                    DisplayMessage("Email cannot be blank");
                    uxEmail.Focus();
                    return;
                }

                //validate the Phone Number field
                if (uxPhoneNumber.Text.Length == 0)
                {
                    DisplayMessage("Phone Number cannot be blank");
                    uxPhoneNumber.Focus();
                    return;
                }

                //Validate the Salary field
                if (uxSalary.Text.Length == 0)
                {
                    DisplayMessage("Salary cannot be blank");
                    uxSalary.Focus();
                    return;
                }
                else if (!Validation.IsNumber(uxSalary.Text))
                {
                    DisplayMessage("Salary must be numeric.");
                    uxSalary.Focus();
                    return;
                }

                employee = new Employee(uxFirstName.Text.Trim(), uxLastName.Text.Trim(), uxCity.Text.Trim(),
                                        uxEmail.Text.Trim(),uxPhoneNumber.Text.Trim(), 
                                        decimal.Parse(uxSalary.Text.Trim()), uxDepartmentCombo.SelectedItem.ToString());

                EmployeeList.AddEmployees(employee);

                DisplayMessage("Employee Information added successfully.");

                //Call form clear method
                ClearForm();
            }
            catch(Exception ex)
            {
                //Call display message method
                DisplayMessage(ex.Message);
            }
        }

        private void uxCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearForm()
        {
            //Clear form and focus on first textbox
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }

            uxDepartmentCombo.SelectedIndex = 0;
            uxFirstName.Focus();
        }

        private void DisplayMessage(string ex)
        {
            //At first, get the mdi parent reference
            MainForm Parent = (MainForm)this.MdiParent;

            //Then, Send error message back to the main form, display in the status strip label and set timer
            Parent.uxMessageLabel.Text = ex;
            Parent.StartTimer();
        }
    }
}
