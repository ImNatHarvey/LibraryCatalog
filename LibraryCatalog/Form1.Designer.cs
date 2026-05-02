namespace LibraryCatalog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.btnAdd = new ReaLTaiizor.Controls.HopeButton();
            this.btnClear = new ReaLTaiizor.Controls.HopeButton();
            this.btnRemove = new ReaLTaiizor.Controls.HopeButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblCatalog = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnBorrow = new ReaLTaiizor.Controls.HopeButton();
            this.btnReturn = new ReaLTaiizor.Controls.HopeButton();
            this.panelTopBar.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55))))); // Gold
            this.panelTopBar.Controls.Add(this.lblClose);
            this.panelTopBar.Controls.Add(this.lblHeader);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(800, 45);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(765, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 21);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(193, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Library Book Catalog";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.lblAddBook);
            this.panelLeft.Controls.Add(this.lblISBN);
            this.panelLeft.Controls.Add(this.txtISBN);
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Controls.Add(this.txtTitle);
            this.panelLeft.Controls.Add(this.lblAuthor);
            this.panelLeft.Controls.Add(this.txtAuthor);
            this.panelLeft.Controls.Add(this.lblYear);
            this.panelLeft.Controls.Add(this.txtYear);
            this.panelLeft.Controls.Add(this.lblCopies);
            this.panelLeft.Controls.Add(this.txtCopies);
            this.panelLeft.Controls.Add(this.btnAdd);
            this.panelLeft.Controls.Add(this.btnClear);
            this.panelLeft.Controls.Add(this.btnRemove);
            this.panelLeft.Location = new System.Drawing.Point(20, 65);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(350, 480);
            this.panelLeft.TabIndex = 1;
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblAddBook.Location = new System.Drawing.Point(15, 15);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(148, 21);
            this.lblAddBook.TabIndex = 0;
            this.lblAddBook.Text = "Add Book Details";
            // 
            // Labels and TextBoxes
            // 
            this.lblISBN.AutoSize = true; this.lblISBN.Location = new System.Drawing.Point(15, 60); this.lblISBN.Name = "lblISBN"; this.lblISBN.Text = "ISBN:";
            this.txtISBN.Location = new System.Drawing.Point(18, 80); this.txtISBN.Size = new System.Drawing.Size(310, 23); this.txtISBN.Name = "txtISBN";

            this.lblTitle.AutoSize = true; this.lblTitle.Location = new System.Drawing.Point(15, 115); this.lblTitle.Name = "lblTitle"; this.lblTitle.Text = "Title:";
            this.txtTitle.Location = new System.Drawing.Point(18, 135); this.txtTitle.Size = new System.Drawing.Size(310, 23); this.txtTitle.Name = "txtTitle";

            this.lblAuthor.AutoSize = true; this.lblAuthor.Location = new System.Drawing.Point(15, 170); this.lblAuthor.Name = "lblAuthor"; this.lblAuthor.Text = "Author:";
            this.txtAuthor.Location = new System.Drawing.Point(18, 190); this.txtAuthor.Size = new System.Drawing.Size(310, 23); this.txtAuthor.Name = "txtAuthor";

            this.lblYear.AutoSize = true; this.lblYear.Location = new System.Drawing.Point(15, 225); this.lblYear.Name = "lblYear"; this.lblYear.Text = "Year Published (Optional):";
            this.txtYear.Location = new System.Drawing.Point(18, 245); this.txtYear.Size = new System.Drawing.Size(145, 23); this.txtYear.Name = "txtYear";

            this.lblCopies.AutoSize = true; this.lblCopies.Location = new System.Drawing.Point(180, 225); this.lblCopies.Name = "lblCopies"; this.lblCopies.Text = "Copies (Optional):";
            this.txtCopies.Location = new System.Drawing.Point(183, 245); this.txtCopies.Size = new System.Drawing.Size(145, 23); this.txtCopies.Name = "txtCopies";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnAdd.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAdd.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAdd.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.HoverTextColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnAdd.Size = new System.Drawing.Size(310, 40);
            this.btnAdd.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.LightGray;
            this.btnClear.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnClear.DefaultColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(18, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.PrimaryColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(145, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.TextColor = System.Drawing.Color.Gray;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderColor = System.Drawing.Color.LightGray;
            this.btnRemove.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnRemove.DefaultColor = System.Drawing.Color.LightGray;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(183, 355);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.PrimaryColor = System.Drawing.Color.White;
            this.btnRemove.Size = new System.Drawing.Size(145, 35);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove Book";
            this.btnRemove.TextColor = System.Drawing.Color.IndianRed;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panelRight (Catalog)
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.lblCatalog);
            this.panelRight.Controls.Add(this.lstBooks);
            this.panelRight.Controls.Add(this.lblDetails);
            this.panelRight.Controls.Add(this.txtDetails);
            this.panelRight.Controls.Add(this.btnBorrow);
            this.panelRight.Controls.Add(this.btnReturn);
            this.panelRight.Location = new System.Drawing.Point(390, 65);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(390, 480);
            this.panelRight.TabIndex = 2;
            // 
            // lblCatalog
            // 
            this.lblCatalog.AutoSize = true;
            this.lblCatalog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblCatalog.Location = new System.Drawing.Point(15, 15);
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(111, 21);
            this.lblCatalog.TabIndex = 0;
            this.lblCatalog.Text = "Book Catalog";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 15;
            this.lstBooks.Location = new System.Drawing.Point(18, 45);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(350, 169);
            this.lstBooks.TabIndex = 1;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetails.ForeColor = System.Drawing.Color.Gray;
            this.lblDetails.Location = new System.Drawing.Point(15, 230);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(95, 19);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Book Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(18, 255);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(350, 120);
            this.txtDetails.TabIndex = 3;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnBorrow.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnBorrow.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrow.Location = new System.Drawing.Point(18, 395);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnBorrow.Size = new System.Drawing.Size(165, 40);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Borrow Copy";
            this.btnBorrow.TextColor = System.Drawing.Color.White;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnReturn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnReturn.DefaultColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(203, 395);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PrimaryColor = System.Drawing.Color.White;
            this.btnReturn.Size = new System.Drawing.Size(165, 40);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return Copy";
            this.btnReturn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))); // Light off-white
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTopBar);
            this.Name = "Form1";
            this.Text = "Library Catalog";
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtCopies;
        private ReaLTaiizor.Controls.HopeButton btnAdd;
        private ReaLTaiizor.Controls.HopeButton btnClear;
        private ReaLTaiizor.Controls.HopeButton btnRemove;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblCatalog;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private ReaLTaiizor.Controls.HopeButton btnBorrow;
        private ReaLTaiizor.Controls.HopeButton btnReturn;
    }
}