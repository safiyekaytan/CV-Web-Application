using aspxliDeneme.sorgular;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace aspxliDeneme
{
    public partial class Sayfa14 : System.Web.UI.Page
    {
        public IDictionary<Panel, bool> panel = new Dictionary<Panel, bool>();
        sorgularr sorgu = new sorgularr();
        services talent;
        public int id;
        public List<dynamic> list = new List<dynamic>();
        public List<services> talentList = new List<services>();
        protected void Page_Load(object sender, EventArgs e)
        {

            id = Convert.ToInt32(Request.QueryString["kId"]);
            ImageMap4.ImageUrl = sorgu.imagesTabloGetir(sorgu.blogGetir(id));

            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorgu.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);


            /*
            panel.Add(Panel1, false);
            panel.Add(Panel2, false);
            panel.Add(Panel3, false);
            panel.Add(Panel4, false);
            panel.Add(Panel5, false);
            panel.Add(Panel6, false);
            panel.Add(Panel7, false);
            panel.Add(Panel8, false);
            panel.Add(Panel9, false);
            panel.Add(Panel10, true);

            
            foreach (var item in panel)
            {
                if(item.Value == false)
                {
                    item.Key.Visible = false;
                }
                else
                {
                    item.Key.Visible = true;
                }
            }
            */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            foreach (var item in panel)
            {
                if(item.Value == false)
                {
                    panel[item.Key] = true;

                    break;
                }
            }
            foreach (var item in panel)
            {
                if(item.Value == false)
                {
                    item.Key.Visible = false;
                }
                else
                {
                    item.Key.Visible = true;
                }
            }
            */

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["kId"]);
            talentList.Add(new services(TextBox17.Text, TextBox18.Text, id, DateTime.Now, " ", DateTime.Now, ""));
            talentList.Add(new services(TextBox15.Text, TextBox16.Text, id, DateTime.Now, " ", DateTime.Now, ""));
            talentList.Add(new services(TextBox13.Text, TextBox14.Text, id, DateTime.Now, " ", DateTime.Now, ""));
            talentList.Add(new services(TextBox11.Text, TextBox12.Text, id, DateTime.Now, " ", DateTime.Now, ""));
            talentList.Add(new services(TextBox9.Text, TextBox10.Text, id, DateTime.Now, " ", DateTime.Now, ""));
            talentList.Add(new services(TextBox7.Text, TextBox8.Text, id, DateTime.Now, " ", DateTime.Now, ""));
            talentList.Add(new services(TextBox5.Text, TextBox6.Text, id, DateTime.Now, " ", DateTime.Now, ""));
            talentList.Add(new services(TextBox3.Text, TextBox4.Text, id, DateTime.Now, " ", DateTime.Now, ""));

            foreach (var item in talentList)
            {
                sorgu.yetenekKayitProsedur(item);
            }
            Response.Redirect("Sayfa10.aspx?kIddd=" + id);
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = ddlCities.SelectedValue;
            id = Convert.ToInt32(Request.QueryString["kId"]);
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