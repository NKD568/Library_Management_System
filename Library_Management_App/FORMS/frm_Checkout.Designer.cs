namespace Library_Management_App.FORMS
{
    partial class frm_Checkout
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
            this.tcrl_CheckoutTabView = new System.Windows.Forms.TabControl();
            this.tabP_FindInfo = new System.Windows.Forms.TabPage();
            this.dgv_InfoView = new System.Windows.Forms.DataGridView();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txt_InputFind = new System.Windows.Forms.TextBox();
            this.cmb_InfoTypeFind = new System.Windows.Forms.ComboBox();
            this.cmb_AttributesFind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabP_TicketManagement = new System.Windows.Forms.TabPage();
            this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ConfirmChange = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_IdTag = new System.Windows.Forms.Label();
            this.cmb_PatronIDs = new System.Windows.Forms.ComboBox();
            this.cmb_BookIDs = new System.Windows.Forms.ComboBox();
            this.cmb_ModifyType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_TicketModify = new System.Windows.Forms.DataGridView();
            this.tcrl_CheckoutTabView.SuspendLayout();
            this.tabP_FindInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InfoView)).BeginInit();
            this.tabP_TicketManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketModify)).BeginInit();
            this.SuspendLayout();
            // 
            // tcrl_CheckoutTabView
            // 
            this.tcrl_CheckoutTabView.Controls.Add(this.tabP_FindInfo);
            this.tcrl_CheckoutTabView.Controls.Add(this.tabP_TicketManagement);
            this.tcrl_CheckoutTabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcrl_CheckoutTabView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcrl_CheckoutTabView.Location = new System.Drawing.Point(0, 0);
            this.tcrl_CheckoutTabView.Name = "tcrl_CheckoutTabView";
            this.tcrl_CheckoutTabView.SelectedIndex = 0;
            this.tcrl_CheckoutTabView.Size = new System.Drawing.Size(1106, 686);
            this.tcrl_CheckoutTabView.TabIndex = 10;
            // 
            // tabP_FindInfo
            // 
            this.tabP_FindInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.tabP_FindInfo.Controls.Add(this.dgv_InfoView);
            this.tabP_FindInfo.Controls.Add(this.btn_Find);
            this.tabP_FindInfo.Controls.Add(this.txt_InputFind);
            this.tabP_FindInfo.Controls.Add(this.cmb_InfoTypeFind);
            this.tabP_FindInfo.Controls.Add(this.cmb_AttributesFind);
            this.tabP_FindInfo.Controls.Add(this.label2);
            this.tabP_FindInfo.Controls.Add(this.label5);
            this.tabP_FindInfo.Controls.Add(this.label3);
            this.tabP_FindInfo.Controls.Add(this.label1);
            this.tabP_FindInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.tabP_FindInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabP_FindInfo.Location = new System.Drawing.Point(4, 57);
            this.tabP_FindInfo.Name = "tabP_FindInfo";
            this.tabP_FindInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_FindInfo.Size = new System.Drawing.Size(1098, 625);
            this.tabP_FindInfo.TabIndex = 0;
            this.tabP_FindInfo.Text = "          Tra Thông Tin          ";
            // 
            // dgv_InfoView
            // 
            this.dgv_InfoView.AllowUserToAddRows = false;
            this.dgv_InfoView.AllowUserToDeleteRows = false;
            this.dgv_InfoView.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgv_InfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InfoView.Location = new System.Drawing.Point(6, 303);
            this.dgv_InfoView.MultiSelect = false;
            this.dgv_InfoView.Name = "dgv_InfoView";
            this.dgv_InfoView.ReadOnly = true;
            this.dgv_InfoView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_InfoView.RowTemplate.Height = 28;
            this.dgv_InfoView.Size = new System.Drawing.Size(1084, 314);
            this.dgv_InfoView.TabIndex = 0;
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Find.Location = new System.Drawing.Point(834, 149);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(155, 44);
            this.btn_Find.TabIndex = 0;
            this.btn_Find.Text = "XEM";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Visible = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txt_InputFind
            // 
            this.txt_InputFind.Enabled = false;
            this.txt_InputFind.Location = new System.Drawing.Point(385, 149);
            this.txt_InputFind.Name = "txt_InputFind";
            this.txt_InputFind.Size = new System.Drawing.Size(358, 45);
            this.txt_InputFind.TabIndex = 2;
            this.txt_InputFind.Visible = false;
            this.txt_InputFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputFind_KeyPress);
            // 
            // cmb_InfoTypeFind
            // 
            this.cmb_InfoTypeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_InfoTypeFind.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_InfoTypeFind.FormattingEnabled = true;
            this.cmb_InfoTypeFind.Location = new System.Drawing.Point(506, 19);
            this.cmb_InfoTypeFind.Name = "cmb_InfoTypeFind";
            this.cmb_InfoTypeFind.Size = new System.Drawing.Size(206, 46);
            this.cmb_InfoTypeFind.TabIndex = 1;
            this.cmb_InfoTypeFind.SelectedIndexChanged += new System.EventHandler(this.cmb_InfoTypeFind_SelectedIndexChanged);
            // 
            // cmb_AttributesFind
            // 
            this.cmb_AttributesFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AttributesFind.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_AttributesFind.FormattingEnabled = true;
            this.cmb_AttributesFind.Location = new System.Drawing.Point(468, 84);
            this.cmb_AttributesFind.Name = "cmb_AttributesFind";
            this.cmb_AttributesFind.Size = new System.Drawing.Size(253, 46);
            this.cmb_AttributesFind.TabIndex = 1;
            this.cmb_AttributesFind.Visible = false;
            this.cmb_AttributesFind.SelectedIndexChanged += new System.EventHandler(this.cmb_AttributesFind_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(376, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Sách Thông Tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "TÌM: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "LỌC: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN:";
            // 
            // tabP_TicketManagement
            // 
            this.tabP_TicketManagement.BackColor = System.Drawing.Color.LightCoral;
            this.tabP_TicketManagement.Controls.Add(this.dtp_DueDate);
            this.tabP_TicketManagement.Controls.Add(this.btn_Clear);
            this.tabP_TicketManagement.Controls.Add(this.btn_ConfirmChange);
            this.tabP_TicketManagement.Controls.Add(this.lbl_Id);
            this.tabP_TicketManagement.Controls.Add(this.label7);
            this.tabP_TicketManagement.Controls.Add(this.label6);
            this.tabP_TicketManagement.Controls.Add(this.label9);
            this.tabP_TicketManagement.Controls.Add(this.label8);
            this.tabP_TicketManagement.Controls.Add(this.lbl_IdTag);
            this.tabP_TicketManagement.Controls.Add(this.cmb_PatronIDs);
            this.tabP_TicketManagement.Controls.Add(this.cmb_BookIDs);
            this.tabP_TicketManagement.Controls.Add(this.cmb_ModifyType);
            this.tabP_TicketManagement.Controls.Add(this.label4);
            this.tabP_TicketManagement.Controls.Add(this.dgv_TicketModify);
            this.tabP_TicketManagement.Location = new System.Drawing.Point(4, 57);
            this.tabP_TicketManagement.Name = "tabP_TicketManagement";
            this.tabP_TicketManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_TicketManagement.Size = new System.Drawing.Size(1098, 625);
            this.tabP_TicketManagement.TabIndex = 1;
            this.tabP_TicketManagement.Text = "          Quản Lý Phiếu          ";
            // 
            // dtp_DueDate
            // 
            this.dtp_DueDate.Location = new System.Drawing.Point(276, 153);
            this.dtp_DueDate.Name = "dtp_DueDate";
            this.dtp_DueDate.Size = new System.Drawing.Size(559, 55);
            this.dtp_DueDate.TabIndex = 6;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(855, 78);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(167, 55);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "LÀM MỚI";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ConfirmChange
            // 
            this.btn_ConfirmChange.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_ConfirmChange.Location = new System.Drawing.Point(841, 153);
            this.btn_ConfirmChange.Name = "btn_ConfirmChange";
            this.btn_ConfirmChange.Size = new System.Drawing.Size(181, 55);
            this.btn_ConfirmChange.TabIndex = 5;
            this.btn_ConfirmChange.Text = "XÁC NHẬN";
            this.btn_ConfirmChange.UseVisualStyleBackColor = true;
            this.btn_ConfirmChange.Click += new System.EventHandler(this.btn_ConfirmChange_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(98, 85);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(28, 48);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 48);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID Người Mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Sách:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 48);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày trả sách:";
            // 
            // lbl_IdTag
            // 
            this.lbl_IdTag.AutoSize = true;
            this.lbl_IdTag.Location = new System.Drawing.Point(26, 85);
            this.lbl_IdTag.Name = "lbl_IdTag";
            this.lbl_IdTag.Size = new System.Drawing.Size(63, 48);
            this.lbl_IdTag.TabIndex = 5;
            this.lbl_IdTag.Text = "ID:";
            // 
            // cmb_PatronIDs
            // 
            this.cmb_PatronIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PatronIDs.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_PatronIDs.FormattingEnabled = true;
            this.cmb_PatronIDs.Location = new System.Drawing.Point(720, 81);
            this.cmb_PatronIDs.Name = "cmb_PatronIDs";
            this.cmb_PatronIDs.Size = new System.Drawing.Size(86, 46);
            this.cmb_PatronIDs.TabIndex = 0;
            // 
            // cmb_BookIDs
            // 
            this.cmb_BookIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BookIDs.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_BookIDs.FormattingEnabled = true;
            this.cmb_BookIDs.Location = new System.Drawing.Point(349, 85);
            this.cmb_BookIDs.Name = "cmb_BookIDs";
            this.cmb_BookIDs.Size = new System.Drawing.Size(89, 46);
            this.cmb_BookIDs.TabIndex = 0;
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
            this.label4.Location = new System.Drawing.Point(417, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh Sách Phiếu";
            // 
            // dgv_TicketModify
            // 
            this.dgv_TicketModify.AllowUserToAddRows = false;
            this.dgv_TicketModify.AllowUserToDeleteRows = false;
            this.dgv_TicketModify.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv_TicketModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TicketModify.Location = new System.Drawing.Point(8, 298);
            this.dgv_TicketModify.MultiSelect = false;
            this.dgv_TicketModify.Name = "dgv_TicketModify";
            this.dgv_TicketModify.ReadOnly = true;
            this.dgv_TicketModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_TicketModify.RowTemplate.Height = 28;
            this.dgv_TicketModify.Size = new System.Drawing.Size(1084, 319);
            this.dgv_TicketModify.TabIndex = 1;
            this.dgv_TicketModify.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TicketModify_CellClick);
            // 
            // frm_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 686);
            this.Controls.Add(this.tcrl_CheckoutTabView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Checkout";
            this.Text = "Quản Lý Phiếu Mượn";
            this.Load += new System.EventHandler(this.frm_Checkout_Load);
            this.tcrl_CheckoutTabView.ResumeLayout(false);
            this.tabP_FindInfo.ResumeLayout(false);
            this.tabP_FindInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InfoView)).EndInit();
            this.tabP_TicketManagement.ResumeLayout(false);
            this.tabP_TicketManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketModify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcrl_CheckoutTabView;
        private System.Windows.Forms.TabPage tabP_FindInfo;
        private System.Windows.Forms.DataGridView dgv_InfoView;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox txt_InputFind;
        private System.Windows.Forms.ComboBox cmb_AttributesFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabP_TicketManagement;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ConfirmChange;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_IdTag;
        private System.Windows.Forms.ComboBox cmb_ModifyType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_TicketModify;
        private System.Windows.Forms.ComboBox cmb_InfoTypeFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_PatronIDs;
        private System.Windows.Forms.ComboBox cmb_BookIDs;
    }
}