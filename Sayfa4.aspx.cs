using aspxliDeneme.sorgular;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspxliDeneme
{
    public partial class Sayfa4 : System.Web.UI.Page
    {
        public List<dynamic> submitButtonList = new List<dynamic>();
        public List<dynamic> idList = new List<dynamic>();
        public List<dynamic> nameList = new List<dynamic>();
        public List<dynamic> departmentList = new List<dynamic>();
        public List<dynamic> DateList = new List<dynamic>();
        public List<dynamic> list = new List<dynamic>();
        dynamic[,] rowArray = new dynamic[6, 5];
        public int a;
        sorgularr sorguEgitim = new sorgularr();
        public int kullaniciNo;
        public int id;
        education education;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            fonk();
            foreach (var itemS in submitButtonList)
            {
                itemS.Enabled = true;
            }
            
            id = Convert.ToInt32(Request.QueryString["kIddd"]);
            ImageMap4.ImageUrl = sorguEgitim.imagesTabloGetir(sorguEgitim.blogGetir(id));
            ListItem item = ddlCities.Items.FindByValue("baslik");
            list = sorguEgitim.cvAboutMeGetirProsedur(id);
            item.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[0]) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(list[1]);
        }
        void fonk()
        {
            kullaniciNo = Convert.ToInt32(Request.QueryString["kIddd"]);
            submitButtonList.Add(egitimKayitButon1);
            submitButtonList.Add(egitimKayitButon2);
            submitButtonList.Add(egitimKayitButon3);
            submitButtonList.Add(egitimKayitButon4);
            submitButtonList.Add(egitimKayitButon5);
            submitButtonList.Add(egitimKayitButon6);

            idList.Add(Label1);
            idList.Add(Label2);
            idList.Add(Label3);
            idList.Add(Label4);
            idList.Add(Label5);
            idList.Add(Label6);

            nameList.Add(name1);
            nameList.Add(name2);
            nameList.Add(name3);
            nameList.Add(name4);
            nameList.Add(name5);
            nameList.Add(name6);

            departmentList.Add(department1);
            departmentList.Add(department2);
            departmentList.Add(department3);
            departmentList.Add(department4);
            departmentList.Add(department5);
            departmentList.Add(department6);

            DateList.Add(date1);
            DateList.Add(date2);
            DateList.Add(date3);
            DateList.Add(date4);
            DateList.Add(date5);
            DateList.Add(date6);

            for (int i = 0; i < 6; i++)
            {
                rowArray[i, 0] = idList[i];
                rowArray[i, 1] = nameList[i];
                rowArray[i, 2] = departmentList[i];
                rowArray[i, 3] = DateList[i];
                rowArray[i, 4] = submitButtonList[i];

            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    rowArray[i, j].Visible = false;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                rowArray[0, i].Visible = true;
                a = 0;
            }
        }
        protected void newRow_Click(object sender, EventArgs e)
        {
            
            //artı butonuna basarsa yeni eğitim kayıt olusturmak için yeni bir textbox sırası oluşsun
            for(int i = 0; i < 6; i++)
            {
                if (idList[i].Visible == true)
                {
                    a = i;
                }
            }
            for(int i = 0; i < 5; i++)
            {
                rowArray[a + 1, i].Visible = true; 
            }

        }
        bool IsDateFormatValid(string input)
        {

            string format = "dd/MM/yyyy";

            //kontrol et
            return DateTime.TryParseExact(input, format, null, System.Globalization.DateTimeStyles.None, out _);
        }
        void okulKaydet(int satir)
        {
            fonk();
            String name = rowArray[satir, 1].Text.ToString();
            String department = rowArray[satir, 2].Text.ToString();

            string dateString = rowArray[satir, 3].Text.ToString(); // ASPX'deki tarih alanından değeri alınır

            if (IsDateFormatValid(dateString))
            {
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                education = new education(name, department, date, kullaniciNo, DateTime.Now, " ", DateTime.Now, " ");
                sorguEgitim.egitimKayitProsedur(education);

                submitButtonList[satir].BackColor = Color.Green;
            }
            else
            {
                submitButtonList[satir].BackColor = Color.Red;
            }
        }
        protected void egitimKayitButon1_Click(object sender, EventArgs e)
        {
            okulKaydet(0);
        }
        
        protected void egitimKayitButon2_Click(object sender, EventArgs e)
        {
            okulKaydet(1);
        }

        protected void egitimKayitButon3_Click(object sender, EventArgs e)
        {
            okulKaydet(2);
        }

        protected void egitimKayitButon4_Click(object sender, EventArgs e)
        {

            okulKaydet(3);
        }

        protected void egitimKayitButon5_Click(object sender, EventArgs e)
        {
            okulKaydet(4);
        }

        protected void egitimKayitButon6_Click(object sender, EventArgs e)
        {
            okulKaydet(5);
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