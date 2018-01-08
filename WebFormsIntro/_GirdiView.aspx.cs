using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsIntro.Models;

namespace WebFormsIntro
{
    public partial class _GirdiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack==false)
            {
                ProjectDB db = new ProjectDB();
                GridView1.DataSource = db.Categories.ToList();
                GridView1.DataBind();
            }

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}