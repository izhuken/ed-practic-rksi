﻿namespace EdPractic_Alex
{
    partial class Director
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
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(179, 115);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(668, 23);
            textBox3.TabIndex = 41;
            // 
            // button5
            // 
            button5.Location = new Point(644, 455);
            button5.Name = "button5";
            button5.Size = new Size(200, 35);
            button5.TabIndex = 40;
            button5.Text = "В конец";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(434, 455);
            button6.Name = "button6";
            button6.Size = new Size(200, 35);
            button6.TabIndex = 39;
            button6.Text = "Вперед";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(434, 496);
            button4.Name = "button4";
            button4.Size = new Size(410, 35);
            button4.TabIndex = 38;
            button4.Text = "Удалить данные";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(13, 496);
            button3.Name = "button3";
            button3.Size = new Size(410, 35);
            button3.TabIndex = 37;
            button3.Text = "Сохранить данные";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(223, 455);
            button2.Name = "button2";
            button2.Size = new Size(200, 35);
            button2.TabIndex = 36;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 455);
            button1.Name = "button1";
            button1.Size = new Size(200, 35);
            button1.TabIndex = 35;
            button1.Text = "В начало";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(181, 70);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(668, 23);
            textBox2.TabIndex = 31;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(20, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 28;
            label4.Text = "Подразделение:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(20, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 27;
            label3.Text = "Должность:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 26;
            label2.Text = "ФИО:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 23);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 25;
            label1.Text = "Код:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(181, 25);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(179, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(668, 23);
            comboBox1.TabIndex = 42;
            // 
            // Director
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 544);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Director";
            Padding = new Padding(10);
            Text = "Director";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}