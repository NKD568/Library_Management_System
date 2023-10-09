namespace Library_Management_App.FORMS
{
    partial class frm_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.pan_SideMenu = new System.Windows.Forms.Panel();
            this.pan_Navigation = new System.Windows.Forms.Panel();
            this.btn_Ticket = new System.Windows.Forms.Button();
            this.btn_Patron = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.lbl_LogoName2 = new System.Windows.Forms.Label();
            this.lbl_LogoName1 = new System.Windows.Forms.Label();
            this.pan_MainScreen = new System.Windows.Forms.Panel();
            this.pan_TotalBooks = new System.Windows.Forms.Panel();
            this.lbl_TotalBooksTag = new System.Windows.Forms.Label();
            this.lbl_TotalBooks = new System.Windows.Forms.Label();
            this.pan_TotalPatrons = new System.Windows.Forms.Panel();
            this.lbl_TotalPatrons = new System.Windows.Forms.Label();
            this.lbl_TotalPatronsTag = new System.Windows.Forms.Label();
            this.pan_TotalTickets = new System.Windows.Forms.Panel();
            this.lbl_TotalTickets = new System.Windows.Forms.Label();
            this.lbl_TotalTicketsTag = new System.Windows.Forms.Label();
            this.pan_LatestBooks = new System.Windows.Forms.Panel();
            this.pan_PopularBooks = new System.Windows.Forms.Panel();
            this.lbl_LatestBooksTag = new System.Windows.Forms.Label();
            this.lbl_PopularBooksTag = new System.Windows.Forms.Label();
            this.btn_Chart = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.pan_SideMenu.SuspendLayout();
            this.pan_Navigation.SuspendLayout();
            this.pan_MainScreen.SuspendLayout();
            this.pan_TotalBooks.SuspendLayout();
            this.pan_TotalPatrons.SuspendLayout();
            this.pan_TotalTickets.SuspendLayout();
            this.pan_LatestBooks.SuspendLayout();
            this.pan_PopularBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_SideMenu
            // 
            resources.ApplyResources(this.pan_SideMenu, "pan_SideMenu");
            this.pan_SideMenu.BackColor = System.Drawing.Color.Linen;
            this.pan_SideMenu.Controls.Add(this.pan_Navigation);
            this.pan_SideMenu.Controls.Add(this.pic_Logo);
            this.pan_SideMenu.Controls.Add(this.lbl_LogoName2);
            this.pan_SideMenu.Controls.Add(this.lbl_LogoName1);
            this.pan_SideMenu.Name = "pan_SideMenu";
            // 
            // pan_Navigation
            // 
            resources.ApplyResources(this.pan_Navigation, "pan_Navigation");
            this.pan_Navigation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan_Navigation.Controls.Add(this.btn_Chart);
            this.pan_Navigation.Controls.Add(this.btn_Ticket);
            this.pan_Navigation.Controls.Add(this.btn_Patron);
            this.pan_Navigation.Controls.Add(this.btn_Book);
            this.pan_Navigation.Name = "pan_Navigation";
            // 
            // btn_Ticket
            // 
            this.btn_Ticket.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.btn_Ticket, "btn_Ticket");
            this.btn_Ticket.Name = "btn_Ticket";
            this.btn_Ticket.UseVisualStyleBackColor = false;
            this.btn_Ticket.Click += new System.EventHandler(this.btn_Ticket_Click);
            // 
            // btn_Patron
            // 
            this.btn_Patron.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.btn_Patron, "btn_Patron");
            this.btn_Patron.Name = "btn_Patron";
            this.btn_Patron.UseVisualStyleBackColor = false;
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.btn_Book, "btn_Book");
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // lbl_LogoName2
            // 
            resources.ApplyResources(this.lbl_LogoName2, "lbl_LogoName2");
            this.lbl_LogoName2.Name = "lbl_LogoName2";
            // 
            // lbl_LogoName1
            // 
            resources.ApplyResources(this.lbl_LogoName1, "lbl_LogoName1");
            this.lbl_LogoName1.Name = "lbl_LogoName1";
            // 
            // pan_MainScreen
            // 
            this.pan_MainScreen.BackColor = System.Drawing.Color.Snow;
            this.pan_MainScreen.Controls.Add(this.pan_PopularBooks);
            this.pan_MainScreen.Controls.Add(this.pan_LatestBooks);
            this.pan_MainScreen.Controls.Add(this.pan_TotalTickets);
            this.pan_MainScreen.Controls.Add(this.pan_TotalPatrons);
            this.pan_MainScreen.Controls.Add(this.pan_TotalBooks);
            resources.ApplyResources(this.pan_MainScreen, "pan_MainScreen");
            this.pan_MainScreen.Name = "pan_MainScreen";
            // 
            // pan_TotalBooks
            // 
            this.pan_TotalBooks.BackColor = System.Drawing.Color.Khaki;
            this.pan_TotalBooks.Controls.Add(this.lbl_TotalBooks);
            this.pan_TotalBooks.Controls.Add(this.lbl_TotalBooksTag);
            resources.ApplyResources(this.pan_TotalBooks, "pan_TotalBooks");
            this.pan_TotalBooks.Name = "pan_TotalBooks";
            // 
            // lbl_TotalBooksTag
            // 
            resources.ApplyResources(this.lbl_TotalBooksTag, "lbl_TotalBooksTag");
            this.lbl_TotalBooksTag.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbl_TotalBooksTag.Name = "lbl_TotalBooksTag";
            // 
            // lbl_TotalBooks
            // 
            resources.ApplyResources(this.lbl_TotalBooks, "lbl_TotalBooks");
            this.lbl_TotalBooks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalBooks.Name = "lbl_TotalBooks";
            // 
            // pan_TotalPatrons
            // 
            this.pan_TotalPatrons.BackColor = System.Drawing.Color.LightCoral;
            this.pan_TotalPatrons.Controls.Add(this.lbl_TotalPatrons);
            this.pan_TotalPatrons.Controls.Add(this.lbl_TotalPatronsTag);
            resources.ApplyResources(this.pan_TotalPatrons, "pan_TotalPatrons");
            this.pan_TotalPatrons.Name = "pan_TotalPatrons";
            // 
            // lbl_TotalPatrons
            // 
            resources.ApplyResources(this.lbl_TotalPatrons, "lbl_TotalPatrons");
            this.lbl_TotalPatrons.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalPatrons.Name = "lbl_TotalPatrons";
            // 
            // lbl_TotalPatronsTag
            // 
            resources.ApplyResources(this.lbl_TotalPatronsTag, "lbl_TotalPatronsTag");
            this.lbl_TotalPatronsTag.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_TotalPatronsTag.Name = "lbl_TotalPatronsTag";
            // 
            // pan_TotalTickets
            // 
            this.pan_TotalTickets.BackColor = System.Drawing.Color.LightBlue;
            this.pan_TotalTickets.Controls.Add(this.lbl_TotalTickets);
            this.pan_TotalTickets.Controls.Add(this.lbl_TotalTicketsTag);
            resources.ApplyResources(this.pan_TotalTickets, "pan_TotalTickets");
            this.pan_TotalTickets.Name = "pan_TotalTickets";
            // 
            // lbl_TotalTickets
            // 
            resources.ApplyResources(this.lbl_TotalTickets, "lbl_TotalTickets");
            this.lbl_TotalTickets.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalTickets.Name = "lbl_TotalTickets";
            // 
            // lbl_TotalTicketsTag
            // 
            resources.ApplyResources(this.lbl_TotalTicketsTag, "lbl_TotalTicketsTag");
            this.lbl_TotalTicketsTag.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_TotalTicketsTag.Name = "lbl_TotalTicketsTag";
            // 
            // pan_LatestBooks
            // 
            this.pan_LatestBooks.BackColor = System.Drawing.Color.LightGreen;
            this.pan_LatestBooks.Controls.Add(this.lbl_LatestBooksTag);
            resources.ApplyResources(this.pan_LatestBooks, "pan_LatestBooks");
            this.pan_LatestBooks.Name = "pan_LatestBooks";
            // 
            // pan_PopularBooks
            // 
            this.pan_PopularBooks.BackColor = System.Drawing.Color.LightGreen;
            this.pan_PopularBooks.Controls.Add(this.lbl_PopularBooksTag);
            resources.ApplyResources(this.pan_PopularBooks, "pan_PopularBooks");
            this.pan_PopularBooks.Name = "pan_PopularBooks";
            // 
            // lbl_LatestBooksTag
            // 
            resources.ApplyResources(this.lbl_LatestBooksTag, "lbl_LatestBooksTag");
            this.lbl_LatestBooksTag.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_LatestBooksTag.Name = "lbl_LatestBooksTag";
            // 
            // lbl_PopularBooksTag
            // 
            resources.ApplyResources(this.lbl_PopularBooksTag, "lbl_PopularBooksTag");
            this.lbl_PopularBooksTag.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_PopularBooksTag.Name = "lbl_PopularBooksTag";
            // 
            // btn_Chart
            // 
            this.btn_Chart.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.btn_Chart, "btn_Chart");
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.UseVisualStyleBackColor = false;
            // 
            // pic_Logo
            // 
            resources.ApplyResources(this.pic_Logo, "pic_Logo");
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.TabStop = false;
            // 
            // frm_Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pan_MainScreen);
            this.Controls.Add(this.pan_SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.Shown += new System.EventHandler(this.frm_Home_Shown);
            this.pan_SideMenu.ResumeLayout(false);
            this.pan_SideMenu.PerformLayout();
            this.pan_Navigation.ResumeLayout(false);
            this.pan_MainScreen.ResumeLayout(false);
            this.pan_TotalBooks.ResumeLayout(false);
            this.pan_TotalBooks.PerformLayout();
            this.pan_TotalPatrons.ResumeLayout(false);
            this.pan_TotalPatrons.PerformLayout();
            this.pan_TotalTickets.ResumeLayout(false);
            this.pan_TotalTickets.PerformLayout();
            this.pan_LatestBooks.ResumeLayout(false);
            this.pan_LatestBooks.PerformLayout();
            this.pan_PopularBooks.ResumeLayout(false);
            this.pan_PopularBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_SideMenu;
        private System.Windows.Forms.Label lbl_LogoName1;
        private System.Windows.Forms.Label lbl_LogoName2;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Panel pan_Navigation;
        private System.Windows.Forms.Button btn_Ticket;
        private System.Windows.Forms.Button btn_Patron;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Panel pan_MainScreen;
        private System.Windows.Forms.Panel pan_TotalBooks;
        private System.Windows.Forms.Label lbl_TotalBooksTag;
        private System.Windows.Forms.Label lbl_TotalBooks;
        private System.Windows.Forms.Panel pan_TotalTickets;
        private System.Windows.Forms.Label lbl_TotalTickets;
        private System.Windows.Forms.Label lbl_TotalTicketsTag;
        private System.Windows.Forms.Panel pan_TotalPatrons;
        private System.Windows.Forms.Label lbl_TotalPatrons;
        private System.Windows.Forms.Label lbl_TotalPatronsTag;
        private System.Windows.Forms.Panel pan_PopularBooks;
        private System.Windows.Forms.Panel pan_LatestBooks;
        private System.Windows.Forms.Label lbl_LatestBooksTag;
        private System.Windows.Forms.Label lbl_PopularBooksTag;
        private System.Windows.Forms.Button btn_Chart;
    }
}