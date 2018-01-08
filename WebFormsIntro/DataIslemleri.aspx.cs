using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsIntro.Models;

namespace WebFormsIntro
{
    public partial class DataIslemleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack==false)
            {
                ProjectDB db = new ProjectDB();
                ListView1.DataSource = db.Categories.ToList();
                //databind ile sayafaya modeli, aktarır.
                ListView1.DataBind();
            }
           
        }
    }
}