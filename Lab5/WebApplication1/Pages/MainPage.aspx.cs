using System;
using System.Web.UI;

namespace WebApplication1
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        public void DataLoad()
        {
            if (Page.IsPostBack)
            {
                dbBook.DataBind();
            }
        }

        protected void dbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect(GetRouteUrl("ActionPage", new
            {
                bookId = Int32.Parse(dbBook.SelectedRow.Cells[1].Text)
            }));
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect(GetRouteUrl("ActionPage", new
            {
                bookId = "newBook"
            }));
        }
    }
}