using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using aspxliDeneme.sorgular;
using Microsoft.Ajax.Utilities;
using System.Drawing;

namespace aspxliDeneme
{
    public partial class loginPage : System.Web.UI.Page
    {
        sorgularr sorgu1 = new sorgularr();
        public String kullaniciId;
        public String kullaniciName;
        public String kullaniciSifre;
        public List<String> loginDataAl = new List<String>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            
                if(textbox1.Text.Length > 0)
                {
                    if(textbox2.Text.Length > 0)
                    {
                      loginDataAl = sorgu1.kayitKontrolProsedur(textbox1.Text.ToString(), textbox2.Text.ToString());

                        if (loginDataAl.Count > 0)
                        {
                          textbox1.ForeColor = Color.Black;
                          textbox2.ForeColor = Color.Black;
                          Response.Redirect("sayfa2.aspx?kId=" + loginDataAl[0] + "&kName=" + loginDataAl[1] + "&kPassword=" + loginDataAl[2]);
                        }
                        else
                        {
                          textbox1.Text = "Kullanici adi veya sifre hatali";
                          textbox1.ForeColor = Color.Red;
                        }
                    
                    }
                    else
                    {
                        textbox2.Text = "Sifre giriniz!";
                        textbox2.ForeColor = Color.Red;
                    }
                }
                else
                {
                    textbox1.Text = "Kullanici adi giriniz!";
                    textbox1.ForeColor = Color.Red;
                }

                
                
            
            
        }

        protected void createAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sayfa11.aspx");
        }

        protected void textbox1_TextChanged(object sender, EventArgs e)
        {
            if (textbox1.Text != "Kullanici adi giriniz!")
            {
                textbox1.ForeColor = Color.Black;
            }
        }

        protected void textbox2_TextChanged(object sender, EventArgs e)
        {
            if (textbox2.Text != "Sifre giriniz!")
            {
                textbox2.ForeColor = Color.Black;
            }
        }
    }
}