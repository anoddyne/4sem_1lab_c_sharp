using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stp_1
{
    internal class Library
    {
        LinkedList<Book> books = new LinkedList<Book>();

        public delegate void ErrorAddingBook();
        public event ErrorAddingBook NotAdded;
        public Library() { }

        public Library(LinkedList<Book> book)
        {
            this.books = book;
        }

        public void addBooks(Book book)
        {
            if (CheckIfContains(book))
            {
                NotAdded?.Invoke();
            }
            else
            {
                books.AddLast(book);
            }

        }

        public bool CheckIfContains(Book book)
        {
            foreach (Book book1 in books)
            {
                if (book1.Equals(book)) return true;
            }
            return false;
        }

        public LinkedList<string> getBooks()
        {
            LinkedList<string> result = new LinkedList<string>();

            foreach (Book book in this.books)
            {
                StringBuilder CurrString = new StringBuilder();
                CurrString.Append(book.bookID);
                CurrString.Append(' ');
                CurrString.Append(book.bookTopic);
                CurrString.Append(' ');
                CurrString.Append(book.bookState);
                CurrString.Append(" ");
                CurrString.Append(book.bookIssueDate.Date);
                CurrString.Append(" ");
                CurrString.Append(book.bookTitle);
                CurrString.Append(" ");
                CurrString.Append(book.bookAuthor);
                CurrString.Append(" ");
                CurrString.Append(book.releaseDate.Date);

                result.AddLast(CurrString.ToString());

            }
            return result;

        }
        public string getOneBook(string book_title)
        {
            foreach (Book book in this.books)
            {
                if (book.bookTitle == book_title)
                {
                    StringBuilder CurrString = new StringBuilder();
                    CurrString.Append(book.bookID);
                    CurrString.Append(' ');
                    CurrString.Append(book.bookTopic);
                    CurrString.Append(' ');
                    CurrString.Append(book.bookState);
                    CurrString.Append(" ");
                    CurrString.Append(book.bookIssueDate.Date);
                    CurrString.Append(" ");
                    CurrString.Append(book.bookTitle);
                    CurrString.Append(" ");
                    CurrString.Append(book.bookAuthor);
                    CurrString.Append(" ");
                    CurrString.Append(book.releaseDate.Date);

                    return CurrString.ToString();
                }

            }
            return null;
        }

        public LinkedList<Book> GetFilteredList(string topic)
        {

            LinkedList<Book> filteredResult = new LinkedList<Book>(books.Where(x => x.bookTopic == topic));
            return filteredResult;

        }

        public bool Deletion(int id)
        {
            LinkedListNode<Book> currNode = books.First;
            while (currNode != null)
            {
                if (currNode.Value.bookID == id)
                {
                    books.Remove(currNode);
                    return true;
                }
                currNode = currNode.Next;
            }
            MessageBox.Show("Книга с таким ID не найдена!");
            return false;
        }

       
    }
}
