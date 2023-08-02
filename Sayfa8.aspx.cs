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
    public partial class Sayfa8 : System.Web.UI.Page
    {
        sorgularr sorguFotoGetir = new sorgularr();
        public dynamic[,] fotoList = new dynamic[100,3];
        public String url;
        public int id;
        public int imagesId;
        public bool tarihKontrol = false;
        public List<dynamic> list = new List<dynamic>();
        blog blog;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            id = Convert.ToInt32(Request.QueryString["kIddd"]);
            ImageMap4.ImageUrl = sorguFotoGetir.imagesTabloGetir(sorguFotoGetir.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorguFotoGetir.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
            fotoList = sorguFotoGetir.fotoGetirProsedur(id);
            if (!IsPostBack)
            {
                List();
            }
            
        }
        void List()
        {
            //kulanıcının id sine göre image tablosundaki imagelerini al
            //listele
            
            fotoList = sorguFotoGetir.fotoGetirProsedur(id);
            cars.Items.Clear();
            

            for (int i = 0; i < fotoList.GetLength(0); i++)
            {
                // Her ListItem'i oluşturun ve DropDownList'e ekleyin
                   //list iteme description ekle
                    ListItem listItem = new ListItem(fotoList[i,2]);
                    cars.Items.Add(listItem);
                
            }
        }
        protected void submitButton_Click(object sender, EventArgs e)
        {

        }

        public void cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            fotoList = sorguFotoGetir.fotoGetirProsedur(id);
            String selectedValue = cars.SelectedValue;
            String selectedText = cars.SelectedItem.Text.ToString();
            for (int i = 0; i < fotoList.GetLength(0); i++)
            {
                if(selectedText == fotoList[i,2])
                {
                    // i = 1 ise 1. description ise 0. url kullanılmıstır.
                    url = fotoList[i,1];
                    ImageMap1.ImageUrl = url;
                    imagesId = fotoList[i, 0];

                }
            }

        }

        protected void cars_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {

        }

        protected void submitButton_Click1(object sender, EventArgs e)
        {
            if(tarihKontrol == true)
            {
                cars_SelectedIndexChanged(sender, e);
                //title, content, foto
                //foto urlsini cek
                blog = new blog(imagesId,
                    titleText.Text.ToString(),
                    contentText.Text.ToString(),
                    DateTime.Parse(publishText.Text.ToString()),
                    id,
                    DateTime.Now,
                    " ",
                    DateTime.Now,
                    " ");

                sorguFotoGetir.blogKayitProsedur(blog);

                
            }
                
        }

        protected void publishText_TextChanged(object sender, EventArgs e)
        {
            tarihKontrol = true;
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