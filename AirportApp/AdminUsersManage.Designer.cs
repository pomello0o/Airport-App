namespace AirportApp
{
    partial class AdminUsersManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersManage));
            this.linkLabelBack = new System.Windows.Forms.LinkLabel();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelInvalidEmail = new System.Windows.Forms.Label();
            this.labelDuplicateEmail = new System.Windows.Forms.Label();
            this.buttonAction = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dateTimePickerBirtday = new System.Windows.Forms.DateTimePicker();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxOld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBack
            // 
            this.linkLabelBack.AutoSize = true;
            this.linkLabelBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBack.Location = new System.Drawing.Point(501, 9);
            this.linkLabelBack.Name = "linkLabelBack";
            this.linkLabelBack.Size = new System.Drawing.Size(77, 21);
            this.linkLabelBack.TabIndex = 12;
            this.linkLabelBack.TabStop = true;
            this.linkLabelBack.Text = "Go back";
            this.linkLabelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBack_LinkClicked);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(426, 227);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(96, 27);
            this.radioButtonFemale.TabIndex = 32;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(331, 227);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(74, 27);
            this.radioButtonMale.TabIndex = 31;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelInvalidEmail
            // 
            this.labelInvalidEmail.AutoSize = true;
            this.labelInvalidEmail.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidEmail.ForeColor = System.Drawing.Color.Crimson;
            this.labelInvalidEmail.Location = new System.Drawing.Point(177, 257);
            this.labelInvalidEmail.Name = "labelInvalidEmail";
            this.labelInvalidEmail.Size = new System.Drawing.Size(90, 16);
            this.labelInvalidEmail.TabIndex = 30;
            this.labelInvalidEmail.Text = "Invalid Email";
            this.labelInvalidEmail.Visible = false;
            // 
            // labelDuplicateEmail
            // 
            this.labelDuplicateEmail.AutoSize = true;
            this.labelDuplicateEmail.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuplicateEmail.ForeColor = System.Drawing.Color.Crimson;
            this.labelDuplicateEmail.Location = new System.Drawing.Point(43, 257);
            this.labelDuplicateEmail.Name = "labelDuplicateEmail";
            this.labelDuplicateEmail.Size = new System.Drawing.Size(224, 16);
            this.labelDuplicateEmail.TabIndex = 29;
            this.labelDuplicateEmail.Text = "User with this email already exists";
            this.labelDuplicateEmail.Visible = false;
            // 
            // buttonAction
            // 
            this.buttonAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAction.FlatAppearance.BorderSize = 3;
            this.buttonAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAction.Location = new System.Drawing.Point(387, 388);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(154, 51);
            this.buttonAction.TabIndex = 28;
            this.buttonAction.Text = "Update";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(311, 192);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(94, 29);
            this.labelGender.TabIndex = 27;
            this.labelGender.Text = "Gender";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(241, 292);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(100, 29);
            this.labelBirthday.TabIndex = 26;
            this.labelBirthday.Text = "Birthday";
            // 
            // dateTimePickerBirtday
            // 
            this.dateTimePickerBirtday.CalendarFont = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirtday.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirtday.Location = new System.Drawing.Point(136, 324);
            this.dateTimePickerBirtday.MaxDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirtday.MinDate = new System.DateTime(1910, 2, 1, 0, 0, 0, 0);
            this.dateTimePickerBirtday.Name = "dateTimePickerBirtday";
            this.dateTimePickerBirtday.Size = new System.Drawing.Size(319, 28);
            this.dateTimePickerBirtday.TabIndex = 25;
            this.dateTimePickerBirtday.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(37, 192);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 29);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(42, 224);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 30);
            this.textBoxEmail.TabIndex = 23;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(311, 87);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(110, 29);
            this.labelSurname.TabIndex = 22;
            this.labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(37, 87);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 29);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(42, 119);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(225, 30);
            this.textBoxName.TabIndex = 20;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(316, 119);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(225, 30);
            this.textBoxSurname.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(42, 399);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(225, 30);
            this.textBoxPassword.TabIndex = 34;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBoxOld
            // 
            this.pictureBoxOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOld.Image = global::AirportApp.Properties.Resources.hidden;
            this.pictureBoxOld.Location = new System.Drawing.Point(273, 399);
            this.pictureBoxOld.Name = "pictureBoxOld";
            this.pictureBoxOld.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOld.TabIndex = 36;
            this.pictureBoxOld.TabStop = false;
            this.pictureBoxOld.MouseEnter += new System.EventHandler(this.pictureBoxOld_MouseEnter);
            this.pictureBoxOld.MouseLeave += new System.EventHandler(this.pictureBoxOld_MouseLeave);
            // 
            // AdminUsersManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(637, 479);
            this.Controls.Add(this.pictureBoxOld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.labelInvalidEmail);
            this.Controls.Add(this.labelDuplicateEmail);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePickerBirtday);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.linkLabelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminUsersManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUsersManage";
            this.Load += new System.EventHandler(this.AdminUsersManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelBack;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelInvalidEmail;
        private System.Windows.Forms.Label labelDuplicateEmail;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirtday;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxOld;
    }
}