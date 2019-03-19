using GCFamily.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GCFamily.DTO
{
    public class Employee
    {
        private string employeeID = "";
        private string privateKey = "";
        private string firstName = "";
        private string lastName = "";
        private string avatar = "";
        private string skype = "";
        private string outlook = "";
        private string profile = "";
        private string position = "";

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string PrivateKey { get => privateKey; set => privateKey = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Skype { get => skype; set => skype = value; }
        public string Outlook { get => outlook; set => outlook = value; }
        public string Profile { get => profile; set => profile = value; }
        public string Position { get => position; set => position = value; }

        public Employee()
        {

        }

        public Employee(XmlNode node) : base()
        {            
            if (node == null) return;
            if (!node.HasChildNodes) return;
            foreach(XmlNode child in node)
            {
                if (child.Name.Equals(ParamsKey._EMPLOYEE_ID_)) { this.EmployeeID = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._PRIVATE_KEY_)) { this.PrivateKey = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._FIRST_NAME_)) {this.FirstName = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._LAST_NAME_)) { this.LastName = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._SKYPE_)) { this.Skype = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._OUTLOOK_)) { this.Outlook = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._AVATAR_)) { this.Avatar = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._PROFILE_)) { this.Profile = child.InnerText; }
                else if (child.Name.Equals(ParamsKey._POSITION_)) { this.Position = child.InnerText; }
            }          
        }

    }
}
