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
    public partial class Search : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string command = "";
        string conn = "Data Source =orcl; User Id=scott ; Password=tiger;";

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (Global.Admin != 0)
            //{

            //}
            //else
            //{

            //}
            Profile p = new Profile();
            p.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                command = @"select restaurantname , hotline from restaurants;";
               // adapter = new OracleDataAdapter(command, conn);
               /* ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0]*/

                ds = new DataSet();

                OracleDataAdapter adapter1 = new OracleDataAdapter(@"select restaurantname , hotline from restaurants;" ,conn);
                adapter1.Fill(ds , "REST");

                OracleDataAdapter adapter2 = new OracleDataAdapter(@"select city , street , branchphone from branches;", conn);
                adapter2.Fill(ds, "Branch");

                DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["RESTAURANTNAME"], ds.Tables[1].Columns["RESTAURANTNAME"]);




            }
            else if (radioButton2.Checked)
            {

            }
            else if( radioButton3.Checked){
                command = @"select restaurantname ,mood from restaurants;";
                adapter = new OracleDataAdapter(command, conn);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            adapter = new OracleDataAdapter(command, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
