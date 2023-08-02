using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using aspxliDeneme.sorgular;

namespace aspxliDeneme
{
    public partial class Sayfa2 : System.Web.UI.Page
    {
        sorgularr sorgu2 = new sorgularr();
        users user;
        public String kullaniciId;
        public String kullaniciName;
        public String kullaniciSifre;
        public List<String> loginDataAlinan = new List<String>();
        public int id;
        public List<dynamic> list = new List<dynamic>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(Request.QueryString["kId"]);

            ImageMap4.ImageUrl = sorgu2.imagesTabloGetir(sorgu2.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorgu2.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);

            ImageMap1.ImageUrl = sorgu2.imagesTabloGetir(sorgu2.blogGetir(id));
            ImageMap2.ImageUrl = sorgu2.imagesTabloGetir(sorgu2.blogGetir(id));
            isim.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
            meslek.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[5]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //userNamesine göre userIdsini çek

            loginDataAlinan.Add(Request.QueryString["kId"]);

            loginDataAlinan.Add(Request.QueryString["kName"]);

            loginDataAlinan.Add(Request.QueryString["kPassword"]);

            user = new users(Convert.ToInt32(Request.QueryString["kId"]),
                page2Name.Text.ToString(),
                page2Lastname.Text.ToString(),
                page2Email.Text.ToString(),
                Convert.ToInt32(page2Phone.Text),
                page2Aboutme.Text.ToString(),
                loginDataAlinan[1],
                loginDataAlinan[2],
                countryText.Text.ToString(),
                adressText.Text.ToString(),
                companyText.Text.ToString(),
                jobText.Text.ToString(),
                DateTime.Now,
                " ",
                DateTime.Now,
                " "
                );
            sorgu2.kayitGuncelleProsedur(user);
        }

        void veriGonder(String page)
        {
            loginDataAlinan.Add(Request.QueryString["kId"]);



            Response.Redirect(page + ".aspx?kIddd=" + loginDataAlinan[0]);
        }
        protected void changePassword_Click(object sender, EventArgs e)
        {
            loginDataAlinan.Add(Request.QueryString["kId"]);
            loginDataAlinan.Add(Request.QueryString["kPassword"]);
            Response.Redirect("Sayfa3.aspx?kIdd=" + loginDataAlinan[0] + "&kPasswordd=" + loginDataAlinan[1]);
        }

        protected void overview_Click(object sender, EventArgs e)
        {
            veriGonder("Sayfa10");
        }

        protected void education_Click(object sender, EventArgs e)
        {
            veriGonder("Sayfa4");
        }

        protected void experiences_Click(object sender, EventArgs e)
        {
            veriGonder("Sayfa5");
        }

        protected void files_Click(object sender, EventArgs e)
        {
            veriGonder("Sayfa6");
        }

        protected void images_Click(object sender, EventArgs e)
        {
            veriGonder("Sayfa7");
        }

        protected void blog_Click(object sender, EventArgs e)
        {
            veriGonder("Sayfa8");
        }

        protected void certificates_Click(object sender, EventArgs e)
        {
            veriGonder("Sayfa9");
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DropDownList'teki seçilen öğenin değerini alalım
            string selectedValue = ddlCities.SelectedValue;

            // Seçilen öğenin değeri 5'e eşitse, istediğiniz işlemi burada gerçekleştirin.
            if (selectedValue == "signout")
            {
                loginDataAlinan.Clear();
                Response.Redirect("loginPage.aspx");
                //      ALERT             ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seçilen şehir Seattle.');", true);

            }
            if (selectedValue == "myprofile")
            {
                Page_Load(sender, e);
                //      ALERT             ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seçilen şehir Seattle.');", true);

            }
            if (selectedValue == "contact")
            {
                veriGonder("Sayfa13");
                //      ALERT             ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seçilen şehir Seattle.');", true);

            }
        }
    }
}