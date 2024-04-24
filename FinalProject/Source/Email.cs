using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject.Source
{
    public static class Email
    {
        /// <summary>
        /// check email hop le
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            // Kiểm tra chuỗi có đúng định dạng email không bằng Regular Expression
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        /// <summary>
         /// check password hop le
         /// </summary>
         /// <param name="email"></param>
         /// <returns></returns>
        public static bool IsValidPassword(string password)
        {
            // Kiểm tra chuỗi có đúng định dạng mật khẩu không bằng Regular Expression
            // Trong ví dụ này, mật khẩu phải chứa ít nhất 8 ký tự và bao gồm ít nhất một chữ cái viết thường,
            // một chữ cái viết hoa, một chữ số và một ký tự đặc biệt.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }
    }
}
