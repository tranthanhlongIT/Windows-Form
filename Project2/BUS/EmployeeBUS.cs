using System;
using Project2.DAO;

namespace Project2.BUS
{
    class EmployeeBUS
    {
        public static bool AddNew(Employee newEmployee)
        {
            newEmployee.password = EncodePasswordToBase64(newEmployee.password);
            return EmployeeDAO.Insert(newEmployee);
        }

        public static Employee GetEmployeeByEmail(string email)
        {
            return EmployeeDAO.SelectAllByEmail(email); ;
        }

        public static bool CheckEmployeeCredential(Employee employee)
        {
            string getPassword = EmployeeDAO.SelectPasswordByEmail(employee.email);
            string password = DecodeFrom64(getPassword);
            bool status = EmployeeDAO.SelectIsActiveByEmail(employee.email);
            if (employee.password == password && status)
                return true;
            return false;
        }

        public static bool ValidateEmail(string email)
        {
            return EmployeeDAO.IsEmailExist(email);
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
        public static string DecodeFrom64(string encodedData)
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
