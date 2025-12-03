using System.IO;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace Lab5._1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string _title = textBox1.Text;
            //string _author = textBox2.Text;
            //int _year = int.Parse(textBox3.Text);
            //string _country = textBox4.Text;
            //int _time = int.Parse(textBox5.Text);
            //int _cost = int.Parse(textBox6.Text);
            //int _income = int.Parse(textBox7.Text);

            Film film = new Film();
            film.Title = textBox1.Text;
            film.Author = textBox2.Text;
            film.Year = int.Parse(textBox3.Text);
            film.Country = textBox4.Text;
            film.Time = int.Parse(textBox5.Text);
            film.Cost = int.Parse(textBox6.Text);
            film.Income = int.Parse(textBox7.Text);
            //MessageBox.Show($"textBox6 містить: '{textBox6.Text}'");

            using (StreamWriter sw = new StreamWriter("newFile.txt"))
            {
                sw.WriteLine($"{film.Title};{film.Author};{film.Year};{film.Country};{film.Time};{film.Cost};{film.Income};");
            }
            MessageBox.Show("Записано");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Cost = int.Parse(textBox6.Text);
            film.Income = int.Parse(textBox7.Text);
            film.calculateIncome();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Year = int.Parse(textBox3.Text);
            film.howOld();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Time = int.Parse(textBox5.Text);
            film.isLong();
        }

        public class Film
        {
            private string title;
            private string author;
            private int year;
            private string country;
            private int time;
            private int cost;
            private int income;

            public Film()
            {
                this.title = "Unknown";
                this.author = "Unknown";
                this.year = 0;
                this.country = "Unknown";
                this.time = 0;
                this.cost = 0;
                this.income = 0;
            }

            //public void writeInto()
            //{
            //    StreamWriter sw = new StreamWriter("ingo.txt");
            //    sw.Write(title);
            //    sw.Write(author);
            //    sw.Write(year);
            //    sw.Write(country);
            //    sw.Write(time);
            //    sw.Write(cost);
            //    sw.Write(income);
            //    sw.Close();
            //}

            public void calculateIncome()
            {
                int profit = Income - Cost;
                MessageBox.Show($"Прибуток фільму: {profit}");
            }


            public void howOld()
            {
                int currentYear = DateTime.Now.Year;
                int result = currentYear - Year;
                MessageBox.Show($"{result}");
            }

            public void isLong()
            {
                if( Time <= 1)
                {
                    MessageBox.Show("No");
                }
                else
                {
                    MessageBox.Show("Yes");
                }
            }
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public string Country { get; set; }
            public int Time { get; set; }
            public int Cost { get; set; }
            public int Income { get; set; }
        }


    }
}
