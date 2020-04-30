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
    public partial class Profile : Form
    {

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Profile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void City_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

            if (Global.Admin != 0)
            {
                edit_res.Visible = true;

            }
            else
            {
                edit_res.Visible = false;

            }
            Save.Visible = false;
            MessageBox.Show(Global.CurrentUser);
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from useraccounts where username=:username";
            cmd.Parameters.Add("username",Global.CurrentUser);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name.Text = dr[1].ToString();
                username.Text = dr[0].ToString();
                email.Text = dr[3].ToString();
                promotions.Text = dr[4].ToString();
                Password.Text = dr[2].ToString();
                phone.Text = dr[5].ToString();
                Flat.Text = dr[6].ToString();
                building.Text=dr[7].ToString();
                City.Text = dr[8].ToString();
                Street.Text = dr[9].ToString();
            }
            dr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            Save.Visible = true;
            name.Enabled = true;
            Password.Enabled = true;
            email.Enabled = true;
            //username.Enabled = true;
            promotions.Enabled = true;
            City.Enabled = true;
            Flat.Enabled = true;
            building.Enabled = true;
            Street.Enabled = true;
        }

        private void deleteacc_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from useraccounts where username=:username";
            cmd.Parameters.Add("username", Global.CurrentUser);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Account deleted");
                this.Close();
                Log l = new Log();
                l.Show();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "update UserAccounts set REALNAME=:name, USERPASSWORD=:password, USEREMAIL=:email,USERPHONE=:phone,APARTMENTNUMBER=:flat, BUILDINGNUMBER=:building,USERCITY=:city,USERSTREET=:street where username=:username";
            cmd2.Parameters.Add("name", name.Text);
            cmd2.Parameters.Add("password", Password.Text);
            cmd2.Parameters.Add("email", email.Text);
            //cmd2.Parameters.Add("promotion", int.Parse(promotions.Text));
            cmd2.Parameters.Add("phone", int.Parse(phone.Text));
            cmd2.Parameters.Add("flat", int.Parse(Flat.Text));
            cmd2.Parameters.Add("building", int.Parse(building.Text));
            cmd2.Parameters.Add("city", City.Text);
            cmd2.Parameters.Add("street", int.Parse(Street.Text));
            cmd2.Parameters.Add("username",Global.CurrentUser);
            int r = cmd2.ExecuteNonQuery();
            MessageBox.Show("UserAccount Updated");
            conn.Close();
            Save.Visible = false;
            name.Enabled = false;
            Password.Enabled = false;
            email.Enabled = false;
            username.Enabled = false;
            promotions.Enabled = false;
            City.Enabled = false;
            Flat.Enabled = false;
            building.Enabled = false;
            Street.Enabled = false;
        }

        private void edit_res_Click(object sender, EventArgs e)
        {
            edit_res.Visible = true;
            AdminPanal admin = new AdminPanal();
            admin.Show();
        }
    }
}
