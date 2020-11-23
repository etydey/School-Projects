using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CSVErrorLog.Utility;

namespace CSVErrorLog.Domain
{
    /// <summary>
    /// This class is for adding new employee and getting all employee into the collection
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Class members are declared
        /// </summary>
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _department;
        private string _phone;

        /// <summary>
        /// Constant Variable for path
        /// </summary>
        private const string _path = @"C:\CSVErrorLog.EtyDey\employee.dat";


        /// <summary>
        /// Constructors of Employee Class
        /// </summary>
        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string department, string phone)
        {
            this.ID = IDGenerator.NewID();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.Phone = phone;
        }


        /// <summary>
        /// This method is intended to add employee information to a file(Binary).
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="path"></param>
        public static void Add(Employee employee, string userName)
        {
            FileStream writerStream = new FileStream(_path, FileMode.Append, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(writerStream, Encoding.ASCII);
            try
            {
                writer.Write(employee.ID);
                writer.Write(employee.FirstName);
                writer.Write(employee.LastName);
                writer.Write(employee.Department);
                writer.Write(employee.Phone);
            }
            catch (Exception ex)
            {
                LogError(userName + "(" + DateTime.Today.ToLongDateString() + ")" + "-" + ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }


        /// <summary>
        /// This method is intended to get all employee information into a Collection 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<Employee> GetAll(string userName)
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = null;

            FileStream readerStream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader reader = new BinaryReader(readerStream,Encoding.ASCII);
            try
            {
                do
                {
                    employee = new Employee();

                    employee.ID = reader.ReadInt32();
                    employee.FirstName = reader.ReadString();
                    employee.LastName = reader.ReadString();
                    employee.Department = reader.ReadString();
                    employee.Phone = reader.ReadString();

                    employees.Add(employee);
                }
                while (reader.PeekChar() != -1);
            }
            catch (Exception ex)
            {
                LogError(userName + "(" + DateTime.Today.ToLongDateString() + ")" + "-" + ex.Message);
            }
            finally
            {
                reader.Close();
            }


            return employees;
        }


        /// <summary>
        /// This method is for logging errors
        /// </summary>
        /// <param name="errorMessage"></param>
        private static void LogError(string errorMessage)
        {
            try
            {
                ErrorLogger.Log(errorMessage);
            }
            catch(Exception ex)
            {
               
            }
            
        }


        public override string ToString()
        {
            return ID + " - " + FirstName + " " + LastName;
        }


        /// <summary>
        /// Public Properties of Private class members
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
    }
}
