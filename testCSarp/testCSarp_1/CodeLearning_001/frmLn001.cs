using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testcsharp_01.CodeLearning_001
{
    public partial class frmLn001 : Form
    {
        public frmLn001()
        {
            InitializeComponent();
        }

        private void frmLn001_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "ยินดีที่รู้จัก";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text;
        }
    }
}
