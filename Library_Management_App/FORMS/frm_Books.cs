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
    public partial class frm_Books : Form
    {

        Panel panelBook = new Panel();
        public frm_Books()
        {

            InitializeComponent();
        }

        private void frm_Books_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
