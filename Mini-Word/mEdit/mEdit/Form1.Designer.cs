namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamToolStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчетИМТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ParamToolStripToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.рассчетИМТToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCreateToolStripMenuItem,
            this.FileOpenToolStripMenuItem,
            this.FileSaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.печатьToolStripMenuItem,
            this.toolStripSeparator3,
            this.FileExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // FileCreateToolStripMenuItem
            // 
            this.FileCreateToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.create;
            this.FileCreateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FileCreateToolStripMenuItem.Name = "FileCreateToolStripMenuItem";
            this.FileCreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.FileCreateToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.FileCreateToolStripMenuItem.Text = "Создать";
            this.FileCreateToolStripMenuItem.Click += new System.EventHandler(this.FileCreateToolStripMenuItem_Click);
            // 
            // FileOpenToolStripMenuItem
            // 
            this.FileOpenToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.open;
            this.FileOpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FileOpenToolStripMenuItem.Name = "FileOpenToolStripMenuItem";
            this.FileOpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.FileOpenToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.FileOpenToolStripMenuItem.Text = "Открыть ...";
            this.FileOpenToolStripMenuItem.Click += new System.EventHandler(this.FileOpenToolStripMenuItem_Click);
            // 
            // FileSaveToolStripMenuItem
            // 
            this.FileSaveToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.save;
            this.FileSaveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FileSaveToolStripMenuItem.Name = "FileSaveToolStripMenuItem";
            this.FileSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.FileSaveToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.FileSaveToolStripMenuItem.Text = "Сохранить";
            this.FileSaveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.print_t;
            this.печатьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.печатьToolStripMenuItem.Text = "Печать ...";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // FileExitToolStripMenuItem
            // 
            this.FileExitToolStripMenuItem.Name = "FileExitToolStripMenuItem";
            this.FileExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.FileExitToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.FileExitToolStripMenuItem.Text = "Выход";
            this.FileExitToolStripMenuItem.Click += new System.EventHandler(this.FileExitToolStripMenuItem_Click);
            // 
            // ParamToolStripToolStripMenuItem
            // 
            this.ParamToolStripToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParamToolStripMenuItem,
            this.ParamFontToolStripMenuItem,
            this.цветШрифтаToolStripMenuItem});
            this.ParamToolStripToolStripMenuItem.Name = "ParamToolStripToolStripMenuItem";
            this.ParamToolStripToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ParamToolStripToolStripMenuItem.Text = "Параметры";
            // 
            // ParamToolStripMenuItem
            // 
            this.ParamToolStripMenuItem.Checked = true;
            this.ParamToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParamToolStripMenuItem.Name = "ParamToolStripMenuItem";
            this.ParamToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ParamToolStripMenuItem.Text = "Панель инструментов";
            this.ParamToolStripMenuItem.Click += new System.EventHandler(this.ParamToolStripMenuItem_Click);
            // 
            // ParamFontToolStripMenuItem
            // 
            this.ParamFontToolStripMenuItem.Name = "ParamFontToolStripMenuItem";
            this.ParamFontToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ParamFontToolStripMenuItem.Text = "Шрифт ...";
            this.ParamFontToolStripMenuItem.Click += new System.EventHandler(this.ParamFontToolStripMenuItem_Click);
            // 
            // цветШрифтаToolStripMenuItem
            // 
            this.цветШрифтаToolStripMenuItem.Name = "цветШрифтаToolStripMenuItem";
            this.цветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.цветШрифтаToolStripMenuItem.Text = "Цвет шрифта";
            this.цветШрифтаToolStripMenuItem.Click += new System.EventHandler(this.цветШрифтаToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpHelpToolStripMenuItem,
            this.HelpAboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            // 
            // HelpHelpToolStripMenuItem
            // 
            this.HelpHelpToolStripMenuItem.Enabled = false;
            this.HelpHelpToolStripMenuItem.Name = "HelpHelpToolStripMenuItem";
            this.HelpHelpToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.HelpHelpToolStripMenuItem.Text = "Справка: MiniWord";
            // 
            // HelpAboutToolStripMenuItem
            // 
            this.HelpAboutToolStripMenuItem.Name = "HelpAboutToolStripMenuItem";
            this.HelpAboutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.HelpAboutToolStripMenuItem.Text = "О программе";
            this.HelpAboutToolStripMenuItem.Click += new System.EventHandler(this.оПрограммаToolStripMenuItem_Click);
            // 
            // рассчетИМТToolStripMenuItem
            // 
            this.рассчетИМТToolStripMenuItem.Name = "рассчетИМТToolStripMenuItem";
            this.рассчетИМТToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.рассчетИМТToolStripMenuItem.Text = "Рассчет ИМТ";
            this.рассчетИМТToolStripMenuItem.Click += new System.EventHandler(this.рассчетИМТToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripTextBox1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(637, 29);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(27, 26);
            this.toolStripButton2.Text = "Новый документ";
            this.toolStripButton2.Click += new System.EventHandler(this.FileCreateToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(27, 26);
            this.toolStripButton3.Text = "Открыть";
            this.toolStripButton3.Click += new System.EventHandler(this.FileOpenToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(27, 26);
            this.toolStripButton1.Text = "Сохранить";
            this.toolStripButton1.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(27, 26);
            this.toolStripButton4.Text = "Печать";
            this.toolStripButton4.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 29);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::WindowsFormsApplication1.Properties.Resources.pngwing_com;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 26);
            this.toolStripButton5.Text = "Найти";
            this.toolStripButton5.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(637, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 235);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 309);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniWord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamToolStripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem FileCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpHelpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem рассчетИМТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветШрифтаToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

