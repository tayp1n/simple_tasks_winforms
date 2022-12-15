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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int countClick = -1;
        int countTrueAnswers = 0;
        List<string> trueAnswers = new List<string>() { "Экипаж", "Азот", "Метание копья", "Весёлый Роджер", "Сладкая жизнь", 
            "Макароны по-флотски", "Выдержка", "Путь в Индию", "Собака на сене", "Динамо" };
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader question = new StreamReader("Questions.txt");
            while (!question.EndOfStream)
            {
                questions.Add(question.ReadLine());
            }
            label1.Text = questions[0];
            StreamReader answer = new StreamReader("Answers.txt");
            while (!answer.EndOfStream)
            {
                answers.Add(answer.ReadLine());
            }
            string[] buf = answers[0].Split(',');
            radioButton1.Text = buf[0];
            radioButton2.Text = buf[1];
            radioButton3.Text = buf[2];
            radioButton4.Text = buf[3];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            countClick++;
            if (radioButton1.Checked && radioButton1.Text == trueAnswers[countClick])
                countTrueAnswers++;
            if (radioButton2.Checked && radioButton2.Text == trueAnswers[countClick])
                countTrueAnswers++;
            if (radioButton3.Checked && radioButton3.Text == trueAnswers[countClick])
                countTrueAnswers++;
            if (radioButton4.Checked && radioButton4.Text == trueAnswers[countClick])
                countTrueAnswers++;
            try{
                Next();
            }
            catch
            {
                label1.Text = "Игра закончена!";
            }
            

        }
        private void Next()
        {
            label1.Text = questions[countClick + 1];
            string[] buf = answers[countClick + 1].Split(',');
            radioButton1.Text = buf[0];
            radioButton2.Text = buf[1];
            radioButton3.Text = buf[2];
            radioButton4.Text = buf[3];
            label2.Text = countTrueAnswers.ToString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }
        
    }
}

