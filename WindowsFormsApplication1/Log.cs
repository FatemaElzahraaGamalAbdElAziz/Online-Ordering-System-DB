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
    public partial class Log : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Log()
        {
            InitializeComponent();
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select username , userpassword, ADMIN  from useraccounts where username=:username";
            cmd.Parameters.Add("username", Name.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            string pass="";
            int count = 0;
            while (dr.Read())
            {
                pass = dr[1].ToString();
                Global.Admin = int.Parse(dr[2].ToString());
                count++;
            }
            dr.Close();
            if(count==0){
                MessageBox.Show("Username is not found");
                Name.Clear();
                Password.Clear();
            }
    
            else if (Password.Text != pass)
            {

                MessageBox.Show("Password is WRONG!");
                Name.Clear();
                Password.Clear();

            }

            else {

                MessageBox.Show("Login Successfully");
                dr.Close();
                conn.Close();
                Global.CurrentUser = Name.Text;
                this.Close();
                Search S = new Search();
                S.Show();
            }


        

        }

        private void Log_Load(object sender, EventArgs e)
        {

        }
    }
}
