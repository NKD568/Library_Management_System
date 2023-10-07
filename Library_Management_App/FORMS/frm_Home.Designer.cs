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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Statistic = new System.Windows.Forms.Button();
            this.btn_Ticket = new System.Windows.Forms.Button();
            this.btn_Patron = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_LogoName2 = new System.Windows.Forms.Label();
            this.lbl_LogoName1 = new System.Windows.Forms.Label();
            this.pan_MainScreen = new System.Windows.Forms.Panel();
            this.pan_SideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_SideMenu
            // 
            resources.ApplyResources(this.pan_SideMenu, "pan_SideMenu");
            this.pan_SideMenu.BackColor = System.Drawing.Color.Linen;
            this.pan_SideMenu.Controls.Add(this.panel1);
            this.pan_SideMenu.Controls.Add(this.pic_Logo);
            this.pan_SideMenu.Controls.Add(this.lbl_LogoName2);
            this.pan_SideMenu.Controls.Add(this.lbl_LogoName1);
            this.pan_SideMenu.Name = "pan_SideMenu";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_Statistic);
            this.panel1.Controls.Add(this.btn_Ticket);
            this.panel1.Controls.Add(this.btn_Patron);
            this.panel1.Controls.Add(this.btn_Book);
            this.panel1.Name = "panel1";
            // 
            // btn_Statistic
            // 
            this.btn_Statistic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Statistic, "btn_Statistic");
            this.btn_Statistic.Name = "btn_Statistic";
            this.btn_Statistic.UseVisualStyleBackColor = false;
            // 
            // btn_Ticket
            // 
            this.btn_Ticket.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Ticket, "btn_Ticket");
            this.btn_Ticket.Name = "btn_Ticket";
            this.btn_Ticket.UseVisualStyleBackColor = false;
            // 
            // btn_Patron
            // 
            this.btn_Patron.BackColor = System.Drawing.Color.Transparent;
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
            // 
            // pic_Logo
            // 
            resources.ApplyResources(this.pic_Logo, "pic_Logo");
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.TabStop = false;
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
            this.pan_MainScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.pan_MainScreen, "pan_MainScreen");
            this.pan_MainScreen.Name = "pan_MainScreen";
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_SideMenu;
        private System.Windows.Forms.Label lbl_LogoName1;
        private System.Windows.Forms.Label lbl_LogoName2;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Statistic;
        private System.Windows.Forms.Button btn_Ticket;
        private System.Windows.Forms.Button btn_Patron;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Panel pan_MainScreen;
    }
}