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
using Library_Management_App.DATABASE.Models;

namespace Library_Management_App.FORMS
{
    public partial class frm_Checkout : Form
    {
        static int currentUpdateBookId;

        // DATABASE MODELS
        CheckoutInfo info = new CheckoutInfo();

        public frm_Checkout()
        {
            InitializeComponent();
        }

        private void frm_Checkout_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            instantiateControls();
            clearFields();

        }
        private void instantiateControls()
        {
            // FindInfo TabPage
            cmb_InfoTypeFind.Items.Add("Sách");
            cmb_InfoTypeFind.Items.Add("Người Mượn");
            addItemsInfoTypeComboBox("book");

            // Modify TabPage
            lbl_Id.Text = (info.getLatestId() + 1).ToString();
            cmb_ModifyType.Items.Add("Thêm");
            cmb_ModifyType.Items.Add("Sửa");
            cmb_ModifyType.Items.Add("Xoá");
            dgv_InfoView.DataSource = null;
            dgv_TicketModify.DataSource = null;
            info.showAllTickets(dgv_TicketModify);
            cmb_ModifyType.SelectedIndex = 0;
            List<int> lstB = new List<int>();
            List<int> lstP = new List<int>();
            using (Library_ManagementEntities _entity = new Library_ManagementEntities())
            {
                lstP = _entity.Patrons.Select(s => s.patron_ID).ToList();
                lstB = _entity.Books.Where(s => s.availability == true).Select(s => s.book_ID).ToList();
            }
            foreach (int id in lstP)
            {
                cmb_PatronIDs.Items.Add(id);
            }
            foreach (int id in lstB)
            {
                cmb_BookIDs.Items.Add(id);
            }

        }

