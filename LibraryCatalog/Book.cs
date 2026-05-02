using System;

namespace LibraryCatalog.Models
{
    public class Book
    {
        // 4. Declare private instance variables
        private string _isbn;
        private string _title;
        private string _author;
        private int _year;
        private int _copies;

        // 5. Create public properties for each field
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
                // Reject values below 1450 or above current year
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
                // Reject values below 0
                if (value < 0)
                    _copies = 0;
                else
                    _copies = value;
            }
        }

        // 6. Default constructor
        public Book()
        {
            ISBN = "000-0000000000";
            Title = "Untitled";
            Author = "Unknown";
            Year = 1450;
            Copies = 0;
        }

        // 7. Partial overloaded constructor (leaves Year and Copies at defaults)
        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = 1450; // Default
            Copies = 0;  // Default
        }

        // 8. Full overloaded constructor (assigns via properties to run validation)
        public Book(string isbn, string title, string author, int year, int copies)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = year;     // Will route through validation
            Copies = copies; // Will route through validation
        }

        // 9. GetDetails() method
        public string GetDetails()
        {
            return $"Title: {Title}\r\n" +
                   $"Author: {Author}\r\n" +
                   $"ISBN: {ISBN}\r\n" +
                   $"Year Published: {Year}\r\n" +
                   $"Copies Available: {Copies}";
        }

        // 10. BorrowCopy() and ReturnCopy() methods
        public bool BorrowCopy()
        {
            if (Copies > 0)
            {
                Copies--;
                return true;
            }
            return false;
        }

        public void ReturnCopy()
        {
            Copies++;
        }
    }
}