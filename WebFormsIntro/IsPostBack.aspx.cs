using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsIntro
{
    public partial class IsPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                drpIL.Items.Add("Ankara");
                drpIL.Items.Add("Istanbul");
            }
  
        }

        protected void drpIL_SelectedIndexChanged(object sender, EventArgs e)
        {

            drpIlace.Items.Clear();

            if (drpIL.Text=="Ankara")
            {
                drpIlace.Items.Add("Mamak");
                drpIlace.Items.Add("Çankaya");
            }
            else
            {
                drpIlace.Items.Add("Beşiktaş");
                drpIlace.Items.Add("Kadıköy");
            }

        }
    }
}