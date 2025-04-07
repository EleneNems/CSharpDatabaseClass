using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_7
{
    public partial class Form1 : Form
    {

        OnlineBookStoreEntities2 db = new OnlineBookStoreEntities2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var book = db.Books.ToList();

            var book1 = db.Books.Select(x => new { price = x.Price, author = x.Author }).ToList();
            dataGridView1.DataSource = book1;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            var filteredData = db.Books.Where(x => x.Price > 30).Select(x=> new { price = x.Price, author = x.Author }).ToList();

            dataGridView1.DataSource = filteredData;

        }
    }
}
