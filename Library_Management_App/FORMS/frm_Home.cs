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
    public partial class frm_Home : Form
    {

        public frm_Home()
        {
            InitializeComponent();
        }
  
        private void frm_Home_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            pic_Logo.Image = Image.FromFile("../../IMAGES/ic_books.png");
            btn_Book.Image = Image.FromFile("../../IMAGES/ic_book.png");
            btn_Patron.Image = Image.FromFile("../../IMAGES/ic_patrons.png");
            btn_Ticket.Image = Image.FromFile("../../IMAGES/ic_ticket.png");       
            btn_Chart.Image = Image.FromFile("../../IMAGES/ic_statistic.png");
            btn_User.Image = Image.FromFile("../../IMAGES/ic_Users.png");
        }
        private void frm_Home_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            frm_Login login = new frm_Login();
            login.Show();
        }
        private void frm_Home_Activated(object sender, EventArgs e)
        {
            if (frm_Login.isLoginedIn)
            {
                this.Enabled = true;
            }
            if (frm_Login.currentUserType != UserType.Admin)
            {
                btn_User.Visible = false;
            }
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            frm_Books Book = new frm_Books();
            Book.ShowDialog();
        }
        private void btn_Patron_Click(object sender, EventArgs e)
        {

        }
        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            frm_Checkout Checkout = new frm_Checkout();
            Checkout.ShowDialog();
        }
        private void btn_Chart_Click(object sender, EventArgs e)
        {

        }
        private void btn_User_Click(object sender, EventArgs e)
        {
            frm_Users formUser = new frm_Users();

            formUser.ShowDialog();
        }
    }
}
