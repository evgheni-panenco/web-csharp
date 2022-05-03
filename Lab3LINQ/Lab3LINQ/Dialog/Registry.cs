using Lab3LINQ.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3LINQ.Dialog
{
    public partial class Registry : Form
    {
        public Registry(List<Author> authors)
        {
            InitializeComponent();

            dataGridView1.DataSource = authors;

            List<Book> books = authors.SelectMany(b => b.Books).ToList();
            dataGridView2.DataSource = books;
        }
    }
}
