using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_App.DATABASE.Models
{
    class BookInfo
    {
        public int Id { get; set; }
        public string Titile { get; set; }
        public string Author { get; set; }
        public bool Avaibility { get; set; }
    }
}
