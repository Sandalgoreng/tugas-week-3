using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_week_3
{
    public partial class mainf : Form
    {
        public bool sec = false;
        sec form2 = new sec();
        public mainf()
        {
            InitializeComponent();
        }

        private void tb_fav_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbox_a_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_a.Checked)
            {
                but_submite.Enabled = true;
            }
            if (cbox_a.Checked == false)
            {
                but_submite.Enabled = false;
            }
        }

        private void but_open_Click(object sender, EventArgs e)
        {
            form2.Show(this);
            sec = true;
        }

        private void but_submite_Click(object sender, EventArgs e)
        {
            
            if (tb_fav.Text == "" || tb_name.Text == "")
            {
                MessageBox.Show("warning the user to enter correct input");
                
            }
            else if (sec = true) 
            {
                form2.change(tb_name.Text, tb_fav.Text);
            }
           

        }

        private void main_Load(object sender, EventArgs e)
        {
           
        }
    }
}
