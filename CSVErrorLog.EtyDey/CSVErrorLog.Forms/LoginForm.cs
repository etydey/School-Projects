using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVErrorLog.Utility;
using System.IO;

namespace CPRG202.Final.Forms
{
    public partial class LoginForm : Form
    {
        int count = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void uxLogin_Click(object sender, EventArgs e)
        {
            if (uxUsername.Text=="" || uxPassword.Text=="")
            {
                MessageBox.Show("Please provide UserName and Password.");
                return;
            }

            try
            {
                if(Authenticator.Authenticate(uxUsername.Text,uxPassword.Text))
                {
                    this.Hide();
                    MainForm fm = new MainForm(uxUsername.Text);
                    fm.Show();
                }
                else
                {
                    count += 1;
                    if(count==3)
                    {
                        MessageBox.Show("Three attempts being made unsuccessfully!");
                        this.Close();
                    }

                    MessageBox.Show("Login failed!");

                    uxUsername.Clear();
                    uxPassword.Clear();
                    uxUsername.Focus();
                }
            }
            catch(Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message + Environment.NewLine + "Would you like to create this folder?"
                                                        ,"Error",MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    Directory.CreateDirectory(@"C:\CSVErrorLog.EtyDey");

                    FileStream stream = new FileStream(@"C:\CSVErrorLog.EtyDey\authorize.dat", FileMode.Append, FileAccess.Write);
                    BinaryWriter writer = new BinaryWriter(stream);
                    try
                    {
                        writer.Write("admin");
                        writer.Write("p@ssw0rd");
                    }
                    catch (Exception newEx)
                    {
                        MessageBox.Show(newEx.Message);
                    }
                    finally
                    {
                        writer.Close();
                    }

                    MessageBox.Show("Folder created successfully.");
                }
                else
                {
                    uxUsername.Clear();
                    uxPassword.Clear();
                    uxUsername.Focus();
                }

            }

        }
    }
}
