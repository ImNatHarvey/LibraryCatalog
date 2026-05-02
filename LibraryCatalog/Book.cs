using System;

namespace LibraryCatalog.Models
{
    public class Book
    {
        private string _isbn;
        private string _title;
        private string _author;
        private int _year;
        private int _copies;
        private int _borrowedCopies;

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1450 || value > DateTime.Now.Year)
                    _year = 1450;
                else
                    _year = value;
            }
        }

        public int Copies
        {
            get { return _copies; }
            set
            {
                if (value < 0)
                    _copies = 0;
                else
                    _copies = value;
            }
        }

        public Book()
        {
            ISBN = "000-0000000000";
            Title = "Untitled";
            Author = "Unknown";
            Year = 1450;
            Copies = 0;
            _borrowedCopies = 0; 
        }

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = 1450;
            Copies = 0;
            _borrowedCopies = 0; 
        }

        public Book(string isbn, string title, string author, int year, int copies)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = year;
            Copies = copies;
            _borrowedCopies = 0; 
        }

        public string GetDetails()
        {
            return $"Title: {Title}\r\n" +
                   $"Author: {Author}\r\n" +
                   $"ISBN: {ISBN}\r\n" +
                   $"Year Published: {Year}\r\n" +
                   $"Copies Available: {Copies}\r\n" +
                   $"Copies Borrowed Out: {_borrowedCopies}";
        }

        public bool BorrowCopy()
        {
            if (Copies > 0)
            {
                Copies--;
                _borrowedCopies++; 
                return true;
            }
            return false;
        }

        public bool ReturnCopy()
        {
            if (_borrowedCopies > 0)
            {
                Copies++;
                _borrowedCopies--; 
                return true;
            }
            return false;
        }
    }
}