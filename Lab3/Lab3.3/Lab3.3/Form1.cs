using System.Threading.Tasks.Dataflow;

namespace Lab3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBox textBox1 = this.richTextBox1;
            string input = textBox1.Text;
            string[] words = input.Split(',', '.', ' ');

            RichTextBox textBox2 = this.richTextBox2;
            string input2 = textBox2.Text;
            string[] words2 = input2.Split('.', ' ', ',');

            string message = "";
            string origMessage = "";

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words2.Length; j++)
                {
                    if(words[i] == words2[j])
                    {
                        words2[j] = "";
                    }
                }
            }

            for (int i = 0; i < words2.Length; i++) {
                message += words2[i] + " ";
            }

            label3.Text = "Текст без повторюваних слів: " + string.Join(", ", message);
        }
    }
}
