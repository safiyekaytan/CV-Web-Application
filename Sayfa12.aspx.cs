using aspxliDeneme.sorgular;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Org.BouncyCastle.Crypto.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Document = iTextSharp.text.Document;

namespace aspxliDeneme
{
    public partial class Sayfa12 : System.Web.UI.Page
    {
        
        public int kullaniciId;
        sorgularr cv = new sorgularr();
        public List<dynamic> cvList = new List<dynamic>();
        public List<education> egitim = new List<education>();
        public List<experiences> deneyim = new List<experiences>();
        public List<dynamic> date = new List<dynamic>();
        public List<dynamic> position = new List<dynamic>();
        public List<dynamic> description = new List<dynamic>();
        public List<Label> select = new List<Label>();
        public List <blog> blogList = new List<blog>();
        public List<files> fileList = new List<files>();
        public List<services> talentList = new List<services>();
        public Color turuncu = Color.FromArgb(255, 196, 116);
        public Color pembe = Color.FromArgb(255, 116, 124);
        protected void Page_Load(object sender, EventArgs e)
        {
           
            kullaniciId = Convert.ToInt32(Request.QueryString["kullaniciId"]);
   
            cvList = cv.cvAboutMeGetirProsedur(kullaniciId);
            egitim = cv.cvEgitimGetirProsedur(kullaniciId); 
            deneyim = cv.cvDeneyimGetirProsedur(kullaniciId);
            talentList = cv.yetenekGetir(kullaniciId);

            nameText.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cvList[0]) + " " + cvList[1].ToUpper();
            contentText.Text = cvList[6] + " based on " + cvList[4] + " in " + cvList[3];
            aboutmeText.Text = cvList[2];

            date.Add(date1);
            date.Add(date2);
            date.Add(date3);
            date.Add(date4);
            date.Add(date5);
            date.Add(date6);

            position.Add(position1);
            position.Add(position2); 
            position.Add(position3);
            position.Add(position4);
            position.Add(position5); 
            position.Add(position6);

            description.Add(description1);
            description.Add(description2);
            description.Add(description3);
            description.Add(description4);
            description.Add(description5);
            description.Add(description6);

            

            for(int i = 0; i < egitim.Count; i++) {
                date[i].Text = egitim[i].GraduationDate.ToString();
                position[i].Text = egitim[i].NameOfSchool.ToString();
                description[i].Text = egitim[i].DepartmentForUniversity.ToString();
            }
            for(int i = egitim.Count; i < egitim.Count + deneyim.Count; i++)
            {
                date[i].Text = deneyim[i - egitim.Count].StartDate.ToString() + " - " + deneyim[i - egitim.Count].EndDate.ToString();

                position[i].Text = deneyim[i - egitim.Count].Position.ToString();
                description[i].Text = deneyim[i - egitim.Count].Description.ToString() + " in " + deneyim[i - egitim.Count].CompanyName.ToString();
            }
            
            
            select.Add(Label1);
            select.Add(Label2);
            select.Add(Label3);
            select.Add(Label4);


            imageId.ImageUrl = cv.imagesTabloGetir(cv.blogGetir(kullaniciId));

            blogList = cv.blogListProsedur(kullaniciId);
            ImageMap1.ImageUrl = cv.imagesTabloGetir(blogList[blogList.Count - 3].ImagesId);
            ImageMap2.ImageUrl = cv.imagesTabloGetir(blogList[blogList.Count - 2].ImagesId);
            ImageMap3.ImageUrl = cv.imagesTabloGetir(blogList[blogList.Count - 1].ImagesId);
            Label6.Text = blogList[0].Content;

            Label7.Text = blogList[1].Content;

            Label8.Text = blogList[2].Content;

            Label9.Text = blogList[0].PublishDate.ToString();
            Label10.Text = blogList[0].PublishDate.ToString();
            Label11.Text = blogList[0].PublishDate.ToString();
            Label12.Text = cvList[0].ToUpper() + " " + cvList[1].ToUpper();
            Label13.Text = cvList[2];

