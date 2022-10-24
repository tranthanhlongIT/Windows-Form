﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Project2.DAO
{
    class EmployeeDAO
    {
        MyDBDataContext db;
        
        public EmployeeDAO()
        {
            db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        }

        public List<Employee> SelectAll()
        {
            try 
            {
                return db.Employees.ToList();
            }
            catch
            {
                return null;
            }
        }

        public Employee SelectAllByEmail(string email)
        {
            try
            {
                return db.Employees.SingleOrDefault(em => em.email == email);
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
                return db.Employees.Where(e => e.email == email).Select(e => e.password).SingleOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public bool SelectIsActiveByEmail(string email)
        {
            return (bool)db.Employees.Where(e => e.email == email).Select(e => e.is_active).SingleOrDefault();
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

        public bool IsEmailExist(string email)
        {
            return db.Employees.Any(em => em.email == email);
        }
    }
}