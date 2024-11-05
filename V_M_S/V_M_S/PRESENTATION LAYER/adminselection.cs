using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_M_S.BUSSINESS_LAYER;
using V_M_S.DATA_LAYER;

namespace V_M_S
{
    public partial class adminselection : Form
    {
        public adminselection()
        {
            InitializeComponent();
        }



        private void adminselection_Load(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string data = "";
                SqlDataReader reader = Connection.Volunteer_T();
                while (reader.Read())
                {
                    string a = reader[0].ToString();
                    string b = reader[1].ToString();
                    string c = reader[2].ToString();
                    data += a + "\t" + b + "\t" + c + "\n";
                    richTextBox1.Text = data;
                }
            }
            else if (radioButton2.Checked)
            {
                string data = " ";
                SqlDataReader reader = Connection.Project_T();
                while (reader.Read())
                {
                    string a = reader[0].ToString();
                    string b = reader[1].ToString();
                    string c = reader[2].ToString();
                    data += a + "\t" + b + "\t" + c + "\n";
                    richTextBox1.Text = data;
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string volunteer_name = textBox1.Text;
                Connection.DeletevolunteerDetails(volunteer_name);
                MessageBox.Show("Record Deleted successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (radioButton2.Checked)
            {

                string PROJECT_ID = textBox2.Text;
                Connection.DeleteprojectDetails(PROJECT_ID);
                MessageBox.Show("Record Deleted successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                string volunteer_name = textBox1.Text;
                string volunteer_id = textBox2.Text;
                string volunteer_skills = textBox3.Text;
                Volunteer volunteer = new Volunteer(volunteer_name, volunteer_id, volunteer_skills);
                Connection.InsertvolunteerData(volunteer);
                MessageBox.Show("Record added successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (radioButton2.Checked)
            {
                string PROJECT_NAME = textBox1.Text;
                string PROJECT_ID = textBox2.Text;
                string PROJECT_SKILLS = textBox3.Text;
                Project proj = new Project(PROJECT_ID, PROJECT_NAME, PROJECT_SKILLS);
                Connection.InsertProjectData(proj);
                MessageBox.Show("Record added successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
