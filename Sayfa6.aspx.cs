using aspxliDeneme.sorgular;
using Org.BouncyCastle.Tsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace aspxliDeneme
{
    public partial class Sayfa6 : System.Web.UI.Page
    { 
        sorgularr dosyaSorgu = new sorgularr();
        public int id;
        public List<dynamic> list = new List<dynamic>();
        files file;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["kIddd"]);

            ImageMap4.ImageUrl = dosyaSorgu.imagesTabloGetir(dosyaSorgu.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = dosyaSorgu.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["kIddd"]);

            file = new files(fileNameText.Text.ToString(),
                fileTypeText.Text.ToString(),
                fileUrlText.Text.ToString(),
                descriptionText.Text.ToString(),
                id,
                DateTime.Now,
                " ",
                DateTime.Now,
                " ");
            dosyaSorgu.dosyaKayitProsedur(file);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            fileNameText.Text = " ";
            fileTypeText.Text = " ";
            fileUrlText.Text = " ";
            descriptionText.Text = " ";
        }
    }
}