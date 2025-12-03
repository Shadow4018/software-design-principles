namespace Lab5._3
{
    partial class Form1
    {
        /// <summary>
        /// Обов’язковий метод для підтримки конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищення ресурсів.
        /// </summary>
        /// <param name="disposing">true, якщо потрібно звільнити керовані ресурси; інакше — false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований Windows Form Designer

        private void InitializeComponent()
        {
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(209, 343);
            button1.Name = "button1";
            button1.Size = new Size(135, 35);
            button1.TabIndex = 6;
            button1.Text = "Створити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(396, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(365, 477);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(183, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(183, 254);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(183, 310);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(187, 27);
            textBox6.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 47);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 14;
            label1.Text = "Сторона а";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 97);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 15;
            label2.Text = "Сторона b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 149);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 16;
            label3.Text = "Сторона с";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 202);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 17;
            label4.Text = "Сторона d";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 257);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 18;
            label5.Text = "Сторона e";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 313);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 19;
            label6.Text = "Сторона f";
            // 
            // button2
            // 
            button2.Location = new Point(209, 384);
            button2.Name = "button2";
            button2.Size = new Size(135, 35);
            button2.TabIndex = 20;
            button2.Text = "Оновити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Lab 5.3 — Геометричні фігури";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}
