namespace EdPractic_Alex
{
    partial class Report
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(840, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Формирование списков";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 99);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 9;
            label2.Text = "до:";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(631, 95);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(137, 23);
            dateTimePicker4.TabIndex = 8;
            dateTimePicker4.ValueChanged += DivisionMaxDirectorTurnoverRangeOnChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 99);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 7;
            label1.Text = "от:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(455, 95);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(137, 23);
            dateTimePicker3.TabIndex = 6;
            dateTimePicker3.ValueChanged += DivisionMaxDirectorTurnoverRangeOnChange;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(455, 66);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(137, 23);
            dateTimePicker2.TabIndex = 5;
            dateTimePicker2.ValueChanged += DivisionNullableEmailsDateOnChange;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(455, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += DivisionPhonesDateOnChange;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 99);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(396, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "название подразделения с самой большой текчкой руководителей";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += ShowDivisionMaxDirectorTurnover;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 70);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(222, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "количество предприятий без E-mail";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += ShowDivisionNullableEmails;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(202, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "список телефонов предприятий";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += ShowDivisionPhones;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(840, 371);
            dataGridView1.TabIndex = 0;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 544);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Report";
            Text = "Формирование отчетов";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private DateTimePicker dateTimePicker4;
        private Label label1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
    }
}