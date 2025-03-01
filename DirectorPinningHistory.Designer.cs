namespace EdPractic_Alex
{
    partial class DirectorPinningHistory
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
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(12, 398);
            button3.Name = "button3";
            button3.Size = new Size(250, 40);
            button3.TabIndex = 14;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CreateNewRow;
            // 
            // button2
            // 
            button2.Location = new Point(275, 398);
            button2.Name = "button2";
            button2.Size = new Size(250, 40);
            button2.TabIndex = 13;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateRow;
            // 
            // button1
            // 
            button1.Location = new Point(538, 398);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 12;
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
            dataGridView1.TabIndex = 11;
            // 
            // DirectorPinningHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "DirectorPinningHistory";
            Text = "Журнал закрепления руководителей";
            Load += DirectorPinningHistory_Load;
            Activated += DirectorPinningHistoryActivated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}