using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork_4
{
    public partial class Form1 : Form
    {
        private ReadDBContainer _db = new ReadDBContainer();
        private Book selectedBook = null;

        public Form1()
        {
            InitializeComponent();
            var bookID = _db.Books.Select(x => x.Id).ToList();
            bookComboBox.DataSource = bookID;

            var authorList = _db.Authors.Select(x => new { x.Id, FullName = x.firstname + " " + x.lastname}).ToList();
            addAuthorComboBox.DataSource = authorList;
            addAuthorComboBox.DisplayMember = "FullName";
            addAuthorComboBox.ValueMember = "Id";

            var readerList = _db.Readers.Select(x => new { x.Id, FullName = x.firstname+ " " + x.lastname }).ToList();
            addReaderComboBox.DataSource = readerList;
            addReaderComboBox.DisplayMember = "FullName";
            addReaderComboBox.ValueMember = "Id";
        }

        private void booksLoadBtn_Click(object sender, EventArgs e)
        {
            var books = _db.Books.ToList();
            dataGridView1.DataSource = books;
        }

        private void authorLoadBtn_Click(object sender, EventArgs e)
        {
            var author = _db.Authors.ToList();
            dataGridView1.DataSource = author;
        }

        private void readersLoadBtn_Click(object sender, EventArgs e)
        {
            var reader = _db.Readers.ToList();
            dataGridView1.DataSource = reader;
        }

        private void booksAddBtn_Click(object sender, EventArgs e)
        {
            string title = titleTxt.Text;
            int publishYear = Convert.ToInt32(publishYearTxt.Text);

            int selectedAuthorId = (int)addAuthorComboBox.SelectedValue;
            int selectedReaderId = (int)addReaderComboBox.SelectedValue;

            Book newBook = new Book
            {
                Title = title,
                PublishedYear = publishYear,
                AuthorId = selectedAuthorId,
                ReaderId = selectedReaderId
            };

            _db.Books.Add(newBook);
            _db.SaveChanges();
            var books = _db.Books.ToList();
            dataGridView1.DataSource = books;
            var bookID = _db.Books.Select(x => x.Id).ToList();
            bookComboBox.DataSource = bookID;
        }

        private void booksDeleteBtn_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(bookComboBox.SelectedValue);
            Book selectedBook = _db.Books.FirstOrDefault(x => x.Id == bookID);
            _db.Books.Remove(selectedBook);
            _db.SaveChanges();
            dataGridView1.DataSource = _db.Books.ToList();
        }

        private void booksEditBtn_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                int bookID = Convert.ToInt32(bookComboBox.SelectedValue);
                selectedBook = _db.Books.First(x => x.Id == bookID);

                titleTxt.Text = selectedBook.Title;
                publishYearTxt.Text = selectedBook.PublishedYear.ToString();

                var authorList = _db.Authors
                                    .Select(x => new { x.Id, FullName = x.firstname+ " " + x.lastname}).ToList();
                addAuthorComboBox.DataSource = authorList;
                addAuthorComboBox.DisplayMember = "FullName";
                addAuthorComboBox.ValueMember = "Id";
                addAuthorComboBox.SelectedValue = selectedBook.AuthorId;

                var readerList = _db.Readers.Select(x => new { x.Id, FullName = x.firstname + " " + x.lastname }).ToList();
                addReaderComboBox.DataSource = readerList;
                addReaderComboBox.DisplayMember = "FullName";
                addReaderComboBox.ValueMember = "Id";
                addReaderComboBox.SelectedValue = selectedBook.ReaderId;
            }
            else
            {
                selectedBook.Title = titleTxt.Text;
                selectedBook.PublishedYear = Convert.ToInt32(publishYearTxt.Text);
                selectedBook.AuthorId = (int)addAuthorComboBox.SelectedValue;
                selectedBook.ReaderId = (int)addReaderComboBox.SelectedValue;

                _db.SaveChanges();
                dataGridView1.DataSource = _db.Books.ToList();
                selectedBook = null; 
            }

        }

    }

}
