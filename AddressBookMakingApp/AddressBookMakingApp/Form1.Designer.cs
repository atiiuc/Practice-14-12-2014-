namespace AddressBookMakingApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.hcontact = new System.Windows.Forms.Label();
            this.hPhone = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailAdressTextBox = new System.Windows.Forms.TextBox();
            this.personalContactNoTextBox = new System.Windows.Forms.TextBox();
            this.homeContactNoTextBox = new System.Windows.Forms.TextBox();
            this.homeAdressTextBox = new System.Windows.Forms.TextBox();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Label();
            this.insertDataTextBox = new System.Windows.Forms.TextBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person\'s Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(91, 87);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(67, 13);
            this.email.TabIndex = 1;
            this.email.Text = "Email Adress";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(61, 125);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(128, 13);
            this.contact.TabIndex = 2;
            this.contact.Text = "Personal Contact Number";
            // 
            // hcontact
            // 
            this.hcontact.AutoSize = true;
            this.hcontact.Location = new System.Drawing.Point(74, 165);
            this.hcontact.Name = "hcontact";
            this.hcontact.Size = new System.Drawing.Size(115, 13);
            this.hcontact.TabIndex = 3;
            this.hcontact.Text = "Home Contact Number";
            // 
            // hPhone
            // 
            this.hPhone.AutoSize = true;
            this.hPhone.Location = new System.Drawing.Point(99, 198);
            this.hPhone.Name = "hPhone";
            this.hPhone.Size = new System.Drawing.Size(76, 13);
            this.hPhone.TabIndex = 4;
            this.hPhone.Text = "Home Address";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(201, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // emailAdressTextBox
            // 
            this.emailAdressTextBox.Location = new System.Drawing.Point(201, 84);
            this.emailAdressTextBox.Name = "emailAdressTextBox";
            this.emailAdressTextBox.Size = new System.Drawing.Size(204, 20);
            this.emailAdressTextBox.TabIndex = 6;
            // 
            // personalContactNoTextBox
            // 
            this.personalContactNoTextBox.Location = new System.Drawing.Point(201, 122);
            this.personalContactNoTextBox.Name = "personalContactNoTextBox";
            this.personalContactNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.personalContactNoTextBox.TabIndex = 7;
            // 
            // homeContactNoTextBox
            // 
            this.homeContactNoTextBox.Location = new System.Drawing.Point(201, 162);
            this.homeContactNoTextBox.Name = "homeContactNoTextBox";
            this.homeContactNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.homeContactNoTextBox.TabIndex = 8;
            // 
            // homeAdressTextBox
            // 
            this.homeAdressTextBox.Location = new System.Drawing.Point(201, 198);
            this.homeAdressTextBox.Name = "homeAdressTextBox";
            this.homeAdressTextBox.Size = new System.Drawing.Size(204, 20);
            this.homeAdressTextBox.TabIndex = 9;
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Items.AddRange(new object[] {
            "Name",
            "Email Adress",
            "Personal Contact Number",
            "Home Contact Number",
            "Home Address"});
            this.selectComboBox.Location = new System.Drawing.Point(201, 291);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(204, 21);
            this.selectComboBox.TabIndex = 10;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(303, 235);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(418, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.Location = new System.Drawing.Point(120, 338);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 13);
            this.Insert.TabIndex = 15;
            this.Insert.Text = "Input the Data";
            // 
            // insertDataTextBox
            // 
            this.insertDataTextBox.Location = new System.Drawing.Point(201, 335);
            this.insertDataTextBox.Name = "insertDataTextBox";
            this.insertDataTextBox.Size = new System.Drawing.Size(204, 20);
            this.insertDataTextBox.TabIndex = 16;
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(180, 434);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(298, 238);
            this.searchListBox.TabIndex = 17;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(422, 384);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 18;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 696);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.insertDataTextBox);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.homeAdressTextBox);
            this.Controls.Add(this.homeContactNoTextBox);
            this.Controls.Add(this.personalContactNoTextBox);
            this.Controls.Add(this.emailAdressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.hPhone);
            this.Controls.Add(this.hcontact);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label hcontact;
        private System.Windows.Forms.Label hPhone;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailAdressTextBox;
        private System.Windows.Forms.TextBox personalContactNoTextBox;
        private System.Windows.Forms.TextBox homeContactNoTextBox;
        private System.Windows.Forms.TextBox homeAdressTextBox;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label Insert;
        private System.Windows.Forms.TextBox insertDataTextBox;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button searchbutton;
    }
}

