
namespace KPFU_2_sem_programming
{
    partial class FormMain
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
            this.mainMenuBar = new System.Windows.Forms.MenuStrip();
            this.menuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_File_CreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_File_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_File_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_File_SaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_File_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_File_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_File_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Correction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Correction_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Correction_Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_Correction_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Correction_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Correction_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Correction_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Correction_Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_Correction_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Format_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_View = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_View_Scale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_View_Scale_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_View_Scale_Down = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_View_Scale_Recover = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_View_StatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Reference_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_AI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTextField = new System.Windows.Forms.RichTextBox();
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.mainStatusBar_Symbols = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusBar_Strings = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusBar_Scale = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusBar_Encoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusBar_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuBar.SuspendLayout();
            this.mainStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mainMenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_File,
            this.menuItem_Correction,
            this.menuItem_Format,
            this.menuItem_View,
            this.menuItem_Reference,
            this.menuItem_AI});
            this.mainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Size = new System.Drawing.Size(803, 28);
            this.mainMenuBar.TabIndex = 0;
            // 
            // menuItem_File
            // 
            this.menuItem_File.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_File_CreateFile,
            this.menuItem_File_OpenFile,
            this.menuItem_File_SaveFile,
            this.menuItem_File_SaveFileAs,
            this.menuItem_File_Separator1,
            this.menuItem_File_Print,
            this.menuItem_File_Separator2,
            this.menuItem_File_Exit});
            this.menuItem_File.Name = "menuItem_File";
            this.menuItem_File.Size = new System.Drawing.Size(59, 24);
            this.menuItem_File.Text = "Файл";
            // 
            // menuItem_File_CreateFile
            // 
            this.menuItem_File_CreateFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_File_CreateFile.Name = "menuItem_File_CreateFile";
            this.menuItem_File_CreateFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuItem_File_CreateFile.ShortcutKeyDisplayString = "CTRL + N";
            this.menuItem_File_CreateFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItem_File_CreateFile.Size = new System.Drawing.Size(325, 26);
            this.menuItem_File_CreateFile.Text = "Создать файл";
            this.menuItem_File_CreateFile.Click += new System.EventHandler(this.menuItem_File_CreateFile_Click);
            // 
            // menuItem_File_OpenFile
            // 
            this.menuItem_File_OpenFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_File_OpenFile.Name = "menuItem_File_OpenFile";
            this.menuItem_File_OpenFile.ShortcutKeyDisplayString = "CTRL + O";
            this.menuItem_File_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItem_File_OpenFile.Size = new System.Drawing.Size(325, 26);
            this.menuItem_File_OpenFile.Text = "Открыть...";
            this.menuItem_File_OpenFile.Click += new System.EventHandler(this.menuItem_File_OpenFile_Click);
            // 
            // menuItem_File_SaveFile
            // 
            this.menuItem_File_SaveFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_File_SaveFile.Name = "menuItem_File_SaveFile";
            this.menuItem_File_SaveFile.ShortcutKeyDisplayString = "CTRL + S";
            this.menuItem_File_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItem_File_SaveFile.Size = new System.Drawing.Size(325, 26);
            this.menuItem_File_SaveFile.Text = "Сохранить";
            this.menuItem_File_SaveFile.Click += new System.EventHandler(this.menuItem_File_SaveFile_Click);
            // 
            // menuItem_File_SaveFileAs
            // 
            this.menuItem_File_SaveFileAs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_File_SaveFileAs.Name = "menuItem_File_SaveFileAs";
            this.menuItem_File_SaveFileAs.ShortcutKeyDisplayString = "CTRL + SHIFT + S";
            this.menuItem_File_SaveFileAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuItem_File_SaveFileAs.Size = new System.Drawing.Size(325, 26);
            this.menuItem_File_SaveFileAs.Text = "Сохранить как...";
            this.menuItem_File_SaveFileAs.Click += new System.EventHandler(this.menuItem_File_SaveFileAs_Click);
            // 
            // menuItem_File_Separator1
            // 
            this.menuItem_File_Separator1.Name = "menuItem_File_Separator1";
            this.menuItem_File_Separator1.Size = new System.Drawing.Size(322, 6);
            // 
            // menuItem_File_Print
            // 
            this.menuItem_File_Print.Name = "menuItem_File_Print";
            this.menuItem_File_Print.ShortcutKeyDisplayString = "CTRL + P";
            this.menuItem_File_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuItem_File_Print.ShowShortcutKeys = false;
            this.menuItem_File_Print.Size = new System.Drawing.Size(325, 26);
            this.menuItem_File_Print.Text = "Печать...";
            this.menuItem_File_Print.Click += new System.EventHandler(this.menuItem_File_Print_Click);
            // 
            // menuItem_File_Separator2
            // 
            this.menuItem_File_Separator2.Name = "menuItem_File_Separator2";
            this.menuItem_File_Separator2.Size = new System.Drawing.Size(322, 6);
            // 
            // menuItem_File_Exit
            // 
            this.menuItem_File_Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuItem_File_Exit.Name = "menuItem_File_Exit";
            this.menuItem_File_Exit.Size = new System.Drawing.Size(325, 26);
            this.menuItem_File_Exit.Text = "Выход";
            this.menuItem_File_Exit.Click += new System.EventHandler(this.menuItem_File_Exit_Click);
            // 
            // menuItem_Correction
            // 
            this.menuItem_Correction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuItem_Correction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Correction_Undo,
            this.menuItem_Correction_Separator3,
            this.menuItem_Correction_Cut,
            this.menuItem_Correction_Copy,
            this.menuItem_Correction_Paste,
            this.menuItem_Correction_Delete,
            this.menuItem_Correction_Separator4,
            this.menuItem_Correction_SelectAll});
            this.menuItem_Correction.Name = "menuItem_Correction";
            this.menuItem_Correction.Size = new System.Drawing.Size(74, 24);
            this.menuItem_Correction.Text = "Правка";
            // 
            // menuItem_Correction_Undo
            // 
            this.menuItem_Correction_Undo.Name = "menuItem_Correction_Undo";
            this.menuItem_Correction_Undo.ShortcutKeyDisplayString = "CTRL + Z";
            this.menuItem_Correction_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItem_Correction_Undo.Size = new System.Drawing.Size(296, 26);
            this.menuItem_Correction_Undo.Text = "Отменить действие";
            this.menuItem_Correction_Undo.Click += new System.EventHandler(this.menuItem_Correction_Undo_Click);
            // 
            // menuItem_Correction_Separator3
            // 
            this.menuItem_Correction_Separator3.Name = "menuItem_Correction_Separator3";
            this.menuItem_Correction_Separator3.Size = new System.Drawing.Size(293, 6);
            // 
            // menuItem_Correction_Cut
            // 
            this.menuItem_Correction_Cut.Name = "menuItem_Correction_Cut";
            this.menuItem_Correction_Cut.ShortcutKeyDisplayString = "CTRL + X";
            this.menuItem_Correction_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItem_Correction_Cut.Size = new System.Drawing.Size(296, 26);
            this.menuItem_Correction_Cut.Text = "Вырезать";
            this.menuItem_Correction_Cut.Click += new System.EventHandler(this.menuItem_Correction_Cut_Click);
            // 
            // menuItem_Correction_Copy
            // 
            this.menuItem_Correction_Copy.Name = "menuItem_Correction_Copy";
            this.menuItem_Correction_Copy.ShortcutKeyDisplayString = "CTRL + C";
            this.menuItem_Correction_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuItem_Correction_Copy.Size = new System.Drawing.Size(296, 26);
            this.menuItem_Correction_Copy.Text = "Копировать";
            this.menuItem_Correction_Copy.Click += new System.EventHandler(this.menuItem_Correction_Copy_Click);
            // 
            // menuItem_Correction_Paste
            // 
            this.menuItem_Correction_Paste.Name = "menuItem_Correction_Paste";
            this.menuItem_Correction_Paste.ShortcutKeyDisplayString = "CTRL + V";
            this.menuItem_Correction_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItem_Correction_Paste.Size = new System.Drawing.Size(296, 26);
            this.menuItem_Correction_Paste.Text = "Вставить";
            this.menuItem_Correction_Paste.Click += new System.EventHandler(this.menuItem_Correction_Paste_Click);
            // 
            // menuItem_Correction_Delete
            // 
            this.menuItem_Correction_Delete.Name = "menuItem_Correction_Delete";
            this.menuItem_Correction_Delete.ShortcutKeyDisplayString = "Del";
            this.menuItem_Correction_Delete.Size = new System.Drawing.Size(296, 26);
            this.menuItem_Correction_Delete.Text = "Удалить";
            this.menuItem_Correction_Delete.Click += new System.EventHandler(this.menuItem_Correction_Delete_Click);
            // 
            // menuItem_Correction_Separator4
            // 
            this.menuItem_Correction_Separator4.Name = "menuItem_Correction_Separator4";
            this.menuItem_Correction_Separator4.Size = new System.Drawing.Size(293, 6);
            // 
            // menuItem_Correction_SelectAll
            // 
            this.menuItem_Correction_SelectAll.Name = "menuItem_Correction_SelectAll";
            this.menuItem_Correction_SelectAll.ShortcutKeyDisplayString = "CTRL + A";
            this.menuItem_Correction_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuItem_Correction_SelectAll.Size = new System.Drawing.Size(296, 26);
            this.menuItem_Correction_SelectAll.Text = "Выделить всё";
            this.menuItem_Correction_SelectAll.Click += new System.EventHandler(this.menuItem_Correction_SelectAll_Click);
            // 
            // menuItem_Format
            // 
            this.menuItem_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Format_Font});
            this.menuItem_Format.Name = "menuItem_Format";
            this.menuItem_Format.Size = new System.Drawing.Size(77, 24);
            this.menuItem_Format.Text = "Формат";
            // 
            // menuItem_Format_Font
            // 
            this.menuItem_Format_Font.Name = "menuItem_Format_Font";
            this.menuItem_Format_Font.Size = new System.Drawing.Size(140, 26);
            this.menuItem_Format_Font.Text = "Шрифт";
            this.menuItem_Format_Font.Click += new System.EventHandler(this.menuItem_Format_Font_Click);
            // 
            // menuItem_View
            // 
            this.menuItem_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_View_Scale,
            this.menuItem_View_StatusBar});
            this.menuItem_View.Name = "menuItem_View";
            this.menuItem_View.Size = new System.Drawing.Size(49, 24);
            this.menuItem_View.Text = "Вид";
            // 
            // menuItem_View_Scale
            // 
            this.menuItem_View_Scale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_View_Scale_Up,
            this.menuItem_View_Scale_Down,
            this.menuItem_View_Scale_Recover});
            this.menuItem_View_Scale.Name = "menuItem_View_Scale";
            this.menuItem_View_Scale.ShortcutKeyDisplayString = "";
            this.menuItem_View_Scale.Size = new System.Drawing.Size(216, 26);
            this.menuItem_View_Scale.Text = "Масштаб";
            // 
            // menuItem_View_Scale_Up
            // 
            this.menuItem_View_Scale_Up.Name = "menuItem_View_Scale_Up";
            this.menuItem_View_Scale_Up.ShortcutKeyDisplayString = "CTRL + плюс (+)";
            this.menuItem_View_Scale_Up.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.menuItem_View_Scale_Up.Size = new System.Drawing.Size(320, 26);
            this.menuItem_View_Scale_Up.Text = "Увеличить";
            this.menuItem_View_Scale_Up.Click += new System.EventHandler(this.menuItem_View_Scale_Up_Click);
            // 
            // menuItem_View_Scale_Down
            // 
            this.menuItem_View_Scale_Down.Name = "menuItem_View_Scale_Down";
            this.menuItem_View_Scale_Down.ShortcutKeyDisplayString = "CTRL + минус (-)";
            this.menuItem_View_Scale_Down.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.menuItem_View_Scale_Down.Size = new System.Drawing.Size(320, 26);
            this.menuItem_View_Scale_Down.Text = "Уменьшить";
            this.menuItem_View_Scale_Down.Click += new System.EventHandler(this.menuItem_View_Scale_Down_Click);
            // 
            // menuItem_View_Scale_Recover
            // 
            this.menuItem_View_Scale_Recover.Name = "menuItem_View_Scale_Recover";
            this.menuItem_View_Scale_Recover.ShortcutKeyDisplayString = "CTRL + 0";
            this.menuItem_View_Scale_Recover.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.menuItem_View_Scale_Recover.Size = new System.Drawing.Size(320, 26);
            this.menuItem_View_Scale_Recover.Text = "Восстанивить масштаб";
            this.menuItem_View_Scale_Recover.Click += new System.EventHandler(this.menuItem_View_Scale_Recover_Click);
            // 
            // menuItem_View_StatusBar
            // 
            this.menuItem_View_StatusBar.Checked = true;
            this.menuItem_View_StatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItem_View_StatusBar.Name = "menuItem_View_StatusBar";
            this.menuItem_View_StatusBar.Size = new System.Drawing.Size(216, 26);
            this.menuItem_View_StatusBar.Text = "Строка состояния";
            this.menuItem_View_StatusBar.Click += new System.EventHandler(this.menuItem_View_StatusBar_Click);
            // 
            // menuItem_Reference
            // 
            this.menuItem_Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Reference_About});
            this.menuItem_Reference.Name = "menuItem_Reference";
            this.menuItem_Reference.Size = new System.Drawing.Size(81, 24);
            this.menuItem_Reference.Text = "Справка";
            // 
            // menuItem_Reference_About
            // 
            this.menuItem_Reference_About.Name = "menuItem_Reference_About";
            this.menuItem_Reference_About.Size = new System.Drawing.Size(187, 26);
            this.menuItem_Reference_About.Text = "О программе";
            this.menuItem_Reference_About.Click += new System.EventHandler(this.menuItem_Reference_About_Click);
            // 
            // menuItem_AI
            // 
            this.menuItem_AI.Name = "menuItem_AI";
            this.menuItem_AI.Size = new System.Drawing.Size(37, 24);
            this.menuItem_AI.Text = "AI";
            this.menuItem_AI.Click += new System.EventHandler(this.menuItem_AI_Click);
            // 
            // mainTextField
            // 
            this.mainTextField.BackColor = System.Drawing.SystemColors.Window;
            this.mainTextField.Location = new System.Drawing.Point(10, 40);
            this.mainTextField.Margin = new System.Windows.Forms.Padding(0);
            this.mainTextField.Name = "mainTextField";
            this.mainTextField.Size = new System.Drawing.Size(780, 397);
            this.mainTextField.TabIndex = 1;
            this.mainTextField.Text = "";
            this.mainTextField.TextChanged += new System.EventHandler(this.mainTextField_TextChanged);
            this.mainTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainTextField_KeyUp);
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusBar_Symbols,
            this.mainStatusBar_Strings,
            this.mainStatusBar_Scale,
            this.mainStatusBar_Encoding,
            this.mainStatusBar_Version});
            this.mainStatusBar.Location = new System.Drawing.Point(0, 444);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.Size = new System.Drawing.Size(803, 30);
            this.mainStatusBar.SizingGrip = false;
            this.mainStatusBar.TabIndex = 2;
            // 
            // mainStatusBar_Symbols
            // 
            this.mainStatusBar_Symbols.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.mainStatusBar_Symbols.Name = "mainStatusBar_Symbols";
            this.mainStatusBar_Symbols.Size = new System.Drawing.Size(147, 24);
            this.mainStatusBar_Symbols.Spring = true;
            this.mainStatusBar_Symbols.Text = "Символов:";
            this.mainStatusBar_Symbols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainStatusBar_Strings
            // 
            this.mainStatusBar_Strings.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.mainStatusBar_Strings.Name = "mainStatusBar_Strings";
            this.mainStatusBar_Strings.Size = new System.Drawing.Size(147, 24);
            this.mainStatusBar_Strings.Spring = true;
            this.mainStatusBar_Strings.Text = "Строк: ";
            this.mainStatusBar_Strings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainStatusBar_Scale
            // 
            this.mainStatusBar_Scale.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.mainStatusBar_Scale.Name = "mainStatusBar_Scale";
            this.mainStatusBar_Scale.Size = new System.Drawing.Size(147, 24);
            this.mainStatusBar_Scale.Spring = true;
            this.mainStatusBar_Scale.Text = "Масштаб: ";
            this.mainStatusBar_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainStatusBar_Encoding
            // 
            this.mainStatusBar_Encoding.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.mainStatusBar_Encoding.Name = "mainStatusBar_Encoding";
            this.mainStatusBar_Encoding.Size = new System.Drawing.Size(52, 24);
            this.mainStatusBar_Encoding.Text = "UTF-8";
            // 
            // mainStatusBar_Version
            // 
            this.mainStatusBar_Version.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.mainStatusBar_Version.Name = "mainStatusBar_Version";
            this.mainStatusBar_Version.Size = new System.Drawing.Size(100, 24);
            this.mainStatusBar_Version.Text = "Версия: 1.6.0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 474);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.mainTextField);
            this.Controls.Add(this.mainMenuBar);
            this.MainMenuStrip = this.mainMenuBar;
            this.Name = "FormMain";
            this.Text = "Безымянный - БлокнотПлюсПлюс";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.mainMenuBar.ResumeLayout(false);
            this.mainMenuBar.PerformLayout();
            this.mainStatusBar.ResumeLayout(false);
            this.mainStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuBar;

        private System.Windows.Forms.ToolStripMenuItem menuItem_File;
        private System.Windows.Forms.ToolStripMenuItem menuItem_File_CreateFile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_File_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_File_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_File_SaveFileAs;
        private System.Windows.Forms.ToolStripSeparator menuItem_File_Separator1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_File_Print;
        private System.Windows.Forms.ToolStripSeparator menuItem_File_Separator2;
        private System.Windows.Forms.ToolStripMenuItem menuItem_File_Exit;

        private System.Windows.Forms.ToolStripMenuItem menuItem_Correction;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Correction_Undo;
        private System.Windows.Forms.ToolStripSeparator menuItem_Correction_Separator3;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Correction_Cut;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Correction_Copy;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Correction_Paste;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Correction_Delete;
        private System.Windows.Forms.ToolStripSeparator menuItem_Correction_Separator4;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Correction_SelectAll;

        private System.Windows.Forms.ToolStripMenuItem menuItem_Format;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Format_Font;

        private System.Windows.Forms.ToolStripMenuItem menuItem_View;
        private System.Windows.Forms.ToolStripMenuItem menuItem_View_Scale;
        private System.Windows.Forms.ToolStripMenuItem menuItem_View_Scale_Up;
        private System.Windows.Forms.ToolStripMenuItem menuItem_View_Scale_Down;
        private System.Windows.Forms.ToolStripMenuItem menuItem_View_Scale_Recover;
        private System.Windows.Forms.ToolStripMenuItem menuItem_View_StatusBar;

        private System.Windows.Forms.ToolStripMenuItem menuItem_Reference;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Reference_About;

        private System.Windows.Forms.StatusStrip mainStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusBar_Symbols;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusBar_Scale;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusBar_Strings;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusBar_Encoding;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusBar_Version;
        private System.Windows.Forms.ToolStripMenuItem menuItem_AI;
        public System.Windows.Forms.RichTextBox mainTextField;
    }
}

