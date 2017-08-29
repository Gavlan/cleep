using System;
using System.Windows.Forms;

namespace cleep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='q')
            {
                richTextBox1.AppendText(Clipboard.GetData(DataFormats.Text).ToString());
            }
        }
    }
}
