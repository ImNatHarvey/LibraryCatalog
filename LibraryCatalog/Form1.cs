using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LibraryCatalog.Models; // 15. Import your namespace

namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        // Form styling and dragging components
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // 16. Declare a book list
        private List<Book> catalog;

        public Form1()
        {
            InitializeComponent();

            // Apply Rounded Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Initialize catalog and add default placeholder book
            catalog = new List<Book>();
            catalog.Add(new Book()); // Uses default constructor

            RefreshCatalog();
        }

        private void RefreshCatalog()
        {
            lstBooks.Items.Clear();
            foreach (Book book in catalog)
            {
                lstBooks.Items.Add($"{book.Title} | {book.ISBN}");
            }

            if (catalog.Count == 0)
            {
                txtDetails.Text = string.Empty;
            }
        }

        // 17. Code the Add Book button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string yearText = txtYear.Text.Trim();
            string copiesText = txtCopies.Text.Trim();

            // 21. Handle empty required fields
            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("ISBN, Title, and Author are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book newBook;

            if (string.IsNullOrEmpty(yearText) && string.IsNullOrEmpty(copiesText))
            {
                // Use Partial Constructor
                newBook = new Book(isbn, title, author);
            }
            else
            {
                // 22. Handle invalid year and copies input
                if (!int.TryParse(yearText, out int year) || !int.TryParse(copiesText, out int copies))
                {
                    MessageBox.Show("Year and Copies must be valid numbers.", "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use Full Constructor
                newBook = new Book(isbn, title, author, year, copies);
            }

            catalog.Add(newBook);
            RefreshCatalog();
            btnClear_Click(null, null); // Optional: clear fields after adding
        }

        // 18. Code the ListBox selection event
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0 && lstBooks.SelectedIndex < catalog.Count)
            {
                Book selectedBook = catalog[lstBooks.SelectedIndex];
                txtDetails.Text = selectedBook.GetDetails();
            }
        }

        // 19. Code the Borrow button
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                Book selectedBook = catalog[lstBooks.SelectedIndex];
                if (selectedBook.BorrowCopy())
                {
                    txtDetails.Text = selectedBook.GetDetails();
                }
                else
                {
                    MessageBox.Show("No copies available to borrow.", "Borrow Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 19. Code the Return button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                Book selectedBook = catalog[lstBooks.SelectedIndex];
                selectedBook.ReturnCopy();
                txtDetails.Text = selectedBook.GetDetails();
            }
        }

        // 20. Code Remove Book
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                catalog.RemoveAt(lstBooks.SelectedIndex);
                RefreshCatalog();
            }
        }

        // 20. Code Clear Fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtCopies.Clear();
            txtISBN.Focus();
        }

        // --- Custom Window Logic (Dragging & Closing) ---
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}