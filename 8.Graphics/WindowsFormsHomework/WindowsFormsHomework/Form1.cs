using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        class Board
        {
            const int size = 8;
            public Board(Graphics g)
            {
                Color cust1 = Color.FromArgb(255, 204, 153);
                Color cust2 = Color.FromArgb(182, 103, 60);
                SolidBrush WhiteBrush = new SolidBrush(cust1);
                SolidBrush BlackBrush = new SolidBrush(cust2);
                Rectangle[,] rect = new Rectangle[size, size];
                Pen BlackPen = new Pen(cust2);
                Rectangle border = new Rectangle(99, 99, 241, 241);
                g.DrawRectangle(BlackPen, border);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                for (int i = 0; i < size; i++)                 //заполняем массив
                {
                    for (int j = 0; j < size; j++)
                    {
                        rect[i, j] = new Rectangle(70 + ((i + 1) * 30), 70 + ((j + 1) * 30), 30, 30);
                    }
                }
                for (int i = 0; i < size; i++)                 //красим клетки в нужный цвет
                {
                    for (int j = 0; j < size; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            g.FillRectangle(WhiteBrush, rect[i, j]);
                        }
                        else g.FillRectangle(BlackBrush, rect[i, j]);
                    }
                }
                Figure[,] pole = new Figure[size, size];
                pole[0, 0] = new Rook(false, g, 0, 0);
                pole[0, 1] = new Knight(false, g, 0, 1);
                pole[0, 2] = new Bishop(false, g, 0, 2);
                pole[0, 3] = new Queen(false, g, 0, 3);
                pole[0, 4] = new King(false, g, 0, 4);
                pole[0, 5] = new Bishop(false, g, 0, 5);
                pole[0, 6] = new Knight(false, g, 0, 6);
                pole[0, 7] = new Rook(false, g, 0, 7);
                for (int i = 0; i < size; i++)
                {
                    pole[1, i] = new Pawn(false, g, 1, i);
                }
                for (int i = 0; i < size; i++)
                {
                    pole[6, i] = new Pawn(true, g, 6, i);
                }
                pole[7, 0] = new Rook(true, g, 7, 0);
                pole[7, 1] = new Knight(true, g, 7, 1);
                pole[7, 2] = new Bishop(true, g, 7, 2);
                pole[7, 3] = new Queen(true, g, 7, 3);
                pole[7, 4] = new King(true, g, 7, 4);
                pole[7, 5] = new Bishop(true, g, 7, 5);
                pole[7, 6] = new Knight(true, g, 7, 6);
                pole[7, 7] = new Rook(true, g, 7, 7);
            }
        }

        class Figure
        {
            int x;
            int y;
            public void Drw_w(Image i, Graphics g, int x, int y)
            {
                this.x = x;
                this.y = y;
                g.DrawImage(i, new Rectangle(100 + (30 * y), 100 + (30 * x), 30, 30));

            }
            public void Drw_b(Image i, Graphics g, int x, int y)
            {
                this.x = x;
                this.y = y;
                g.DrawImage(i, new Rectangle(100 + (30 * y), 100 + (30 * x), 30, 30));
            }
            public void Empty(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class Empty : Figure
        {
            public Empty(int x, int y)
            {
                Empty(x, y);
            }
        }

        class Pawn : Figure
        {
            Image p_w = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\pawn-white.png");
            Image p_b = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\pawn-black.png");
            public Pawn(bool color, Graphics g, int x, int y)
            {
                if (color == true)
                {
                    Drw_w(p_w, g, x, y);
                }
                if (color == false)
                {
                    Drw_b(p_b, g, x, y);
                }
            }
        }

        class Rook : Figure
        {
            Image r_w = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\rook-white.png");
            Image r_b = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\rook-white.png");
            public Rook(bool color, Graphics g, int x, int y)
            {
                if (color == true)
                {
                    Drw_w(r_w, g, x, y);
                }
                if (color == false)
                {
                    Drw_b(r_b, g, x, y);
                }
            }
        }

        class Knight : Figure
        {
            Image n_w = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\knight-white.png");
            Image n_b = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\knight-white.png");
            public Knight(bool color, Graphics g, int x, int y)
            {
                if (color == true)
                {
                    Drw_w(n_w, g, x, y);
                }
                if (color == false)
                {
                    Drw_b(n_b, g, x, y);
                }
            }
        }

        class Bishop : Figure
        {
            Image b_w = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\bishop-white.png");
            Image b_b = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\bishop-white.png");
            public Bishop(bool color, Graphics g, int x, int y)
            {
                if (color == true)
                {
                    Drw_w(b_w, g, x, y);
                }
                if (color == false)
                {
                    Drw_b(b_b, g, x, y);
                }
            }
        }

        class Queen : Figure
        {
            Image q_w = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\queen-white.png");
            Image q_b = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\queen-white.png");
            public Queen(bool color, Graphics g, int x, int y)
            {
                if (color == true)
                {
                    Drw_w(q_w, g, x, y);
                }
                if (color == false)
                {
                    Drw_b(q_b, g, x, y);
                }
            }
        }

        class King : Figure
        {
            Image k_w = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\king-white.png");
            Image k_b = Image.FromFile(@"D:\Visual Studio Projects\WindowsFormsHomework\WindowsFormsHomework\assets\king-white.png");
            public King(bool color, Graphics g, int x, int y)
            {
                if (color == true)
                {
                    Drw_w(k_w, g, x, y);
                }
                if (color == false)
                {
                    Drw_b(k_b, g, x, y);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Board b = new Board(g);
        }

    }
}

