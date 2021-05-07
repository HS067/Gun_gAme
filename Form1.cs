using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun_Project
{
    public partial class Form1 : Form
    {
        mainclass classgun = new mainclass(); // class added
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            classgun.Gunreload(); // gunload method
        }

        private void Rollbtn_Click(object sender, EventArgs e)
        {
            classgun.Forspingun(); // spin method
        }

        private void shootbtn_Click(object sender, EventArgs e)
        {
            classgun.GunShoot(); // shoot method
        }

        private void awaybtn_Click(object sender, EventArgs e)
        {
            classgun.GunShootAway();// shootaway method
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();// close
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            Application.Restart();// restart
        }
    }
}
