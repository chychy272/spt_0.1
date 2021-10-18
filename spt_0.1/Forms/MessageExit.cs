using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spt_0._1.Forms
{
    public partial class MessageExit : Form
    {
        public MessageExit()
        {
            InitializeComponent();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void MsgExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
