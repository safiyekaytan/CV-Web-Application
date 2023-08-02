using aspxliDeneme.sorgular;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspxliDeneme
{
    public partial class Sayfa9 : System.Web.UI.Page
    {
        sorgularr sorguSertifika = new sorgularr();
        public int id;
        public List<dynamic> list = new List<dynamic>();
        certificates certificate;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(Request.QueryString["kIddd"]);
            ImageMap4.ImageUrl = sorguSertifika.imagesTabloGetir(sorguSertifika.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorguSertifika.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
            
        }

        protected void submitButon_Click(object sender, EventArgs e)
        {
            certificate = new certificates(nameText.Text.ToString(),
                DateTime.Parse(dateText.Text.ToString()),
                instText.Text.ToString(),
                departmentText.Text.ToString(),
                id,
                DateTime.Now,
                " ",
                DateTime.Now,
                " ");
            sorguSertifika.sertifikaProsedur(certificate);

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
    }
}