using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LibraryCatalog.Models;

namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private List<Book> catalog;

        public Form1()
        {
            InitializeComponent();

            // Apply Rounded Corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            catalog = new List<Book>();
            catalog.Add(new Book());

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string yearText = txtYear.Text.Trim();
            string copiesText = txtCopies.Text.Trim();

            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                CustomDialog.ShowMessage("ISBN, Title, and Author are required fields.", "Validation Error");
                return;
            }

            Book newBook;

            if (string.IsNullOrEmpty(yearText) && string.IsNullOrEmpty(copiesText))
            {
                newBook = new Book(isbn, title, author);
            }
            else
            {
                if (!int.TryParse(yearText, out int year) || !int.TryParse(copiesText, out int copies))
                {
                    CustomDialog.ShowMessage("Year and Copies must be valid numbers.", "Parse Error");
                    return;
                }

                newBook = new Book(isbn, title, author, year, copies);
            }

            catalog.Add(newBook);
            RefreshCatalog();
            btnClear_Click(null, null);
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0 && lstBooks.SelectedIndex < catalog.Count)
            {
                Book selectedBook = catalog[lstBooks.SelectedIndex];
                txtDetails.Text = selectedBook.GetDetails();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                Book selectedBook = catalog[lstBooks.SelectedIndex];
                if (selectedBook.BorrowCopy())
                {
                    txtDetails.Text = selectedBook.GetDetails();
                    CustomDialog.ShowMessage($"Success! You have borrowed a copy of:\n\n'{selectedBook.Title}'", "Borrow Successful");
                }
                else
                {
                    CustomDialog.ShowMessage($"Sorry, there are no copies of '{selectedBook.Title}' currently available to borrow.", "Borrow Failed");
                }
            }
            else
            {
                CustomDialog.ShowMessage("Please select a book from the catalog first.", "Selection Required");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                Book selectedBook = catalog[lstBooks.SelectedIndex];
                if (selectedBook.ReturnCopy())
                {
                    txtDetails.Text = selectedBook.GetDetails();
                    CustomDialog.ShowMessage($"Success! You have returned your copy of:\n\n'{selectedBook.Title}'", "Return Successful");
                }
                else
                {
                    CustomDialog.ShowMessage($"Invalid Return: All borrowed copies of '{selectedBook.Title}' have already been returned.", "Return Failed");
                }
            }
            else
            {
                CustomDialog.ShowMessage("Please select a book from the catalog first.", "Selection Required");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                catalog.RemoveAt(lstBooks.SelectedIndex);
                RefreshCatalog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtCopies.Clear();
            txtISBN.Focus();
        }

        // Dragging Logic
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