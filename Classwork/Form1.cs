﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork
{
    public partial class Form1 : Form
    {
        OnlineBookStoreEntities db = new OnlineBookStoreEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var book = db.Books.ToList();  
            var firstbook = db.Books.First(); 

            dataGridView1.DataSource = new List<Book> { firstbook };
        }
    }
}
