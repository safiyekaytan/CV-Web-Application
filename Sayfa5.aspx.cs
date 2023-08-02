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
    public partial class Sayfa5 : System.Web.UI.Page
    {
        sorgularr sorguDeneyim = new sorgularr();
        experiences experience;
        public int id;
        public List<dynamic> list = new List<dynamic>();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["kIddd"]);

            ImageMap4.ImageUrl = sorguDeneyim.imagesTabloGetir(sorguDeneyim.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorguDeneyim.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["kIddd"]);

            experience = new experiences(positionText.Text.ToString(),
                departmentText.Text.ToString(),
                companyText.Text.ToString(),
                DateTime.Parse(startText.Text.ToString()),
                DateTime.Parse(endText.Text.ToString()),
                descriptionText.Text.ToString(),
                id,
                DateTime.Now,
                " ",
                DateTime.Now,
                " "
                );
            sorguDeneyim.deneyimEkleProsedur(experience);


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