using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private RunningControls _runnings;
        public Form1()
        {
            InitializeComponent();
            
            _runnings = new RunningControls();
            
            _runnings.AddControl(button1);
            
            _runnings.Start();
        }
        
    }
}


