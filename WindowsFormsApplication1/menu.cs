using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Log L = new Log();
            L.Show();
            this.Hide();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
            this.Hide();
        }
    }
}
