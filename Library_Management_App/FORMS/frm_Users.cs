using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_App.DATABASE;
using Library_Management_App.DATABASE.Models;

namespace Library_Management_App.FORMS
{
    public partial class frm_Users : Form
    {

        // DATABASE MODELS
        UserInfo info = new UserInfo();

        public frm_Users()
        {
            InitializeComponent();
        }

        private void frm_Users_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            instantiateControls();
            clearFields();
            info.showAllUsers(dgv_UserModify);
        }

        private void instantiateControls()
        {
            // General TabPage
            cmb_AttributesFind.Items.Add("Tất cả");
            cmb_AttributesFind.Items.Add("ID");
            cmb_AttributesFind.Items.Add("Tên");
            cmb_AttributesFind.Items.Add("Email");
            cmb_AttributesFind.Items.Add("Cấp");
            cmb_AttributesFind.SelectedIndex = 0;

            // Modify TabPage
            cmb_ModifyType.Items.Add("Thêm");
            cmb_ModifyType.Items.Add("Sửa");
            cmb_ModifyType.Items.Add("Xoá");

            cmb_LevelUser.Items.Add(0);
            cmb_LevelUser.Items.Add(1);
        }

        // TABPAGE GENERAL 
        private void findUsersByAttribute(int numData, string strData, int dataType)
        {

            int attributeType = dataType;
            try
            {
                using (DATABASE.Library_ManagementEntities _entity = new DATABASE.Library_ManagementEntities())
                {
                    List<UserInfo> lst = new List<UserInfo>();
                    switch (attributeType)
                    {
                        case 0: // Find by ID
                            {
                                lst = _entity.UserInfos.Where(s => s.user_ID == numData).Select(s => new UserInfo {
                                    Id = s.user_ID,
                                    Username = s.username,
                                    Password = "",
                                    Email = s.email,
                                    Level = s.user_level
                                }).ToList();
                                break;
                            }
                        case 1: // Find by Name
                            {
                                lst = _entity.UserInfos.Where(s => s.username == strData).Select(s => new UserInfo
                                {
                                    Id = s.user_ID,
                                    Username = s.username,
                                    Password = "",
                                    Email = s.email,
                                    Level = s.user_level
                                }).ToList();
                                break;
                            }
                        case 2: // Find by Email
                            {
                                lst = _entity.UserInfos.Where(s => s.email == strData).Select(s => new UserInfo
                                {
                                    Id = s.user_ID,
                                    Username = s.username,
                                    Password = "",
                                    Email = s.email,
                                    Level = s.user_level
                                }).ToList();
                                break;
                            }
                        case 3: // Find by Level
                            {
                                lst = _entity.UserInfos.Where(s => s.user_level == numData).Select(s => new UserInfo
                                {
                                    Id = s.user_ID,
                                    Username = s.username,
                                    Password = "",
                                    Email = s.email,
                                    Level = s.user_level
                                }).ToList();
                                break;
                            }
                        default: // Alls
                            {
                                lst = _entity.UserInfos.Select(s => new UserInfo
                                {
                                    Id = s.user_ID,
                                    Username = s.username,
                                    Password = "",
                                    Email = s.email,
                                    Level = s.user_level
                                }).ToList();
                                break;
                            }
                    }
                    dgv_UserView.DataSource = lst;
                    info.modifyDataGridViewColumn(dgv_UserView);
                }
            }
            catch
            {
                MessageBox.Show("Exception while Find Users!");
            }
        }
        private void btn_Find_Click(object sender, EventArgs e)
        {
           if(txt_InputFind.Text == string.Empty && cmb_AttributesFind.SelectedIndex != 0)
            {
                MessageBox.Show("Hãy nhập thông tin để tìm!");
                return;
            }
            else
            {
                int numData;
                string strData;
                switch (cmb_AttributesFind.SelectedIndex)
                {
                    case 1: // Item: ID
                        {
                            numData = Convert.ToInt32(txt_InputFind.Text);
                            strData = "";
                            findUsersByAttribute(numData, strData, 0);
                            break;
                        }
                    case 2: // Item: Name
                        {
                            numData = 0;
                            strData = txt_InputFind.Text;
                            findUsersByAttribute(numData, strData, 1);
                            break;
                        }
                    case 3: // Item: Email
                        {
                            if (!validateEmailAddress(txt_InputFind.Text))
                            {
                                MessageBox.Show("Hãy nhập đúng cấu trúc Email.");
                                return;
                            }
                            else
                            {
                                numData = 0;
                                strData = txt_InputFind.Text;
                                findUsersByAttribute(numData, strData, 2);
                                break;
                            }
                        }
                    case 4: // Item: Level
                        {
                            numData = Convert.ToInt32(txt_InputFind.Text);
                            strData = "";
                            findUsersByAttribute(numData, strData, 3);
                            break;
                        }
                    default: // Item: Alls
                        {
                            numData = 0;
                            strData = "";
                            findUsersByAttribute(numData, strData, 4);
                            break;
                        }
                }
            }
        }
        private void cmb_AttributesFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_InputFind.Text = "";
            if (cmb_AttributesFind.SelectedIndex != 0)
            {
                txt_InputFind.Enabled = true;
            }
            else
            {
                txt_InputFind.Enabled = false;
            }
        }
        private void txt_InputFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cmb_AttributesFind.SelectedIndex)
            {
                case 1:
                case 4:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }
                    break;
                case 2:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                        txt_InputFind.TextLength >= 50 && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        return;
                    }
                    break;
            }
        }

        // TABPAGE MODIFY 
        private void cmb_ModifyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ModifyType.SelectedIndex == 0)
            {
                clearFields();
                lbl_IdUser.Text = (info.getLatestId() + 1).ToString();
                setVisibleControls(true);
                lbl_UserPassword.Visible = true;
                txt_UserPassword.Visible = true;
                dgv_UserModify.Enabled = false;
            }
            else if (cmb_ModifyType.SelectedIndex == - 1)
            {
                setVisibleControls(false);
            }
            else
            {
                clearFields();
                setVisibleControls(true);
                dgv_UserModify.Enabled = true;
                lbl_UserPassword.Visible = false;
                txt_UserPassword.Visible = false;
            }
        }
        private void txt_NameUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) ||
                 txt_InputFind.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        private void txt_UserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_InputFind.TextLength >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        private void dgv_UserModify_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_UserModify.Rows.Count > 0)
            {               
                foreach (DataGridViewRow row in dgv_UserModify.SelectedRows)
                {                   
                    lbl_IdUser.Text = row.Cells[0].Value.ToString();
                    txt_NameUser.Text = row.Cells[1].Value.ToString();
                    txt_EmailUser.Text = row.Cells[3].Value.ToString();
                    cmb_LevelUser.SelectedItem = row.Cells[4].Value;
                }
            }
        }
        private void addUser()
        {
            tb_UserInfo user = new tb_UserInfo();
            user.username = txt_NameUser.Text;
            user.email = txt_EmailUser.Text;
            user.user_level = cmb_LevelUser.SelectedIndex;
            user.password = txt_UserPassword.Text;

            bool result = info.insertNewUser(user);
            if (result)
            {
                MessageBox.Show("Thêm thành công! ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
                info.showAllUsers(dgv_UserModify);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, hãy thử lại...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void updateUser()
        {
            try
            {
                tb_UserInfo user = new tb_UserInfo();
                user.user_ID = int.Parse(lbl_IdUser.Text);
                user.username = txt_NameUser.Text;
                user.email = txt_EmailUser.Text;
                user.user_level = cmb_LevelUser.SelectedIndex;
                user.password = txt_UserPassword.Text;

                bool result = info.updateUser(user);
                if (result)
                {
                    MessageBox.Show("Sửa thành công! ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    info.showAllUsers(dgv_UserModify);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, hãy thử lại...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình sửa.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deleteUser()
        {
            try
            {
                int idUser = Convert.ToInt32(lbl_IdUser.Text);

                string result = info.deleteUser(idUser);
                if (result == "Success")
                {
                    MessageBox.Show("Xoá thành công! ...", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    info.showAllUsers(dgv_UserModify);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, hãy thử lại...\n" + "Lưu ý: Không xoá Admin hoặc chính mình", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình xoá.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_ConfirmChange_Click(object sender, EventArgs e)
        {
            if (txt_NameUser.Text == string.Empty || txt_EmailUser.Text == string.Empty || cmb_LevelUser.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
                return;
            }
            if (!validateEmailAddress(txt_EmailUser.Text))
            {
                MessageBox.Show("Hãy nhập đúng cấu trúc Email.");
                return;
            }
            switch (cmb_ModifyType.SelectedIndex)
            {
                case 0: // Mode: Insert
                    {
                        if (txt_UserPassword.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập mật khẩu!");
                        }
                        addUser();
                        break;
                    }
                case 1: // Mode: Update
                    {
                        updateUser();
                        break;
                    }
                case 2: // Mode: Delete
                    {
                        deleteUser();
                        break;
                    }
                default: // Mode: Unchosen
                    {
                        MessageBox.Show("Hãy chọn chế độ!");
                        break;
                    }
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void clearFields()
        {
            txt_NameUser.Text = "";
            txt_EmailUser.Text = "";
            cmb_LevelUser.SelectedIndex = -1;
            txt_UserPassword.Text = "";
            lbl_IdUser.Text = "";
        }
        private void setVisibleControls(bool mode)
        {
            lbl_IdUser.Visible = mode;
            txt_NameUser.Visible = mode;
            txt_EmailUser.Visible = mode;
            cmb_LevelUser.Visible = mode;
            lbl_UserPassword.Visible = mode;
            txt_UserPassword.Visible = mode;
            btn_Clear.Visible = mode;
            btn_ConfirmChange.Visible = mode;
        }       
        private bool validateEmailAddress(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
        }
    }
}
