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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void Bus_button_Click(object sender, EventArgs e)
        {
           // this.Hide();
            bus_trips bus = new bus_trips();
            bus.ShowDialog();
        }

        private void Train_button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            trains_trips train = new trains_trips();
            train.ShowDialog();
        }

        private void Plane_button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            plane_trips plane = new plane_trips();
            plane.ShowDialog();
        }
    }
}
