using Lab3LINQ.Model;
using Lab3LINQ.Service;
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
    public partial class QueryResult : Form
    {
        public QueryResult(List<Author> authors, string requestDescription, IQuery<Author, Book> query)
        {
            InitializeComponent();
            label2.Text = requestDescription;
            label5.Text = query.QueryValue();

            dataGridView1.DataSource = query.ExecuteQuery(authors);

            label7.Text = "";
            label6.Text = "";
        }

        public QueryResult(List<Author> authors, string requestDescription, IQuery<Author, string> query)
        {
            InitializeComponent();
            label2.Text = requestDescription;
            label5.Text = query.QueryValue();

            label7.Text = query.ExecuteQuery(authors)[0];
        }

        public QueryResult(List<Author> authors, string requestDescription, IQuery<Author, IGrouping<Genre, Book>> query)
        {
            InitializeComponent();
            label2.Text = requestDescription;
            label5.Text = query.QueryValue();

            var group = query.ExecuteQuery(authors);

            StringBuilder sb = new StringBuilder();
            foreach (var genreGroup in group)
            {
                sb.AppendFormat("\n### Genre {0} ###\n", genreGroup.Key);
                foreach (var book in genreGroup)
                {
                    sb.AppendFormat("{0}\n", book.Title);
                }
            }
                
            label7.Text = sb.ToString();
        }

        public QueryResult(List<Author> authors, string requestDescription, IQuery<Author, IGrouping<Author, Book>> query)
        {
            InitializeComponent();
            label2.Text = requestDescription;
            label5.Text = query.QueryValue();

            var group = query.ExecuteQuery(authors);

            StringBuilder sb = new StringBuilder();
            foreach (var genreGroup in group)
            {
                sb.AppendFormat("\n### Author {0} ###\n", genreGroup.Key);
                foreach (var book in genreGroup)
                {
                    sb.AppendFormat("{0}\n", book.Title);
                }
            }

            label7.Text = sb.ToString();
        }
    }
}
