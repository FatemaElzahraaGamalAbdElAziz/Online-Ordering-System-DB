using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication1
{
    public partial class Registration : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {


            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select username from useraccounts where username=:username";
            cmd.Parameters.Add("username", User_Name.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
            }
            dr.Close();
            if (count != 0)
            {
                MessageBox.Show("UserName already taken");
                User_Name.Clear();
                Password.Clear();
                Confirm.Clear();
                conn.Close();
            }
            else if (Password.Text != Confirm.Text)
            {
                MessageBox.Show("Password doesn't match");
                Password.Clear();
                Confirm.Clear();
                conn.Close();
            }
            else
            {
                if(checkBox1.Checked)
                {
                    Global.Admin = 1;
                }
               
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "insert into UserAccounts values (:username,:name,:password,:email,null,:phone,:flat,:building,:city,:street,:admin)";
                cmd2.Parameters.Add("username",User_Name.Text);
                cmd2.Parameters.Add("name",Name.Text);
                cmd2.Parameters.Add("password",Password.Text);
                cmd2.Parameters.Add("email",Email.Text);
                cmd2.Parameters.Add("phone",int.Parse(Phone.Text));
                cmd2.Parameters.Add("flat", int.Parse(Flat.Text));
                cmd2.Parameters.Add("building",int.Parse(building.Text));
                cmd2.Parameters.Add("city",City.Text);
                cmd2.Parameters.Add("street",int.Parse(Street.Text));
                cmd2.Parameters.Add("admin", Global.Admin);
                int r = cmd2.ExecuteNonQuery();
                MessageBox.Show("UserAccount Created");
                conn.Close();
                Global.CurrentUser = Name.Text;
                Search S = new Search();
                S.Show();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
