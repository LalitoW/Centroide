using Centroide.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centroide
{

    public partial class Form1 : Form
    {
        private Canvas canvas;
        private PointF a, b, c, d;
        private float angle;

        static Bitmap bmp;
        static Graphics g;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            canvas = new Canvas(bmp);
            a = new PointF(0, 0);
            b = new PointF(0, 100);
            c = new PointF(100, 100);
            d = new PointF(100, 0);

            
            angle = float.Parse(textBoxRot.Text) / 57.2958f;
            if (angle != 0)
            {
                angle = 0;
            }

            Render(g);

        }

        public void Render(Graphics g)
        {
            g.Clear(Color.Transparent);
            g.DrawLine(Pens.Yellow, bmp.Width / 2, 0, bmp.Width / 2, bmp.Height);
            g.DrawLine(Pens.Yellow, 0, bmp.Height / 2, bmp.Width, bmp.Height / 2);
            RenderLine(a, b);
            RenderLine(b, c);
            RenderLine(c, d);
            RenderLine(d, a);
            pictureBox1.Invalidate();
        }

        

        private void RenderLine(PointF a, PointF b)
        {
            a = Translate(a, new PointF(-50, -50)); // centroide
            b = Translate(b, new PointF(-50, -50)); // centroide
            PointF c = Rotate(a);
            PointF d = Rotate(b);//*/
            c = TranslateToCenter(c);
            d = TranslateToCenter(d);
            c = Translate(c, new PointF(50, -50));
            d = Translate(d, new PointF(50, -50));
            g.DrawLine(Pens.Gray, c, d);
        }

        private PointF TranslateToCenter(PointF a)
        {
            //Esta funcion mueve el punto hacia el centro
            int Sx = (bmp.Width / 2); // origen central en x
            int Sy = (bmp.Height / 2); // origen central en y
            return new PointF(Sx + a.X, Sy - a.Y);
        }

        private PointF Translate(PointF a, PointF b)
        {
            //Esta funcion mueve un punto de un lugar a otro
            return new PointF(a.X + b.X, a.Y + b.Y);
        }

        private PointF Rotate(PointF a)
        {
            PointF b = new PointF();
            b.X = (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            b.Y = (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));
            return b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxX3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxX4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxY1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxY2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxY3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DrawButton_Click_1(object sender, EventArgs e)
        {
            a = new PointF (float.Parse(textBoxX1.Text), float.Parse(textBoxY1.Text));
            b = new PointF(float.Parse(textBoxX2.Text), float.Parse(textBoxY2.Text));
            c = new PointF(float.Parse(textBoxX3.Text), float.Parse(textBoxY3.Text));
            d = new PointF(float.Parse(textBoxX4.Text), float.Parse(textBoxY4.Text));

            Render(g);
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {

            angle = float.Parse(textBoxRot.Text) / 57.2958f;

            Render(g);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void RSTButton_Click(object sender, EventArgs e)
        {
            a = new PointF(0, 0);
            b = new PointF(0, 100);
            c = new PointF(100, 100);
            d = new PointF(100, 0);


            angle = float.Parse(textBoxRot.Text) / 57.2958f;
            if (angle != 0)
            {
                angle = 0;
            }

            Render(g);
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            float scale = float.Parse(SizeBox.Text);

            a = new PointF(a.X * scale, a.Y * scale);
            b = new PointF(b.X * scale, b.Y * scale);
            c = new PointF(c.X * scale, c.Y * scale);
            d = new PointF(d.X * scale, d.Y * scale);

            /* origen central en y
            a = new PointF(CentreX + float.Parse(textBoxX1.Text), CentreY + float.Parse(textBoxY1.Text));
            b = new PointF(CentreX + float.Parse(textBoxX2.Text), CentreY + float.Parse(textBoxY2.Text));
            c = new PointF(CentreX + float.Parse(textBoxX3.Text), CentreY + float.Parse(textBoxY3.Text));
            d = new PointF(CentreX + float.Parse(textBoxX4.Text), CentreY + float.Parse(textBoxY4.Text));
            */
            Render(g);
        }

        private void SizeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            a = new PointF(a.X, a.Y + 1);
            b = new PointF(b.X, b.Y + 1);
            c = new PointF(c.X, c.Y + 1);
            d = new PointF(d.X, d.Y + 1);

            Render(g);

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            a = new PointF(a.X, a.Y - 1);
            b = new PointF(b.X, b.Y - 1);
            c = new PointF(c.X, c.Y - 1);
            d = new PointF(d.X, d.Y - 1);

            Render(g);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            a = new PointF(a.X - 1, a.Y);
            b = new PointF(b.X - 1, b.Y);
            c = new PointF(c.X - 1, c.Y);
            d = new PointF(d.X - 1, d.Y);

            Render(g);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            a = new PointF(a.X + 1, a.Y);
            b = new PointF(b.X + 1, b.Y);
            c = new PointF(c.X + 1, c.Y);
            d = new PointF(d.X + 1, d.Y);

            Render(g);
        }

        private void buttonCentre_Click(object sender, EventArgs e)
        {
            
            a = new PointF((a.X / 2) - a.X, (a.Y / 2) - a.Y);
            b = new PointF((b.X / 2) - b.X, (b.Y / 2) - b.Y);
            c = new PointF((c.X / 2) - c.X, (c.Y / 2) - c.Y);
            d = new PointF((d.X / 2) - d.X, (d.Y / 2) - d.Y);

            Render(g);
        }

        private void textBoxY4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
