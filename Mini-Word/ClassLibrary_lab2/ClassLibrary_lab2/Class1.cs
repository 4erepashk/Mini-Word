using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Linq;

namespace ClassLibrary_lab2
{
    public class TextFile
    {
        public event EventHandler FileChange;

        private string file_content; // содержимое файла
        private string file_path;//путь
        private Font file_font;
        private bool change;


        public string Content
        {
            get => file_content;
            set
            {
                file_content = value;
                Change = true;
                FileChange?.Invoke(this, new EventArgs());
            }
        }

        public string File_path // принятие пути файла
        {
            get { return file_path; }
            private set { file_path = value; }
        }

        public Font File_font // принятие пути файла
        {
            get { return file_font; }
            private set { file_font = value; }
        }
        public bool Change //изменение файла
        {
            get { return change; }
            private set { change = value; }
        }
        

        public TextFile()
        {
            FileChange = (a, b) => { }; 
            File_path = string.Empty;
            Change = false;
            File_font = null;
        }

        public TextFile(string file_name, string cont)
        {
            FileChange = (a, b) => { };
            Content = cont;
            File_path = file_name;
        }

        public TextFile(string file_name, string cont,Font  font) 
        {
            FileChange = (a, b) => { }; 
            Content = cont;
            File_path = file_name;
            File_font = font;
        }

        public static TextFile OpenFile(string file_path) // Открытие файла и проверка на его существование 
        {
            TextFile Open_text = new TextFile();
            if (File.Exists(file_path))
            {
                Open_text.File_path = file_path;
                using (StreamReader sr = new StreamReader(file_path, System.Text.Encoding.GetEncoding(1251)))
                {
                    
                    Open_text.Content = sr.ReadToEnd();
                    
                }
                return Open_text;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        


        public static TextFile SaveFile(string Content, string file_path) // Метод для сохраненния файла
        {
            TextFile Save_text = new TextFile(file_path,Content);

            File.WriteAllText(Save_text.file_path, string.Empty);

            using (FileStream txt = new FileStream(Save_text.file_path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] text = System.Text.Encoding.Default.GetBytes(Save_text.Content);

                txt.Write(text, 0, text.Length);
            }
            return Save_text;
        }


       

        static StreamReader streamToPrint;
        static Font printFont;

        public static TextFile FileToPrinter(TextFile file, short count_copy) 
        {
            try
            {
                
                streamToPrint = new System.IO.StreamReader(file.File_path, System.Text.Encoding.GetEncoding(1251));
                try
                {
                    printFont = file.File_font;
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                    (pd_PrintPage);
                    pd.PrinterSettings.Copies = count_copy;
                    pd.Print();
                    return file;
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch
            {
                return file;
            }
        }
        // Событие PrintPage вызывается для каждой страницы, которая будет напечатана
        public static void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Чтобы вычислить количество строк на странице
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Печатаем каждую строку файла
            while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                count++;
            }

            // если строки не закончились, распечатаем еще одну страницу
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        public static int CountWords(string content) // подсчет кол-ва слов
        {
            string pattern = @"[-.?!)(,:]";
            string target = "";
            Regex regex = new Regex(pattern);
            string[] result = regex.Replace(content.Trim(), target).Split(' ', '\n');

            return result.Length;
        }



        public static string[] SearchDirectory(string Catalog) // Поиск файлов в дирректории 
        {

            try
            {
                string SearhAllFiles = "";
                foreach (string FindFile in Directory.EnumerateFiles(Catalog))
                {
                    FileInfo FL;
                    FL = new FileInfo(FindFile);
                    if (FL.Exists)
                    {
                        SearhAllFiles += FL.FullName;
                    }
                }
                string[] s;
                s = SearhAllFiles.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return s;
            }
            catch (Exception)
            {
                throw new Exception("Произошла ошибка поиска файлов!");
            }

        }

        public static string[] SortingBySymbols(string Catalog)// по кол ву символов 
        {

            string[] files = Directory.GetFiles(Catalog).OrderByDescending(line => new FileInfo(line).Length).ToArray();
            return files;
        }

        public static string[] searchInText(string content, string search_word)
        {

            string words = string.Empty;
            string pattern1 = @"[-.?!)(,:]";
            string target = "";
            Regex regex = new Regex(pattern1);
            string[] text= regex.Replace(content.Trim(), target).Split(' ', '\n');
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains(search_word)) words += text[i] + " ";
            }

            string[] res = words.Split(' ');

            return res;
        }


        public static string[] SortingByWords(string Catalog) // по кол-ву слов 
        {

            string[] files = Directory.GetFiles(Catalog);
            for (int i = 0; i < files.Length - 1; i++)
            {
                if (CountWords(files[i]) > CountWords(files[i + 1]))
                {
                    string temp = files[i];
                    files[i] = files[i + 1];
                    files[i + 1] = temp;
                }

            }
            return files;
        }

        


        public static string Method(TextFile file)// Личный метод
        {
           
            double weigth = 0;//вес
            double height = 0;//рост
            string s;//содержимое
            double IMT = 0.0;// Индекс массы тела
            int count=0;//кол-во человек
            int temp = 0;//вспомогательная переменная
            string name = string.Empty;//имя человека
            s = file.Content;
            string[] str = s.Split('\n');
            string pattern = @"\d+";
            int index = 0;
            string IMS = string.Empty;
            

            MatchCollection res = Regex.Matches(s, pattern);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].StartsWith("Имя")) count++;
            }

            for (int i = 0; i < count; i++)
            {
                for ( int j = temp; (i<count-1 ? !string.IsNullOrEmpty(str[j].Trim()):j<str.Length-1) ; j++)
                {
                    
                    if (str[j].StartsWith("Имя")) name = str[j];
                    if (str[j].StartsWith("Рост")) { height = Convert.ToDouble(res[index].Value); index++; }
                    if (str[j].StartsWith("Вес")) { weigth = Convert.ToDouble(res[index].Value); index++; }
                    if(i<count-1)temp = j+2;

                }
                
                IMT = (weigth / Math.Pow((height / 100.0),2.0));
                IMS += name +"\nИМТ = "+ IMT.ToString();
                if (IMT < 18) IMS += "\nНедостаточно\n";
                else if (IMT > 25) IMS += "\nМного\n";
                else IMS += "\nНорма\n";
            }

            return IMS;
        }

        public static bool operator ==(TextFile First, TextFile Second) // оператор равенства двух файлов  
        {
            return First.Content.ToCharArray().Length == Second.Content.ToCharArray().Length;

        }

        public static bool operator !=(TextFile First, TextFile Second)// оператор неравенства двух файлов 
        {
            return First.Content.ToCharArray().Length != Second.Content.ToCharArray().Length;
        }

        public static bool operator >(TextFile First, TextFile Second) // оператор больше 
        {
            return First.Content.ToCharArray().Length > Second.Content.ToCharArray().Length;
        }

        public static bool operator <(TextFile First, TextFile Second)// оператор меньше 
        {
            return First.Content.ToCharArray().Length < Second.Content.ToCharArray().Length;
        }

        public static bool operator >=(TextFile First, TextFile Second) // оператор больше 
        {
            return First.Content.ToCharArray().Length >= Second.Content.ToCharArray().Length;
        }

        public static bool operator <=(TextFile First, TextFile Second)// оператор меньше 
        {
            return First.Content.ToCharArray().Length <= Second.Content.ToCharArray().Length;
        }



    }

}
