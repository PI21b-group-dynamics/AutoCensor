namespace Лабораторная_ГДиК_AutoCensor_Подгорный
{
    partial class AutoCensor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCensor));
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.LotsWordsTextBox = new System.Windows.Forms.TextBox();
            this.LogsTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьРезультатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPathButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveLogsInFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 31);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(1007, 30);
            this.FilePathTextBox.TabIndex = 0;
            this.FilePathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilePathTextBox_KeyPress);
            this.FilePathTextBox.Leave += new System.EventHandler(this.FilePathTextBox_Leave);
            // 
            // LotsWordsTextBox
            // 
            this.LotsWordsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LotsWordsTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LotsWordsTextBox.Location = new System.Drawing.Point(12, 108);
            this.LotsWordsTextBox.Multiline = true;
            this.LotsWordsTextBox.Name = "LotsWordsTextBox";
            this.LotsWordsTextBox.Size = new System.Drawing.Size(328, 384);
            this.LotsWordsTextBox.TabIndex = 3;
            // 
            // LogsTextBox
            // 
            this.LogsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogsTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogsTextBox.Location = new System.Drawing.Point(346, 67);
            this.LogsTextBox.Multiline = true;
            this.LogsTextBox.Name = "LogsTextBox";
            this.LogsTextBox.ReadOnly = true;
            this.LogsTextBox.Size = new System.Drawing.Size(724, 425);
            this.LogsTextBox.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(12, 67);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(328, 35);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Запустить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьxmlToolStripMenuItem,
            this.загрузитьxmlToolStripMenuItem,
            this.путьКФайлуToolStripMenuItem,
            this.путьРезультатаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьxmlToolStripMenuItem
            // 
            this.сохранитьxmlToolStripMenuItem.Name = "сохранитьxmlToolStripMenuItem";
            this.сохранитьxmlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьxmlToolStripMenuItem.Text = "Сохранить xml";
            this.сохранитьxmlToolStripMenuItem.Click += new System.EventHandler(this.сохранитьxmlToolStripMenuItem_Click);
            // 
            // загрузитьxmlToolStripMenuItem
            // 
            this.загрузитьxmlToolStripMenuItem.Name = "загрузитьxmlToolStripMenuItem";
            this.загрузитьxmlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьxmlToolStripMenuItem.Text = "Загрузить xml";
            this.загрузитьxmlToolStripMenuItem.Click += new System.EventHandler(this.загрузитьxmlToolStripMenuItem_Click);
            // 
            // путьКФайлуToolStripMenuItem
            // 
            this.путьКФайлуToolStripMenuItem.Name = "путьКФайлуToolStripMenuItem";
            this.путьКФайлуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.путьКФайлуToolStripMenuItem.Text = "Путь к файлу";
            this.путьКФайлуToolStripMenuItem.Click += new System.EventHandler(this.путьКФайлуToolStripMenuItem_Click);
            // 
            // путьРезультатаToolStripMenuItem
            // 
            this.путьРезультатаToolStripMenuItem.Name = "путьРезультатаToolStripMenuItem";
            this.путьРезультатаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.путьРезультатаToolStripMenuItem.Text = "Путь результата";
            this.путьРезультатаToolStripMenuItem.Click += new System.EventHandler(this.путьРезультатаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // SetPathButton
            // 
            this.SetPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPathButton.BackgroundImage = global::Лабораторная_ГДиК_AutoCensor_Подгорный.Properties.Resources.Iynque_Flat_Ios7_Style_Documents_Txt_512;
            this.SetPathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SetPathButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetPathButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetPathButton.Location = new System.Drawing.Point(1025, 28);
            this.SetPathButton.Name = "SetPathButton";
            this.SetPathButton.Size = new System.Drawing.Size(45, 35);
            this.SetPathButton.TabIndex = 1;
            this.SetPathButton.UseVisualStyleBackColor = true;
            this.SetPathButton.Click += new System.EventHandler(this.SetPathButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Txt files(*.txt)|*.txt|Xml Files(*.xml)|*.xml|All files(*.)|*.";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Txt files(*.txt)|*.txt|Xml Files(*.xml)|*.xml|All files(*.)|*.";
            // 
            // SaveLogsInFile
            // 
            this.SaveLogsInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLogsInFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveLogsInFile.Location = new System.Drawing.Point(991, 72);
            this.SaveLogsInFile.Name = "SaveLogsInFile";
            this.SaveLogsInFile.Size = new System.Drawing.Size(79, 30);
            this.SaveLogsInFile.TabIndex = 5;
            this.SaveLogsInFile.Text = "В файл";
            this.SaveLogsInFile.UseVisualStyleBackColor = true;
            this.SaveLogsInFile.Click += new System.EventHandler(this.SaveLogsInFile_Click);
            // 
            // AutoCensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 504);
            this.Controls.Add(this.SaveLogsInFile);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LogsTextBox);
            this.Controls.Add(this.LotsWordsTextBox);
            this.Controls.Add(this.SetPathButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutoCensor";
            this.Text = "AutoCensor ГДиК Подгорный";
            this.Load += new System.EventHandler(this.AutoCensor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button SetPathButton;
        private System.Windows.Forms.TextBox LotsWordsTextBox;
        private System.Windows.Forms.TextBox LogsTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem путьРезультатаToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SaveLogsInFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

