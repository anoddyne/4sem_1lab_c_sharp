namespace stp_1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBookTopic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBookIssueDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBookTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBookAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddReleaseDate = new System.Windows.Forms.TextBox();
            this.AddBookState = new System.Windows.Forms.CheckBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonShowAllBooks = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(661, 468);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузить данные из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(679, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск по названию книги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(938, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавление новой книги";
            // 
            // AddBookId
            // 
            this.AddBookId.Location = new System.Drawing.Point(14, 51);
            this.AddBookId.Name = "AddBookId";
            this.AddBookId.Size = new System.Drawing.Size(215, 24);
            this.AddBookId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Жанр книги";
            // 
            // AddBookTopic
            // 
            this.AddBookTopic.Location = new System.Drawing.Point(14, 113);
            this.AddBookTopic.Name = "AddBookTopic";
            this.AddBookTopic.Size = new System.Drawing.Size(215, 24);
            this.AddBookTopic.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата выдачи";
            // 
            // AddBookIssueDate
            // 
            this.AddBookIssueDate.Location = new System.Drawing.Point(14, 207);
            this.AddBookIssueDate.Name = "AddBookIssueDate";
            this.AddBookIssueDate.ReadOnly = true;
            this.AddBookIssueDate.Size = new System.Drawing.Size(215, 24);
            this.AddBookIssueDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Название книги";
            // 
            // AddBookTitle
            // 
            this.AddBookTitle.Location = new System.Drawing.Point(14, 269);
            this.AddBookTitle.Name = "AddBookTitle";
            this.AddBookTitle.Size = new System.Drawing.Size(215, 24);
            this.AddBookTitle.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Автор";
            // 
            // AddBookAuthor
            // 
            this.AddBookAuthor.Location = new System.Drawing.Point(14, 331);
            this.AddBookAuthor.Name = "AddBookAuthor";
            this.AddBookAuthor.Size = new System.Drawing.Size(215, 24);
            this.AddBookAuthor.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Год выпуска";
            // 
            // AddReleaseDate
            // 
            this.AddReleaseDate.Location = new System.Drawing.Point(14, 393);
            this.AddReleaseDate.MaxLength = 4;
            this.AddReleaseDate.Name = "AddReleaseDate";
            this.AddReleaseDate.Size = new System.Drawing.Size(215, 24);
            this.AddReleaseDate.TabIndex = 17;
            // 
            // AddBookState
            // 
            this.AddBookState.AutoSize = true;
            this.AddBookState.Location = new System.Drawing.Point(19, 147);
            this.AddBookState.Name = "AddBookState";
            this.AddBookState.Size = new System.Drawing.Size(204, 22);
            this.AddBookState.TabIndex = 19;
            this.AddBookState.Text = "Книга выдана читателю?";
            this.AddBookState.UseVisualStyleBackColor = true;
            this.AddBookState.CheckedChanged += new System.EventHandler(this.AddBookState_CheckedChanged);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(14, 427);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(215, 35);
            this.buttonAddBook.TabIndex = 20;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Тематика книги";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(14, 84);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(219, 41);
            this.buttonFilter.TabIndex = 24;
            this.buttonFilter.Text = "Отфильтровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonShowAllBooks
            // 
            this.buttonShowAllBooks.Location = new System.Drawing.Point(679, 443);
            this.buttonShowAllBooks.Name = "buttonShowAllBooks";
            this.buttonShowAllBooks.Size = new System.Drawing.Size(252, 44);
            this.buttonShowAllBooks.TabIndex = 25;
            this.buttonShowAllBooks.Text = "Показать все книги";
            this.buttonShowAllBooks.UseVisualStyleBackColor = true;
            this.buttonShowAllBooks.Click += new System.EventHandler(this.buttonShowAllBooks_click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "ID книги";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 24);
            this.textBox2.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddBookId);
            this.groupBox1.Controls.Add(this.AddBookTopic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddBookIssueDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddBookTitle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AddBookAuthor);
            this.groupBox1.Controls.Add(this.buttonAddBook);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AddBookState);
            this.groupBox1.Controls.Add(this.AddReleaseDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(942, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 476);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление новой книги";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 24);
            this.textBox4.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.buttonFilter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(679, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 134);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDeleteBook);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(679, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 140);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление существующей записи";
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(13, 94);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(215, 40);
            this.buttonDeleteBook.TabIndex = 29;
            this.buttonDeleteBook.Text = "Удалить";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonShowAllBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddBookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddBookTopic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddBookIssueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddBookTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddBookAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AddReleaseDate;
        private System.Windows.Forms.CheckBox AddBookState;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonShowAllBooks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDeleteBook;
    }
}

