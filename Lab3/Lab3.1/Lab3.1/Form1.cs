namespace Lab3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            char[] ch = input.ToCharArray();
            int count = 0;
            bool flag = false;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'b' && flag == false)
                {
                    count++;
                    flag = true;
                }
                if(ch[i] == ' ' && flag == true)
                {
                    flag = false;
                }
            }
            label2.Text = "Кількість слів на б: " + count;
        }
    }
}
