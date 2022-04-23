using System;
using System.Drawing;
using ClassLibrary_lab2;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // имя файла
        private string fn = string.Empty;        
        private bool docChanged = false; // true - в текст внесены изменения
        string status="";

        public Form1()  //конструктор формы
        {
            InitializeComponent();

            textBox1.ScrollBars = RichTextBoxScrollBars.Vertical;  //только вертикальная прокрутка
            textBox1.Text = string.Empty;               //очистить текст

            this.Text = "MiniWord - Новый документ";      //заголовок формы

            // отобразить панель инструментов
            toolStrip1.Visible = true;
            ParamToolStripMenuItem.Checked = true;  //установить галочку на данном пункте меню (Панель инструментов)

            // назначаем файл справки
   //         helpProvider1.HelpNamespace = "m_edit.chm";

            // настройка компонента openDialog1
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "текст|*.txt";
            openFileDialog1.Title = "Открыть документ";
            openFileDialog1.Multiselect = false;

            // настройка компонента saveDialog1
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "текст|*.txt";
            saveFileDialog1.Title = "Сохранить документ";
        }

        // открывает документ
        private void OpenDocument()
        {
            openFileDialog1.FileName = string.Empty;
            
            // отобразить диалог Открыть
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;

                // отобразить имя файла в заголовке окна
                this.Text = fn;

                try
                {
                    textBox1.Text=TextFile.OpenFile(fn).Content;
                    // считываем данные из файла
                    
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка чтения файла.\n" +
                        exc.ToString(), "MiniWord",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // сохранить документ
        private int SaveDocument()
        {
            status = "Сохранение документа";
            statusStrip1.Items[2].Text = "Состояние: " + status;

            int result = 0;
    
            if (fn == string.Empty|| fn == "Новый документ")
            {
                 // отобразить диалог Сохранить
                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                      // отобразить имя файла в заголовке окна
                      fn = saveFileDialog1.FileName;
                      this.Text = fn;
                 }
                 else result = -1;

            }

            // сохранить файл
            if (fn != string.Empty)
            {
                 try
                 {
                    TextFile.SaveFile(textBox1.Text ,fn);
                 }
                 catch (Exception exc)
                 {
                     MessageBox.Show(exc.ToString(), "MiniWord",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                 }
            }
            

            statusStrip1.Items[2].Text = "Состояние: ";
            return result;
        }
        
        // выбор в меню Файл команды Создать
        private void FileCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Создание документа";
            statusStrip1.Items[2].Text = "Состояние: " + status;


            fn = "Новый документ";

            // отобразить имя файла в заголовке окна
            this.Text = fn;

            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show("Сохранить изменения ?", "NkEdit",
                                      MessageBoxButtons.YesNoCancel,
                                      MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        
                        if (SaveDocument() == 0)
                        {
                            textBox1.Clear();
                            docChanged = false;
                        }
                        break;
                    case DialogResult.No:
                        textBox1.Clear();
                        docChanged = false;
                        break;
                    case DialogResult.Cancel:                        
                        break;
                }
            }

            statusStrip1.Items[2].Text = "Состояние: ";
        }

        // выбор в меню Файл команды Открыть
        private void FileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Открытие документа";
            statusStrip1.Items[2].Text = "Состояние: " + status;

            OpenDocument();

            statusStrip1.Items[2].Text = "Состояние: ";
        }

        // выбор в меню Файл команды Сохранить
        private void FileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            SaveDocument();
        }

        // выбор в меню Файл команды Выход
        private void FileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // выбор в меню Параметры команды Панель инструментов
        private void ParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // отобразить/скрыть панель инструментов
            toolStrip1.Visible = ! toolStrip1.Visible;
            ParamToolStripMenuItem.Checked = ! ParamToolStripMenuItem.Checked;
        }

        // выбор в меню Параметры команды Шрифт
        private void ParamFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Выбор шрифта";
            statusStrip1.Items[2].Text = "Состояние: " + status;

            fontDialog1.Font = textBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.SelectionFont = fontDialog1.Font;
            }

            statusStrip1.Items[2].Text = "Состояние: ";
        }

        //обработка события TextChanged
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            docChanged = true;
            int len = textBox1.Text.Length; // кол-во символов в поле редактирования 
            
            // в поле toolStripStatusLabel2 показать
            // кол-во символов, введенных в поле редактирования
            statusStrip1.Items[0].Text = "Число знаков: " + len.ToString("D");
            int lines = textBox1.Lines.Length;            
            statusStrip1.Items[1].Text = "Число строк: " + lines.ToString("D");
            statusStrip1.Items[2].Text = "Число слов: " + TextFile.CountWords(textBox1.Text);
            status = "Редактирование документа";
            statusStrip1.Items[3].Text = "Состояние: " + status;    
        }

        // пользователь сделал щелчок на кнопке "Закрыть окно"
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (docChanged )
            {
                DialogResult dr;
                dr = MessageBox.Show("Сохранить изменения?", "NkEdit",
                                      MessageBoxButtons.YesNoCancel,
                                      MessageBoxIcon.Warning);
                switch ( dr )
                {
                    case DialogResult.Yes :
                        status = "Сохранение документа";
                        if ( SaveDocument() != 0)
                            // пользователь отменил операцию сохранения файла 
                            e.Cancel = true; // отменить закрытие окна программы 
                         break;
                    case DialogResult.No: ;
                         break;
                    case DialogResult.Cancel:
                         // отменить закрытие окна программы  
                         e.Cancel = true;
                         break; 
                }
            }
        }

        // выбор в меню Справка команды О программе
        private void оПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Справка о программе";
            statusStrip1.Items[2].Text = "Состояние: " + status;

            Form2 about = new Form2();
            about.ShowDialog();
            statusStrip1.Items[2].Text = "Состояние: ";
        }

        // выбор в меню Файл команды Печать
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Печать документа";
            statusStrip1.Items[2].Text = "Состояние: " + status;

            statusStrip1.Items[2].Text = "Состояние: ";

            TextFile txt = new TextFile(fn,textBox1.Text,textBox1.Font);

            DialogResult dr;
            dr = printDialog1.ShowDialog();
            
            switch (dr)
            {
                case DialogResult.OK: TextFile.FileToPrinter(txt,printDialog1.PrinterSettings.Copies);break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void рассчетИМТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = "Выполнение метода ИМТ";
            statusStrip1.Items[2].Text = "Состояние: " + status;

            statusStrip1.Items[2].Text = "Состояние: ";

            TextFile txt = new TextFile(fn, textBox1.Text, textBox1.Font);
            
            MessageBox.Show($"{TextFile.Method(txt)}","ИМТ");
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.Color = textBox1.ForeColor;         
           
            if (colorDialog1.ShowDialog() == DialogResult.OK)    
                textBox1.SelectionColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = TextFile.searchInText(textBox1.Text, toolStripTextBox1.Text);

            

            for (int i = 0; i < words.Length; i++)
            {
                    textBox1.Select(textBox1.Text.IndexOf(words[i]), words[i].Length);
                    textBox1.SelectionBackColor = Color.Yellow;
            }
            textBox1.SelectionBackColor = SystemColors.Window;

        }
    }
}
