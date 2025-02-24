namespace EdPractic_Alex
{
    partial class PinPhone
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
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(345, 496);
            button3.Name = "button3";
            button3.Size = new Size(211, 35);
            button3.TabIndex = 25;
            button3.Text = "Сохранить данные";
            button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(418, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(138, 23);
            dateTimePicker1.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(345, 114);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 56;
            label4.Text = "Дата:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(190, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(366, 23);
            comboBox2.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(20, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 53;
            label3.Text = "Телефон:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 52;
            label2.Text = "Подразделение:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 22);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 51;
            label1.Text = "Номер:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(190, 24);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 23);
            textBox1.TabIndex = 50;
            textBox1.Text = " ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(101, 119);
            maskedTextBox1.Mask = "8 (999) 999-99-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(107, 23);
            maskedTextBox1.TabIndex = 58;
            // 
            // PinPhone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 544);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Name = "PinPhone";
            Padding = new Padding(10);
            Text = "Закрепление телефона";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
    }
}