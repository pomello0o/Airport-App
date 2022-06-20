namespace AirportApp
{
    partial class AdminChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChangePasswordForm));
            this.pictureBoxConfirm = new System.Windows.Forms.PictureBox();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.pictureBoxOld = new System.Windows.Forms.PictureBox();
            this.linkLabelProfile = new System.Windows.Forms.LinkLabel();
            this.labelInvalidConfirm = new System.Windows.Forms.Label();
            this.labelInvalidNew = new System.Windows.Forms.Label();
            this.labelInvalidOld = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxConfirm
            // 
            this.pictureBoxConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConfirm.Image = global::AirportApp.Properties.Resources.hidden;
            this.pictureBoxConfirm.Location = new System.Drawing.Point(306, 275);
            this.pictureBoxConfirm.Name = "pictureBoxConfirm";
            this.pictureBoxConfirm.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfirm.TabIndex = 37;
            this.pictureBoxConfirm.TabStop = false;
            this.pictureBoxConfirm.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxConfirm.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNew.Image = global::AirportApp.Properties.Resources.hidden;
            this.pictureBoxNew.Location = new System.Drawing.Point(306, 179);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNew.TabIndex = 36;
            this.pictureBoxNew.TabStop = false;
            this.pictureBoxNew.MouseEnter += new System.EventHandler(this.pictureBoxNew_MouseEnter);
            this.pictureBoxNew.MouseLeave += new System.EventHandler(this.pictureBoxNew_MouseLeave);
            // 
            // pictureBoxOld
            // 
            this.pictureBoxOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOld.Image = global::AirportApp.Properties.Resources.hidden;
            this.pictureBoxOld.Location = new System.Drawing.Point(306, 83);
            this.pictureBoxOld.Name = "pictureBoxOld";
            this.pictureBoxOld.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOld.TabIndex = 35;
            this.pictureBoxOld.TabStop = false;
            this.pictureBoxOld.MouseEnter += new System.EventHandler(this.pictureBoxOld_MouseEnter);
            this.pictureBoxOld.MouseLeave += new System.EventHandler(this.pictureBoxOld_MouseLeave);
            // 
            // linkLabelProfile
            // 
            this.linkLabelProfile.AutoSize = true;
            this.linkLabelProfile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelProfile.Location = new System.Drawing.Point(269, 11);
            this.linkLabelProfile.Name = "linkLabelProfile";
            this.linkLabelProfile.Size = new System.Drawing.Size(114, 19);
            this.linkLabelProfile.TabIndex = 34;
            this.linkLabelProfile.TabStop = true;
            this.linkLabelProfile.Text = "Back to profile";
            this.linkLabelProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProfile_LinkClicked);
            // 
            // labelInvalidConfirm
            // 
            this.labelInvalidConfirm.AutoSize = true;
            this.labelInvalidConfirm.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidConfirm.ForeColor = System.Drawing.Color.Crimson;
            this.labelInvalidConfirm.Location = new System.Drawing.Point(99, 308);
            this.labelInvalidConfirm.Name = "labelInvalidConfirm";
            this.labelInvalidConfirm.Size = new System.Drawing.Size(191, 16);
            this.labelInvalidConfirm.TabIndex = 33;
            this.labelInvalidConfirm.Text = "Doesn\'t match new password";
            this.labelInvalidConfirm.Visible = false;
            // 
            // labelInvalidNew
            // 
            this.labelInvalidNew.AutoSize = true;
            this.labelInvalidNew.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidNew.ForeColor = System.Drawing.Color.Crimson;
            this.labelInvalidNew.Location = new System.Drawing.Point(71, 212);
            this.labelInvalidNew.Name = "labelInvalidNew";
            this.labelInvalidNew.Size = new System.Drawing.Size(219, 16);
            this.labelInvalidNew.TabIndex = 32;
            this.labelInvalidNew.Text = "Should contain at least 8 symbols";
            this.labelInvalidNew.Visible = false;
            // 
            // labelInvalidOld
            // 
            this.labelInvalidOld.AutoSize = true;
            this.labelInvalidOld.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidOld.ForeColor = System.Drawing.Color.Crimson;
            this.labelInvalidOld.Location = new System.Drawing.Point(81, 116);
            this.labelInvalidOld.Name = "labelInvalidOld";
            this.labelInvalidOld.Size = new System.Drawing.Size(209, 16);
            this.labelInvalidOld.TabIndex = 31;
            this.labelInvalidOld.Text = "Doesn\'t match current password";
            this.labelInvalidOld.Visible = false;
            // 
            // buttonChange
            // 
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonChange.FlatAppearance.BorderSize = 3;
            this.buttonChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(112, 348);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(137, 53);
            this.buttonChange.TabIndex = 30;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(75, 275);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(225, 30);
            this.textBoxConfirmPass.TabIndex = 29;
            this.textBoxConfirmPass.UseSystemPasswordChar = true;
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.Location = new System.Drawing.Point(70, 246);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(195, 26);
            this.labelConfirmPass.TabIndex = 28;
            this.labelConfirmPass.Text = "Confirm password";
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(75, 179);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(225, 30);
            this.textBoxNewPass.TabIndex = 27;
            this.textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "New password";
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPass.Location = new System.Drawing.Point(75, 83);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(225, 30);
            this.textBoxOldPass.TabIndex = 25;
            this.textBoxOldPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Old password";
            // 
            // AdminChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(414, 427);
            this.Controls.Add(this.pictureBoxConfirm);
            this.Controls.Add(this.pictureBoxNew);
            this.Controls.Add(this.pictureBoxOld);
            this.Controls.Add(this.linkLabelProfile);
            this.Controls.Add(this.labelInvalidConfirm);
            this.Controls.Add(this.labelInvalidNew);
            this.Controls.Add(this.labelInvalidOld);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Change password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxConfirm;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.PictureBox pictureBoxOld;
        private System.Windows.Forms.LinkLabel linkLabelProfile;
        private System.Windows.Forms.Label labelInvalidConfirm;
        private System.Windows.Forms.Label labelInvalidNew;
        private System.Windows.Forms.Label labelInvalidOld;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.Label label1;
    }
}