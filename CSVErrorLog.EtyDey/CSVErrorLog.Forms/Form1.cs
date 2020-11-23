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

namespace CSVErrorLog.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ErrorLogger.Log(uxError.Text);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            FileStream stream = new FileStream(@"C:\CSVErrorLog.EtyDey\authorize.dat", FileMode.Append, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            try
            {
                writer.Write("ety");
                writer.Write("ety");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                writer.Close();
            }

            //FileStream stream = new FileStream(@"C:\CPRG202\authorize.dat", FileMode.OpenOrCreate, FileAccess.Read);
            //BinaryReader reader = new BinaryReader(stream);

            //uxError.Text = reader.ReadString();
            //uxError.Text += " ";
            //uxError.Text += reader.ReadString();

            //listBox1.DataSource = File.ReadAllLines(@"C:\CPRG202\authorize.dat");
        }

        private void uxDisplay_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = ErrorLogger.DisplayErrors();

            //MessageBox.Show(ErrorLogger.DisplayErrors());
        }
    }
}
