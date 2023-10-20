using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_App.FORMS;

namespace Library_Management_App.DATABASE.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }

        public int getLatestId()
        {
            int latestId = 0;
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                    latestId = _entity.UserInfos.Max(t => t.user_ID);
                }
            }
            catch
            {
                MessageBox.Show("Exception while Getting Latest Id!");
            }
            return latestId;
        }
        public void showAllUsers(DataGridView dgv)
        {
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                List<tb_UserInfo> lst = new List<tb_UserInfo>();
                    lst = _entity.UserInfos.ToList();
                    dgv.DataSource = lst;
                    modifyDataGridViewColumn(dgv);
                }   
            }
            catch
            {
                MessageBox.Show("Exception while Showing All Users!");
            }
        }
        public bool insertNewUser(tb_UserInfo user)
        {
            bool result = false;
            using (Library_ManagementEntities _entity = new Library_ManagementEntities())
            {

                _entity.UserInfos.Add(user);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public bool updateUser(tb_UserInfo user)
        {
            bool result = false;
            using (Library_ManagementEntities _entity = new Library_ManagementEntities())
            {
                tb_UserInfo _user = _entity.UserInfos.Where(x => x.user_ID == user.user_ID).Select(x => x).FirstOrDefault();
                _user.username = user.username;
                _user.email = user.email;
                _user.user_level = user.user_level;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public string deleteUser(int id)
        {
            string result;
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                    tb_UserInfo _user = _entity.UserInfos.Find(id);
                    if (_user != null && _user.user_level != Convert.ToInt32(UserType.Admin) && _user.user_ID != frm_Login.currentUserId)
                    {
                        _entity.UserInfos.Remove(_user);
                        _entity.SaveChanges();
                        result = "Success";
                    }
                    else
                    {
                        result = "Fail";
                    }

                }
            }
            catch
            {
                result = "Fail";
            }
            return result;
        }
        public void modifyDataGridViewColumn(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Tên";
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].HeaderText = "Email";
            dgv.Columns[4].HeaderText = "Cấp";
            dgv.Columns[0].Width = 88;
            dgv.Columns[1].Width = 200;
            dgv.Columns[3].Width = 300;
            dgv.Columns[4].Width = 88;
        }

    }
}
