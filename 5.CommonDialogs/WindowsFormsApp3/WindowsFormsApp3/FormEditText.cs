using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormEditText : Form
    {
        Form1 form1;
        
        public FormEditText(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;

        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            form1.Controls.Find("textBox1", false)[0].Text = textBoxEdit.Text;
        }

        private void btnCancelFile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditText_Load(object sender, EventArgs e)
        {
            textBoxEdit.Text = form1.Controls.Find("textBox1", false)[0].Text;

        }
    }
}
