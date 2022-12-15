using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>(); 
        List<int> numbers = new List<int>();
       

        public Form1()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            RandNum();
            progressBar1.Maximum = Int32.Parse(numericUpDown1.Value.ToString());
            timer1.Interval = 1000;
            timer1.Enabled = true;
            button1.Enabled = false;

        }
        public void RandNum()
        {
          
            Random rand = new Random();
            int number = 0;
            buttons.Add(button2); buttons.Add(button4);
            buttons.Add(button3); buttons.Add(button5);
            buttons.Add(button6); buttons.Add(button8);
            buttons.Add(button7); buttons.Add(button9);
            buttons.Add(button10); buttons.Add(button12);
            buttons.Add(button11); buttons.Add(button13);
            buttons.Add(button14); buttons.Add(button16);
            buttons.Add(button15); buttons.Add(button17);
          
            foreach (var item in buttons)
            {
                do
                {
                    number = rand.Next(0, 100);
                }
                while (numbers.Contains(number));
                numbers.Add(number);
                item.Text = number.ToString();
            }
            numbers.Sort();
        }
        private void groupBox1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in buttons)
                {
                    if (item.Focused)
                    {
                        if (item.Text == numbers[listBox1.Items.Count].ToString())
                        {
                            listBox1.Items.Add(item.Text);
                            item.Enabled = false;
                            listBox1.Focus();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Конец игры!");
            }
        }

        
    }
}

