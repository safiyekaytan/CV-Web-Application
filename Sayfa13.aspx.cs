using aspxliDeneme.sorgular;
using aspxliDeneme.Tables;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspxliDeneme
{
    public partial class Sayfa13 : System.Web.UI.Page
    {
        public int id;
        sorgularr sorgu = new sorgularr();
        List<dynamic> list = new List<dynamic>();
        message message;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["kIddd"]);


            ImageMap4.ImageUrl = sorgu.imagesTabloGetir(sorgu.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorgu.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ddlCities.SelectedValue;

            // Seçilen öğenin değeri 5'e eşitse, istediğiniz işlemi burada gerçekleştirin.
            if (selectedValue == "signout")
            {
                Response.Redirect("loginPage");
            }
            if (selectedValue == "myprofile")
            {
                Response.Redirect("Sayfa2.aspx?kId=" + id.ToString());
            }
            if (selectedValue == "contact")
            {
                Page_Load(sender, e);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["kIddd"]);
            message = new message(TextBox1.Text.ToString(), TextBox2.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString(), id);
            sorgu.mesajKayitProsedur(message);
        }
    }
}