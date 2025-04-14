using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_10
{
    public partial class addButton : Form
    {
        private OnlineBookStoreEntities _db = new OnlineBookStoreEntities();

        public addButton()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Books.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book newBook = new Book()
            {
                Title = "The C# Programming Language",  
                Author = "John Doe",                 
                ISBN = "978-1234567890",               
                Price = 29,                         
                Stock = 100,                          
                PublishedDate = DateTime.Now
            };
            _db.Books.Add(newBook);
            _db.SaveChanges();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = 9;
            Book book = _db.Books.FirstOrDefault(x=>x.BookID == id);
            book.Price = 20;
            _db.SaveChanges();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = 8;
            Book book = _db.Books.FirstOrDefault(x => x.BookID == id);
            _db.Books.Remove(book);
            _db.SaveChanges();
        }
    }
}
