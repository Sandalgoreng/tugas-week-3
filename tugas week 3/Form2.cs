using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_week_3

{
    
    public partial class sec : Form
    {
        
        public void change(string lab_name, string lab_fav)
        {
            output.Text = ("Hi, my name is " + lab_name + " and my favorite artist is " + lab_fav);
        }
        public sec()
        {
            InitializeComponent();
        }

        private void rbut_yellow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbox_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_1.Checked && cbox_2.Checked)
            {
                but_magic.Enabled = true;
            }
            if (cbox_1.Checked == false)
            {
                but_magic.Enabled = false;
            }
        }

        private void cbox_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_2.Checked && cbox_1.Checked)
            {
                but_magic.Enabled = true;
            }
            if (cbox_2.Checked == false)
            {
                but_magic.Enabled = false;
            }
        }

        private void but_magic_Click(object sender, EventArgs e)
        {
            mainf terserah = (mainf)this.Owner;
            if (rbut_red.Checked == false && rbut_green.Checked == false && rbut_blue.Checked == false && rbut_orange.Checked == false && rbut_purple.Checked == false || (rbutt_red.Checked == false && rbutt_green.Checked == false && rbutt_blue.Checked == false))
            {
                MessageBox.Show("warning the user to choose from the radio buttons");
            }
            else
            {
                if (rbut_red.Checked)
                {
                    terserah.BackColor = Color.Red;
                }
                if (rbut_green.Checked)
                {
                    terserah.BackColor = Color.Green;
                }
                if (rbut_blue.Checked)
                {
                    terserah.BackColor = Color.Blue;
                }
                if (rbut_orange.Checked)
                {
                    terserah.BackColor = Color.Orange;
                }
                if (rbut_purple.Checked)
                {
                    terserah.BackColor = Color.Purple;
                }
                if (rbutt_red.Checked)
                {
                    terserah.ForeColor = Color.Red;
                }
                if (rbutt_green.Checked)
                {
                    terserah.ForeColor = Color.Green;
                }
                if (rbutt_blue.Checked)
                {
                    terserah.ForeColor = Color.Blue;
                }
            }
        }
       
    }
}
