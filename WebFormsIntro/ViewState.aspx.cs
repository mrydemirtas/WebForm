using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsIntro
{
    public partial class ViewState : System.Web.UI.Page
    {
        private int sayac = 0;
        //sayfalama yapıların muhteşem bir hayat kurtarıcı
        
        private int Sayac
        {
            get
            {
                if (ViewState["Sayac"]==null)
                {
                    return 0;
                }
                else
                {
                    return (int)ViewState["Sayac"];
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ViewState["Sayac"] = Sayac;
            ViewState["Sayac"] = (int)ViewState["Sayac"] + 1;

            Label1.Text = Sayac.ToString();
        }
    }
}