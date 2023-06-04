using System;
using System.Text;

namespace stp_1
{
    internal class Book
    {
        int BookID;
        string BookTopic;
        string BookTitle;
        string BookAuthor;
        bool BookState;
        DateTime BookIssueDate;
        DateTime ReleaseDate;

        public Book(int id, string topic, bool state, DateTime issueDate, string title, string author, DateTime releaseDate)
        {
            this.BookID = id;
            this.BookTopic = topic;
            this.BookState = state;
            this.BookIssueDate = issueDate;
            this.BookTitle = title;
            this.BookAuthor = author;
            this.ReleaseDate = releaseDate;
        }

        public int bookID
        {
            get { return BookID; }
            set { BookID = value; }
        }
        public string bookTopic
        {
            get { return BookTopic; }
            set { BookTopic = value; }
        }

        public bool bookState
        {
            get { return BookState; }
            set { BookState = value; }
        }

        public DateTime bookIssueDate
        {
            get { return BookIssueDate; }
            set { BookIssueDate = value; }
        }
        public string bookTitle
        {
            get { return BookTitle; }
            set { BookTitle = value; }
        }

        public string bookAuthor
        {
            get { return BookAuthor; }
            set { BookAuthor = value; }
        }
        public DateTime releaseDate
        {
            get { return ReleaseDate; }
            set { ReleaseDate = value; }
        }

        override
            public string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.bookID);
            str.Append(' ');
            str.Append(this.bookTopic);
            str.Append(' ');
            str.Append(this.bookTitle);
            str.Append(' ');
            str.Append(this.bookAuthor);
            str.Append(' ');
            str.Append(this.bookState);
            str.Append(' ');
            str.Append(this.bookIssueDate);
            str.Append(' ');
            str.Append(this.releaseDate);

            return str.ToString();
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Book p = (Book)obj;
                return bookID.Equals(p.bookID) && bookIssueDate.Equals(p.BookIssueDate)
                && bookState.Equals(p.BookState)
                    && bookTitle.Equals(p.BookTitle);

            }
        }
    }
}