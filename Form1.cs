using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace stp_1
{
    public partial class Form1 : Form
    {
        private Library library = new Library();
        private ErrorAddingEventHandler errorAddingEventHandler = new ErrorAddingEventHandler();
        public Form1()
        {
            library.NotAdded += errorAddingEventHandler.ErrorMessage;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "input.txt";
            string[] filelines = File.ReadAllLines(filename);

            foreach (string line in filelines)
            {
                string[] parts = line.Split(',');
                Book currBook = new Book(Int32.Parse(parts[0]),
                        parts[1],
                        bool.Parse(parts[2]),
                        dateParser(parts[3]),
                        parts[4],
                        parts[5],
                        DateTime.ParseExact(parts[6], "yyyy", CultureInfo.InvariantCulture));
                library.addBooks(currBook);
            }
            ListboxOutput();

        }
        private DateTime dateParser(string date)
        {
            if (date == "-")
            {
                return default(DateTime);
            }
            else return DateTime.Parse(date);
        }

        private void ListboxOutput()
        {
            listBox1.Items.Clear();
            LinkedList<string> LibraryInfo = library.getBooks();
            listBox1.Items.AddRange(LibraryInfo.ToArray());

        }

        private void FilteredListboxOutput(LinkedList<Book> books)
        {
            LinkedList<string> strBooks = new LinkedList<string>();
            foreach (Book book in books)
            {
                strBooks.AddLast(book.ToString());
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(strBooks.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string book_title = textBox1.Text;
            string book = library.getOneBook(book_title);

            if (book != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(book);
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Нет такой книги. Попробуйте ввести другое название.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int BookID = int.Parse(AddBookId.Text);
            string BookTopic = AddBookTopic.Text;
            string BookTitle = AddBookTitle.Text;
            string BookAuthor = AddBookAuthor.Text;
            bool BookState = AddBookState.Checked;

            if (BookState && DateTime.TryParse(AddBookIssueDate.Text, out DateTime BookIssueDate))
            {
                BookIssueDate = DateTime.Parse(AddBookIssueDate.Text);
            }
            else
            {
                BookIssueDate = default(DateTime);
            }

            if (DateTime.TryParseExact(AddReleaseDate.Text, "yyyy", null, DateTimeStyles.None, out DateTime ReleaseDate))
            {
                ReleaseDate = DateTime.ParseExact(AddReleaseDate.Text, "yyyy", CultureInfo.InvariantCulture);
            }

            Book book = new Book(BookID, BookTopic, BookState, BookIssueDate, BookTitle, BookAuthor, ReleaseDate);

            library.addBooks(book);
            ListboxOutput();
        }

        private class ErrorAddingEventHandler
        {
            public void ErrorMessage()
            {
                MessageBox.Show("Такая книга уже существует!");
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string topic = textBox4.Text;
            FilteredListboxOutput(library.GetFilteredList(topic));
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            int bookIDtoRemove = Int32.Parse(textBox2.Text);

            if (library.Deletion(bookIDtoRemove))
            {
                ListboxOutput();

            }
        }

        private void buttonShowAllBooks_click(object sender, EventArgs e)
        {
            ListboxOutput();
        }

        private void AddBookState_CheckedChanged(object sender, EventArgs e)
        {
            if (AddBookState.Checked)
            {
                AddBookIssueDate.ReadOnly = false;
            }
            else
            {
                AddBookIssueDate.ReadOnly = true;
            }

        }

        
    }
}
