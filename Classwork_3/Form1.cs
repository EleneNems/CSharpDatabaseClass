using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Classwork_3
{
    public partial class Form1 : Form
    {
        BookDBContainer db = new BookDBContainer();
        private Book selectedBook = null;
        public Form1()
        {
            InitializeComponent();
            var bookID = db.Books.Select(x=>x.Id).ToList();
            idBox.DataSource = bookID;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var books = db.Books.ToList();
            dataGridView1.DataSource = books;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string author = authorTxt.Text;
            int publishYearInt = Convert.ToInt32(publishYear.Text);
            int price = Convert.ToInt32( priceTxt.Text);

            Book newBook = new Book
            {
                Name = name,
                Author = author,
                PublishedYear = publishYearInt,
                Price = price
            };

            db.Books.Add(newBook);
            db.SaveChanges();
            dataGridView1.DataSource = db.Books.ToList();
            var bookID = db.Books.Select(x => x.Id).ToList();
            idBox.DataSource = bookID;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                int bookID = Convert.ToInt32(idBox.SelectedValue);
                selectedBook = db.Books.First(x => x.Id == bookID);

                nameTxt.Text = selectedBook.Name;
                authorTxt.Text = selectedBook.Author;
                publishYear.Text = selectedBook.PublishedYear.ToString();
                priceTxt.Text = selectedBook.Price.ToString();
            }
            else
            {
                selectedBook.Name = nameTxt.Text;
                selectedBook.Author = authorTxt.Text;
                selectedBook.PublishedYear = Convert.ToInt32(publishYear.Text);
                selectedBook.Price = Convert.ToInt32(priceTxt.Text);

                db.SaveChanges();
                dataGridView1.DataSource = db.Books.ToList();
                selectedBook = null;

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(idBox.SelectedValue);

            Book selectedBook = db.Books.FirstOrDefault(x => x.Id == bookID);
            db.Books.Remove(selectedBook);
            db.SaveChanges();
            dataGridView1.DataSource = db.Books.ToList();
        }
    }
}
