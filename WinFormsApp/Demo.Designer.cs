namespace WinFormsApp
{
    partial class Demo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnCreateContact = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.textContactId = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.lblContactId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstContactOfAccount = new System.Windows.Forms.ListBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtAccountCity = new System.Windows.Forms.TextBox();
            this.txtAccountPostalCode = new System.Windows.Forms.TextBox();
            this.txtAccountStreet = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(664, 414);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(124, 25);
            this.btnDeleteContact.TabIndex = 77;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Location = new System.Drawing.Point(664, 383);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(124, 25);
            this.btnUpdateContact.TabIndex = 76;
            this.btnUpdateContact.Text = "Update Contact";
            this.btnUpdateContact.UseVisualStyleBackColor = true;
            // 
            // btnCreateContact
            // 
            this.btnCreateContact.Location = new System.Drawing.Point(664, 352);
            this.btnCreateContact.Name = "btnCreateContact";
            this.btnCreateContact.Size = new System.Drawing.Size(124, 25);
            this.btnCreateContact.TabIndex = 75;
            this.btnCreateContact.Text = "Create Contact";
            this.btnCreateContact.UseVisualStyleBackColor = true;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(286, 375);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(188, 23);
            this.txtLastname.TabIndex = 74;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(286, 334);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(188, 23);
            this.txtFirstname.TabIndex = 73;
            // 
            // textContactId
            // 
            this.textContactId.Location = new System.Drawing.Point(80, 334);
            this.textContactId.Name = "textContactId";
            this.textContactId.Size = new System.Drawing.Size(93, 23);
            this.textContactId.TabIndex = 72;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(198, 337);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(59, 15);
            this.lblFirstname.TabIndex = 71;
            this.lblFirstname.Text = "Firstname";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(198, 383);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(58, 15);
            this.LblLastName.TabIndex = 70;
            this.LblLastName.Text = "Lastname";
            // 
            // lblContactId
            // 
            this.lblContactId.AutoSize = true;
            this.lblContactId.Location = new System.Drawing.Point(12, 337);
            this.lblContactId.Name = "lblContactId";
            this.lblContactId.Size = new System.Drawing.Size(62, 15);
            this.lblContactId.TabIndex = 69;
            this.lblContactId.Text = "Contact Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "Contactlist of Account <Name>";
            // 
            // lstContactOfAccount
            // 
            this.lstContactOfAccount.FormattingEnabled = true;
            this.lstContactOfAccount.ItemHeight = 15;
            this.lstContactOfAccount.Location = new System.Drawing.Point(14, 223);
            this.lstContactOfAccount.Name = "lstContactOfAccount";
            this.lstContactOfAccount.Size = new System.Drawing.Size(774, 94);
            this.lstContactOfAccount.TabIndex = 67;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(664, 95);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(124, 25);
            this.btnDeleteAccount.TabIndex = 66;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(664, 62);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(124, 27);
            this.btnUpdateAccount.TabIndex = 65;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(664, 31);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(124, 27);
            this.btnCreateAccount.TabIndex = 64;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountCity
            // 
            this.txtAccountCity.Location = new System.Drawing.Point(363, 139);
            this.txtAccountCity.Name = "txtAccountCity";
            this.txtAccountCity.Size = new System.Drawing.Size(133, 23);
            this.txtAccountCity.TabIndex = 63;
            // 
            // txtAccountPostalCode
            // 
            this.txtAccountPostalCode.Location = new System.Drawing.Point(286, 139);
            this.txtAccountPostalCode.Name = "txtAccountPostalCode";
            this.txtAccountPostalCode.Size = new System.Drawing.Size(71, 23);
            this.txtAccountPostalCode.TabIndex = 62;
            // 
            // txtAccountStreet
            // 
            this.txtAccountStreet.Location = new System.Drawing.Point(224, 98);
            this.txtAccountStreet.Name = "txtAccountStreet";
            this.txtAccountStreet.Size = new System.Drawing.Size(272, 23);
            this.txtAccountStreet.TabIndex = 61;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(224, 61);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(272, 23);
            this.txtAccountName.TabIndex = 60;
            // 
            // txtAccountId
            // 
            this.txtAccountId.Location = new System.Drawing.Point(80, 61);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(93, 23);
            this.txtAccountId.TabIndex = 59;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(254, 141);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 58;
            this.lblCity.Text = "City";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(179, 141);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(78, 15);
            this.lblPostalCode.TabIndex = 57;
            this.lblPostalCode.Text = "Postal Code /";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(179, 106);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(37, 15);
            this.lblStreet.TabIndex = 56;
            this.lblStreet.Text = "Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(179, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 55;
            this.lblName.Text = "Name";
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Location = new System.Drawing.Point(12, 64);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(62, 15);
            this.lblAccountId.TabIndex = 54;
            this.lblAccountId.Text = "AccountId";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(14, 11);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(52, 15);
            this.lblAccount.TabIndex = 53;
            this.lblAccount.Text = "Account";
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(80, 11);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(416, 23);
            this.cmbAccount.TabIndex = 52;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnUpdateContact);
            this.Controls.Add(this.btnCreateContact);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.textContactId);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.lblContactId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstContactOfAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtAccountCity);
            this.Controls.Add(this.txtAccountPostalCode);
            this.Controls.Add(this.txtAccountStreet);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAccountId);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.cmbAccount);
            this.Name = "Demo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeleteContact;
        private Button btnUpdateContact;
        private Button btnCreateContact;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private TextBox textContactId;
        private Label lblFirstname;
        private Label LblLastName;
        private Label lblContactId;
        private Label label1;
        private ListBox lstContactOfAccount;
        private Button btnDeleteAccount;
        private Button btnUpdateAccount;
        private Button btnCreateAccount;
        private TextBox txtAccountCity;
        private TextBox txtAccountPostalCode;
        private TextBox txtAccountStreet;
        private TextBox txtAccountName;
        private TextBox txtAccountId;
        private Label lblCity;
        private Label lblPostalCode;
        private Label lblStreet;
        private Label lblName;
        private Label lblAccountId;
        private Label lblAccount;
        private ComboBox cmbAccount;
    }
}