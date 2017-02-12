using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            labelKorda.Visible = !checkBoxTricks.Checked;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new Form { TopMost = true }, "Кордушка моя!", "title",
     MessageBoxButtons.OK,
     MessageBoxIcon.Warning);

            labelKorda.Visible = true;
            



        }
    }
}
