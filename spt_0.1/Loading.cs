using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace spt_0._1
{
    public partial class Loading : Form
    {
        [DllImport("GDi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottonRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public Loading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ProgressBar.Value = 0;
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value += 3;
            ProgressBar.Text = ProgressBar.Value.ToString() + "%";

            if (ProgressBar.Value == 30)
            {
                timer1.Enabled = false;
                MainForm main_form = new MainForm();
                main_form.Show();
                this.Hide();
            }
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
