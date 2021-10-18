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
    public partial class FormEncrypt : Form
    {
        public string qpwd;

        public FormEncrypt()
        {
            InitializeComponent();
            this.AutoSize = false;
        }
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormEncrypt_Load(object sender, EventArgs e)
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

        private void encryptButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            GeneratePW(13,rnd);
        }

        private void GeneratePW(int length, Random random)
        {
            throw new NotImplementedException();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            
            qpwd = result.ToString();

        }
        
    }
}