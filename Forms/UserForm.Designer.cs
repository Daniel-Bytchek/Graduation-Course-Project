namespace Version_1._1
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bookSearchIdBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.bookSearchPublishingBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.bookSearchLanguageBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.bookSearchAuthorBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.bookSearchGenreBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.bookSearchNameBox = new System.Windows.Forms.TextBox();
            this.bookDeleteButton = new System.Windows.Forms.Button();
            this.bookDeleteLabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.bookDeleteIdBox = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.BooksMenu = new System.Windows.Forms.TabPage();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.BorrowsMenu = new System.Windows.Forms.TabPage();
            this.BorrowedBooksGridView = new System.Windows.Forms.DataGridView();
            this.ReaderMenu = new System.Windows.Forms.TabControl();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.BooksMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.BorrowsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowedBooksGridView)).BeginInit();
            this.ReaderMenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage3.Controls.Add(this.bookSearchIdBox);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.bookSearchPublishingBox);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.bookSearchLanguageBox);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.bookSearchAuthorBox);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.bookSearchGenreBox);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.bookSearchNameBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(340, 476);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Пошук";
            // 
            // bookSearchIdBox
            // 
            this.bookSearchIdBox.Location = new System.Drawing.Point(147, 81);
            this.bookSearchIdBox.Name = "bookSearchIdBox";
            this.bookSearchIdBox.Size = new System.Drawing.Size(170, 26);
            this.bookSearchIdBox.TabIndex = 15;
            this.bookSearchIdBox.TextChanged += new System.EventHandler(this.bookSearchIdBox_TextChanged);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(6, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 89);
            this.button5.TabIndex = 14;
            this.button5.Text = "Оновити базу даних";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(3, 241);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 18);
            this.label25.TabIndex = 13;
            this.label25.Text = "Видавництво: ";
            // 
            // bookSearchPublishingBox
            // 
            this.bookSearchPublishingBox.Location = new System.Drawing.Point(147, 241);
            this.bookSearchPublishingBox.Name = "bookSearchPublishingBox";
            this.bookSearchPublishingBox.Size = new System.Drawing.Size(170, 26);
            this.bookSearchPublishingBox.TabIndex = 12;
            this.bookSearchPublishingBox.TextChanged += new System.EventHandler(this.bookSearchNameBox_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(2, 209);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 18);
            this.label26.TabIndex = 11;
            this.label26.Text = "Мова: ";
            // 
            // bookSearchLanguageBox
            // 
            this.bookSearchLanguageBox.Location = new System.Drawing.Point(147, 209);
            this.bookSearchLanguageBox.Name = "bookSearchLanguageBox";
            this.bookSearchLanguageBox.Size = new System.Drawing.Size(170, 26);
            this.bookSearchLanguageBox.TabIndex = 10;
            this.bookSearchLanguageBox.TextChanged += new System.EventHandler(this.bookSearchNameBox_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(3, 177);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 18);
            this.label27.TabIndex = 9;
            this.label27.Text = "Автор: ";
            // 
            // bookSearchAuthorBox
            // 
            this.bookSearchAuthorBox.Location = new System.Drawing.Point(147, 177);
            this.bookSearchAuthorBox.Name = "bookSearchAuthorBox";
            this.bookSearchAuthorBox.Size = new System.Drawing.Size(170, 26);
            this.bookSearchAuthorBox.TabIndex = 8;
            this.bookSearchAuthorBox.TextChanged += new System.EventHandler(this.bookSearchNameBox_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(3, 145);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 18);
            this.label28.TabIndex = 7;
            this.label28.Text = "Жанр: ";
            // 
            // bookSearchGenreBox
            // 
            this.bookSearchGenreBox.Location = new System.Drawing.Point(147, 145);
            this.bookSearchGenreBox.Name = "bookSearchGenreBox";
            this.bookSearchGenreBox.Size = new System.Drawing.Size(170, 26);
            this.bookSearchGenreBox.TabIndex = 6;
            this.bookSearchGenreBox.TextChanged += new System.EventHandler(this.bookSearchNameBox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(4, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 18);
            this.label29.TabIndex = 5;
            this.label29.Text = "Назва:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(3, 81);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 18);
            this.label30.TabIndex = 3;
            this.label30.Text = "id: ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(3, 11);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(176, 18);
            this.label31.TabIndex = 2;
            this.label31.Text = "Параметри пошуку";
            // 
            // bookSearchNameBox
            // 
            this.bookSearchNameBox.Location = new System.Drawing.Point(147, 113);
            this.bookSearchNameBox.Name = "bookSearchNameBox";
            this.bookSearchNameBox.Size = new System.Drawing.Size(170, 26);
            this.bookSearchNameBox.TabIndex = 1;
            this.bookSearchNameBox.TextChanged += new System.EventHandler(this.bookSearchNameBox_TextChanged);
            // 
            // bookDeleteButton
            // 
            this.bookDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.bookDeleteButton.Location = new System.Drawing.Point(74, 300);
            this.bookDeleteButton.Name = "bookDeleteButton";
            this.bookDeleteButton.Size = new System.Drawing.Size(194, 55);
            this.bookDeleteButton.TabIndex = 21;
            this.bookDeleteButton.Text = "Запозичити";
            this.bookDeleteButton.UseVisualStyleBackColor = true;
            this.bookDeleteButton.Visible = false;
            this.bookDeleteButton.Click += new System.EventHandler(this.bookDeleteButton_Click);
            // 
            // bookDeleteLabel
            // 
            this.bookDeleteLabel.AutoSize = true;
            this.bookDeleteLabel.ForeColor = System.Drawing.Color.Black;
            this.bookDeleteLabel.Location = new System.Drawing.Point(6, 158);
            this.bookDeleteLabel.Name = "bookDeleteLabel";
            this.bookDeleteLabel.Size = new System.Drawing.Size(68, 18);
            this.bookDeleteLabel.TabIndex = 19;
            this.bookDeleteLabel.Text = "Книга:";
            this.bookDeleteLabel.Visible = false;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(6, 384);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(331, 89);
            this.button7.TabIndex = 18;
            this.button7.Text = "Оновити базу даних";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bookDeleteIdBox
            // 
            this.bookDeleteIdBox.Location = new System.Drawing.Point(147, 81);
            this.bookDeleteIdBox.Name = "bookDeleteIdBox";
            this.bookDeleteIdBox.Size = new System.Drawing.Size(170, 26);
            this.bookDeleteIdBox.TabIndex = 17;
            this.bookDeleteIdBox.TextChanged += new System.EventHandler(this.bookDeleteIdBox_TextChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(3, 81);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(35, 18);
            this.label34.TabIndex = 16;
            this.label34.Text = "id: ";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(3, 11);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(211, 36);
            this.label35.TabIndex = 0;
            this.label35.Text = "Введіть ID книги,\r\nяку хочете запозичити:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage5.Controls.Add(this.bookDeleteButton);
            this.tabPage5.Controls.Add(this.bookDeleteLabel);
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.bookDeleteIdBox);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.label35);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(340, 476);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Запозичення";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.closeLabel);
            this.panel2.Controls.Add(this.authorizationLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 86);
            this.panel2.TabIndex = 0;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.Silver;
            this.closeLabel.Location = new System.Drawing.Point(1157, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(27, 26);
            this.closeLabel.TabIndex = 3;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorizationLabel.Font = new System.Drawing.Font("Georgia", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationLabel.ForeColor = System.Drawing.Color.Silver;
            this.authorizationLabel.Location = new System.Drawing.Point(0, 0);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(1184, 86);
            this.authorizationLabel.TabIndex = 0;
            this.authorizationLabel.Text = "Доброго дня ";
            this.authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorizationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authorizationLabel_MouseDown);
            this.authorizationLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.authorizationLabel_MouseMove);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(100, 23);
            this.tabControl2.Location = new System.Drawing.Point(821, 3);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(348, 507);
            this.tabControl2.TabIndex = 3;
            // 
            // BooksMenu
            // 
            this.BooksMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BooksMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BooksMenu.Controls.Add(this.tabControl2);
            this.BooksMenu.Controls.Add(this.booksGridView);
            this.BooksMenu.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BooksMenu.Location = new System.Drawing.Point(4, 4);
            this.BooksMenu.Name = "BooksMenu";
            this.BooksMenu.Padding = new System.Windows.Forms.Padding(3);
            this.BooksMenu.Size = new System.Drawing.Size(1176, 517);
            this.BooksMenu.TabIndex = 1;
            this.BooksMenu.Text = "                                                             Книги               " +
    "                                              ";
            // 
            // booksGridView
            // 
            this.booksGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.booksGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.booksGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.booksGridView.Location = new System.Drawing.Point(3, 3);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.Size = new System.Drawing.Size(818, 507);
            this.booksGridView.TabIndex = 2;
            // 
            // BorrowsMenu
            // 
            this.BorrowsMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BorrowsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorrowsMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BorrowsMenu.Controls.Add(this.BorrowedBooksGridView);
            this.BorrowsMenu.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BorrowsMenu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BorrowsMenu.Location = new System.Drawing.Point(4, 4);
            this.BorrowsMenu.Name = "BorrowsMenu";
            this.BorrowsMenu.Padding = new System.Windows.Forms.Padding(3);
            this.BorrowsMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BorrowsMenu.Size = new System.Drawing.Size(1176, 517);
            this.BorrowsMenu.TabIndex = 0;
            this.BorrowsMenu.Text = "                                                            Запозичення          " +
    "                                                  ";
            // 
            // BorrowedBooksGridView
            // 
            this.BorrowedBooksGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.BorrowedBooksGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorrowedBooksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.BorrowedBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorrowedBooksGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.BorrowedBooksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrowedBooksGridView.Location = new System.Drawing.Point(3, 3);
            this.BorrowedBooksGridView.Name = "BorrowedBooksGridView";
            this.BorrowedBooksGridView.Size = new System.Drawing.Size(1166, 507);
            this.BorrowedBooksGridView.TabIndex = 0;
            // 
            // ReaderMenu
            // 
            this.ReaderMenu.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ReaderMenu.Controls.Add(this.BooksMenu);
            this.ReaderMenu.Controls.Add(this.BorrowsMenu);
            this.ReaderMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReaderMenu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaderMenu.HotTrack = true;
            this.ReaderMenu.ItemSize = new System.Drawing.Size(50, 50);
            this.ReaderMenu.Location = new System.Drawing.Point(0, 86);
            this.ReaderMenu.Multiline = true;
            this.ReaderMenu.Name = "ReaderMenu";
            this.ReaderMenu.Padding = new System.Drawing.Point(10, 10);
            this.ReaderMenu.SelectedIndex = 0;
            this.ReaderMenu.Size = new System.Drawing.Size(1184, 575);
            this.ReaderMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.ReaderMenu.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.mainPanel.Controls.Add(this.ReaderMenu);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1184, 661);
            this.mainPanel.TabIndex = 2;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.BooksMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.BorrowsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowedBooksGridView)).EndInit();
            this.ReaderMenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox bookSearchIdBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox bookSearchPublishingBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox bookSearchLanguageBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox bookSearchAuthorBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox bookSearchGenreBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox bookSearchNameBox;
        private System.Windows.Forms.Button bookDeleteButton;
        private System.Windows.Forms.Label bookDeleteLabel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox bookDeleteIdBox;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage BooksMenu;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.TabPage BorrowsMenu;
        private System.Windows.Forms.DataGridView BorrowedBooksGridView;
        private System.Windows.Forms.TabControl ReaderMenu;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label closeLabel;
    }
}