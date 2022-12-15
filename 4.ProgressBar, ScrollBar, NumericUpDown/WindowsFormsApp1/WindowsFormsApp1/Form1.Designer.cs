
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Location = new System.Drawing.Point(12, 284);
            this.progressBar1.Maximum = 190;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(454, 35);
            this.progressBar1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(4, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            190,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(361, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время игры";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Новая игра";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 2;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 100;
            this.listBox1.Location = new System.Drawing.Point(346, 15);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(87, 14);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 59);
            this.button16.TabIndex = 19;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(168, 14);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 59);
            this.button15.TabIndex = 18;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(249, 14);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 59);
            this.button14.TabIndex = 17;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 79);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 59);
            this.button13.TabIndex = 16;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(87, 79);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 59);
            this.button12.TabIndex = 15;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(168, 79);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 59);
            this.button11.TabIndex = 14;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(249, 79);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 59);
            this.button10.TabIndex = 13;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 144);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 59);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(87, 144);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 59);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(168, 144);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 59);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(249, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 59);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 59);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 59);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 59);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 59);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 14);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 59);
            this.button17.TabIndex = 20;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 277);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

