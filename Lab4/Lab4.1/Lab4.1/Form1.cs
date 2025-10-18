namespace Lab4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int COL = 7;
            string filePath = "D:\\projects\\GitHub\\software-design-principles\\Lab4\\Lab4.1\\Lab4.1\\info.txt";

            if (File.Exists(filePath))
            {
                string[] txt = File.ReadAllLines(filePath);
                string[,] array = new string[txt.Length, COL];

                for (int i = 0; i < txt.Length; i++)
                {
                    string[] parts = txt[i].Split(';');
                    for (int j = 0; j < COL && j < parts.Length; j++)
                    {
                        array[i, j] = parts[j];
                    }
                }

                using (StreamWriter sw = new StreamWriter("newFile.txt"))
                {
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (array[i, 6] == "Walt Disney")
                        {
                            for (int j = 0; j < COL; j++)
                            {
                                richTextBox1.AppendText(array[i, j]);
                                sw.Write(array[i, j]);

                                if (j < COL - 1)
                                {
                                    sw.Write("; ");
                                    richTextBox1.AppendText("; ");
                                }
                            }
                            sw.WriteLine();
                            richTextBox1.AppendText("\n");
                        }
                    }
                }

                MessageBox.Show("File created and saved.");
            }
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    const int COL = 8;
        //    string filePath = @"D:\\projects\\GitHub\\software-design-principles\\Lab4\\Lab4.1\\Lab4.1\\info.txt";

        //    try
        //    {
        //        if (File.Exists(filePath))
        //        {
        //            string[] txt = File.ReadAllLines(filePath);
        //            //richTextBox1.Text = txt;
        //            string[,] array = new string[txt.Length, COL];
        //            for(int i = 0; i < txt.Length; i++)
        //            {
        //                string[] parts = txt[i].Split(';');
        //                for(int j = 0; j < COL && j < parts.Length; j++)
        //                {
        //                    array[i, j] = parts[j];
        //                }
        //            }

        //            using (StreamWriter sw = new StreamWriter("newFile.txt"))
        //            {
        //                for(int i = 0; i < txt.Length; i++)
        //                {
        //                    if (array[i, 7] == "Walt Disney")
        //                    {
        //                        for (int j = 0; j < COL; j++)
        //                        {
        //                            richTextBox1.Text += array[i, j];
        //                            sw.Write(array[i, j]);
        //                        if (j < COL - 1)
        //                        {
        //                            sw.Write("; ");
        //                                richTextBox1.Text += "; ";
        //                        }

        //                        }
        //                    }
        //                }
        //                MessageBox.Show("File created and saved.");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("File not found: " + filePath);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error reading file: " + ex.Message);
        //    }
        //}


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
