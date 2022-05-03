using Lab3LINQ.Dialog;
using Lab3LINQ.Model;
using Lab3LINQ.Query;
using Lab3LINQ.Service;

namespace Lab3LINQ
{
    public partial class MainDialog : Form
    {
        DatabasePopulator databasePopulator = new DatabasePopulator();

        List<Author> authors;

        public MainDialog()
        {
            InitializeComponent();
            authors = databasePopulator.GetAuthorsList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Registry(authors).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label1.Text, new Query1()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label2.Text, new Query2()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label3.Text, new Query3()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label4.Text, new Query4()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label5.Text, new Query5()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label6.Text, new Query6()).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label7.Text, new Query7()).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label8.Text, new Query8()).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label9.Text, new Query9()).Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label10.Text, new Query10()).Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label11.Text, new Query11()).Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label12.Text, new Query12()).Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label13.Text, new Query13()).Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label14.Text, new Query14()).Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new QueryResult(authors, label15.Text, new Query15()).Show();
        }
    }
}