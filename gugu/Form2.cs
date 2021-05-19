using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gugu
{
    public partial class Form2 : Form
    {
        public enum TypeFigure
        {
            Null,
            Rectangle,
            Circle,
            Line,
            Triangle
        }

        TypeFigure fig = TypeFigure.Null;
        Graphics paper;
        Pen pen;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fig = TypeFigure.Circle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Rec(object sender, EventArgs e)
        {
            fig = TypeFigure.Rectangle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fig = TypeFigure.Line;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fig = TypeFigure.Triangle;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (fig != TypeFigure.Null)
            {
                Draw(e);
            }
        }

        private void Draw(MouseEventArgs data)
        {
            paper = panel1.CreateGraphics();
            pen = new Pen(Color.Pink, 5);

            switch (fig)
            {
                case TypeFigure.Circle:
                    paper.DrawEllipse(pen, data.X, data.Y, 50, 50);
                    break;
                case TypeFigure.Rectangle:
                    paper.DrawRectangle(pen, data.X, data.Y, 100, 100);
                    break;
                case TypeFigure.Line:
                    paper.DrawLine(pen, data.X, data.Y, data.X + 100, data.Y + 100);
                    break;
                case TypeFigure.Triangle:
                    paper.DrawLine(pen, data.X, data.Y, data.X + 51, data.Y + 51);
                    paper.DrawLine(pen, data.X, data.Y, data.X - 51, data.Y + 51);
                    paper.DrawLine(pen, data.X - 51, data.Y + 51, data.X + 51, data.Y + 51);
                    break;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
