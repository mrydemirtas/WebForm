using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsIntro.Models;

namespace WebFormsIntro
{
    public partial class DataRepeate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProjectDB db = new ProjectDB();
            Repeater1.DataSource = db.Categories.ToList();
            Repeater1.DataBind();
        }
    }
}