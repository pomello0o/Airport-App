namespace AirportApp
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelInvalidOld = new System.Windows.Forms.Label();
            this.labelInvalidNew = new System.Windows.Forms.Label();
            this.labelInvalidConfirm = new System.Windows.Forms.Label();
            this.linkLabelProfile = new System.Windows.Forms.LinkLabel();
            this.pictureBoxOld = new System.Windows.Forms.PictureBox();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.pictureBoxConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password";
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPass.Location = new System.Drawing.Point(100, 81);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(225, 30);
            this.textBoxOldPass.TabIndex = 1;
            this.textBoxOldPass.UseSystemPasswordChar = true;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(100, 177);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(225, 30);
            this.textBoxNewPass.TabIndex = 3;
            this.textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(100, 273);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(225, 30);
            this.textBoxConfirmPass.TabIndex = 5;
            this.textBoxConfirmPass.UseSystemPasswordChar = true;
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPass.Location = new System.Drawing.Point(95, 244);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(195, 26);
            this.labelConfirmPass.TabIndex = 4;
            this.labelConfirmPass.Text = "Confirm password";
            // 
            // buttonChange
            // 
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonChange.FlatAppearance.BorderSize = 3;
            this.buttonChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(137, 346);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(137, 53);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelInvalidOld
            // 
            this.labelInvalidOld.AutoSize = true;
            this.labelInvalidOld.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidOld.ForeColor = System.Drawing.Color.Crimson;
            this.labelInvalidOld.Location = new System.Drawing.Point(106, 114);
            this.labelInvalidOld.Name = "labelInvalidOld";
            this.labelInvalidOld.Size = new System.Drawing.Size(209, 16);
            this.labelInvalidOld.TabIndex = 17;
            this.labelInvalidOld.Text = "Doesn\'t match current password";
            this.labelInvalidOld.Visible = false;
            // 
            // labelInvalidNew
            // 
            this.labelInvalidNew.AutoSize = true;
            this.labelInvalidNew.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidNew.ForeColor = System.Drawing.Color.Crimson;
            this.labelInvalidNew.Location = new System.Drawing.Point(96, 210);
            this.labelInvalidNew.Name = "labelInvalidNew";
            this.labelInvalidNew.Size = new System.Drawing.Size(219, 16);
            this.labelInvalidNew.TabIndex = 18;
            this.labelInvalidNew.Text = "Should contain at least 8 symbols";
            this.labelInvalidNew.Visible = false;
            // 
            // labelInvalidConfirm
            // 
            this.labelInvalidConfirm.AutoSize = true;
            this.labelInvalidConfirm.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidConfirm.ForeColor = System.Drawing.Color.Crimson;
            this.labelInvalidConfirm.Location = new System.Drawing.Point(124, 306);
            this.labelInvalidConfirm.Name = "labelInvalidConfirm";
            this.labelInvalidConfirm.Size = new System.Drawing.Size(191, 16);
            this.labelInvalidConfirm.TabIndex = 19;
            this.labelInvalidConfirm.Text = "Doesn\'t match new password";
            this.labelInvalidConfirm.Visible = false;
            // 
            // linkLabelProfile
            // 
            this.linkLabelProfile.AutoSize = true;
            this.linkLabelProfile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelProfile.Location = new System.Drawing.Point(294, 9);
            this.linkLabelProfile.Name = "linkLabelProfile";
            this.linkLabelProfile.Size = new System.Drawing.Size(114, 19);
            this.linkLabelProfile.TabIndex = 20;
            this.linkLabelProfile.TabStop = true;
            this.linkLabelProfile.Text = "Back to profile";
            this.linkLabelProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProfile_LinkClicked);
            // 
            // pictureBoxOld
            // 
            this.pictureBoxOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOld.Image = global::AirportApp.Properties.Resources.hidden;
            this.pictureBoxOld.Location = new System.Drawing.Point(331, 81);
            this.pictureBoxOld.Name = "pictureBoxOld";
            this.pictureBoxOld.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOld.TabIndex = 21;
            this.pictureBoxOld.TabStop = false;
            this.pictureBoxOld.MouseEnter += new System.EventHandler(this.pictureBoxOld_MouseEnter);
            this.pictureBoxOld.MouseLeave += new System.EventHandler(this.pictureBoxOld_MouseLeave);
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNew.Image = global::AirportApp.Properties.Resources.hidden;
            this.pictureBoxNew.Location = new System.Drawing.Point(331, 177);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNew.TabIndex = 22;
            this.pictureBoxNew.TabStop = false;
            this.pictureBoxNew.MouseEnter += new System.EventHandler(this.pictureBoxNew_MouseEnter);
            this.pictureBoxNew.MouseLeave += new System.EventHandler(this.pictureBoxNew_MouseLeave);
            // 
            // pictureBoxConfirm
            // 
            this.pictureBoxConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConfirm.Image = global::AirportApp.Properties.Resources.hidden;
            this.pictureBoxConfirm.Location = new System.Drawing.Point(331, 273);
            this.pictureBoxConfirm.Name = "pictureBoxConfirm";
            this.pictureBoxConfirm.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfirm.TabIndex = 23;
            this.pictureBoxConfirm.TabStop = false;
            this.pictureBoxConfirm.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxConfirm.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(436, 428);
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
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelInvalidOld;
        private System.Windows.Forms.Label labelInvalidNew;
        private System.Windows.Forms.Label labelInvalidConfirm;
        private System.Windows.Forms.LinkLabel linkLabelProfile;
        private System.Windows.Forms.PictureBox pictureBoxOld;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.PictureBox pictureBoxConfirm;
    }
}