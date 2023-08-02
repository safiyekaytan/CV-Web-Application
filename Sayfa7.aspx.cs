using aspxliDeneme.sorgular;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace aspxliDeneme
{
    public partial class Sayfa7 : System.Web.UI.Page
    {
        sorgularr fotoSorgu = new sorgularr();
        public int id;
        public List<dynamic> list = new List<dynamic>();
        images image;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(Request.QueryString["kIddd"]);
            
            ImageMap4.ImageUrl = fotoSorgu.imagesTabloGetir(fotoSorgu.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = fotoSorgu.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);

        }

        protected void TextBox33_TextChanged(object sender, EventArgs e)
        {

        }
        protected void TextBox33_Click(object sender, EventArgs e)
        {/*
            if(TextBox11.Text.ToString() != null)
            {
                TextBox11.Enabled = false;
            }
            */
        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //fotoyu kaydett
            id = Convert.ToInt32(Request.QueryString["kIddd"]);

            image = new images(inlineFormInputGroup.Text.ToString(),
            descriptionText.Text.ToString(),
            id,
            typeeText.Text.ToString(),
            DateTime.Now,
            " ",
            DateTime.Now,
            " "); 

            fotoSorgu.fotoYukleProsedur(image);


            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            if(inlineFormInputGroup.Text.ToString() != null)
            {
                ImageMap1.ImageUrl = inlineFormInputGroup.Text.ToString();
            }
            else
            {
            }
            
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