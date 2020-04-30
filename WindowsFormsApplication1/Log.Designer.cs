namespace WindowsFormsApplication1
{
    partial class Log
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
            this.Password = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Log_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(127, 90);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(116, 24);
            this.Password.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(127, 39);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(116, 24);
            this.Name.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 48);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Username";
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(199, 160);
            this.Log_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(87, 28);
            this.Log_in.TabIndex = 8;
            this.Log_in.Text = "Log In";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 321);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
           // this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox Password;
        internal System.Windows.Forms.TextBox Name;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Log_in;
    }
}