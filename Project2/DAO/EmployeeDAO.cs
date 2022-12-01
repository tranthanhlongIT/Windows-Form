using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System;

namespace Project2.DAO
{
    class EmployeeDAO
    {
        private static readonly MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        
        public static List<Employee> SelectAll()
        {
            try 
            {
                return db.Employees.OrderByDescending(e => e.is_active).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static Employee SelectAllByID(int id)
        {
            try
            {
                return db.Employees.SingleOrDefault(e => e.id == id);
            }
            catch
            {
                return null;
            }
        }

        public static Employee SelectAllByEmail(string email)
        {
            try
            {
                return db.Employees.SingleOrDefault(e => e.email == email);
            }
            catch
            {
                return null;
            }
        }

        public static string SelectPasswordByEmail(string email)
        {
            try
            {
                return db.Employees.Where(e => e.email == email).Select(e => e.password).SingleOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public static bool SelectIsActiveByEmail(string email)
        {
            return (bool)db.Employees.Where(e => e.email == email).Select(e => e.is_active).SingleOrDefault();
        }

        public static bool Insert(Employee newEmployee)
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

        public static bool Update(Employee newEmployee)
        {
            Employee dbEmployee = db.Employees.SingleOrDefault(e => e.id == newEmployee.id);
            if (dbEmployee != null)
            {
                try
                {
                    dbEmployee.password = newEmployee.password;
                    dbEmployee.fname = newEmployee.fname;
                    dbEmployee.lname = newEmployee.lname;
                    dbEmployee.gender = newEmployee.gender;
                    dbEmployee.phone = newEmployee.phone;
                    dbEmployee.address = newEmployee.address;
                    dbEmployee.image = newEmployee.image;
                    dbEmployee.is_active = newEmployee.is_active;
                    dbEmployee.updated_at = DateTime.Now;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public static bool UpdatePassword(Employee newEmployee)
        {
            Employee dbEmployee = db.Employees.SingleOrDefault(e => e.id == newEmployee.id);
            if (dbEmployee != null)
            {
                try
                {
                    dbEmployee.password = newEmployee.password;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public static bool Disable(int id)
        {
            Employee dbEmployee = db.Employees.SingleOrDefault(e => e.id == id);
            if (dbEmployee != null)
            {
                try
                {
                    dbEmployee.is_active = false;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public static bool IsEmailExist(string email)
        {
            try
            {
                return db.Employees.Any(e => e.email == email);
            }
            catch 
            {
                return false;
            }
        }
    }
}