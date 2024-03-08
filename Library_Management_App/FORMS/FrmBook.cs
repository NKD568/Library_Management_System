using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Library_Management_App.DATABASE.Models;
using Library_Management_App.DATABASE;

namespace Library_Management_App.FORMS
{
    public partial class Form1 : Form
    {
        BookInfor bin4 = new BookInfor();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            instantiateControls();
            bin4.showAllUsers(dgvListbooks);
        }
        private void instantiateControls()
        {
            cmbAvailability.Items.Add(true);
            cmbAvailability.Items.Add(false);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput() != true)
                {
                    return;
                }
                addb();
            }
            catch { };
        }
        private void addb()
        {
            tb_Book b = new tb_Book();

            b.title = txtTitle.Text;
            b.author = txtAuthor.Text;
            b.availability = Boolean.Parse(cmbAvailability.SelectedItem.ToString());

            bool result = bin4.insertNewBook(b);
            if (result)
            {
                MessageBox.Show("Thêm thành công! ...", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
                bin4.showAllUsers(dgvListbooks);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, hãy thử lại...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
   
        private void updateBooks()
        {
            try
            {
                tb_Book b = new tb_Book();
                b.book_ID = int.Parse(txtBook_Id.Text);
                b.title = txtTitle.Text;
                b.author = txtAuthor.Text;
                b.availability = Boolean.Parse(cmbAvailability.SelectedItem.ToString());
                bool result = bin4.updateBook(b);
                if (result==true)
                {
                    MessageBox.Show("Sửa thành công! ...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    bin4.showAllUsers(dgvListbooks);
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
        private void deleteBook()
        {
            try
            {
                int idUser = Convert.ToInt32(txtBook_Id.Text);

                string result = bin4.deleteBook(idUser);
                if (result == "Success")
                {
                    MessageBox.Show("Xoá thành công! ...", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    bin4.showAllUsers(dgvListbooks);
                }
                else
                {
                    MessageBox.Show("Error, hãy thử lại..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void clearFields()
        {
            txtAuthor.Text = "";
            txtTitle.Text = "";
            cmbAvailability.SelectedIndex = -1;
            txtBook_Id.Text = "";
        }
        public bool CheckInput()
        {
            
            if (txtTitle.Text.Trim().Length < 5 || txtTitle.Text.Trim().Length > 50 )
            {

                MessageBox.Show("Loi Nhap", "Hay nhap lai", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtTitle.Text = "";
                txtTitle.Focus();
                return false;
            }
            if (txtAuthor.Text.Trim().Length < 5 || txtAuthor.Text.Trim().Length > 50 )
            {
                MessageBox.Show("Loi Nhap ", "Hay nhap lai", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtAuthor.Text = "";
                txtAuthor.Focus();
                return false;
            }
            if (cmbAvailability.SelectedIndex == -1)
            {
                MessageBox.Show("Hay chon tinh trang sach ", "Hay nhap lai", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                cmbAvailability.Focus();
                return false;
            }
            return true;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput() != true)
                {
                    return;
                }
                updateBooks();
            }
            catch { };
            
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult f = MessageBox.Show("Ban muon Thoat", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteBook();
        }

        private void dgvListbooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListbooks.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListbooks.SelectedRows)
                {
                    txtBook_Id.Text = row.Cells[0].Value.ToString();
                    txtTitle.Text = row.Cells[1].Value.ToString();
                    txtAuthor.Text = row.Cells[2].Value.ToString();
                    cmbAvailability.SelectedItem = row.Cells[3].Value;
                }
            }
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
