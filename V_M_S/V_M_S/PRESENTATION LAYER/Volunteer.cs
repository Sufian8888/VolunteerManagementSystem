using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_M_S.DATA_LAYER;
using V_M_S.BUSSINESS_LAYER;

namespace V_M_S
{
    public partial class Volunteer : Form
    {
        private string volunteer_name;
        private string volunteer_id;
        private string volunteer_skills;
        private string Email;
        private string skills;
        private string regdate;

        public Volunteer()
        {
            InitializeComponent();
        }

        public Volunteer(string volunteer_name, string volunteer_id, string volunteer_skills)
        {
            this.volunteer_name = volunteer_name;
            this.volunteer_id = volunteer_id;
            this.volunteer_skills = volunteer_skills;
        }

        public Volunteer(string volunteer_name, string volunteer_id, string volunteer_skills,string Email,string regdate)
        {
            this.volunteer_name = volunteer_name;
            this.volunteer_id = volunteer_id;
            this.volunteer_skills = volunteer_skills;
            this.Email = Email;
            this.regdate = regdate;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("registered successfully !");
            string name = textBox1.Text;
            string id = textBox2.Text;
            string Email = textBox3.Text;
            string skills = textBox4.Text;
            string regdate = textBox5.Text;

            Volunteer volunteer = new Volunteer(name, id, skills, Email, regdate);
            Connection.InsertvolunteerloginData(volunteer);
            MessageBox.Show("Record added successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
