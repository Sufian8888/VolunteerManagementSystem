using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_M_S
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            adminselection adminselection = new adminselection();
            adminselection.Show();
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Volunteer volunteerF = new Volunteer();
            volunteerF.Show();
            this.Hide();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
