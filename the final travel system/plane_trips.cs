using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_final_travel_system
{
    public partial class plane_trips : Form
    {
        public plane_trips()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            textBox9.Visible = true;
            label2.Visible = true;
            textBox10.Visible = true;
            label12.Visible = true;
            textBox11.Visible = true;
            label14.Visible = true;
            textBox12.Visible = true;
            label15.Visible = true;
            textBox13.Visible = true;
            label17.Visible = true;
            comboBox1.Visible = true;
            label16.Visible = true;
            textBox14.Visible = true;
            label18.Visible = true;
            textBox15.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
