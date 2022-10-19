using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Project2.DAO
{
    class EmployeeDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<Employee> SelectAll()
        {
            try 
            {
                List<Employee> employees = db.Employees.ToList();
                return employees;
            }
            catch
            {
                return null;
            }
        }

        public string SelectPasswordByEmail(string email)
        {
            try
            {
                string password = db.Employees.Where(e => e.email == email).Select(e => e.password).SingleOrDefault();
                return password;
            }
            catch
            {
                return null;
            }
        }

        public bool SelectIsActiveByEmail(string email)
        {
            bool result = (bool)db.Employees.Where(e => e.email == email).Select(e => e.is_active).SingleOrDefault();
            if (result)
            {
                return true;
            }
            return false;
        }

        public Employee SelectAllByEmail(string email)
        {
            try
            {
                Employee employee = db.Employees.SingleOrDefault(em => em.email == email);
                return employee;
            }
            catch
            {
                return null;
            }
        }

        public bool Insert(Employee newEmployee)
        {
            try
            {
                db.Employees.InsertOnSubmit(newEmployee);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsExistEmail(string email)
        {
            bool result = db.Employees.Any(em => em.email == email);
            if (result)
            {
                return true;
            }
            else return false;
        }
    }
}