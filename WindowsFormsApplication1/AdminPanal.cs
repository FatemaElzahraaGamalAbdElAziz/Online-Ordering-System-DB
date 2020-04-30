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
    public partial class AdminPanal : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public AdminPanal()
        {
            InitializeComponent();
        }

        private void AdminPanal_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
             OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select resturantname from resturats";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
                Restname.Items.Add(dr[0].ToString());
            }
            OracleCommand dish_cmd = new OracleCommand();
            dish_cmd.Connection = conn;
            dish_cmd.CommandText = "select DISHID from DISHES";
            OracleDataReader dish_dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dishid.Items.Add(dish_dr[0].ToString());
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertResturant";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Resturantname", Restname.Text);
            cmd.Parameters.Add("Hotline", hotline.Text);
            cmd.Parameters.Add("Rate", rate.Text);
            cmd.Parameters.Add("Mood", mood.Text);
            cmd.Parameters.Add("Cuisine", cuisine.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("done");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATERESTURANT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Resturantname", Restname.Text);
            cmd.Parameters.Add("Hotline", hotline.Text);
            cmd.Parameters.Add("Rate", rate.Text);
            cmd.Parameters.Add("Mood", mood.Text);
            cmd.Parameters.Add("Cuisine", cuisine.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update  done");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETERESTURANT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Resturantname", Restname.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete  done");

        }

        private void insertdish_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertDishes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", dishid.Text);
            cmd.Parameters.Add("name", dishname.Text);
            cmd.Parameters.Add("size", dishsize.Text);
            cmd.Parameters.Add("price", price.Text);
            cmd.Parameters.Add("categaroy", dcategory.Text);
            cmd.Parameters.Add("description", desc.Text);
            cmd.Parameters.Add("rate", ratedish.Text);
            cmd.Parameters.Add("restname", restnumber.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert done");

        }

        private void updatedish_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATEDISHES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", dishid.Text);
            cmd.Parameters.Add("name", dishname.Text);
            cmd.Parameters.Add("size", dishsize.Text);
            cmd.Parameters.Add("price", price.Text);
            cmd.Parameters.Add("categaroy", dcategory.Text);
            cmd.Parameters.Add("description", desc.Text);
            cmd.Parameters.Add("rate", ratedish.Text);
            cmd.Parameters.Add("restname", restnumber.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update done");
        }

        private void deletedish_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETEDISHE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", dishid.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete done");
        }

        private void insertbranch_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertBranches";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Resturantname", comboBox1.Text);
            cmd.Parameters.Add("id", bid.Text);
            cmd.Parameters.Add("phone", bphone.Text);
            cmd.Parameters.Add("Street", street.Text);
            cmd.Parameters.Add("City", city.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert done");

        }

        private void rname_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebranch_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATEBRANCHES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Resturantname", comboBox1.Text);
            cmd.Parameters.Add("id", bid.Text);
            cmd.Parameters.Add("phone", bphone.Text);
            cmd.Parameters.Add("Street", street.Text);
            cmd.Parameters.Add("City", city.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert done");

        }

        private void deletebranch_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETEBRANCH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Resturantname", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete done");
        }
    }
}
