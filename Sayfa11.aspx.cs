using aspxliDeneme.sorgular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspxliDeneme
{
    public partial class Sayfa11 : System.Web.UI.Page
    {
        sorgularr kayitolSorgu = new sorgularr();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(kayitolSorgu.kayitKontrolProsedur(userNameText.Text.ToString(), passwordText.Text.ToString()) == null){
                ///boyle bir kullanici yoksa kayit yap
                kayitolSorgu.yeniKayitOlusturProsedur(userNameText.Text.ToString(), passwordText.Text.ToString());
            }
            else
            {
                userNameText.Text = "Bu userName e kayitli bir hesap vardir!";
                //BÖYLE BİR KULLANICI ZATEN VAR
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginPage.aspx");
        }
    }
}