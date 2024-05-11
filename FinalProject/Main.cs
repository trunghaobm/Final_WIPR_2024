using FinalProject.Database;
using FinalProject.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace FinalProject
{
    public partial class F_Main : Form
    {
        public Source.Role Role;
        public Login.Login login;
        public DataTable User;

        public Course.Main Course;

        public Admin.StudentManager studentManager;
        public Admin.LecturerManager lecturerManager;
        public Admin.CourseRegistrationStudenLlist courseRegistrationStudenLlist;

        public Student.Assignment studentAssignment;
        public Student.Information studentInformation;
        public Student.CourseManagement studentCourseManagement;

        public Lecturer.AvgScoreManager avgManager;
        public Lecturer.AssignmentManager assignmentManager;
        public Lecturer.Information lecturerinformation;

        public string studentID;

        public F_Main()
        {
            InitializeComponent();
            login = new Login.Login();
            User = new DataTable();
            this.Course = new Course.Main();
            LoadPermistion();
        }

        public void FirstLoad()
        {
            Role = Source.Role.None;
            if (!login.TryAutoLogin())
            {
                login.ShowDialog();
                this.User = login.User;
                Role = login.role;
                LoadUser(User);
            }
            else
            {
                if(login.role != Source.Role.None)
                {
                    this.User = login.User;
                    Role = login.role;
                    LoadUser(User);
                }
            }
            if(Role == Source.Role.None )
            {
                this.Close();
            }
            LoadPermistion();
        }

        public void LoadUser(DataTable user)
        {
            string appPath = Application.StartupPath;
            string imgPath;
            studentID = "";
            switch (Role)
            {
                case Source.Role.None: break;
                case Source.Role.Admin:
                    L_NAME.Text = Role.ToString();
                    Meta.SetNullImage(PIC_LOGO);
                    break;
                case Source.Role.Student:
                    studentID = User.Rows[0]["ID"].ToString();
                    imgPath = Path.Combine(appPath, "avatar", "student", user.Rows[0]["AVATAR"].ToString());
                    try
                    {
                        PIC_LOGO.BackgroundImage = null;
                        PIC_LOGO.Image = Image.FromFile(imgPath);
                    }
                    catch
                    {
                        Meta.SetNullImage(PIC_LOGO);
                    }
                    //B_LOGIN.Text = L_NAME.Text = user.Rows[0]["FIRSTNAME"].ToString() + " " + user.Rows[0]["LASTNAME"].ToString() + "-" + Role.ToString();
                    break;
                case Source.Role.Lecturer:
                    try
                    {
                        PIC_LOGO.BackgroundImage = null;
                        imgPath = Path.Combine(appPath, "avatar", "lecturer", user.Rows[0]["AVATAR"].ToString());
                        PIC_LOGO.Image = Image.FromFile(imgPath);
                    }
                    catch
                    {
                        Meta.SetNullImage(PIC_LOGO);
                    }
                    break;
                default: break;

            }
        }

        public void LoadPermistion()
        {
            foreach (Control control in P_LEFTMENU.Controls)
            {
                if (control is Button)
                {
                    control.Visible = false;
                }
            }
            switch (Role)
            {

                case Source.Role.None: 
                    foreach(Control control in P_LEFTMENU.Controls)
                    {
                        if(control is Button)
                        {
                            control.Visible = false; 
                        }
                    }
                    break;
                case Source.Role.Admin:
                    foreach (Control control in P_LEFTMENU.Controls)
                    {
                        if (control is Button && control.Name.Contains("_ADMIN_"))
                        {
                            control.Visible = true;
                        }
                    }
                    break;
                case Source.Role.Student:
                    foreach (Control control in P_LEFTMENU.Controls)
                    {
                        if (control is Button && control.Name.Contains("_STUDENT_"))
                        {
                            control.Visible = true;
                        }
                    }
                    break;
                case Source.Role.Lecturer:
                    foreach (Control control in P_LEFTMENU.Controls)
                    {
                        if (control is Button && control.Name.Contains("_LECTURER_"))
                        {
                            control.Visible = true;
                        }
                    }
                    break;

                default: break;
            }
        }

        private void B_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_LOGIN_Click(object sender, EventArgs e)
        {
        }

        private async void F_Main_Load(object sender, EventArgs e)
        {
            //await Task.Run(() =>
            //{
            //    // Hàm ReloadUser sẽ chạy liên tục trong luồng mới
            //    while (true)
            //    {
            //        ReloadUser();
            //        System.Threading.Thread.Sleep(1); // Đợi 1 giây trước khi thực hiện lại
            //    }
            //});
        }

        private void B_LOGOUT_Click(object sender, EventArgs e)
        {
            P_MAIN_PARENT.Controls.Clear();
            login.isAutoLogin = false;
            login.RemoveAutoLogin();
            FirstLoad();
        }

        private void F_Main_Shown(object sender, EventArgs e)
        {
            FirstLoad();
        }

        private void B_STUDENT_ACCOUNT_Click(object sender, EventArgs e)
        {
            studentInformation = new Student.Information(User);
            studentInformation.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, studentInformation);
        }

        private void B_ADMIN_COURSE_Click(object sender, EventArgs e)
        {
            Course = new Course.Main();
            Course.Size = P_MAIN_PARENT.Size;
            Source.Meta.OpenChileForm(P_MAIN_PARENT, this.Course); 
        }

        private void B_ADMIN_STUDENT_Click(object sender, EventArgs e)
        {
            studentManager = new Admin.StudentManager();
            studentManager.Size = P_MAIN_PARENT.Size;
            Source.Meta.OpenChileForm(P_MAIN_PARENT, studentManager);
        }

        private void B_ADMIN_LECTURE_Click(object sender, EventArgs e)
        {
            lecturerManager = new Admin.LecturerManager();
            lecturerManager.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, lecturerManager);
        }

        private void B_LECTURER_SCORE_Click(object sender, EventArgs e)
        {
            avgManager = new Lecturer.AvgScoreManager();
            avgManager.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, avgManager);
        }

        private void B_STUDENT_COURSE_Click(object sender, EventArgs e)
        {
            studentCourseManagement = new Student.CourseManagement(studentID);
            studentCourseManagement.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, studentCourseManagement);
        }

        private void B_LECTURER_ASSIGNMENT_Click(object sender, EventArgs e)
        {
            assignmentManager = new Lecturer.AssignmentManager();
            assignmentManager.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, assignmentManager);
        }

        private void B_STUDENT_ASSIGNMENT_Click(object sender, EventArgs e)
        {
            studentAssignment = new Student.Assignment(User.Rows[0]["ID"].ToString());
            studentAssignment.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, studentAssignment);
        }

        private void B_ADMIN_COURSEREGISTION_Click(object sender, EventArgs e)
        {
            courseRegistrationStudenLlist = new Admin.CourseRegistrationStudenLlist();
            courseRegistrationStudenLlist.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, courseRegistrationStudenLlist);
        }

        private void B_LECTURER_INFOMATION_Click(object sender, EventArgs e)
        {
            lecturerinformation = new Lecturer.Information(User);
            lecturerinformation.Size = P_MAIN_PARENT.Size;
            Meta.OpenChileForm(P_MAIN_PARENT, lecturerinformation);
        }

        public void ReloadUser()
        {
            Database.Database DB = new Database.Database("localhost", "Final", "STUDENT");
            switch(Role)
            {
                case Role.Admin: break;
                case Role.Student:
                    DB.TableName = "STUDENT";
                    break;
                case Role.Lecturer:
                    DB.TableName = "LECTURER";
                    break;

                default: break;
            }


            DB.Open();

            if (!string.IsNullOrWhiteSpace(DB.TableName) && !string.IsNullOrEmpty(DB.TableName))
            {
                DB.Connect();
                User = DB.GetTable(User.Rows[0]["EMAIL"].ToString());
                DB.Disconnect();
            }
            LoadUser(User);
        }
        private void TIMER_RELOAD_Tick(object sender, EventArgs e)
        {
            //ReloadUser();
            TIMER_RELOAD.Stop();
        }

        private void PIC_LOGO_Click(object sender, EventArgs e)
        {
            ReloadUser();
        }
    }
}
