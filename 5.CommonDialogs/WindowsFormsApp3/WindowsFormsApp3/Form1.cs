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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public string TextBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (var file = new OpenFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(file.FileName);
                }
            }
        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            var formEdit = new FormEditText(this);
            formEdit.Show();
        }
       

    }
}
