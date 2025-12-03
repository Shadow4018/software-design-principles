using System;
using System.Configuration;

namespace Lab5._3
{
    public partial class Form1 : Form
    {
        private Triangle triangle;
        private Square square;
        private RectangularTriangle rectTr;

        public Form1()
        {
            InitializeComponent();
        }

        public double ran()
        {
            Random random = new Random();
            double value = random.Next(1, 20);
            return value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            double ee = double.Parse(textBox5.Text);
            double f = double.Parse(textBox6.Text);
            triangle = new Triangle(a, b, c);
            square = new Square(a, b, c, d, ee, f);
            rectTr = new RectangularTriangle(a, b, c);

            richTextBox1.Text = $"{triangle.info()}\n\n{square.info()}\n\n{rectTr.info()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (triangle == null || square == null || rectTr == null)
            {
                MessageBox.Show("Спершу створіть об'єкти кнопкою 'Створити'");
                return;
            }

            triangle = new Triangle(double.Parse(textBox1.Text),
                                    double.Parse(textBox2.Text),
                                    double.Parse(textBox3.Text));

            square = new Square(double.Parse(textBox1.Text),
                                double.Parse(textBox2.Text),
                                double.Parse(textBox3.Text),
                                double.Parse(textBox4.Text),
                                double.Parse(textBox5.Text),
                                double.Parse(textBox6.Text));

            rectTr = new RectangularTriangle(double.Parse(textBox1.Text),
                                             double.Parse(textBox2.Text),
                                             double.Parse(textBox3.Text));

            richTextBox1.Text = $"{triangle.info()}\n\n{square.info()}\n\n{rectTr.info()}";
        }



        public class Triangle
        {
            private double a;
            private double b;
            private double c;

            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            virtual public double findP()
            {
                return a + b + c;
            }

            virtual public double findS()
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

            virtual public string info()
            {
                return $"Інфо про Трикутник:\nДовжина сторін:\nA = {a}\nB = {b}\n C = {c}\n" +
                    $"Його P = {findP()}\nЙого S = {findS()}";
            }

            public double getA()
            {
                return a;
            }

            public double getB()
            {
                return b;
            }
            public double getC()
            {
                return c;
            }
        }

        public class Square : Triangle
        {
            private double d;
            private double e;
            private double f;

            public Square(double a, double b, double c, double d, double e, double f) : base(a, b, c)
            {
                this.d = d;
                this.e = e;
                this.f = f;
            }

            public override double findP()
            {
                return getA() + getB() + getC() + d;
            }

            public override double findS()
            {
                double first = (4 * Math.Pow(e, 2) * (Math.Pow(f, 2)));
                double second = Math.Pow(Math.Pow(getB(), 2) + Math.Pow(d, 2) - Math.Pow(getA(), 2) - Math.Pow(getC(), 2), 2);
                return Math.Sqrt((first - second) / 16);
            }

            public override string info()
            {
                return $"Інформація про прямоктуний трикутник:\nДовжина сторін:\nA = {getA()}\nB = {getB()}\n C = {getC()}\nD = {d}\nE = {e}\nF = {f}\n" +
                    $"Його P = {findP()}\nЙого S = {findS()}";
            }
        }

        public class RectangularTriangle : Triangle
        {
            public RectangularTriangle(double a, double b, double c) : base(a, b, c)
            { }

            public override double findP()
            {
                return getA() + getB() + getC();
            }

            public override double findS()
            {
                return (getA() * getB()) / 2;
            }
        }
    }
}
