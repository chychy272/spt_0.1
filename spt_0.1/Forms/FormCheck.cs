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
    public partial class FormCheck : Form
    {       

        public FormCheck()
        {
            InitializeComponent();
            this.AutoSize = false;

        }
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }



        private void FormCheck_Load(object sender, EventArgs e)
        {

        }

        private void check_password_button_Click(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            String file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                textBox1.Text = file_path;
            }
        }
    }
}
