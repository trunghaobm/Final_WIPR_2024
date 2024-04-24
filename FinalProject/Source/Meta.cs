using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Source
{
    public static class Meta
    {
        /// <summary>
        /// Mo form trong panel
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        public static void OpenChileForm(Panel parent, Form child)
        {
            if (parent == null || child == null) { return; }

            // Đặt thuộc tính Dock của Form con thành Fill để nó lấp đầy Panel cha
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.None;
            child.StartPosition = FormStartPosition.CenterParent;

            // Xóa tất cả các control hiện có trong Panel cha
            parent.Controls.Clear();

            // Thêm Form con vào Panel cha
            parent.Controls.Add(child);

            // Hiển thị Form con
            child.Show();
        }

        public static string LoadImage(PictureBox picturebox, string fileNamePrefix)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    string imagePath = openFileDialog.FileName;

                    // Tạo đường dẫn đầy đủ cho thư mục "avatar/student/"
                    string dirPath = Path.Combine("avatar", "student");

                    string fileName = fileNamePrefix + DateTime.Now.ToString("yyyyMMddhhmmss");

                    // Lấy tên tệp từ đường dẫn và mở rộng tên tệp
                    string fileExtension = Path.GetExtension(imagePath);

                    // Tạo tên tệp mới bằng cách thêm số duy nhất vào tên gốc
                    string newFileName = fileName + fileExtension;

                    // Trả về đường dẫn của tệp mới

                    picturebox.Image = image;
                    return newFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }

            // Trả về null nếu không có hình ảnh nào được chọn
            return null;
        }

        public static bool SaveImage(PictureBox picturebox, string directory)
        {
            Image image = picturebox.Image;
            if (image != null)
            {
                string appDriectory = Application.StartupPath;
                string imagePath = picturebox.Text;

                string saveDir = Path.Combine(appDriectory, directory);

                if (!Directory.Exists(saveDir))
                {
                    Directory.CreateDirectory(saveDir);
                }


                picturebox.Image.Save(Path.Combine(saveDir, imagePath));
                return true;

            }
            return false;
        }

        public static bool IsVietnameseCharacter(char c)
        {
            return c >= 'À' && c <= 'ỹ'; // Các ký tự tiếng Việt trong bảng mã Unicode Latin-1 mở rộng
        }
        public static bool IsVietnameseName(string name)
        {
            string pattern = @"^[a-zA-ZÀ-ỹ\s]+$";
            // Biểu thức chính quy để kiểm tra ký tự tiếng Việt

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool a = regex.IsMatch(name);
            return regex.IsMatch(name);
        }

        public static string RandomString(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            // Use regex to ensure the password meets the criteria
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");

            string result;
            do
            {
                result = new string(Enumerable.Repeat(allowedChars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (!regex.IsMatch(result));

            return result;
        }

        public static string PasswordGenerate(int length)
        {
            return RandomString(length);
        }

        public static string GeneratePhoneNumber(int length)
        {
            StringBuilder phoneNumber = new StringBuilder();
            Random random = new Random();

            // The first digit should be 0 to ensure it's a valid phone number
            phoneNumber.Append(0);

            for (int i = 1; i < length; i++)
            {
                phoneNumber.Append(random.Next(10)); // Append random digits from 0 to 9
                if ((i + 1) % 3 == 0) // Add space or space after the area code and exchange code
                {
                    phoneNumber.Append(' '); // You can change this to ' ' (space) if needed
                }
            }

            return phoneNumber.ToString();

        }

        public static void UpLoadFile(string srcFile, string destDir, string fileName)
        {
            string appPath = Application.StartupPath;
            string destFile = Path.Combine(appPath, destDir, fileName);

            // Kiểm tra xem thư mục đích đã tồn tại chưa, nếu không thì tạo mới
            Directory.CreateDirectory(Path.Combine(appPath, destDir));

            // Sao chép tệp từ srcFile sang destFile
            File.Copy(srcFile, destFile, true);
        }
    }
}