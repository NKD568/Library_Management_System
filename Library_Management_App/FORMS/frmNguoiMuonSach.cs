using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library_Management_App.DATABASE.Models;

namespace Library_Management_App.FORMS
{
    public partial class Form2 : Form
    {      
        public Form2()
        {
            InitializeComponent();
        }
     
        public void ResetInput()
        {
            //txtName.Text = txtAddress.Text = txtPhone.Text = "";
            

        }
       


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter the following information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return ;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter the following information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter the following information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            ADD(txtName.Text, txtAddress.Text, int.Parse(txtPhone.Text));
            MessageBox.Show("Patrons added successfully", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInput();
            txtName.Focus();
            ListData();

        }


        public void ADD(string name, string address, int phone)
        {
            string str = "INSERT INTO Patrons(name,address,phone)  VALUES ( N'" + name + "',N'" + address + "'," + phone + ")";
            ConnectSQL.ExecuteNonQuery(str);
        }
        public void Update(int patron_ID,string name, string address, int phone)
        {
            string str = "UPDATE Patrons SET name=N'" + name + "',address = N'" + address + "',phone =" + phone + " WHERE patron_ID = " + patron_ID + "";
            ConnectSQL.ExecuteNonQuery(str);
        }
        public void DELETE(int patron_ID)
        {
            string str = "DELETE Patrons WHERE patron_ID = " + patron_ID + "";
            ConnectSQL.ExecuteNonQuery(str);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvMain.Rows.Count == 0)
            {
                return;
            };
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter the following information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter the following information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter the following information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            Update(int.Parse(txtID.Text),txtName.Text, txtAddress.Text, int.Parse(txtPhone.Text));
            MessageBox.Show("Patrons updated successfully", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInput();
            txtName.Focus();
            ListData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dtgvMain.Rows.Count == 0) 
            {
                return;
            };
            DialogResult f = MessageBox.Show("Do you want to delete this patron?", "Delete patrons", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
             if (f == DialogResult.Yes)
            {
                DELETE(int.Parse(txtID.Text));
                MessageBox.Show("Patrons deleted successfully", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListData();
            }
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Are you sure to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }


        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            else if (txtPhone.TextLength >= 10 && !char.IsControl(e.KeyChar)) 
            {
                
                e.Handled = true;
                return;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ListData();
        }
        private void ListData ()
        {
            dtgvMain.DataSource = ConnectSQL.GetData("select * from Patrons");

            if (dtgvMain.Rows.Count == 0)
            {
                txtID.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
            }
            else
            {
                var row = this.dtgvMain.Rows[0];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
            } 
        }


        private void dtgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvMain.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();

            }
        }

        
    }
    }


