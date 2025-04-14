using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork_2
{
    public partial class Form1 : Form
    {
        private OnlineBookStoreEntities _db = new OnlineBookStoreEntities();
        private Book selectedBook = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bookID = _db.Books.Select(x=> x.BookID).ToList();
            IDComboBox.DataSource = bookID;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Books.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title = titleText.Text; 
            string author = authorText.Text; 
            string isbn = IsbnText.Text; 
            int price = Convert.ToInt32(PriceText.Text); 
            int stock = Convert.ToInt32(StockText.Text);
            DateTime publishDate = publishDatePicker.Value;

            Book newBook = new Book
            {
                Title = title,
                Author = author,    
                ISBN = isbn,
                Price = price,
                Stock = stock,
                PublishedDate = publishDate,
            };

            _db.Books.Add(newBook);
            _db.SaveChanges();

            dataGridView1.DataSource = _db.Books.ToList();
            var bookID = _db.Books.Select(x => x.BookID).ToList();
            IDComboBox.DataSource = bookID;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                int bookID = Convert.ToInt32(IDComboBox.SelectedValue);

                selectedBook = _db.Books.FirstOrDefault(x => x.BookID == bookID); 

                titleText.Text = selectedBook.Title;
                authorText.Text = selectedBook.Author;
                IsbnText.Text = selectedBook.ISBN;
                PriceText.Text = selectedBook.Price.ToString();
                StockText.Text = selectedBook.Stock.ToString();
                publishDatePicker.Value = (DateTime)selectedBook.PublishedDate;
                  
            }
            else
            {
                selectedBook.Title = titleText.Text;
                selectedBook.Author = authorText.Text;
                selectedBook.ISBN = IsbnText.Text;
                selectedBook.Price = Convert.ToDecimal(PriceText.Text);
                selectedBook.Stock = Convert.ToInt32(StockText.Text);
                selectedBook.PublishedDate = publishDatePicker.Value;

                _db.SaveChanges();
                selectedBook = null;
                dataGridView1.DataSource = _db.Books.ToList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(IDComboBox.SelectedValue);

            Book selectedBook = _db.Books.FirstOrDefault(x => x.BookID == bookID);
            _db.Books.Remove(selectedBook);
            _db.SaveChanges();
            dataGridView1.DataSource = _db.Books.ToList();
        }
    }
}