            ImageButton1.ImageUrl = "https://r.resimlink.com/lnsuKorJ.png";

            Label14.Text = talentList[0].Title.ToUpper();
            Label15.Text = talentList[1].Title.ToUpper();
            Label16.Text = talentList[2].Title.ToUpper();
            Label17.Text = talentList[3].Title.ToUpper();
            Label18.Text = talentList[4].Title.ToUpper();
            Label19.Text = talentList[5].Title.ToUpper();
            Label20.Text = talentList[6].Title.ToUpper();
            Label21.Text = talentList[7].Title.ToUpper();

            Label22.Text = talentList[0].Description + "%";
            Label23.Text = talentList[1].Description + "%";
            Label24.Text = talentList[2].Description + "%";
            Label25.Text = talentList[3].Description + "%";
            Label26.Text = talentList[4].Description + "%";
            Label27.Text = talentList[5].Description + "%";
            Label28.Text = talentList[6].Description + "%";
            Label29.Text = talentList[7].Description + "%";

            //TAMAMI 370
            L1.Width = Convert.ToInt32(talentList[0].Description) * 4;
            L2.Width = Convert.ToInt32(talentList[1].Description) * 4;

            L3.Width = Convert.ToInt32(talentList[2].Description) * 4;
            L4.Width = Convert.ToInt32(talentList[3].Description) * 4;

            L5.Width = Convert.ToInt32(talentList[4].Description) * 4;
            L6.Width = Convert.ToInt32(talentList[5].Description) * 4;

            L7.Width = Convert.ToInt32(talentList[6].Description) * 4;
            L8.Width = Convert.ToInt32(talentList[7].Description) * 4;
            ImageMap4.ImageUrl = "https://r.resimlink.com/IR9iyKkMvEw.png";
            ImageMap5.ImageUrl = "https://r.resimlink.com/jtO7nA0Gd.png";
            ImageMap6.ImageUrl = "https://r.resimlink.com/AcLxnZqOJ9X.png";
            ImageMap7.ImageUrl = "https://r.resimlink.com/V5S-42.png";
            ImageMap8.ImageUrl = "https://r.resimlink.com/YRH3d.png";
            ImageMap9.ImageUrl = "https://r.resimlink.com/rCbwd0Bf6.png";
            ImageMap10.ImageUrl = "https://r.resimlink.com/6RdDu3nm.png";
            ImageMap11.ImageUrl = "https://r.resimlink.com/uDKVUQA.png";

        }
        void selection(int id)
        {
            select[id].BackColor = turuncu;

        }
        protected void skills_Click(object sender, EventArgs e)
        {
            selection(0);
        }

        protected void service_Click(object sender, EventArgs e)
        {
            selection(1);
        }

        protected void interview_Click(object sender, EventArgs e)
        {
            selection(2);
        }

        protected void certificates_Click(object sender, EventArgs e)
        {
            selection(3);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            string htmlContent = GetHtmlContent();
            if (htmlContent != null)
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, memStream);
                    document.Open();

                    using (StringReader stringReader = new StringReader(htmlContent))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, stringReader);
                    }
                    document.Close();

                    Response.Clear();
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("Content-Disposition", "attachment;filename=YourPage.pdf");
                    Response.OutputStream.Write(memStream.GetBuffer(), 0, memStream.GetBuffer().Length);
                    Response.OutputStream.Flush();
                    Response.OutputStream.Close();
                    Response.End();
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('FThere is no valid aspx url in files');", true);
            }
        }
        private string GetHtmlContent()
        {
            fileList = cv.dosyaGetirProsedur(kullaniciId);
            if(fileList.Count > 0)
            {
                String url = fileList[fileList.Count - 1].FileUrl;

                using (WebClient client = new WebClient())
                {
                    client.Encoding = System.Text.Encoding.UTF8;
                    return client.DownloadString(url);
                }
            }
            else
            {
                return null;
            }
        }

        protected void ImageMap6_Click(object sender, ImageMapEventArgs e)
        {

        }
    }
}