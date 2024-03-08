using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Management_App.FORMS;

namespace Library_Management_App.DATABASE.Models
{
    public class CheckoutInfo
    {
        public int Id { get; set; }
        public int BookID { get; set; }
        public int PatronsID { get; set; }
        public DateTime Checkout_Date { get; set; }
        public DateTime Due_Date { get; set; }

        public int getLatestId()
        {
            int latestId = 0;
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                    latestId = _entity.Checkout.Max(t => t.checkout_ID);
                }
            }
            catch
            {
                MessageBox.Show("Exception while Getting Latest Id!");
            }
            return latestId;
        }
        public void showAllTickets(DataGridView dgv)
        {
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                List<tb_Checkout> lst = new List<tb_Checkout>();
                    lst = _entity.Checkout.ToList();
                    dgv.DataSource = lst;
                    modifyDataGridViewTicketColumn(dgv);
                }   
            }
            catch
            {
                MessageBox.Show("Exception while Showing All Tickets!");
            }
        }
        public bool insertNewTicket(tb_Checkout ticket)
        {
            bool result = false;
            using (Library_ManagementEntities _entity = new Library_ManagementEntities())
            {

                _entity.Checkout.Add(ticket);


                // Update Book Avaibility
                tb_Book _book = _entity.Books.Where(x => x.book_ID == ticket.book_ID).Select(x => x).FirstOrDefault();
                _book.availability = false;

                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public bool updateTicket(tb_Checkout ticket)
        {
            bool result = false;
            int preBookID;

            using (Library_ManagementEntities _entity = new Library_ManagementEntities())
            {
                tb_Checkout _ticket = _entity.Checkout.Where(x => x.checkout_ID == ticket.checkout_ID).Select(x => x).FirstOrDefault();
                 preBookID = _ticket.book_ID;
                _ticket.book_ID = ticket.book_ID;
                _ticket.patron_ID = ticket.patron_ID;
                _ticket.due_Date = ticket.due_Date;

                // Update Book Avaibility IF change to new book
                if(_ticket.book_ID != preBookID)
                {
                    // Update Old Book
                    tb_Book _book = _entity.Books.Where(x => x.book_ID == preBookID).Select(x => x).FirstOrDefault();
                    _book.availability = true;

                    // Update New Book
                    _book = _entity.Books.Where(x => x.book_ID == ticket.book_ID).Select(x => x).FirstOrDefault();
                    _book.availability = false;
                }


                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public bool deleteTicket(int id)
        {
            bool result = false;
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                    tb_Checkout _ticket = _entity.Checkout.Find(id);
                    _entity.Checkout.Remove(_ticket);

                     // Update Book Avaibility
                     tb_Book _book = _entity.Books.Where(x => x.book_ID == _ticket.book_ID).Select(x => x).FirstOrDefault();
                    _book.availability = true;

                    _entity.SaveChanges();
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }
        public void modifyDataGridViewBookColumn(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Tên Sách";
            dgv.Columns[2].HeaderText = "Tác Giả";
            dgv.Columns[3].HeaderText = "Chưa Mượn";
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 300;
            dgv.Columns[2].Width = 250;
            dgv.Columns[3].Width = 100;
        }
        public void modifyDataGridViewPatronColumn(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Tên";
            dgv.Columns[2].HeaderText = "Địa Chỉ";
            dgv.Columns[3].HeaderText = "Số Điện Thoại";
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 250;
            dgv.Columns[2].Width = 300;
            dgv.Columns[3].Width = 100;
        }

        public void modifyDataGridViewTicketColumn(DataGridView dgv)
        {
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "ID Sách";
            dgv.Columns[2].HeaderText = "ID Người mượn";
            dgv.Columns[3].HeaderText = "Ngày mượn";
            dgv.Columns[4].HeaderText = "Ngày trả";
            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 250;
            dgv.Columns[4].Width = 250;

        }

    }
}
