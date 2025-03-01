namespace EdPractic_Alex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            asdfToolStripMenuItem = new ToolStripMenuItem();
            предприятиеToolStripMenuItem = new ToolStripMenuItem();
            подразделениеToolStripMenuItem = new ToolStripMenuItem();
            руководительToolStripMenuItem = new ToolStripMenuItem();
            asdfToolStripMenuItem1 = new ToolStripMenuItem();
            закреплениеМестоположенияToolStripMenuItem = new ToolStripMenuItem();
            закреплениеТелефоновToolStripMenuItem = new ToolStripMenuItem();
            закреплениеРуководителяToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            сервисныеФункцииToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            logoPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { asdfToolStripMenuItem, asdfToolStripMenuItem1, отчетыToolStripMenuItem, сервисныеФункцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // asdfToolStripMenuItem
            // 
            asdfToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { предприятиеToolStripMenuItem, подразделениеToolStripMenuItem, руководительToolStripMenuItem });
            asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            asdfToolStripMenuItem.Size = new Size(68, 20);
            asdfToolStripMenuItem.Text = "Объекты";
            // 
            // предприятиеToolStripMenuItem
            // 
            предприятиеToolStripMenuItem.Name = "предприятиеToolStripMenuItem";
            предприятиеToolStripMenuItem.Size = new Size(159, 22);
            предприятиеToolStripMenuItem.Text = "Предприятие";
            предприятиеToolStripMenuItem.Click += OpenCompanyForm;
            // 
            // подразделениеToolStripMenuItem
            // 
            подразделениеToolStripMenuItem.Name = "подразделениеToolStripMenuItem";
            подразделениеToolStripMenuItem.Size = new Size(159, 22);
            подразделениеToolStripMenuItem.Text = "Подразделение";
            подразделениеToolStripMenuItem.Click += OpenDivisionForm;
            // 
            // руководительToolStripMenuItem
            // 
            руководительToolStripMenuItem.Name = "руководительToolStripMenuItem";
            руководительToolStripMenuItem.Size = new Size(159, 22);
            руководительToolStripMenuItem.Text = "Руководитель";
            руководительToolStripMenuItem.Click += OpenDirectorForm;
            // 
            // asdfToolStripMenuItem1
            // 
            asdfToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { закреплениеМестоположенияToolStripMenuItem, закреплениеТелефоновToolStripMenuItem, закреплениеРуководителяToolStripMenuItem });
            asdfToolStripMenuItem1.Name = "asdfToolStripMenuItem1";
            asdfToolStripMenuItem1.Size = new Size(75, 20);
            asdfToolStripMenuItem1.Text = "Операции";
            // 
            // закреплениеМестоположенияToolStripMenuItem
            // 
            закреплениеМестоположенияToolStripMenuItem.Name = "закреплениеМестоположенияToolStripMenuItem";
            закреплениеМестоположенияToolStripMenuItem.Size = new Size(245, 22);
            закреплениеМестоположенияToolStripMenuItem.Text = "Закрепление местоположения";
            закреплениеМестоположенияToolStripMenuItem.Click += OpenPlacementPinnigForm;
            // 
            // закреплениеТелефоновToolStripMenuItem
            // 
            закреплениеТелефоновToolStripMenuItem.Name = "закреплениеТелефоновToolStripMenuItem";
            закреплениеТелефоновToolStripMenuItem.Size = new Size(245, 22);
            закреплениеТелефоновToolStripMenuItem.Text = "Закрепление телефонов";
            закреплениеТелефоновToolStripMenuItem.Click += OpenPhonePinnigForm;
            // 
            // закреплениеРуководителяToolStripMenuItem
            // 
            закреплениеРуководителяToolStripMenuItem.Name = "закреплениеРуководителяToolStripMenuItem";
            закреплениеРуководителяToolStripMenuItem.Size = new Size(245, 22);
            закреплениеРуководителяToolStripMenuItem.Text = "Закрепление руководителя";
            закреплениеРуководителяToolStripMenuItem.Click += OpenDirectorPinnigForm;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            отчетыToolStripMenuItem.Click += OpenReportForm;
            // 
            // сервисныеФункцииToolStripMenuItem
            // 
            сервисныеФункцииToolStripMenuItem.Name = "сервисныеФункцииToolStripMenuItem";
            сервисныеФункцииToolStripMenuItem.Size = new Size(133, 20);
            сервисныеФункцииToolStripMenuItem.Text = "Сервисные функции";
            сервисныеФункцииToolStripMenuItem.Click += OpenAboutBoxForm;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "edi-logo.png");
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(0, 24);
            logoPictureBox.Margin = new Padding(4, 3, 4, 3);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(800, 385);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 13;
            logoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(logoPictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Справочник предприятия";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem asdfToolStripMenuItem;
        private ToolStripMenuItem asdfToolStripMenuItem1;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem сервисныеФункцииToolStripMenuItem;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox logoPictureBox;
        private ToolStripMenuItem предприятиеToolStripMenuItem;
        private ToolStripMenuItem подразделениеToolStripMenuItem;
        private ToolStripMenuItem руководительToolStripMenuItem;
        private ToolStripMenuItem закреплениеМестоположенияToolStripMenuItem;
        private ToolStripMenuItem закреплениеТелефоновToolStripMenuItem;
        private ToolStripMenuItem закреплениеРуководителяToolStripMenuItem;
    }
}
