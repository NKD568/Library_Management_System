namespace Library_Management_App.FORMS
{
    partial class frm_Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Forgot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(70, 60);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(320, 65);
            this.lbl_Login.TabIndex = 5;
            this.lbl_Login.Text = "ĐĂNG NHẬP";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.Linen;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(82, 189);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(565, 50);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Text = "Nhập tên ...";
            this.txt_Name.Enter += new System.EventHandler(this.emptyPlaceHolderText);
            this.txt_Name.Leave += new System.EventHandler(this.resetPlaceHolderText);
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Linen;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(82, 292);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(565, 50);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Text = "Nhập mật khẩu ...";
            this.txt_Password.Enter += new System.EventHandler(this.emptyPlaceHolderText);
            this.txt_Password.Leave += new System.EventHandler(this.resetPlaceHolderText);
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Login.Location = new System.Drawing.Point(369, 458);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(356, 51);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "ĐĂNG NHẬP  ";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Register.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Register.Location = new System.Drawing.Point(4, 458);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(356, 51);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "  ĐĂNG KÝ";
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Register.UseVisualStyleBackColor = false;
            // 
            // btn_Forgot
            // 
            this.btn_Forgot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Forgot.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Forgot.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Forgot.Location = new System.Drawing.Point(188, 355);
            this.btn_Forgot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Forgot.Name = "btn_Forgot";
            this.btn_Forgot.Size = new System.Drawing.Size(356, 51);
            this.btn_Forgot.TabIndex = 4;
            this.btn_Forgot.Text = "Quên Mật Khẩu?";
            this.btn_Forgot.UseVisualStyleBackColor = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 512);
            this.Controls.Add(this.btn_Forgot);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Login";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Forgot;
    }
}