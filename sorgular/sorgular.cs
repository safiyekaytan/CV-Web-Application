using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using Org.BouncyCastle.Asn1.Ocsp;
using aspxliDeneme.Tables;

namespace aspxliDeneme.sorgular
{
    
    public class sorgularr
    {
        education education2;
        experiences experiences2;

       public int userIdGonder = 0;
       public  String userNameGonder;
       public  String passwordGonder;
       public List<String> loginDataGonder = new List<String>();


        public void yeniKayitOlusturProsedur(string userNamee, string passwordd)
        {
            
            if (userNamee != null && passwordd != null)
            {
                // IFormatProvider pro = CultureInfo.CreateSpecificCulture("tr-TR");

                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("yeniKayitOlustur", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter userName = cmd.Parameters.Add("@userName", SqlDbType.VarChar, 200);
                SqlParameter password = cmd.Parameters.Add("@password", SqlDbType.VarChar, 200);


                userName.Value = userNamee;
                password.Value = passwordd;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {

            }

        }
        public void kayitGuncelleProsedur(users user)
        {
             
            if (user.Id != null)
            {
                if (user.Name != null && user.LastName != null)
                {
                    // IFormatProvider pro = CultureInfo.CreateSpecificCulture("tr-TR");

                    SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("kayitTamamla", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter nameParametre = cmd.Parameters.Add("@name", user.Name);
                    SqlParameter lastNameParametre = cmd.Parameters.Add("@lastName", user.LastName);
                    SqlParameter emailParametre = cmd.Parameters.Add("@email", user.Email);
                    SqlParameter phoneParametre = cmd.Parameters.Add("@phone", user.Phone);
                    SqlParameter aboutMeParametre = cmd.Parameters.Add("@aboutMe", user.AboutMe);
                    SqlParameter userIdParametre = cmd.Parameters.Add("@userId", user.Id);
                    SqlParameter countryParametre = cmd.Parameters.Add("@country", user.Country);
                    SqlParameter companyParametre = cmd.Parameters.Add("@company", user.Company);
                    SqlParameter adressParametre = cmd.Parameters.Add("@adress", user.Adress);
                    SqlParameter jobParametre = cmd.Parameters.Add("@job", user.Job);

                    nameParametre.Value = user.Name;
                    lastNameParametre.Value = user.LastName;
                    emailParametre.Value = user.Email;
                    phoneParametre.Value = user.Phone;
                    aboutMeParametre.Value = user.AboutMe;
                    userIdParametre.Value = user.Id;
                    countryParametre.Value = user.Country;
                    companyParametre.Value = user.Company;
                    adressParametre.Value = user.Adress;
                    jobParametre.Value = user.Job;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {

                }
            }
            

        }
        public List<String> kayitKontrolProsedur(String kullanici, String sifre)
        {
            
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("kayitVarMi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;


            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            int i = 0;
            bool kontrol = false;
            bool kontrolUserName = false;
            String[] user = new String[100];
            String[] pass = new String[100];
            int[] userIds = new int[100];
            while (reader.Read())
            {
                user[i] = reader["userName"].ToString();
                pass[i] = reader["password"].ToString();
                userIds[i] = reader.GetInt32(0);
                i++;
            }
            for (int j = 0; j < user.Length; j++)
            {
                if (user[j] == kullanici) //ayse
                {
                    kontrolUserName = true;
                    if (pass[j] == sifre) //123ayse
                    {
                       //kullanıcı adı sifre denkse idsini dondur
                        userIdGonder = userIds[j]; //aysenin idsi
                        passwordGonder = pass[j]; //aysenin sifrsi
                        userNameGonder = user[j]; //aysenin usernamei
                        kontrol = true;
                    }
                    
                }
            }
            
            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();
            if(kontrol == true) //bu kullanıcı adi ve sifreye kayıtlı kullanıcı var
            {
            loginDataGonder.Add(userIdGonder.ToString());
            loginDataGonder.Add(userNameGonder);
            loginDataGonder.Add(passwordGonder);
                return loginDataGonder;
            }
            else if(kontrolUserName == true && kontrol == false) //bu kullanıcı adına kayıtlı kullanıcı var ama şifresi yanlıs
            {
                loginDataGonder.Clear();
                return loginDataGonder;
            }
            else if(kontrolUserName == false) //bu kullanıcı adına kayıtlı bir kullanici yok
            {
                return null;
            }
            else
            {
                return null;
            }
                
            



            
        }
        public void sifreDegistirProsedur(int userId, String sifre)
        {
            if (userId != null)
            {
                
                    // IFormatProvider pro = CultureInfo.CreateSpecificCulture("tr-TR");

                    SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sifreDegistir", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter nameParametre = cmd.Parameters.Add("@userId", userId);
                    SqlParameter passwordParametre = cmd.Parameters.Add("@password", sifre);
                nameParametre.Value = userId;
                

                passwordParametre.Value = sifre;

                cmd.ExecuteNonQuery();
                    conn.Close();
              
            }
        }
        public void egitimKayitProsedur(education education)
        {
            if (education.UserId != null && education.NameOfSchool != null && education.DepartmentForUniversity != null)
            {
                // IFormatProvider pro = CultureInfo.CreateSpecificCulture("tr-TR");

                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;" +
                    "Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("egitimBilgi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter nameOfSchoolParametre = cmd.Parameters.Add("@nameOfSchool", education.NameOfSchool);
                SqlParameter departmentForUniversityParametre = cmd.Parameters.Add("@departmentForUniversity", education.DepartmentForUniversity);
                SqlParameter graduationDateParametre = cmd.Parameters.Add("@graduationDate", education.GraduationDate);
                SqlParameter userIdParametre = cmd.Parameters.Add("@userId", education.UserId);

                nameOfSchoolParametre.Value = education.NameOfSchool;
                departmentForUniversityParametre.Value = education.DepartmentForUniversity;
                graduationDateParametre.Value = education.GraduationDate;
                userIdParametre.Value = education.UserId;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {

            }
        }
        public void deneyimEkleProsedur(experiences experience)
        {
            if (experience.UserId != null)
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;" +
                    "Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("deneyimEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter positionParametre = cmd.Parameters.Add("@position", experience.Position);
                SqlParameter departmentParametre = cmd.Parameters.Add("@department", experience.Department);
                SqlParameter companyNameParametre = cmd.Parameters.Add("@companyName", experience.CompanyName);
                SqlParameter startDateParametre = cmd.Parameters.Add("@startDate", experience.StartDate);
                SqlParameter endDateParametre = cmd.Parameters.Add("@endDate", experience.EndDate);
                SqlParameter descriptionParametre = cmd.Parameters.Add("@description", experience.Description);
                SqlParameter idParametre = cmd.Parameters.Add("@userId", experience.UserId);
                positionParametre.Value = experience.Position;
                departmentParametre.Value = experience.Department;
                companyNameParametre.Value = experience.CompanyName;
                startDateParametre.Value = experience.StartDate;
                endDateParametre.Value = experience.EndDate;
                descriptionParametre.Value = experience.Description;
                idParametre.Value = experience.UserId;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {}}

        public void fotoYukleProsedur(images image)
        {
            if (image.UserId != null)
            {

                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("fotoYukle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter urlParametre = cmd.Parameters.Add("@url", image.Url);
                SqlParameter typeeParametre = cmd.Parameters.Add("@typee", image.Typee);
                SqlParameter descriptionParametre = cmd.Parameters.Add("@description", image.Description);
                SqlParameter idParametre = cmd.Parameters.Add("@userId", image.UserId);

                typeeParametre.Value = image.Typee;
                urlParametre.Value = image.Url;
                descriptionParametre.Value = image.Description;
                idParametre.Value = image.UserId;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {

            }
        }
        public dynamic[,] fotoGetirProsedur(int id)
        {
            //FOTO GETİR FONKSİYONUNU YAZACAKSIIIN
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("fotoGetir", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            dynamic[,] fotoData;

            List<String> url = new List<String>();
            List<String> description = new List<String>();
            List<int> fotoId = new List<int>();


            while (reader.Read())
            {
                fotoId.Add(Convert.ToInt32(reader["id"].ToString())); //foto idsi
                url.Add(reader["url"].ToString()); //foto url
                description.Add(reader["description"].ToString()); //foro açıklama
            }
            fotoData = new dynamic[fotoId.Count, 3];

            for(int i = 0; i < fotoId.Count; i++)
            {
                fotoData[i, 0] = fotoId[i];
                fotoData[i, 1] = url[i];
                fotoData[i, 2] = description[i];

            }

            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();


            return fotoData;
        }
        public void blogKayitProsedur(blog blog)
        {
            if (blog.UserId != null)
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;" +
                    "Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("blogKayit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter imagesIdParametre = cmd.Parameters.Add("@imagesId", blog.ImagesId);
                SqlParameter titleParametre = cmd.Parameters.Add("@title", blog.Title);
                SqlParameter contentParametre = cmd.Parameters.Add("@content", blog.Content);
                SqlParameter publishDateParametre = cmd.Parameters.Add("@publishDate", blog.PublishDate);
                SqlParameter idParametre = cmd.Parameters.Add("@userId", blog.UserId);
                imagesIdParametre.Value = blog.ImagesId;
                titleParametre.Value = blog.Title;
                contentParametre.Value = blog.Content;
                publishDateParametre.Value = blog.PublishDate;
                idParametre.Value = blog.UserId;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
            }
        }
        public void sertifikaProsedur(certificates certificate)
        {
            if (certificate.UserId != null)
            {
                // IFormatProvider pro = CultureInfo.CreateSpecificCulture("tr-TR");
                
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("sertifikaKayit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter nameParametre = cmd.Parameters.Add("@name", certificate.Name);
                SqlParameter institutionParametre = cmd.Parameters.Add("@institution", certificate.Instiution);
                SqlParameter departmentParametre = cmd.Parameters.Add("@department", certificate.Departmanet);
                SqlParameter deliveryDateParametre = cmd.Parameters.Add("@deliveryDate", certificate.DeliveryDate);
                SqlParameter idParametre = cmd.Parameters.Add("@userId", certificate.UserId);

                nameParametre.Value = certificate.Name;
                institutionParametre.Value = certificate.Instiution;
                departmentParametre.Value = certificate.Departmanet;
                deliveryDateParametre.Value = certificate.DeliveryDate;
                idParametre.Value = certificate.UserId;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {

            }
        }
        public Dictionary<string, dynamic> kullaniciGetir(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("userGetir", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@id", id);
            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();


            Dictionary<string, dynamic> kullaniciBilgi = new Dictionary<string, dynamic>();

            int m = 1;
                while (reader.Read() && m == 1)
                {
                    kullaniciBilgi["name"] = reader["name"].ToString();
                    kullaniciBilgi["lastName"] = reader["lastName"].ToString();
                    kullaniciBilgi["email"] = reader["email"].ToString();
                    kullaniciBilgi["phone"] = Convert.ToInt32(reader["phone"].ToString());
                    kullaniciBilgi["aboutMe"] = reader["aboutMe"].ToString();
                    kullaniciBilgi["company"] = reader["company"].ToString();
                    kullaniciBilgi["adress"] = reader["adress"].ToString();
                    kullaniciBilgi["country"] = reader["country"].ToString();
                    kullaniciBilgi["job"] = reader["job"].ToString();
                    m++;
                }

            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();


            return kullaniciBilgi;
        }
        public int blogGetir(int id)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("blogGetir", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<int> imageId = new List<int>();


            while (reader.Read())
            {

                imageId.Add(Convert.ToInt32(reader["imagesId"].ToString())); //foto url
            }
           
            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();
            if(imageId.Count > 0)
            {
                return imageId[imageId.Count - 1];
            }
            else
            {
                return -1;
            }
            
        }
        public String imagesTabloGetir(int fotoId)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("profilFotoGetir", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@id", fotoId);

            idParametre.Value = fotoId;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<String> imageUrl = new List<String>();


            while (reader.Read())
            {
                imageUrl.Add(reader["url"].ToString()); //foto url
            }

            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();


            return imageUrl[0];
        }
        public List<dynamic> cvAboutMeGetirProsedur(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("cvAboutMe", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<dynamic> cvAboutMeList = new List<dynamic>();
            String name, lastName, aboutMe, company, country, job, content;
            int imagesId;

            while (reader.Read())
            {
                name = reader["name"].ToString();
                lastName = reader["lastName"].ToString();
                aboutMe = reader["aboutMe"].ToString();
                company = reader["company"].ToString();
                country = reader["country"].ToString();
                job = reader["job"].ToString();
                content = reader["content"].ToString();
                imagesId = Convert.ToInt32(reader["imagesId"].ToString());

                cvAboutMeList.Add(name);
                cvAboutMeList.Add(lastName);
                cvAboutMeList.Add(aboutMe);
                cvAboutMeList.Add(company);
                cvAboutMeList.Add(country);
                cvAboutMeList.Add(job);
                cvAboutMeList.Add(content);
                cvAboutMeList.Add(imagesId);
            }

            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();

            return cvAboutMeList;
        }
        public List<education> cvEgitimGetirProsedur(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("okul", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            String name, department;
            DateTime graduation;
            int i = 0;
            List <education> okul = new List<education>();
            while (reader.Read())
            {
                name = reader["nameOfSchool"].ToString();
                department = reader["departmentForUniversity"].ToString();
                graduation = DateTime.Parse(reader["graduationDate"].ToString());
                education2 = new education(name, department, graduation, id, DateTime.Now, "safiye", DateTime.Now, "safiye");
                okul.Add(education2);
                i++;
            }



            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();

            return okul;
        }
        public List<experiences> cvDeneyimGetirProsedur(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("deneyim", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            String position, companyName, description;
            DateTime startDate, endDate;

            List<experiences> deneyim = new List<experiences>();
            while (reader.Read())
            {
                position = reader["position"].ToString();
                companyName = reader["companyName"].ToString();
                description = reader["description"].ToString();
                startDate = DateTime.Parse(reader["startDate"].ToString());
                endDate = DateTime.Parse(reader["endDate"].ToString());

                experiences2 = new experiences(position, "", companyName, startDate, endDate, description, id, DateTime.Now, "safiye", DateTime.Now, "safiye");
                deneyim.Add(experiences2);
            }



            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();

            return deneyim;
        }
        public void dosyaKayitProsedur(files file)
        {
            if (file.UserId != null)
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("dosyaYukle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlParameter nameParametre = cmd.Parameters.Add("@fileName", file.FileName);
                SqlParameter contentTypeParametre = cmd.Parameters.Add("@fileContentType", file.FileContentType);
                SqlParameter urlParametre = cmd.Parameters.Add("@fileUrl", file.FileUrl);
                SqlParameter descriptionParametre = cmd.Parameters.Add("@description", file.Description);
                SqlParameter idParametre = cmd.Parameters.Add("@userId", file.UserId);
                nameParametre.Value = file.FileName;
                contentTypeParametre.Value = file.FileContentType;
                urlParametre.Value = file.FileUrl;
                descriptionParametre.Value = file.Description;
                idParametre.Value = file.UserId;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {} }
        public void mesajKayitProsedur(message message)
        {
            if (message.UserId != null)
            {
                // IFormatProvider pro = CultureInfo.CreateSpecificCulture("tr-TR");


                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("mesajGonder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter nameParametre = cmd.Parameters.Add("@name", message.Name);
                SqlParameter subjectParametre = cmd.Parameters.Add("@subject", message.Subject);
                SqlParameter emailParametre = cmd.Parameters.Add("@email", message.Email);
                SqlParameter messageParametre = cmd.Parameters.Add("@messageAtt", message.MessageAtt);
                SqlParameter idParametre = cmd.Parameters.Add("@userId", message.UserId);

                nameParametre.Value = message.Name;
                subjectParametre.Value = message.Subject;
                emailParametre.Value = message.Email;
                messageParametre.Value = message.MessageAtt;
                idParametre.Value = message.UserId;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {

            }
        }
        public List<blog> blogListProsedur(int id)
        {
            //FOTO GETİR FONKSİYONUNU YAZACAKSIIIN
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("cvFotolar", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();


            List<blog> blogList = new List<blog>();
            blog b;
            while (reader.Read())
            {
                b = new blog(
                    Convert.ToInt32(reader["imagesId"].ToString()),
                    reader["title"].ToString(), reader["content"].ToString(),
                    DateTime.Parse(reader["publishDate"].ToString()),
                    Convert.ToInt32(reader["userId"].ToString()),
                    DateTime.Now,
                    " ",
                    DateTime.Now,
                    " "
                    );
                blogList.Add(b);
            }


            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();


            return blogList;
        }
        public List<files> dosyaGetirProsedur(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("dosyaGetir", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            List<files> filesList = new List<files>();
            files file;

            while (reader.Read())
            {
                file = new files(reader["fileName"].ToString(),
                    reader["fileContentType"].ToString(),
                    reader["fileUrl"].ToString(),
                    reader["description"].ToString(),
                    id,
                    DateTime.Now,
                    " ",
                    DateTime.Now,
                    " ");
                filesList.Add(file);
            }

            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();


            return filesList;
        }
        public void yetenekKayitProsedur(services talent)
        {
            if (talent.UserId != null)
            {
                // IFormatProvider pro = CultureInfo.CreateSpecificCulture("tr-TR");


                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("yetenekKayit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter descriptionParametre = cmd.Parameters.Add("@description", talent.Description);
                SqlParameter titleParametre = cmd.Parameters.Add("@title", talent.Title);
                SqlParameter idParametre = cmd.Parameters.Add("@userId", talent.UserId);

                descriptionParametre.Value = talent.Description;
                titleParametre.Value = talent.Title;
                idParametre.Value = talent.UserId;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {

            }
        }
        public List<services> yetenekGetir(int id)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=cv;Trusted_Connection=True;TrustServerCertificate=True; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("yetenekGetir", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter idParametre = cmd.Parameters.Add("@userId", id);

            idParametre.Value = id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            services talent;
            List<services> talents = new List<services>();

            
            while (reader.Read())
            {
                talent = new services(reader["title"].ToString(), reader["description"].ToString(), id, DateTime.Now, " ", DateTime.Now, " ");
                talents.Add(talent);
            }

            reader.Close();
            cmd.ExecuteNonQuery();
            conn.Close();

            return talents;

        }
        public sorgularr()
        {

        }
    }
}