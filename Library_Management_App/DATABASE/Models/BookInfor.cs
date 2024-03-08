using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Library_Management_App.DATABASE.Models
{
    public class BookInfor
    {
        public int Book_Id { set; get; }
        public string Title { set; get; }
        public string Author { set; get; }
        public bool Availability { set; get; }
        public void showAllUsers(DataGridView dgv)
        {
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                    List<tb_Book> lst = new List<tb_Book>();
                    lst = _entity.Books.ToList();
                    dgv.DataSource = lst;
                    dgv.Columns.RemoveAt(4);
                    modifyDataGridViewColumn(dgv);
                }
            }
            catch
            {
                MessageBox.Show("Exception while Showing All Books!");
            }
        }
        public bool insertNewBook(tb_Book b)
        {
            bool result = false;
            using (Library_ManagementEntities _entity = new Library_ManagementEntities())
            {

                _entity.Books.Add(b);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public bool updateBook(tb_Book b)
        {
            bool result = false;
            using (Library_ManagementEntities _entity = new Library_ManagementEntities())
            {
                tb_Book _b = _entity.Books.Where(x => x.book_ID == b.book_ID).Select(x => x).FirstOrDefault();
                _b.title = b.title;
                _b.author = b.author;
                _b.availability = b.availability;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public string deleteBook(int id)
        {
            string result;
            try
            {
                using (Library_ManagementEntities _entity = new Library_ManagementEntities())
                {
                    tb_Book _b = _entity.Books.Find(id);
                    if (_b != null &&  _b.book_ID != 0)
                    {
                        _entity.Books.Remove(_b);
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
            
            dgv.Columns[0].HeaderText = "Ma Sach";
            dgv.Columns[1].HeaderText = "Tên sach";
            dgv.Columns[2].HeaderText = "Ten Tac Gia";
            dgv.Columns[3].HeaderText = "Tinh Trang";
            
        }
    }
}
