namespace EdPractic_Alex
{
    partial class PinDirector
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 129);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 29;
            label3.Text = "Руководитель:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 28;
            label2.Text = "Подразделение:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(21, 26);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 27;
            label1.Text = "Номер:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(174, 24);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 26;
            textBox1.Text = " ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(174, 76);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(388, 23);
            comboBox2.TabIndex = 46;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(174, 131);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(388, 23);
            comboBox3.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 48;
            label4.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(174, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(388, 23);
            dateTimePicker1.TabIndex = 49;
            // 
            // button1
            // 
            button1.Location = new Point(351, 497);
            button1.Name = "button1";
            button1.Size = new Size(211, 35);
            button1.TabIndex = 53;
            button1.Text = "Сохранить данные";
            button1.UseVisualStyleBackColor = true;
            // 
            // PinDirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 544);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "PinDirector";
            Text = "Закрепление руководителя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}