using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsIntro
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kullanıcını sayfa ile her bir etkileşiminde sayfa yeniden yüklenir.
            //sayfa ilk açılışta isPostback false tur. daha sonra her bir sayfanın post edilmesinde true olur.

            if (IsPostBack==true)
            {
                return;
            }
            else
            {

                //int id = int.Parse(Request.QueryString["categoryId"]);
                //Response.Write("id = " + id);
                //form load kodlarını çalıştır.
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Merhaba Web Forms";
            Label1.Style.Add("color", "red"); 


        }
    }
}