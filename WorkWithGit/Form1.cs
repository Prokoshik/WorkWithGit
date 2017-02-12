using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithGit.Properties;

namespace WorkWithGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxTricks_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = !checkBoxTricks.Checked;
            checkBoxTricks.Hide();
            checkBoxShow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form().Show();

            label1.Text = Resources.nok_was_here;
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.trollface;
            label1.Location = new Point(0,0);
            this.Size = new Size(640,640);
            checkBoxShow.Hide();
            this.CenterToScreen();
        }
    }
}
