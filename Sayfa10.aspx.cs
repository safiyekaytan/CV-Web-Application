using aspxliDeneme.sorgular;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspxliDeneme
{
    public partial class Sayfa10 : System.Web.UI.Page
    {
        sorgularr userSorgu = new sorgularr();
        public int id;
        public Dictionary<string, dynamic> list = new Dictionary<string, dynamic>();
        public List<dynamic> list2 = new List<dynamic>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(Request.QueryString["kIddd"]);
            ImageMap4.ImageUrl = userSorgu.imagesTabloGetir(userSorgu.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list2 = userSorgu.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list2[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list2[1]);
            list = userSorgu.kullaniciGetir(id);
            users kullanici = new users(
                id, 
                list["name"], 
                list["lastName"], 
                list["email"], 
                list["phone"], 
                list["aboutMe"], 
                "userName", 
                "password", 
                list["country"], 
                list["adress"], 
                list["company"], 
                list["job"], 
                DateTime.Now, 
                "safiye", 
                DateTime.Now, 
                "kaytan");

            fullNameTitleText.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kullanici.Name) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kullanici.LastName);
            jobTitleText.Text = kullanici.Job;
            aboutText.Text = kullanici.AboutMe;
            companyText.Text = kullanici.Company;
            countryText.Text = kullanici.Country;
            adressText.Text = kullanici.Adress;
            emailText.Text = kullanici.Email;
            fullNameText.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kullanici.Name) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kullanici.LastName);

            int fotoId = userSorgu.blogGetir(id);
            String fotoUrl = userSorgu.imagesTabloGetir(fotoId);
            imageId.ImageUrl = fotoUrl;
            ImageMap4.ImageUrl = fotoUrl;
            
            

        }

        protected void createCV_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sayfa12.aspx?kullaniciId=" + Request.QueryString["kIddd"]);
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ddlCities.SelectedValue;
            id = Convert.ToInt32(Request.QueryString["kIddd"]);
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

        protected void talent_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sayfa14.aspx?kId=" + id);
        }
    }
}