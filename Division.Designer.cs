namespace EdPractic_Alex
{
    partial class Division
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox3 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(181, 19);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 29);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 22);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 1;
            label1.Text = "Код:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Название:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(20, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 3;
            label3.Text = "Короткое название:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(441, 244);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 4;
            label4.Text = "Код подразделения:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(20, 157);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 5;
            label5.Text = "Вид деятельности:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(20, 202);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 64);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(668, 29);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(651, 241);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 29);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(181, 154);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(669, 29);
            textBox5.TabIndex = 10;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(181, 199);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(249, 29);
            maskedTextBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(20, 415);
            button1.Name = "button1";
            button1.Size = new Size(200, 35);
            button1.TabIndex = 15;
            button1.Text = "В начало";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GoToStart;
            // 
            // button2
            // 
            button2.Location = new Point(230, 415);
            button2.Name = "button2";
            button2.Size = new Size(200, 35);
            button2.TabIndex = 16;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GoToPrevious;
            // 
            // button3
            // 
            button3.Location = new Point(20, 456);
            button3.Name = "button3";
            button3.Size = new Size(410, 35);
            button3.TabIndex = 17;
            button3.Text = "Сохранить данные";
            button3.UseVisualStyleBackColor = true;
            button3.Click += UpdateOrCreate;
            // 
            // button4
            // 
            button4.Location = new Point(441, 456);
            button4.Name = "button4";
            button4.Size = new Size(410, 35);
            button4.TabIndex = 20;
            button4.Text = "Удалить данные";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DeleteRow;
            // 
            // button5
            // 
            button5.Location = new Point(651, 415);
            button5.Name = "button5";
            button5.Size = new Size(200, 35);
            button5.TabIndex = 22;
            button5.Text = "В конец";
            button5.UseVisualStyleBackColor = true;
            button5.Click += GoToEnd;
            // 
            // button6
            // 
            button6.Location = new Point(441, 415);
            button6.Name = "button6";
            button6.Size = new Size(200, 35);
            button6.TabIndex = 21;
            button6.Text = "Вперед";
            button6.UseVisualStyleBackColor = true;
            button6.Click += GoToNext;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 109);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(668, 29);
            textBox3.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(20, 247);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 24;
            label7.Text = "Компания:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(181, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 29);
            comboBox1.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(441, 202);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(177, 21);
            label8.TabIndex = 26;
            label8.Text = "Дата назначения email:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(651, 196);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 27;
            // 
            // Division
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 504);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Division";
            Padding = new Padding(10);
            Text = "Подразделения";
            Load += Division_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox3;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}