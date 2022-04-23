using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // имя файла
        private string fn = string.Empty;
        
        private bool docChanged = false; // true - в текст внесены изменения

        public Form1()
        {
            InitializeComponent();

            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Text = string.Empty;

            this.Text = "NkEdit - Новый документ";

            // отобразить панель инструментов
            toolStrip1.Visible = true;
            ParamToolStripMenuItem.Checked = true;

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
            if (openFileDialog1.ShowDialog() ==
                                DialogResult.OK)
            {
                fn = openFileDialog1.FileName;

                // отобразить имя файла в заголовке окна
                this.Text = fn;

                try
                {
                    // считываем данные из файла
                    System.IO.StreamReader sr =
                        new System.IO.StreamReader(fn);

                    textBox1.Text = sr.ReadToEnd();
                    textBox1.SelectionStart = textBox1.TextLength;

                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка чтения файла.\n" +
                        exc.ToString(), "NkEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // сохранить документ
        private int SaveDocument()
        {
            int result = 0;
    
            if (fn == string.Empty)
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
                        // получим информацию о файле fn
                        System.IO.FileInfo fi =
                            new System.IO.FileInfo(fn);

                        // поток для записи (перезаписываем файл)
                        System.IO.StreamWriter sw = fi.CreateText();

                        // записываем данные
                        sw.Write(textBox1.Text);

                        // закрываем поток
                        sw.Close();
                        result = 0;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString(), "NkEdit",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }
                return result;
     }
        
        // выбор в меню Файл команды Создать
        private void FileCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show( 
                                      "Сохранить изменения ?", "NkEdit",
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
                        // 
                        break;
                };
            }
        }

        // выбор в меню Файл команды Открыть
        private void FileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;

            // отобразить диалог Открыть
            if (openFileDialog1.ShowDialog() ==
                                DialogResult.OK)
            {
                fn = openFileDialog1.FileName;

                // отобразить имя файла в заголовке окна
                this.Text = fn;

                try
                {
                    // считываем данные из файла
                    System.IO.StreamReader sr =
                        new System.IO.StreamReader(fn);

                    textBox1.Text = sr.ReadToEnd();
                    textBox1.SelectionStart = textBox1.TextLength;

                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка чтения файла.\n" +
                        exc.ToString(), "MEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

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
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            docChanged = true;
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
                };
            }
        }

        // выбор в меню Справка команды О программе
        private void оПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();

            about.ShowDialog();
        }

        // выбор в меню Файл команды Печать
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

    }
}
