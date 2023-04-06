using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Лабораторная_ГДиК_AutoCensor_Подгорный
{
    public partial class AutoCensor : Form
    {
        string PathToFile { get; set; }
        string PathToEndFile { get; set; }

        public AutoCensor()
        {
            InitializeComponent();
        }

        private void AutoCensor_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
            
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(FilePathTextBox, "Впишите сюда путь к файлу который требуется зацензурить");
            toolTip.SetToolTip(SetPathButton, "Выставить путь к файлу который требуется зацензурить");
            toolTip.SetToolTip(StartButton, "Запускает алгоритм цензуры");
            toolTip.SetToolTip(LotsWordsTextBox, "Впишиту сюда слова-предложение которые нужно заценузирть\nРазделителем служит новая строка");
            toolTip.SetToolTip(LogsTextBox, "Здесь будет выводится история цензуры");
            toolTip.SetToolTip(SaveLogsInFile, "Текущую историю в файл");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(PathToFile == null || PathToFile.Length == 0) return;

            try
            {

                if (PathToEndFile != null && PathToEndFile.Length > 0)
                    sendText_in_LogsField(new Censor(LotsWordsTextBox.Text).StartConsor(PathToFile, PathToEndFile));
                else
                    sendText_in_LogsField(new Censor(LotsWordsTextBox.Text).StartConsor(PathToFile, null));

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        
        }

        private void sendText_in_LogsField(List<string> list)
        {
            String str = "";

            if (list != null && list.Count > 0)
            {
                using (var sw = new StreamWriter("UserHistory.txt", true))
                {
                    sw.WriteLine(DateTime.Now);
                    foreach (string item in list)
                    {
                        str += item + "\r\n";
                        sw.WriteLine(item);
                    }
                }

            }


            LogsTextBox.Text = str;
        }

        private void FilePathTextBox_Leave(object sender, EventArgs e)
        {
            if(FilePathTextBox.Text.Length == 0)
            {
                FilePathTextBox.BackColor = Color.White;
            }
            else if(File.Exists(FilePathTextBox.Text))
            {
                FilePathTextBox.BackColor = Color.LightGreen;
            } 
            else
            {
                FilePathTextBox.BackColor = Color.Red;
                PathToFile = null;
                return;
            }

            PathToFile = FilePathTextBox.Text;
        }

        private void SetPathButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PathToFile = FilePathTextBox.Text = openFileDialog1.FileName;
                FilePathTextBox_Leave(null, null);
            }

        }

        private void путьКФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPathButton_Click(null, null);
        }

        private void путьРезультатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                PathToEndFile = folderBrowserDialog1.SelectedPath;
            }
        }

        private void сохранитьxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] SerializerString = { PathToFile, PathToEndFile, LotsWordsTextBox.Text, LogsTextBox.Text };

                using(var fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(string[]));

                    try
                    {
                        xmlSerializer.Serialize(fs, SerializerString);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка сериализации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void загрузитьxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(string[]));

                    string[] SerializerString;

                    try
                    {
                        SerializerString = xmlSerializer.Deserialize(fs) as string[];
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка десереализации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FilePathTextBox.Text = PathToFile = SerializerString[0];
                    FilePathTextBox_Leave(null, null);

                    PathToEndFile = SerializerString[1];
                    LotsWordsTextBox.Text = SerializerString[2];
                    LogsTextBox.Text = SerializerString[3];

                    MessageBox.Show("Данные успешно загружены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void SaveLogsInFile_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(var sw = new StreamWriter(saveFileDialog1.FileName, false))
                {
                    sw.WriteLine(LogsTextBox.Text);
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"AutoCensor Программа разработанная для цензуры по ключевым словам

Впишите или выставите путь к файлу для цензуры,
Впишите слова-предложения которые требуется зацензурить,
Нажмите кнопку Запустить.
Историю можно сохранить в файл.
Все вписанные данные можно сохранить в xml документ.
Вся историю хранится по относительному пути к exe файлу.", "Справка");
        }

        private void FilePathTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                StartButton_Click(null, null);
                e.Handled = true;
                return;
            }
        }
    }
}
