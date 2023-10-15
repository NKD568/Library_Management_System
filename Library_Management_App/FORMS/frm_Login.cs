using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_App.DATABASE;

namespace Library_Management_App.FORMS
{
    public partial class frm_Login : Form
    {

        frm_Home Home;
        // USER TYPE
        public static UserType currentUserType;
        public static int currentUserId;

        // Placehloder text for textbox
        string placeholderName = "Nhập tên ...";
        string placeholderPassword = "Nhập mật khẩu ...";

        // DATABASE
        Library_ManagementEntities db = new Library_ManagementEntities();

        public frm_Login()
        {
            InitializeComponent();      
        }
        public frm_Login(frm_Home Home)
        {
            InitializeComponent();
            this.Home = Home;
        }


        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../IMAGES/bg_Login.jpg");
            this.CenterToScreen();
        }

        private void emptyPlaceHolderText(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == placeholderName || txt.Text == placeholderPassword)
            {
                txt.Text = "";
                if (txt.Name == txt_Password.Name)
                    txt.PasswordChar = '*';
            }     
            else
                return;
        }

        private void resetPlaceHolderText(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "" && txt.Text != placeholderName && txt.Text != placeholderPassword) return;
            else
            {
                if (txt.Name == txt_Name.Name)
                    txt.Text = placeholderName;
                if (txt.Name == txt_Password.Name)
                {
                    txt.PasswordChar = '\0';
                    txt.Text = placeholderPassword;
                }

            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(validateUser(txt_Name.Text, txt_Password.Text))
            {
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Thông tin không chính xác./n Vui lòng kiểm tra lại!");
                return;
            }
        }

        private bool validateUser(string username, string password)
        {
            bool result = false;
            try
            {
                tb_UserInfo user = db.UserInfos.Where(s => s.username == username && s.password == password).FirstOrDefault();
                if(user != null)
                {                   
                    frm_Login.currentUserType = user.user_level == 0 ? UserType.Admin : UserType.Staff;
                    frm_Login.currentUserId = user.user_ID;
                    result = true;
                }
            }
            catch
            {
                MessageBox.Show("Exception in Validating Users!!!");
            }
            return result;
        }

        private void btn_ExitLogin_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Thoát Ứng Dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