        // TAB PAGE FIND INFO
        private void addItemsInfoTypeComboBox(string type)
        {
            cmb_AttributesFind.Items.Clear();
            if (type == "book")
            {
                cmb_AttributesFind.Items.Add("Tất cả");
                cmb_AttributesFind.Items.Add("ID");
                cmb_AttributesFind.Items.Add("Tên Sách");
                cmb_AttributesFind.Items.Add("Tác Giả");
                cmb_AttributesFind.Items.Add("Đã mượn");
            }
            else
            {
                cmb_AttributesFind.Items.Add("Tất cả");
                cmb_AttributesFind.Items.Add("ID");
                cmb_AttributesFind.Items.Add("Tên");
                cmb_AttributesFind.Items.Add("Địa chỉ");
                cmb_AttributesFind.Items.Add("Số điện thoại");
            }
            cmb_AttributesFind.SelectedIndex = 0;
        }
        private void cmb_InfoTypeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_InputFind.Text = "";
            if (cmb_InfoTypeFind.SelectedIndex == -1)
            {
                txt_InputFind.Visible = false;
                cmb_AttributesFind.Visible = false;
                btn_Find.Visible = false;              
            }
            else if (cmb_InfoTypeFind.SelectedIndex == 0)
            {
                txt_InputFind.Visible = true;
                addItemsInfoTypeComboBox("book");
                cmb_AttributesFind.Visible = true;
                btn_Find.Visible = true;
            }
            else
            {
                txt_InputFind.Visible = true;
                addItemsInfoTypeComboBox("patron");
                cmb_AttributesFind.Visible = true;
                btn_Find.Visible = true;
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
            if(cmb_InfoTypeFind.SelectedIndex == 0)
            {
                switch (cmb_AttributesFind.SelectedIndex)
                {
                    case 1:
                        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                    case 2:
                        if (txt_InputFind.TextLength >= 100 && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                    case 3:
                        if (txt_InputFind.TextLength >= 50 && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                    case 4:
                        if (txt_InputFind.TextLength >= 1 && !char.IsControl(e.KeyChar) ||
                            !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                }
            }
            else
            {
                switch (cmb_AttributesFind.SelectedIndex)
                {
                    case 1:
                        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                    case 2:
                        if (txt_InputFind.TextLength >= 50 && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                    case 3:
                        if (txt_InputFind.TextLength >= 50 && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                    case 4:
                        if (txt_InputFind.TextLength >= 10 && !char.IsControl(e.KeyChar) ||
                            !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                        {
                            e.Handled = true;
                            return;
                        }
                        break;
                }
            }
        
        }
        private void findInfoByAttribute(int numData, string strData, bool bolData, int dataType, string infoType)
        {
            int attributeType = dataType;
            try
            {
                using (DATABASE.Library_ManagementEntities _entity = new DATABASE.Library_ManagementEntities())
                {
                    if(infoType == "book")
                    {
                        List<BookInfo> lst = new List<BookInfo>();
                        switch (attributeType)
                        {
                            case 0: // Find by ID
                                {
                                    lst = _entity.Books.Where(s => s.book_ID == numData).Select(s => new BookInfo
                                    {
                                        Id = s.book_ID,
                                        Titile = s.title,
                                        Author = s.author,
                                        Avaibility = s.availability
                                    }).ToList();
                                    break;
                                }
                            case 1: // Find by Title
                                {
                                    lst = _entity.Books.Where(s => s.title == strData).Select(s => new BookInfo
                                    {
                                        Id = s.book_ID,
                                        Titile = s.title,
                                        Author = s.author,
                                        Avaibility = s.availability
                                    }).ToList();
                                    break;
                                }
                            case 2: // Find by Author
                                {
                                    lst = _entity.Books.Where(s => s.author == strData).Select(s => new BookInfo
                                    {
                                        Id = s.book_ID,
                                        Titile = s.title,
                                        Author = s.author,
                                        Avaibility = s.availability
                                    }).ToList();
                                    break;
                                }
                            case 3: // Find by Avaibility
                                {
                                    lst = _entity.Books.Where(s => s.availability == bolData).Select(s => new BookInfo
                                    {
                                        Id = s.book_ID,
                                        Titile = s.title,
                                        Author = s.author,
                                        Avaibility = s.availability
                                    }).ToList();
                                    break;
                                }
                            default: // Alls
                                {
                                    lst = _entity.Books.Select(s => new BookInfo
                                    {
                                        Id = s.book_ID,
                                        Titile = s.title,
                                        Author = s.author,
                                        Avaibility = s.availability
                                    }).ToList();
                                    break;
                                }
                        }
                        dgv_InfoView.DataSource = lst;
                        info.modifyDataGridViewBookColumn(dgv_InfoView);
                    }
                    else
                    {
                        List<PatronInfo> lst = new List<PatronInfo>();
                        switch (attributeType)
                        {
                            case 0: // Find by ID
                                {
                                    lst = _entity.Patrons.Where(s => s.patron_ID == numData).Select(s => new PatronInfo
                                    {
                                        Id = s.patron_ID,
                                        Name = s.name,
                                        Address = s.address,
                                        Phone = s.phone
                                    }).ToList();
                                    break;
                                }
                            case 1: // Find by Name
                                {
                                    lst = _entity.Patrons.Where(s => s.name == strData).Select(s => new PatronInfo
                                    {
                                        Id = s.patron_ID,
                                        Name = s.name,
                                        Address = s.address,
                                        Phone = s.phone
                                    }).ToList();
                                    break;
                                }
                            case 2: // Find by Address
                                {
                                    lst = _entity.Patrons.Where(s => s.address == strData).Select(s => new PatronInfo
                                    {
                                        Id = s.patron_ID,
                                        Name = s.name,
                                        Address = s.address,
                                        Phone = s.phone
                                    }).ToList();
                                    break;
                                }
                            case 3: // Find by Phone
                                {
                                    lst = _entity.Patrons.Where(s => s.phone == numData).Select(s => new PatronInfo
                                    {
                                        Id = s.patron_ID,
                                        Name = s.name,
                                        Address = s.address,
                                        Phone = s.phone
                                    }).ToList();
                                    break;
                                }
                            default: // Alls
                                {
                                    lst = _entity.Patrons.Select(s => new PatronInfo
                                    {
                                        Id = s.patron_ID,
                                        Name = s.name,
                                        Address = s.address,
                                        Phone = s.phone
                                    }).ToList();
                                    break;
                                }
                        }
                        dgv_InfoView.DataSource = lst;
                        info.modifyDataGridViewPatronColumn(dgv_InfoView);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Exception while Find Infos!");
            }
        }
        private void chooseBookInfoType()
        {
            int numData;
            string strData;
            bool bolData = false;
            string infoType = "book";
            switch (cmb_AttributesFind.SelectedIndex)
            {
                case 1: // Item: ID
                    {
                        numData = Convert.ToInt32(txt_InputFind.Text);
                        strData = "";
                        findInfoByAttribute(numData, strData, bolData, 0, infoType);
                        break;
                    }
                case 2: // Item: Title
                    {
                        numData = 0;
                        strData = txt_InputFind.Text;
                        findInfoByAttribute(numData, strData, bolData, 1, infoType);
                        break;
                    }
                case 3: // Item: Author
                    {
                         numData = 0;
                         strData = txt_InputFind.Text;
                        findInfoByAttribute(numData, strData, bolData, 2, infoType);
                         break;
                    }
                 case 4: // Item: Avaibility
                    {
                        int num = int.Parse(txt_InputFind.Text);
                        if(num != 1 || num != 0)
                        {
                            MessageBox.Show("Chỉ nhập 0 và 1.\n 0 là Đã mượn, 1 là Chưa mượn");
                            return;
                        }
                        numData = 0;
                        strData = "";
                        bolData = Boolean.Parse(txt_InputFind.Text);
                        findInfoByAttribute(numData, strData, bolData, 3, infoType);
                        break;
                    }
                default: // Item: Alls
                    {
                        numData = 0;
                        strData = "";
                        findInfoByAttribute(numData, strData, bolData, 4, infoType);
                        break;
                    }
            }
        }
        private void choosePatronInfoType()
        {
            int numData;
            string strData;
            bool bolData = false;
            string infoType = "patron";
            switch (cmb_AttributesFind.SelectedIndex)
            {
                case 1: // Item: ID
                    {
                        numData = Convert.ToInt32(txt_InputFind.Text);
                        strData = "";
                        findInfoByAttribute(numData, strData, bolData, 0, infoType);
                        break;
                    }
                case 2: // Item: Name
                    {
                        numData = 0;
                        strData = txt_InputFind.Text;
                        findInfoByAttribute(numData, strData, bolData, 1, infoType);
                        break;
                    }
                case 3: // Item: Address
                    {
                            numData = 0;
                            strData = txt_InputFind.Text;
                            findInfoByAttribute(numData, strData, bolData, 2, infoType);
                            break;
                    }
                 case 4: // Item: Phone
                    {
                        numData = Convert.ToInt32(txt_InputFind.Text);
                        strData = "";
                        findInfoByAttribute(numData, strData, bolData, 3, infoType);
                        break;
                    }
                default: // Item: Alls
                    {
                        numData = 0;
                        strData = "";
                        findInfoByAttribute(numData, strData, bolData, 4, infoType);
                        break;
                    }
            }
        }
        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (txt_InputFind.Text == string.Empty && cmb_AttributesFind.SelectedIndex != 0)
            {
                MessageBox.Show("Hãy nhập thông tin để tìm!");
                return;
            }
            else
            {
                if(cmb_InfoTypeFind.SelectedIndex == 0)
                {
                    chooseBookInfoType();
                }
                else
                {
                    choosePatronInfoType();
                }
            }
        }

        // TAB PAGE TICKET MANAGEMENT
        private void cmb_ModifyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ModifyType.SelectedIndex == 0)
            {
                clearFields();
                lbl_Id.Text = (info.getLatestId() + 1).ToString();
                dgv_TicketModify.Enabled = false;
                cmb_BookIDs.Enabled = true;
                cmb_PatronIDs.Enabled = true;
            }
            else if (cmb_ModifyType.SelectedIndex == 1)
            {
                clearFields();
                dgv_TicketModify.Enabled = true;
                //cmb_BookIDs.Enabled = false;
                //cmb_PatronIDs.Enabled = false;
            }
            else
            {
                clearFields();
                dgv_TicketModify.Enabled = true;
                cmb_BookIDs.Enabled = true;
                cmb_PatronIDs.Enabled = true;
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void clearFields()
        {
            cmb_BookIDs.SelectedIndex = -1;
            cmb_PatronIDs.SelectedIndex = -1;
            dtp_DueDate.Value = DateTime.Now;
            lbl_Id.Text = "";
        }
        private void dgv_TicketModify_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_TicketModify.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_TicketModify.SelectedRows)
                {
                    lbl_Id.Text = row.Cells[0].Value.ToString();
                    cmb_BookIDs.SelectedItem = currentUpdateBookId = int.Parse(row.Cells[1].Value.ToString());
                    cmb_PatronIDs.SelectedItem = int.Parse(row.Cells[2].Value.ToString());
                    dtp_DueDate.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                }
            }
        }
        private void addTicket()
        {
            tb_Checkout ticket = new tb_Checkout();
            ticket.book_ID = int.Parse(cmb_BookIDs.SelectedItem.ToString());
            ticket.patron_ID = int.Parse(cmb_PatronIDs.SelectedItem.ToString());
            ticket.checkout_Date = DateTime.Now;
            ticket.due_Date = dtp_DueDate.Value;

            bool result = info.insertNewTicket(ticket);
            if (result)
            {
                MessageBox.Show("Thêm thành công! ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
                info.showAllTickets(dgv_TicketModify);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, hãy thử lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void updateTicket()
        {
            tb_Checkout ticket = new tb_Checkout();
            ticket.checkout_ID = int.Parse(lbl_Id.Text);
            if(cmb_BookIDs.SelectedIndex != -1)
            {
                ticket.book_ID = int.Parse(cmb_BookIDs.SelectedItem.ToString());
            }
            else
            {
                ticket.book_ID = currentUpdateBookId;
            }
            ticket.patron_ID = int.Parse(cmb_PatronIDs.SelectedItem.ToString());
            ticket.due_Date = dtp_DueDate.Value;

                bool result = info.updateTicket(ticket);
                if (result)
                {
                    MessageBox.Show("Sửa thành công! ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    info.showAllTickets(dgv_TicketModify);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, hãy thử lại...\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        private void deleteTicket()
        {
            try
            {
                int idTicket = Convert.ToInt32(lbl_Id.Text);

                bool result = info.deleteTicket(idTicket);
                if (result)
                {
                    MessageBox.Show("Xoá thành công! ...", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    info.showAllTickets(dgv_TicketModify);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, hãy thử lại...\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình xoá.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_ConfirmChange_Click(object sender, EventArgs e)
        {           
            if(cmb_ModifyType.SelectedIndex == 1 || cmb_ModifyType.SelectedIndex == 2)
            {
                if (cmb_PatronIDs.SelectedIndex == -1)
                {
                    MessageBox.Show("Hãy chọn đầy đủ thông tin\n!");
                    return;
                }
            }
            else if (cmb_BookIDs.SelectedIndex == -1 || cmb_PatronIDs.SelectedIndex == -1 || dtp_DueDate.Value < DateTime.Now)
            {
                MessageBox.Show("Hãy chọn đầy đủ thông tin\n và chọn ngày trả ít nhất sau 1 ngày!");
                return;
            }
            switch (cmb_ModifyType.SelectedIndex)
            {
                case 0: // Mode: Insert
                    {
                        addTicket();
                        break;
                    }
                case 1: // Mode: Update
                    {
                        updateTicket();
                        break;
                    }
                case 2: // Mode: Delete
                    {
                        deleteTicket();
                        break;
                    }
                default: // Mode: Unchosen
                    {
                        MessageBox.Show("Hãy chọn chế độ!");
                        break;
                    }
            }
        }
    }
}
