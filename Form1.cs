using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private double pix = 37.936;
        private double visibleSize = 0;

        public Form1()
        {
            InitializeComponent();

            double radius = (double)numericUpDown1.Value * pix;
            paintFigure(radius / pix);
            calcS(radius / pix);
            visibleSize = radius / pix;

            Logic l = new Logic();
            SPolygon.Text = l.SPolygon(2343434343) + " ";
        }

        private void paintFigure(double sideCm)
        {
            visibleSize = sideCm;
            labelSize.Text = "масштаб " + Math.Round(sideCm, 3) + " см." ;
            var sidePx = sideCm * pix;
             

            Bitmap polygon = new Bitmap(picCanvas.Width,
                picCanvas.Height);


            using (Graphics g = Graphics.FromImage(polygon))
            {

                var width = picCanvas.Width;
                var height = picCanvas.Height;

                int angle = 0;

                Pen pen = new Pen(Color.Black, 4);
                Point center = new Point((int)sidePx, (int)sidePx);
                Point[] verticies = CalculateVertices(sidePx, angle, center, 6);

                SolidBrush solidBrush = new SolidBrush(Color.LightYellow);
                SolidBrush br = solidBrush;

                //draw
                g.DrawPolygon(pen, verticies);
                g.FillPolygon(br, verticies);

                pen = new Pen(Color.Red, 0);
                br = new SolidBrush(Color.Red);
                Point[] verticies2 = CalculateVertices(sidePx - verticies[2].Y, 30, center, 3);
                g.DrawPolygon(pen, verticies2);
                g.FillPolygon(br, verticies2);

                Point[] verticies3 = CalculateVertices(sidePx - verticies[2].Y, 90, center, 3);
                g.DrawPolygon(pen, verticies3);
                g.FillPolygon(br, verticies3);
            }
            picCanvas.Image = polygon;

           
        }

        private void calcS(double sideCm)
        {

            Logic logic = new Logic();

            var SYellowArea = logic.calcS(sideCm);
            if (SYellowArea > 0)
            {
                var SPolygon = logic.SPolygon(sideCm);
                var triangleSide = logic.findBottomSideOfRightTrapecia(sideCm, sideCm / 2, 60);
                var sDavidStar = logic.SdavidStar(triangleSide);


                labelStarR.Text = sDavidStar.ToString();
                SPolygonR.Text = SPolygon.ToString();
                labelSYellowAreaR.Text = SYellowArea.ToString();

                numericUpDown1.Text = sideCm.ToString();
            }
            else
            {
                MessageBox.Show(logic.getErrorMsg(), "Ошибка", MessageBoxButtons.OKCancel);
            }
        }


        private Point[] CalculateVertices(double side, int startingAngle, Point center, int vertices)
        {
            List<Point> points = new List<Point>();
            float step = 360.0f / vertices;
            float angle = startingAngle;
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //go in a circle
            {
                Point xy = new Point();
                double radians = angle * Math.PI / 180.0;
                xy.X = (int)(Math.Cos(radians) * side + center.X);
                xy.Y = (int)(Math.Sin(-radians) * side + center.Y);
                points.Add(xy);
                angle += step;
            }
            return points.ToArray();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double cmRadius = (double)(numericUpDown1.Value);

            if (cmRadius > 0 && cmRadius < 15)
            {
                visibleSize = cmRadius;
                paintFigure(cmRadius);
                calcS(cmRadius);
            }
            else
            {

                if (cmRadius <= 0) numericUpDown1.Value = 1;
                else numericUpDown1.Value = (decimal)14.999;

                MessageBox.Show("сторона многоугольника должна быть > 0 и < 15", "Ошибка", MessageBoxButtons.OKCancel);
            }

        }

   
    private void Form1_ResizeEnd(object sender, EventArgs e)
    {
        var goodSize = picCanvas.Width < picCanvas.Height ? picCanvas.Width : picCanvas.Height;
        var radius = goodSize / 2;
        paintFigure(radius / pix);
    }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void buttonDecrease_Click(object sender, EventArgs e)
        {

            var decreaseOn = Convert.ToDouble(textBox1.Text);
            var decr = visibleSize - decreaseOn;

            if (decr > 0)
            {
                paintFigure(decr);
               // numericUpDown1.Value = decr;
            }
            else
            {
                MessageBox.Show("сторона многоугольника должна быть > 0 ", "Ошибка", MessageBoxButtons.OKCancel);

            }
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {

            var increaseOn = Convert.ToDouble(textBox1.Text);
            var incr = visibleSize + increaseOn;

            if (incr < 15)
            {
                paintFigure(incr);
                //numericUpDown1.Value = incr;
            }
            else
            {
                MessageBox.Show("сторона многоугольника должна быть < 15 ", "Ошибка", MessageBoxButtons.OKCancel);
            }

        }
    }
}

