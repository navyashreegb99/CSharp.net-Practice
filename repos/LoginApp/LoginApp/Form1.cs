using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            WelcomeMsg.Text = "You clicked Set button";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomeMsg.Text = "You logged in!! This is home page";
        }

        private void btnSet_Click_1(object sender, EventArgs e)
        {
            WelcomeMsg.Text = "You clicked Set button";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WelcomeMsg.Text = "Back to home page";
        }
    }
}
