namespace EdPractic_Alex
{
    partial class PhonePinningHistory
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
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(275, 398);
            button2.Name = "button2";
            button2.Size = new Size(250, 40);
            button2.TabIndex = 5;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateRow;
            // 
            // button1
            // 
            button1.Location = new Point(538, 398);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 4;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DeleteRow;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 380);
            dataGridView1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(12, 398);
            button3.Name = "button3";
            button3.Size = new Size(250, 40);
            button3.TabIndex = 6;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CreateNewRow;
            // 
            // PhonePinningHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "PhonePinningHistory";
            Text = "Журнал прикреплений телефонов";
            Load += PhonePinningHistory_Load;
            Activated += PhonePinningHistoryActivated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
    }
}