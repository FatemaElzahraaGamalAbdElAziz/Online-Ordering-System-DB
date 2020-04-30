namespace WindowsFormsApplication1
{
    partial class Profile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Flat = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.promotions = new System.Windows.Forms.TextBox();
            this.edit_profile = new System.Windows.Forms.Button();
            this.deleteacc = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.edit_res = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Orders";
            // 
            // building
            // 
            this.building.Enabled = false;
            this.building.Location = new System.Drawing.Point(252, 212);
            this.building.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(76, 24);
            this.building.TabIndex = 25;
            // 
            // Street
            // 
            this.Street.Enabled = false;
            this.Street.Location = new System.Drawing.Point(364, 212);
            this.Street.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(76, 24);
            this.Street.TabIndex = 26;
            // 
            // City
            // 
            this.City.Enabled = false;
            this.City.Location = new System.Drawing.Point(479, 212);
            this.City.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(76, 24);
            this.City.TabIndex = 27;
            this.City.TextChanged += new System.EventHandler(this.City_TextChanged);
            // 
            // Flat
            // 
            this.Flat.Enabled = false;
            this.Flat.Location = new System.Drawing.Point(147, 212);
            this.Flat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(76, 24);
            this.Flat.TabIndex = 24;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(21, 212);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(56, 17);
            this.Label7.TabIndex = 28;
            this.Label7.Text = "Address";
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(147, 40);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(142, 24);
            this.name.TabIndex = 29;
            // 
            // phone
            // 
            this.phone.Enabled = false;
            this.phone.Location = new System.Drawing.Point(147, 171);
            this.phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(142, 24);
            this.phone.TabIndex = 30;
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(147, 72);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(142, 24);
            this.username.TabIndex = 31;
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(158, 112);
            this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(116, 24);
            this.email.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(714, 332);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Promotions";
            // 
            // promotions
            // 
            this.promotions.Enabled = false;
            this.promotions.Location = new System.Drawing.Point(613, 95);
            this.promotions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promotions.Name = "promotions";
            this.promotions.Size = new System.Drawing.Size(76, 24);
            this.promotions.TabIndex = 36;
            // 
            // edit_profile
            // 
            this.edit_profile.Location = new System.Drawing.Point(12, 623);
            this.edit_profile.Name = "edit_profile";
            this.edit_profile.Size = new System.Drawing.Size(110, 34);
            this.edit_profile.TabIndex = 37;
            this.edit_profile.Text = "Edit profile";
            this.edit_profile.UseVisualStyleBackColor = true;
            this.edit_profile.Click += new System.EventHandler(this.edit_Click);
            // 
            // deleteacc
            // 
            this.deleteacc.Location = new System.Drawing.Point(511, 623);
            this.deleteacc.Name = "deleteacc";
            this.deleteacc.Size = new System.Drawing.Size(110, 34);
            this.deleteacc.TabIndex = 38;
            this.deleteacc.Text = "Delete Account";
            this.deleteacc.UseVisualStyleBackColor = true;
            this.deleteacc.Click += new System.EventHandler(this.deleteacc_Click);
            // 
            // Password
            // 
            this.Password.Enabled = false;
            this.Password.Location = new System.Drawing.Point(158, 144);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(116, 24);
            this.Password.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "password";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(331, 629);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 41;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // edit_res
            // 
            this.edit_res.Location = new System.Drawing.Point(147, 623);
            this.edit_res.Name = "edit_res";
            this.edit_res.Size = new System.Drawing.Size(127, 34);
            this.edit_res.TabIndex = 42;
            this.edit_res.Text = "Edit Database";
            this.edit_res.UseVisualStyleBackColor = true;
            this.edit_res.Click += new System.EventHandler(this.edit_res_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 669);
            this.Controls.Add(this.edit_res);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleteacc);
            this.Controls.Add(this.edit_profile);
            this.Controls.Add(this.promotions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.building);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Flat);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox building;
        internal System.Windows.Forms.TextBox Street;
        internal System.Windows.Forms.TextBox City;
        internal System.Windows.Forms.TextBox Flat;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.TextBox phone;
        internal System.Windows.Forms.TextBox username;
        internal System.Windows.Forms.TextBox email;
        internal System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox promotions;
        private System.Windows.Forms.Button edit_profile;
        private System.Windows.Forms.Button deleteacc;
        internal System.Windows.Forms.TextBox Password;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button edit_res;
    }
}