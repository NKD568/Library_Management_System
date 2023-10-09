using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_App.FORMS
{
    public partial class frm_Login : Form
    {
        string placeholderName = "Nhập tên ...";
        string placeholderPassword = "Nhập mật khẩu ...";

        public frm_Login()
        {
            InitializeComponent();      
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

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("../../IMAGES/bg_Login.jpg");
            
            this.CenterToScreen();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text == "root" && txt_Password.Text == "1")
            {
                this.Close();
            }
        }
    }
}
