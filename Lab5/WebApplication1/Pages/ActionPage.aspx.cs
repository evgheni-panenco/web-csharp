using System;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private string databaseConnectionUrl = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private static Random rand = new Random();

        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;

        public static string bookId;

        protected void Page_Load(object sender, EventArgs e)
        {
            Book book;

            try
            {
                if (!Page.IsPostBack)
                {
                    bookId = RouteData.Values["bookId"].ToString();

                    if (bookId == "newBook")
                    {
                        updtBtn.Enabled = false;
                        dltBtn.Enabled = false;
                    }
                    else
                    {
                        addButton.Enabled = false;
                        using (BookModel bookModel = new BookModel())
                        {
                            book = bookModel.Books.Find(Int32.Parse(bookId));
                            ddGen.Text = book.Genre;
                            txtTitle.Text = book.Title;
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                RedirectToMainPage();
            }
            
        }

        public void ClearAllData()
        {
            err_msg.Visible = false;
            txtTitle.Text = String.Empty;
            ddGen.SelectedIndex = 0;
        }

        protected void cnclBtn_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        protected void RedirectToMainPage()
        {
            Response.Redirect(GetRouteUrl("MainPage"));
        }

        protected void dltBtn_Click(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(databaseConnectionUrl))
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("Delete From Book Where Id=@id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", bookId);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                ClearAllData();

                RedirectToMainPage();
            }
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && ddGen.SelectedValue.ToString() != "")
            {
                using (sqlConnection = new SqlConnection(databaseConnectionUrl))
                {
                    sqlConnection.Open();

                    int id = rand.Next(99999999);

                    sqlCommand = new SqlCommand(
                        "Insert Into Book (Id, Title, Genre) Values(@id, @title, @genre)", 
                        sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@title", txtTitle.Text);
                    sqlCommand.Parameters.AddWithValue("@genre", ddGen.SelectedValue);
                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    RedirectToMainPage();
                }
            }
            else
            {
                ShowError();
            }
        }

        protected void updtBtn_Click(object sender, EventArgs e)
        {
            bool isValidated = txtTitle.Text != "" && ddGen.SelectedValue.ToString() != "";

            if (!isValidated)
            {
                ShowError();
                return;
            }

            using (sqlConnection = new SqlConnection(databaseConnectionUrl))
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("Update Book Set Title=@name, Genre=@genre Where Id=@id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", txtTitle.Text);
                sqlCommand.Parameters.AddWithValue("@genre", ddGen.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@id", bookId);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                RedirectToMainPage();
            }
        }

        private void ShowError()
        {
            err_msg.Visible = true;
            err_msg.Text = "Validation failed for one or more fields!";
        }

        protected void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        protected void goBack(object sender, EventArgs e) => RedirectToMainPage();
    }
}