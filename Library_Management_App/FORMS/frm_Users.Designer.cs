namespace Library_Management_App.FORMS
{
    partial class frm_Users
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
            this.tcrl_UserTabView = new System.Windows.Forms.TabControl();
            this.tabP_General = new System.Windows.Forms.TabPage();
            this.dgv_UserView = new System.Windows.Forms.DataGridView();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txt_InputFind = new System.Windows.Forms.TextBox();
            this.cmb_AttributesFind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabP_Modify = new System.Windows.Forms.TabPage();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ConfirmChange = new System.Windows.Forms.Button();
            this.lbl_IdUser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_UserPassword = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_IdUserTag = new System.Windows.Forms.Label();
            this.txt_UserPassword = new System.Windows.Forms.TextBox();
            this.txt_EmailUser = new System.Windows.Forms.TextBox();
            this.txt_NameUser = new System.Windows.Forms.TextBox();
            this.cmb_LevelUser = new System.Windows.Forms.ComboBox();
            this.cmb_ModifyType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_UserModify = new System.Windows.Forms.DataGridView();
            this.tcrl_UserTabView.SuspendLayout();
            this.tabP_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserView)).BeginInit();
            this.tabP_Modify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserModify)).BeginInit();
            this.SuspendLayout();
            // 
            // tcrl_UserTabView
            // 
            this.tcrl_UserTabView.Controls.Add(this.tabP_General);
            this.tcrl_UserTabView.Controls.Add(this.tabP_Modify);
            this.tcrl_UserTabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcrl_UserTabView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcrl_UserTabView.Location = new System.Drawing.Point(0, 0);
            this.tcrl_UserTabView.Name = "tcrl_UserTabView";
            this.tcrl_UserTabView.SelectedIndex = 0;
            this.tcrl_UserTabView.Size = new System.Drawing.Size(1106, 686);
            this.tcrl_UserTabView.TabIndex = 9;
            // 
            // tabP_General
            // 
            this.tabP_General.BackColor = System.Drawing.Color.PeachPuff;
            this.tabP_General.Controls.Add(this.dgv_UserView);
            this.tabP_General.Controls.Add(this.btn_Find);
            this.tabP_General.Controls.Add(this.txt_InputFind);
            this.tabP_General.Controls.Add(this.cmb_AttributesFind);
            this.tabP_General.Controls.Add(this.label2);
            this.tabP_General.Controls.Add(this.label3);
            this.tabP_General.Controls.Add(this.label1);
            this.tabP_General.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.tabP_General.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabP_General.Location = new System.Drawing.Point(4, 57);
            this.tabP_General.Name = "tabP_General";
            this.tabP_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_General.Size = new System.Drawing.Size(1098, 625);
            this.tabP_General.TabIndex = 0;
            this.tabP_General.Text = "          Tổng Quan          ";
            // 
            // dgv_UserView
            // 
            this.dgv_UserView.AllowUserToAddRows = false;
            this.dgv_UserView.AllowUserToDeleteRows = false;
            this.dgv_UserView.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_UserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserView.Location = new System.Drawing.Point(6, 214);
            this.dgv_UserView.MultiSelect = false;
            this.dgv_UserView.Name = "dgv_UserView";
            this.dgv_UserView.ReadOnly = true;
            this.dgv_UserView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_UserView.RowTemplate.Height = 28;
            this.dgv_UserView.Size = new System.Drawing.Size(1084, 403);
            this.dgv_UserView.TabIndex = 0;
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Find.Location = new System.Drawing.Point(801, 95);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(155, 44);
            this.btn_Find.TabIndex = 0;
            this.btn_Find.Text = "XEM";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txt_InputFind
            // 
            this.txt_InputFind.Enabled = false;
            this.txt_InputFind.Location = new System.Drawing.Point(384, 95);
            this.txt_InputFind.Name = "txt_InputFind";
            this.txt_InputFind.Size = new System.Drawing.Size(361, 45);
            this.txt_InputFind.TabIndex = 2;
            this.txt_InputFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputFind_KeyPress);
            // 
            // cmb_AttributesFind
            // 
            this.cmb_AttributesFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AttributesFind.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_AttributesFind.FormattingEnabled = true;
            this.cmb_AttributesFind.Location = new System.Drawing.Point(384, 27);
            this.cmb_AttributesFind.Name = "cmb_AttributesFind";
            this.cmb_AttributesFind.Size = new System.Drawing.Size(361, 46);
            this.cmb_AttributesFind.TabIndex = 1;
            this.cmb_AttributesFind.SelectedIndexChanged += new System.EventHandler(this.cmb_AttributesFind_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(376, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Sách Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "LỌC: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN:";
            // 
            // tabP_Modify
            // 
            this.tabP_Modify.BackColor = System.Drawing.Color.LightCoral;
            this.tabP_Modify.Controls.Add(this.btn_Clear);
            this.tabP_Modify.Controls.Add(this.btn_ConfirmChange);
            this.tabP_Modify.Controls.Add(this.lbl_IdUser);
            this.tabP_Modify.Controls.Add(this.label8);
            this.tabP_Modify.Controls.Add(this.label7);
            this.tabP_Modify.Controls.Add(this.lbl_UserPassword);
            this.tabP_Modify.Controls.Add(this.label6);
            this.tabP_Modify.Controls.Add(this.label9);
            this.tabP_Modify.Controls.Add(this.lbl_IdUserTag);
            this.tabP_Modify.Controls.Add(this.txt_UserPassword);
            this.tabP_Modify.Controls.Add(this.txt_EmailUser);
            this.tabP_Modify.Controls.Add(this.txt_NameUser);
            this.tabP_Modify.Controls.Add(this.cmb_LevelUser);
            this.tabP_Modify.Controls.Add(this.cmb_ModifyType);
            this.tabP_Modify.Controls.Add(this.label4);
            this.tabP_Modify.Controls.Add(this.dgv_UserModify);
            this.tabP_Modify.Location = new System.Drawing.Point(4, 57);
            this.tabP_Modify.Name = "tabP_Modify";
            this.tabP_Modify.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Modify.Size = new System.Drawing.Size(1098, 625);
            this.tabP_Modify.TabIndex = 1;
            this.tabP_Modify.Text = "          Tuỳ Chỉnh          ";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(919, 153);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(167, 55);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "LÀM MỚI";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Visible = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ConfirmChange
            // 
            this.btn_ConfirmChange.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_ConfirmChange.Location = new System.Drawing.Point(732, 153);
            this.btn_ConfirmChange.Name = "btn_ConfirmChange";
            this.btn_ConfirmChange.Size = new System.Drawing.Size(181, 55);
            this.btn_ConfirmChange.TabIndex = 5;
            this.btn_ConfirmChange.Text = "XÁC NHẬN";
            this.btn_ConfirmChange.UseVisualStyleBackColor = true;
            this.btn_ConfirmChange.Visible = false;
            this.btn_ConfirmChange.Click += new System.EventHandler(this.btn_ConfirmChange_Click);
            // 
            // lbl_IdUser
            // 
            this.lbl_IdUser.AutoSize = true;
            this.lbl_IdUser.Location = new System.Drawing.Point(69, 75);
            this.lbl_IdUser.Name = "lbl_IdUser";
            this.lbl_IdUser.Size = new System.Drawing.Size(28, 48);
            this.lbl_IdUser.TabIndex = 5;
            this.lbl_IdUser.Text = ".";
            this.lbl_IdUser.Visible = false;
            this.lbl_IdUser.TextChanged += new System.EventHandler(this.lbl_IdUser_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 48);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cấp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 48);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email: ";
            // 
            // lbl_UserPassword
            // 
            this.lbl_UserPassword.AutoSize = true;
            this.lbl_UserPassword.Location = new System.Drawing.Point(236, 157);
            this.lbl_UserPassword.Name = "lbl_UserPassword";
            this.lbl_UserPassword.Size = new System.Drawing.Size(176, 48);
            this.lbl_UserPassword.TabIndex = 5;
            this.lbl_UserPassword.Text = "Mật khẩu:";
            this.lbl_UserPassword.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 48);
            this.label9.TabIndex = 5;
            this.label9.Text = "Chế độ:";
            // 
            // lbl_IdUserTag
            // 
            this.lbl_IdUserTag.AutoSize = true;
            this.lbl_IdUserTag.Location = new System.Drawing.Point(0, 75);
            this.lbl_IdUserTag.Name = "lbl_IdUserTag";
            this.lbl_IdUserTag.Size = new System.Drawing.Size(63, 48);
            this.lbl_IdUserTag.TabIndex = 5;
            this.lbl_IdUserTag.Text = "ID:";
            // 
            // txt_UserPassword
            // 
            this.txt_UserPassword.Location = new System.Drawing.Point(418, 153);
            this.txt_UserPassword.Name = "txt_UserPassword";
            this.txt_UserPassword.PasswordChar = '*';
            this.txt_UserPassword.Size = new System.Drawing.Size(308, 55);
            this.txt_UserPassword.TabIndex = 4;
            this.txt_UserPassword.Visible = false;
            this.txt_UserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UserPassword_KeyPress);
            // 
            // txt_EmailUser
            // 
            this.txt_EmailUser.Location = new System.Drawing.Point(706, 79);
            this.txt_EmailUser.Name = "txt_EmailUser";
            this.txt_EmailUser.Size = new System.Drawing.Size(379, 55);
            this.txt_EmailUser.TabIndex = 2;
            this.txt_EmailUser.Visible = false;
            // 
            // txt_NameUser
            // 
            this.txt_NameUser.Location = new System.Drawing.Point(258, 72);
            this.txt_NameUser.Name = "txt_NameUser";
            this.txt_NameUser.Size = new System.Drawing.Size(288, 55);
            this.txt_NameUser.TabIndex = 1;
            this.txt_NameUser.Visible = false;
            this.txt_NameUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NameUser_KeyPress);
            // 
            // cmb_LevelUser
            // 
            this.cmb_LevelUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LevelUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_LevelUser.FormattingEnabled = true;
            this.cmb_LevelUser.Location = new System.Drawing.Point(95, 162);
            this.cmb_LevelUser.Name = "cmb_LevelUser";
            this.cmb_LevelUser.Size = new System.Drawing.Size(135, 46);
            this.cmb_LevelUser.TabIndex = 3;
            this.cmb_LevelUser.Visible = false;
            // 
            // cmb_ModifyType
            // 
            this.cmb_ModifyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ModifyType.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_ModifyType.FormattingEnabled = true;
            this.cmb_ModifyType.Location = new System.Drawing.Point(519, 17);
            this.cmb_ModifyType.Name = "cmb_ModifyType";
            this.cmb_ModifyType.Size = new System.Drawing.Size(237, 46);
            this.cmb_ModifyType.TabIndex = 0;
            this.cmb_ModifyType.SelectedIndexChanged += new System.EventHandler(this.cmb_ModifyType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(384, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh Sách Tài Khoản";
            // 
            // dgv_UserModify
            // 
            this.dgv_UserModify.AllowUserToAddRows = false;
            this.dgv_UserModify.AllowUserToDeleteRows = false;
            this.dgv_UserModify.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv_UserModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserModify.Location = new System.Drawing.Point(8, 298);
            this.dgv_UserModify.MultiSelect = false;
            this.dgv_UserModify.Name = "dgv_UserModify";
            this.dgv_UserModify.ReadOnly = true;
            this.dgv_UserModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_UserModify.RowTemplate.Height = 28;
            this.dgv_UserModify.Size = new System.Drawing.Size(1084, 319);
            this.dgv_UserModify.TabIndex = 1;
            this.dgv_UserModify.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UserModify_CellClick);
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 686);
            this.Controls.Add(this.tcrl_UserTabView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Users";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_Users_Load);
            this.tcrl_UserTabView.ResumeLayout(false);
            this.tabP_General.ResumeLayout(false);
            this.tabP_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserView)).EndInit();
            this.tabP_Modify.ResumeLayout(false);
            this.tabP_Modify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserModify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcrl_UserTabView;
        private System.Windows.Forms.TabPage tabP_General;
        private System.Windows.Forms.DataGridView dgv_UserView;
        private System.Windows.Forms.TextBox txt_InputFind;
        private System.Windows.Forms.ComboBox cmb_AttributesFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TabPage tabP_Modify;
        private System.Windows.Forms.DataGridView dgv_UserModify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ModifyType;
        private System.Windows.Forms.TextBox txt_NameUser;
        private System.Windows.Forms.Label lbl_IdUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_IdUserTag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_UserPassword;
        private System.Windows.Forms.TextBox txt_UserPassword;
        private System.Windows.Forms.TextBox txt_EmailUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ConfirmChange;
        private System.Windows.Forms.ComboBox cmb_LevelUser;
        private System.Windows.Forms.Button btn_Clear;
    }
}