using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace V_M_S
{
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        private void Splashform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString();
            }
            else
            {
                timer1.Stop();
                Selection selection = new Selection();
                selection.Show();
                this.Hide();
            }
        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
