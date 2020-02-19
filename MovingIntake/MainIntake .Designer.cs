using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MovingIntake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblMoveDate = new System.Windows.Forms.Label();
            this.dateTimeMoveDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxFromCity = new System.Windows.Forms.TextBox();
            this.textBoxFromStreet = new System.Windows.Forms.TextBox();
            this.lblFromAddress = new System.Windows.Forms.Label();
            this.textBoxFromState = new System.Windows.Forms.TextBox();
            this.textBoxFromZipCode = new System.Windows.Forms.TextBox();
            this.textBoxToZipCode = new System.Windows.Forms.TextBox();
            this.textBoxToState = new System.Windows.Forms.TextBox();
            this.textBoxToCity = new System.Windows.Forms.TextBox();
            this.textBoxToStreet = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblRoomCount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblToAddress = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvTableView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxRoomCount = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Window;
            this.Title.Font = new System.Drawing.Font("Cooper Black", 55F);
            this.Title.Location = new System.Drawing.Point(327, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(584, 85);
            this.Title.TabIndex = 1;
            this.Title.Text = "2 Guys Moving";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblFullName.Location = new System.Drawing.Point(12, 138);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 19);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxFirstName.Location = new System.Drawing.Point(181, 136);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(143, 26);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Text = "First Name";
            this.textBoxFirstName.Enter += new System.EventHandler(this.TextBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.TextBoxFirstName_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxEmail.Location = new System.Drawing.Point(181, 175);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(304, 26);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "xxxx@xxxxx.com";
            this.textBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblEmail.Location = new System.Drawing.Point(12, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(121, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email Address:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxLastName.Location = new System.Drawing.Point(342, 136);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(143, 26);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Text = "Last Name";
            this.textBoxLastName.Enter += new System.EventHandler(this.TextBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.TextBoxLastName_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblPhone.Location = new System.Drawing.Point(12, 217);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(123, 19);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone Number:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(181, 215);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(165, 26);
            this.textBoxPhoneNumber.TabIndex = 6;
            this.textBoxPhoneNumber.Text = "xxx-xxx-xxxx";
            this.textBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhoneNumber.Enter += new System.EventHandler(this.TextBoxPhoneNumber_Enter);
            this.textBoxPhoneNumber.Leave += new System.EventHandler(this.TextBoxPhoneNumber_Leave);
            // 
            // lblMoveDate
            // 
            this.lblMoveDate.AutoSize = true;
            this.lblMoveDate.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblMoveDate.Location = new System.Drawing.Point(12, 262);
            this.lblMoveDate.Name = "lblMoveDate";
            this.lblMoveDate.Size = new System.Drawing.Size(90, 19);
            this.lblMoveDate.TabIndex = 15;
            this.lblMoveDate.Text = "Move Date";
            // 
            // dateTimeMoveDate
            // 
            this.dateTimeMoveDate.CustomFormat = "MM/dd HH:mm";
            this.dateTimeMoveDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.dateTimeMoveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeMoveDate.Location = new System.Drawing.Point(181, 256);
            this.dateTimeMoveDate.MinDate = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            this.dateTimeMoveDate.Name = "dateTimeMoveDate";
            this.dateTimeMoveDate.Size = new System.Drawing.Size(165, 26);
            this.dateTimeMoveDate.TabIndex = 7;
            this.dateTimeMoveDate.Value = new System.DateTime(2020, 1, 1, 23, 0, 0, 0);
            // 
            // textBoxFromCity
            // 
            this.textBoxFromCity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFromCity.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxFromCity.Location = new System.Drawing.Point(181, 340);
            this.textBoxFromCity.Name = "textBoxFromCity";
            this.textBoxFromCity.Size = new System.Drawing.Size(143, 26);
            this.textBoxFromCity.TabIndex = 17;
            this.textBoxFromCity.Text = "City";
            this.textBoxFromCity.Enter += new System.EventHandler(this.TextBoxFromCity_Enter);
            this.textBoxFromCity.Leave += new System.EventHandler(this.TextBoxFromCity_Leave);
            // 
            // textBoxFromStreet
            // 
            this.textBoxFromStreet.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFromStreet.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxFromStreet.Location = new System.Drawing.Point(181, 300);
            this.textBoxFromStreet.Name = "textBoxFromStreet";
            this.textBoxFromStreet.Size = new System.Drawing.Size(304, 26);
            this.textBoxFromStreet.TabIndex = 16;
            this.textBoxFromStreet.Text = "Street";
            this.textBoxFromStreet.Enter += new System.EventHandler(this.TextBoxFromStreet_Enter);
            this.textBoxFromStreet.Leave += new System.EventHandler(this.TextBoxFromStreet_Leave);
            // 
            // lblFromAddress
            // 
            this.lblFromAddress.AutoSize = true;
            this.lblFromAddress.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblFromAddress.Location = new System.Drawing.Point(12, 302);
            this.lblFromAddress.Name = "lblFromAddress";
            this.lblFromAddress.Size = new System.Drawing.Size(53, 19);
            this.lblFromAddress.TabIndex = 18;
            this.lblFromAddress.Text = "From:";
            // 
            // textBoxFromState
            // 
            this.textBoxFromState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxFromState.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFromState.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxFromState.Location = new System.Drawing.Point(330, 340);
            this.textBoxFromState.MaxLength = 2;
            this.textBoxFromState.Name = "textBoxFromState";
            this.textBoxFromState.Size = new System.Drawing.Size(39, 26);
            this.textBoxFromState.TabIndex = 19;
            this.textBoxFromState.Text = "ST";
            this.textBoxFromState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFromState.Enter += new System.EventHandler(this.TextBoxFromState_Enter);
            this.textBoxFromState.Leave += new System.EventHandler(this.TextBoxFromState_Leave);
            // 
            // textBoxFromZipCode
            // 
            this.textBoxFromZipCode.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxFromZipCode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxFromZipCode.Location = new System.Drawing.Point(375, 340);
            this.textBoxFromZipCode.MaxLength = 5;
            this.textBoxFromZipCode.Name = "textBoxFromZipCode";
            this.textBoxFromZipCode.Size = new System.Drawing.Size(110, 26);
            this.textBoxFromZipCode.TabIndex = 20;
            this.textBoxFromZipCode.Text = "Zip Code";
            this.textBoxFromZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFromZipCode.Enter += new System.EventHandler(this.TextBoxFromZipCode_Enter);
            this.textBoxFromZipCode.Leave += new System.EventHandler(this.TextBoxFromZipCode_Leave);
            // 
            // textBoxToZipCode
            // 
            this.textBoxToZipCode.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxToZipCode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxToZipCode.Location = new System.Drawing.Point(375, 430);
            this.textBoxToZipCode.MaxLength = 5;
            this.textBoxToZipCode.Name = "textBoxToZipCode";
            this.textBoxToZipCode.Size = new System.Drawing.Size(110, 26);
            this.textBoxToZipCode.TabIndex = 25;
            this.textBoxToZipCode.Text = "Zip Code";
            this.textBoxToZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxToZipCode.Enter += new System.EventHandler(this.TextBoxToZipCode_Enter);
            this.textBoxToZipCode.Leave += new System.EventHandler(this.TextBoxToZipCode_Leave);
            // 
            // textBoxToState
            // 
            this.textBoxToState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxToState.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxToState.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxToState.Location = new System.Drawing.Point(330, 430);
            this.textBoxToState.MaxLength = 2;
            this.textBoxToState.Name = "textBoxToState";
            this.textBoxToState.Size = new System.Drawing.Size(39, 26);
            this.textBoxToState.TabIndex = 24;
            this.textBoxToState.Text = "ST";
            this.textBoxToState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxToState.Enter += new System.EventHandler(this.TextBoxToState_Enter);
            this.textBoxToState.Leave += new System.EventHandler(this.TextBoxToState_Leave);
            // 
            // textBoxToCity
            // 
            this.textBoxToCity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxToCity.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxToCity.Location = new System.Drawing.Point(181, 430);
            this.textBoxToCity.Name = "textBoxToCity";
            this.textBoxToCity.Size = new System.Drawing.Size(143, 26);
            this.textBoxToCity.TabIndex = 22;
            this.textBoxToCity.Text = "City";
            this.textBoxToCity.Enter += new System.EventHandler(this.TextBoxToCity_Enter);
            this.textBoxToCity.Leave += new System.EventHandler(this.TextBoxToCity_Leave);
            // 
            // textBoxToStreet
            // 
            this.textBoxToStreet.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxToStreet.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxToStreet.Location = new System.Drawing.Point(181, 390);
            this.textBoxToStreet.Name = "textBoxToStreet";
            this.textBoxToStreet.Size = new System.Drawing.Size(304, 26);
            this.textBoxToStreet.TabIndex = 21;
            this.textBoxToStreet.Text = "Street";
            this.textBoxToStreet.Enter += new System.EventHandler(this.TextBoxToStreet_Enter);
            this.textBoxToStreet.Leave += new System.EventHandler(this.TextBoxToStreet_Leave);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxNotes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxNotes.Location = new System.Drawing.Point(181, 511);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(304, 99);
            this.textBoxNotes.TabIndex = 27;
            this.textBoxNotes.Text = "Additional Information";
            this.textBoxNotes.Enter += new System.EventHandler(this.TextBoxNotes_Enter);
            this.textBoxNotes.Leave += new System.EventHandler(this.TextBoxNotes_Leave);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblNotes.Location = new System.Drawing.Point(12, 513);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(56, 19);
            this.lblNotes.TabIndex = 27;
            this.lblNotes.Text = "Notes:";
            // 
            // lblRoomCount
            // 
            this.lblRoomCount.AutoSize = true;
            this.lblRoomCount.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblRoomCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblRoomCount.Location = new System.Drawing.Point(12, 473);
            this.lblRoomCount.Name = "lblRoomCount";
            this.lblRoomCount.Size = new System.Drawing.Size(65, 19);
            this.lblRoomCount.TabIndex = 28;
            this.lblRoomCount.Text = "Rooms:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(385, 630);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblToAddress
            // 
            this.lblToAddress.AutoSize = true;
            this.lblToAddress.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblToAddress.Location = new System.Drawing.Point(12, 392);
            this.lblToAddress.Name = "lblToAddress";
            this.lblToAddress.Size = new System.Drawing.Size(34, 19);
            this.lblToAddress.TabIndex = 34;
            this.lblToAddress.Text = "To:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSearch.Location = new System.Drawing.Point(596, 136);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(333, 26);
            this.textBoxSearch.TabIndex = 36;
            this.textBoxSearch.Text = "Name, Email, or Phone Number";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.lblSearch.Location = new System.Drawing.Point(510, 138);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 19);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Search:";
            // 
            // dgvTableView
            // 
            this.dgvTableView.AllowUserToAddRows = false;
            this.dgvTableView.AllowUserToDeleteRows = false;
            this.dgvTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableView.Location = new System.Drawing.Point(514, 188);
            this.dgvTableView.Name = "dgvTableView";
            this.dgvTableView.ReadOnly = true;
            this.dgvTableView.RowHeadersWidth = 51;
            this.dgvTableView.Size = new System.Drawing.Size(594, 422);
            this.dgvTableView.TabIndex = 38;
            this.dgvTableView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTableView_RowHeaderMouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(514, 630);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1008, 630);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // textBoxRoomCount
            // 
            this.textBoxRoomCount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic);
            this.textBoxRoomCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxRoomCount.Location = new System.Drawing.Point(181, 471);
            this.textBoxRoomCount.MaxLength = 2;
            this.textBoxRoomCount.Name = "textBoxRoomCount";
            this.textBoxRoomCount.Size = new System.Drawing.Size(34, 26);
            this.textBoxRoomCount.TabIndex = 26;
            this.textBoxRoomCount.Text = "xx";
            this.textBoxRoomCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRoomCount.Enter += new System.EventHandler(this.TextBoxRoomCount_Enter);
            this.textBoxRoomCount.Leave += new System.EventHandler(this.TextBoxRoomCount_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1068, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1023, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(181, 630);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1140, 700);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxRoomCount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvTableView);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblToAddress);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblRoomCount);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.textBoxToZipCode);
            this.Controls.Add(this.textBoxToState);
            this.Controls.Add(this.textBoxToCity);
            this.Controls.Add(this.textBoxToStreet);
            this.Controls.Add(this.textBoxFromZipCode);
            this.Controls.Add(this.textBoxFromState);
            this.Controls.Add(this.textBoxFromCity);
            this.Controls.Add(this.textBoxFromStreet);
            this.Controls.Add(this.lblFromAddress);
            this.Controls.Add(this.dateTimeMoveDate);
            this.Controls.Add(this.lblMoveDate);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2 Guys Moving";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label lblMoveDate;
        private System.Windows.Forms.DateTimePicker dateTimeMoveDate;
        private System.Windows.Forms.TextBox textBoxFromCity;
        private System.Windows.Forms.TextBox textBoxFromStreet;
        private System.Windows.Forms.Label lblFromAddress;
        private System.Windows.Forms.TextBox textBoxFromState;
        private System.Windows.Forms.TextBox textBoxFromZipCode;
        private System.Windows.Forms.TextBox textBoxToZipCode;
        private System.Windows.Forms.TextBox textBoxToState;
        private System.Windows.Forms.TextBox textBoxToCity;
        private System.Windows.Forms.TextBox textBoxToStreet;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblRoomCount;
        private Button btnSubmit;
        private Label lblToAddress;
        private TextBox textBoxSearch;
        private Label lblSearch;
        private DataGridView dgvTableView;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox textBoxRoomCount;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnClear;
    }
}

