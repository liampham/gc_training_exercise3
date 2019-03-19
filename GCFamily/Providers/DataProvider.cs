using GCFamily.Constants;
using GCFamily.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GCFamily.Providers
{

    public class DataProvider
    {
        private string filePath = "Assets/GrapeCity.xml";
        
        private static DataProvider _instance = null;

        private Dictionary<string,Employee> mEmployees = new Dictionary<string,Employee>();

        private Employee user = new Employee();

        private DataProvider()
        {
            try
            {
                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot read data files");
            }
        }

        public static DataProvider GetInstance()
        {
            if (_instance == null) _instance = new DataProvider();
            return _instance;
        }

        /*Getting list of all employees of company*/
        public List<Employee> getEmployees()
        {
            return this.mEmployees.Values.ToList() ;
        }

        /*Get current logged in user*/
        public Employee getUser()
        {
            return this.user;
        } 

        /*Load all employee data from local files.*/
        public void LoadData()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                foreach(XmlNode node in doc.DocumentElement)
                {                    
                    if (node.Name.Equals(ParamsKey._EMPLOYEES_))
                    {
                        foreach (XmlNode child in node.ChildNodes) {
                            if (child.Name.Equals(ParamsKey._EMPLOYEE_)) {
                                Employee employee = new Employee(child);
                                if (!"".Equals(employee.EmployeeID))
                                {
                                    mEmployees.Add(employee.EmployeeID, employee);
                                }
                                continue;
                            }                            
                        }                        
                    }
                }            
            }
            catch
            {

            }
        }
        /*Set current user that has been logged in. use this information to retrive data later. */
        public void setUserID(string employeeID)
        {
            this.user = this.getEmployee(employeeID);
        }

        /*Get employee with specific ID, return null if not.*/
        public Employee getEmployee(string employeeID)
        {
            if (this.mEmployees.ContainsKey(employeeID)){
                return this.mEmployees[employeeID];
            }
            return null;
        }


    }
}
