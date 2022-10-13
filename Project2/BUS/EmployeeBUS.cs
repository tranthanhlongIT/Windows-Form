using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Project2.DAO;

namespace Project2.BUS
{
    class EmployeeBUS
    {
        public bool AddNew(Employee newEmployee)
        {
            newEmployee.password = EncodePasswordToBase64(newEmployee.password);
            bool result = new EmployeeDAO().Insert(newEmployee);
            return result;
        }

        public bool CheckEmployeePassword(Employee employee)
        {
            string getPassword = new EmployeeDAO().SelectPassword(employee.email);
            string password = DecodeFrom64(getPassword);
            if (employee.password == password)
                return true;
            return false;
        }

        public bool ValidateEmail(string email)
        {
            bool result = new EmployeeDAO().IsExistEmail(email);
            return result;
        }

        //this function Convert to Encord your Password
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        //this function Convert to Decord your Password
        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
