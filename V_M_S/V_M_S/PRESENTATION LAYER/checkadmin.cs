using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using V_M_S.DATA_LAYER;
using V_M_S.BUSSINESS_LAYER;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace V_M_S
{
    public partial class checkadmin : Form
    {
        public checkadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
            SqlDataReader reader = Connection.Authentication();
            while (reader.Read())
            {
                a = reader[0].ToString();
                b = reader[1].ToString();
            }
            if (a == textBox1.Text && b == textBox2.Text)
            {
                adminselection AdminF = new adminselection();
                AdminF.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("PLZ! Enter correct username & password."); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }
    }
}
