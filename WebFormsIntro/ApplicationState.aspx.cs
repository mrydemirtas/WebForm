using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsIntro
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //sunucu tarafında her bir client verilen unique session oturum idsi
           var sessionId =  Session.SessionID;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Kullanıcının sunucuda oluşturulan session sonlandırır.
            Session.Abandon();
        }
    }
}