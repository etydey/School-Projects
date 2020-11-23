using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIApplication.EtyDey
{
    public class EmployeeList
    {
        //Instantiate the list class
        private static List<Employee> employeeList = new List<Employee>();

        public static List<Employee> GetEmployees()
        {
            return employeeList;
        }

        public static void AddEmployees(Employee employee)
        {
            if (employee == null)
            {
                throw new Exception("A employee information was not created or value was empty");
            }

            employeeList.Add(employee);
        }

        public static void AddTestData()
        {
            //Add some test data to the collection list
            AddEmployees(new Employee("Frank", "Carlson", "Calgary", "frank.car@gmail.com", "403-234-1867",
                                         8000, Department.Finance.ToString()));
            AddEmployees(new Employee("Pearl", "Larson", "Edmonton", "pearl.ln@yahoo.ca", "780-470-2364",
                                         7000, Department.Sales.ToString()));
            AddEmployees(new Employee("Daniel", "Carr", "Calgary", "daniel_carr@yahoo.ca", "587-890-6538",
                                         8000, Department.Engineering.ToString()));
            AddEmployees(new Employee("Sam", "Kennedy", "Saskatoon", "sam2000@gmail.com", "306-770-8322",
                                         5000, Department.Administration.ToString()));
        }
    }
}
