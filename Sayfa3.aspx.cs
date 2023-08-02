using aspxliDeneme.sorgular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Net;
using System.Net.Mail;
using SmtpClient = System.Net.Mail.SmtpClient;
using System.Globalization;

namespace aspxliDeneme
{
    public partial class Sayfa3 : System.Web.UI.Page
    {   sorgularr sorgu = new sorgularr();
        public List<String> loginDataAlinan = new List<String>();
        public Dictionary<string, dynamic> mail = new Dictionary<string, dynamic>();
        public int id;
        public List<dynamic> list = new List<dynamic>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(Request.QueryString["kIdd"]);

            ImageMap1.ImageUrl = sorgu.imagesTabloGetir(sorgu.blogGetir(id));

            ImageMap4.ImageUrl = sorgu.imagesTabloGetir(sorgu.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorgu.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);

            isim.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
            meslek.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[5]);
        }

        protected void changePassword2_Click(object sender, EventArgs e)
        {
            controlPassword();
        }
        void controlPassword()
        {
            
            loginDataAlinan.Add(Request.QueryString["kIdd"]); //id
            loginDataAlinan.Add(Request.QueryString["kPasswordd"]); //sifre
            if (loginDataAlinan[1] == mevcutSifre.Text.ToString())
            {
                if (yeniSifre1.Text.ToString() == yeniSifre2.Text.ToString())
                {
                    sorgu.sifreDegistirProsedur(Convert.ToInt32(loginDataAlinan[0]), yeniSifre1.Text.ToString());
                }
            }
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ddlCities.SelectedValue;
            loginDataAlinan.Add(Request.QueryString["kIdd"]);
            id = Convert.ToInt32(loginDataAlinan[0]); //sifre

            if (selectedValue == "signout")
            {
                Response.Redirect("loginPage.aspx");
                //      ALERT             ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seçilen şehir Seattle.');", true);

            }
            if (selectedValue == "myprofile")
            {
                Response.Redirect("Sayfa2.aspx?kId=" + id);
                //      ALERT             ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seçilen şehir Seattle.');", true);

            }
            if (selectedValue == "contact")
            {
                Response.Redirect("Sayfa13.aspx?kIddd=" + id);
                //      ALERT             ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seçilen şehir Seattle.');", true);
            }
        }
        /*
void a()
{
   MailMessage msg = new MailMessage();
   msg.Subject = "Asp.Net Send Mail";
   msg.From = new MailAddress("safiyekaytanStmp@gmail.com", "Safiye Kaytan");
   msg.To.Add(new MailAddress("safiyekytn@gmail.com", "Görünen Ad"));
   msg.Body = "Mesajınız... <br>" + msg.From.Address;
   msg.IsBodyHtml = true;
   msg.Priority = MailPriority.High;
   // Host ve Port Gereklidir!

   SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25);
   // Güvenli bağlantı gerektiğinden kullanıcı adı ve şifrenizi giriniz.
   NetworkCredential AccountInfo = new NetworkCredential("safiyekaytanStmp@gmail.com", "stmp1234");
   smtp.UseDefaultCredentials = false;
   smtp.Credentials = AccountInfo;
   smtp.EnableSsl = true;
   smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
   smtp.Send(msg);
}
*/


    }
}