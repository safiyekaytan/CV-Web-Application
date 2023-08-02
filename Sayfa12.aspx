<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa12.aspx.cs" Inherits="aspxliDeneme.Sayfa12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="aaa.css" type="text/css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.3/dist/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>


</head>
<body>
  
    <form id="form1" runat="server">
        <style>
            div.ex1 {
                background-color: lightblue;
border: none;
border-radius: 5px 5px;
height: 150px;
width: 220px;
overflow-y: scroll;
            }
            body{
    background-color : white;
}

.grid-first {
    grid-gap: 10px;
    display: grid;
    padding: 10px;
    grid-column-start: auto;
    grid-template-columns: 500px 500px 500px;
    font-family: 'Segoe UI Variable Text';
    height: 100px;
}

.grid-item0 {

    font-size: 13px;
    text-align: center;
    background-color: white;
}
.iconIlk{
    margin-top:30px;
    font-size:20px;
    color:grey;
}
.grid-item00 {

    font-size: 13px;
    text-align: center;
    background-color: white;
    color : white;
    float: right;
}
.grid-item000 {
    font-size: 13px;
    text-align: center;
    background-color: white;
    float:right;
    
}
.iconsUst {
    float: right;
    margin-right: 150px;
    margin-top: 20px;
    color: grey;
    font-size: 20px;
}
.grid-us {
    grid-gap: 1px;
    display: grid;
    background-color: white;
    padding: 10px;
    grid-column-start: auto;
    grid-template-columns: 120px 120px 120px 120px;
    font-family: 'Segoe UI Variable Text';
}

.us {
    background-color: white;
    padding: 20px;
    font-size: 13px;
    text-align: center;
    color: grey;
    font-size:14px;
}
.sonlar{
    margin-left:300px;
}
#iki {
    height: 500px;
    background-color: #70bdc2;
}

#HOME {
    margin-left: 10px;
    margin-right: 10px;
    float: right;
}
#FEATURES {
    margin-left: 10px;
    margin-right: 10px;
    float: right;
}
#ABOUT {
    margin-left: 10px;
    margin-right: 10px;
    float: right;
}
#CONTACT {
    margin-left: 10px;
    margin-right: 10px;
    float: right;
}
.yazilar {
    background-color:white;
    width: 400px;
    margin-left: 550px;
    margin-bottom: 35px;
}
.btn {
    float:left;
    background-color: pink;
}
.btnn {
    float:right;
    margin-left: 5px;
    margin-right: 5px;
    
}
#profile{
    margin-left: 250px;
    margin-top: 100px;
}
#im, #john {
    margin-top: 50px;
}
#im, #john, #text0, #text1, #text2, #text3 {
    font-family: 'Segoe UI Variable Text';
    color: white;
}
#text0{
    font-weight:500;
}
#im{
    margin-right:10px;
}
.sil {
    color: #70bdc2;
}
.sil2 {
    color: white;
}
#nokta {
    line-height: 6;
    color: #70bdc2;
}
.icons{
    color: white;
    margin-left: 5px;
    margin-right: 510px;


}
#im, #john {
    font-size: 30px;
    font-family: 'Segoe UI Variable Text';
}
#nokta2 {
    line-height: 1;
    color: #70bdc2;
}
#ok{
    margin-top:1px;
font-size:50px;
}
#nokta3 {
    outline-width: 6px;
    color: #70bdc2;
}
#nokta4 {
    outline-width: 6px;
    color: firebrick;
}
h2 {
    margin-left: 240px;
    font-family: 'Segoe UI Variable Text';
}
#ilkbuton{
    margin-top:40px;
}

#aa{
    color:black;
    background-color: white;
    font-size:18px;

}

.grid-container {
    justify-items: start;
    margin-left: 235px;
    grid-gap: 10px;
    display: grid;
    grid-template-columns: 500px 500px;
    padding: 5px;
    border: 3px dashed #454545;
    width: 1010px;
    font-family: 'Segoe UI Variable Text';
}
.grid-item {
    background-color: white;

    align-items: start;
    padding: 10px;
    padding-bottom: 170px;
    font-size: 15px;
    text-align: center;
}
.grid-iki {
    grid-gap: 1px;
    margin-left: 230px;
    display: grid;
    background-color: white;
    padding: 10px;
    grid-column-start: auto;
    grid-template-columns: 260px 260px 260px 260px;
    font-family: 'Segoe UI Variable Text';
}
.grid-item2 {
    background-color: #f8777c;
    padding: 20px;
    font-size: 13px;
    text-align: center;
    color:white;
}
.grid-item8 {
    background-color: #ffc576;
    padding: 20px;
    font-size: 13px;
    text-align: center;
    color: white;
}
#pembekisim {
    background-color: #ffeded;
    width:1044px;
    height: 500px;
    margin-left: 240px;
}
.grid-uc {
    grid-gap: 40px;
    margin-left: 230px;
    display: grid;
    background-color: white;
    padding: 10px;
    grid-column-start: auto;
    grid-template-columns: 320px 320px 320px;
    grid-template-rows: 370px;
}

.grid-item3 {
    padding: 20px;
    font-size: 13px;
    text-align: center;
    font-family: 'Segoe UI Variable Text';
}
#yesil {
    background-color: #70bdc2;
    height: 300px;
    margin-top:250px;
}

.grid-dort {
    margin-top: 250px;
    grid-gap: 80px;
    height: 400px;
    display: grid;
    background-color: #70bdc2;
    padding: 10px;
    grid-column-start: auto;
    grid-template-columns: 260px 260px 260px 260px;
}

.grid-item4 {
    margin-left: 120px;
    background-color: #70bdc2;
    height: 100px;
    width: 150px;
    position: relative;
}
.item-a {
    margin-top: 15px;
    grid-column-start: 1;
    grid-row-start: 0;
    grid-column-end: five;
    height: 60px;
    grid-row-end: 1;
    background-color: #70bdc2;
    text-align: center;
    font-family: 'Segoe UI Variable Text';
    font-size: 20px;
}

.item-b {
    margin-bottom: 15px;
    grid-column-start: 1;
    grid-row-start: 2;
    grid-column-end: five;
    height: 35px;
    grid-row-end: 3;
    background-color: #70bdc2;
    text-align: center;
    color: white;
    font-family: 'Segoe UI Variable Text';
    font-size:25px;

}

.grid-bes {
    grid-gap: 20px;
    margin-left: 230px;
    display: grid;
    background-color: white;
    padding: 10px;
    grid-column-start: auto;
    grid-template-columns: 260px 260px 260px;
    grid-template-rows: 260px 260px ;
}

.grid-item5 {
    float: left;
    background-color: white;
    padding: 20px;
    font-size: 13px;
    text-align: center;
    font-family: 'Segoe UI Variable Text';
    color: grey;
}
.bio {
    text-align: start;
    font-family: 'Segoe UI Variable Text';
    color: grey;
}
#ad{
    color:black;
}
.iconsAlt{
    float:right;
    margin-top:200px;
    margin-right:100px;
}
#copy{
    margin-top: 125px;
    font-family: 'Segoe UI Variable Text';
    margin-top: 180px;
}
 #aboutme {
    margin-top: 125px;
    font-family: 'Segoe UI Variable Text';
    margin-top: 125px;
}
#one, #one2, #one3, #one4 {
    position: absolute;
    left: 0;
    right: 0;
    top: 0;
    bottom: 0;
    margin: auto;
}




table {
    margin-left: 240px;
    width: 1042px;
    height: 550px;
    background-color: #ffeded;
    border-collapse: collapse;
}

th, td {
    border: 1px solid black;
    padding: 10px;
}

.cell {
    position: relative;
}

.top-left {
    position: absolute;
    top: 0;
    left: 0;
    margin-top: 40px;
    margin-left: 60px;
    font-family: 'Segoe UI Variable Text';
    font-size: 13px;
}

.top-right {
    position: absolute;
    top: 0;
    right: 0;
    margin-top: 30px;
    margin-right: 70px;
    font-family: 'Segoe UI Variable Text';
    color: #7abfc3;
    font-size:13px;
    font-weight:bold;
}

.middle {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
}

.container {
    margin-top:50px;

    width: 395px;
    text-align: center;
}

.progress {
    padding: 1px;
    background-color: #07646a;
    border-radius: 1px;
    box-shadow: inset 0 1px 2px none, 0 1px blue;
}

.progress-bar {
    height: 5px;
    background-color: green;
    border-radius: 4px;
    transition: 0.4s linear;
    transition-property: width, background-color;
}

.progress-striped .progress-bar {
    background-color: #70bdc2;
    width: 75%;
}
th {
    font-weight: normal;
}
table {
    border: none;
    border-collapse: collapse;
}

td, th {
    border: none;
}

.ustTablo{
    border:5px,dashed,red;
}

#tableIlk {
    border-collapse: collapse;
    width: 1000px; /* Tablo genişliği */
    height:500px;
    background-color:white;
    border:dashed 2px black;
}

.first-column {

    padding: 8px;
}

.first-column,
.third-column {
    width: 80px;
    font-family: 'Segoe UI Variable Text';
}

.second-column,
.fourth-column {
    width: 400px;
    font-family: 'Segoe UI Variable Text';
}
.tabloIcon {
    color: white;
    margin-left: 20px;
    display: flex;
    justify-content: center;
    align-items: center;
    width: 33px;
    height: 33px;
    border-radius: 50%;
    border: 2px solid #77bfc3;
    background-color: #77bfc3;
}
.vr {
    color:grey;
    border-left: 1px solid grey;
    height: 80px;
    left: 50%;
    margin-left: 37px;
    margin-bottom:250px;

}
#enalt {
    margin-bottom: 240px;
    font-family: 'Segoe UI Variable Text';
}
.textBorder {
    color: grey;
    font-size: 15px;
    border: 2px solid #f1f1f1;
    background-color: #f1f1f1;
    border-radius: 20px;
    padding: 5px;
    display: inline-block;
    font-family: 'Segoe UI Variable Text';
}
.ortaYazi {
    font-size: 14px;
    font-family: 'Segoe UI Variable Text';
}
.icon-button {
    display: inline-flex;
    align-items: center;
    padding: 8px 16px;
    border:3px solid white;
    border-radius: 4px;
    background: linear-gradient(to right, #5a979b 23%, #70bdc2 22%);
    color: #333;
    font-size: 14px;
    font-weight: bold;
    cursor: pointer;
}

.button-icon {
    background-color: #5a979b;
    padding: 0px;
    margin-left:5px;
    font-size:20px;
    color:white;

}

.button-text {
    margin-left: 10px;
    background-color: #70bdc2;
    padding: 10px;
    font-family: 'Segoe UI Variable Text';
    color:white;
}
@media screen and (max-width: 1000px) {
.grid-item00,
.grid-item000{
    display:none;
}
    .dropdown:hover .dropdown-content {
        display: unblock;
    }

}

.iconIlk {
    background-color: white;
    color: grey;
    padding: 16px;
    font-size: 16px;
    border: none;
    cursor: pointer;
}

.dropdown {
    position: relative;
    display: inline-block;
}

.dropdown-content {
    display: none;
    position: absolute;
    background-color: white;
    min-width: 160px;
    box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
    z-index: 1;
}

    .dropdown-content a {
        color: black;
        padding: 12px 16px;
        text-decoration: none;
        display: block;
    }

        .dropdown-content a:hover {
            background-color: white;
        }

.dropdown:hover .dropdown-content {
    display: block;
}

.dropdown:hover .dropbtn {
    background-color: white;
}
.containerr {
            position: relative;
            width: 40px; /* Alt etiketin uzunluğu */
        }

        .topLabel {
            position: absolute;
            background-color: #04646c;
            width: 400px; /* Üst etiketin uzunluğu */
            height: 8px;
            border: none;
            border-radius: 4px 4px;
        }

        .bottomLabel {
            position: absolute;

            background-color: #74bcc4;
            width: 40px; /* Alt etiketin uzunluğu */
            height: 8px;
            border: none;
            border-radius: 4px 4px;
        }



        </style>
        <div class="grid-first">
 

        <div class="dropdown">
            <div class="grid-item0">
                <div class="iconIlk">
                    <i class="fa fa-bars"></i>
                </div>
            </div>
            <div class="dropdown-content">
                <a href="#">Link 1</a>
                <a href="#">Link 2</a>
                <a href="#">Link 3</a>
            </div>
        </div>

        

        <div class="grid-item00">
            <div class="grid-us">
                <div class="us">
                    <a href="http://www.google.com">
                        HOME
                    </a>

                </div>
                <div class="us">
                    <a href="http://www.google.com">
                        FEATURES
                    </a>

                </div>
                <div class="us">
                    <a href="http://www.google.com">
                        ABOUT ME
                    </a>

                </div>
                <div class="us">
                    <a href="http://www.google.com">
                        CONTACT
                    </a>

                </div>
            </div>

        </div>

        <div class="grid-item000">
            <div class="iconsUst">
                <i class="fa fa-facebook"></i>
                <span class="sil2">...</span>
                <i class="fa fa-instagram"></i>
                <span class="sil2">...</span>
                <i class="fa fa-linkedin"></i>
                <span class="sil2">...</span>
                <i class="fa fa-twitter"></i>
                <span class="sil2">...</span>
                <i class="fa fa-youtube"></i>
            </div>
        </div>

    </div>


    <div id="iki">


        <div id="profile" style="float:left">
             <asp:Image ID="imageId" alt="Profile" class="rounded-circle" style="width:300px;" ImageUrl="https://avatars.githubusercontent.com/u/95499415?s=96&v=4" runat="server" />
        </div>
        <div id="nokta">
            .
        </div>
        <div style="margin-left: 575px; " id="im" >
            I'm
            <b>
                <asp:Label ID="nameText" runat="server"  Text="John Doe"></asp:Label>
            </b>
        </div>

        <div id="text0"  style="width:500px; margin-left: 580px;">
            <asp:Label ID="contentText" runat="server" Text=" Content Writter based on USA."></asp:Label>
        </div>
        <p></p>
        <div id="text1" style="width:500px; margin-left: 580px;">
           <asp:Label ID="aboutmeText" runat="server" Text=" I love to work fun, also like watching movies and a food addicted person. I am a"></asp:Label>
        </div>
        <p></p>
        
        <div class="icons" style="margin-left: 585px;">
            <span>
                <i class="fa fa-facebook"></i>
                &nbsp; 
                &nbsp; 
            <i class="fa fa-instagram"></i>
                &nbsp; 
                &nbsp; 
            <i class="fa fa-linkedin"></i>
                &nbsp; 
                &nbsp; 
            <i class="fa fa-twitter"></i>
                &nbsp; 
                &nbsp; 
            <i class="fa fa-youtube"></i>
            </span>
            
        </div>
        <p></p>


        <button class="icon-button">
            <span class="button-icon"><asp:ImageButton ID="ImageButton1" runat="server" OnClientClick="downloadPage()" OnClick="ImageButton1_Click1"/>
                <script>
                    function downloadPage() {
                        // Mevcut sayfanın içeriğini alın
                        var content = document.documentElement.outerHTML;

                        // Veri URI oluşturun
                        var dataUri = "data:text/html;charset=utf-8," + encodeURIComponent(content);

                        // Dosya adını belirleyin (isteğe bağlı olarak, farklı bir ad verebilirsiniz)
                        var filename = "Sayfa12.html";

                        // Dosya indirme için bir bağlantı oluşturun
                        var link = document.createElement("a");
                        link.href = dataUri;
                        link.download = filename;

                        // Bağlantıya tıklayarak dosya indirme işlemini başlatın
                        link.click();
                    }
                </script>
            </span>
            <span class="button-text">  DOWNLOAD RESUME</span>
        </button>
        
    </div>
        
    <div id="aa">
        <h2> EXPERIENCE & EDUCATION </h2>
    </div>

    <table id="tableIlk">
        <tr>
            <td class="first-column">
                <div class="tabloIcon">
                    <i class="fa fa-briefcase"></i>
                </div>
                <div class="vr"></div>
            </td>
            
            <td class="second-column">
                <div>
                    <div class="textBorder">
                        <asp:Label ID="date1" runat="server" Text="Label"></asp:Label>2018 - Present
                    </div>

                    <p></p>

                    <div>
                        <asp:Label ID="position1" runat="server" Text="Label"></asp:Label>
                    </div>

                    <p></p>

                    <div class="ortaYazi">
                        <div>
                            <asp:Label ID="description1" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div id="enalt">
                            
                        </div>
                    </div>
                </div>
                
                
            </td>
            <td class="third-column">
                <div class="tabloIcon">
                    <i class="fa fa-briefcase"></i>
                </div>
                <div class="vr"></div>
            </td>
            <td class="fourth-column">
                <div>
                    <div class="textBorder">
                        <asp:Label ID="date2" runat="server" Text="Label"></asp:Label>
                    </div>

                    <p></p>

                    <div>
                        <asp:Label ID="position2" runat="server" Text="Label"></asp:Label>
                    </div>

                    <p></p>

                    <div class="ortaYazi">
                        <div>
                            <asp:Label ID="description2" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div id="enalt">
                            
                        </div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td class="first-column">
                <div class="tabloIcon">
                    <i class="fa fa-briefcase"></i>
                </div>
                <div class="vr"></div>
            </td>
            <td class="second-column"><div>
    <div class="textBorder">
         <asp:Label ID="date3" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div>
         <asp:Label ID="position3" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div class="ortaYazi">
        <div>
             <asp:Label ID="description3" runat="server" Text="Label"></asp:Label>
        </div>
        <div id="enalt">
            
        </div>
    </div>
</div></td>
            <td class="third-column">
                <div class="tabloIcon">
                    <i class="fa fa-briefcase"></i>
                </div>
                <div class="vr"></div>
            </td>
            <td class="fourth-column"><div>
    <div class="textBorder">
         <asp:Label ID="date4" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div>
         <asp:Label ID="position4" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div class="ortaYazi">
        <div>
             <asp:Label ID="description4" runat="server" Text="Label"></asp:Label>
        </div>
        <div id="enalt">
            
        </div>
    </div>
</div></td>
        </tr>
        <tr>
            <td class="first-column">
                <div class="tabloIcon">
                    <i class="fa fa-briefcase"></i>
                </div>
                <div class="vr"></div>
            </td>
            <td class="second-column"><div>
    <div class="textBorder">
         <asp:Label ID="date5" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div>
         <asp:Label ID="position5" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div class="ortaYazi">
        <div>
             <asp:Label ID="description5" runat="server" Text="Label"></asp:Label>
        </div>
        <div id="enalt">
            
        </div>
    </div>
</div></td>
            <td class="third-column">
                <div class="tabloIcon">
                    <i class="fa fa-briefcase"></i>
                </div>
                <div class="vr"></div>
            </td>
            <td class="fourth-column"><div>
    <div class="textBorder">
         <asp:Label ID="date6" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div>
         <asp:Label ID="position6" runat="server" Text="Label"></asp:Label>
    </div>

    <p></p>

    <div class="ortaYazi">
        <div>
             <asp:Label ID="description6" runat="server" Text="Label"></asp:Label>
        </div>
        <div id="enalt">
            
        </div>
    </div>
</div>

            </td>
        </tr>
    </table>

    <hr />
        
    <h2>
        ABOUT ME
    </h2>
        

        <asp:Label ID="Label5" class="grid-iki" runat="server" Text="">

                    <asp:Label ID="Label1" class="grid-item2" runat="server" Text="">
            <asp:Button ID="skills" style="border: none; background-color: #f8777c; color: white;" runat="server" Text="SKILLS" OnClick="skills_Click" />
        </asp:Label>

        <asp:Label ID="Label2" class="grid-item2" runat="server" Text="">
            <asp:Button ID="service" style="border: none; background-color: #f8777c; color: white;" runat="server" Text="SERVICE" OnClick="service_Click" />
        </asp:Label>

        <asp:Label ID="Label3" class="grid-item2" runat="server" Text="">
            <asp:Button ID="interview" style="border: none; background-color: #f8777c; color: white;" runat="server" Text="INTERVIEW" OnClick="interview_Click" />
        </asp:Label>

       <asp:Label ID="Label4" class="grid-item2" runat="server" Text="">
       
                      <asp:Button ID="certificates" style="border: none; background-color: #f8777c; color: white;" runat="server" Text="CERTIFICATES" OnClick="certificates_Click" />
          
        </asp:Label>

        </asp:Label>
        




    <table>
        <tr>
            <th class="cell">
                <div class="top-left">
                    <div>
                        <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
                    </div>
                    
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="lblTop" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L1" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </th>
            <th class="cell">
                <div class="top-left">
                    <div>
                        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="Label30" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L2" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </th>
        </tr>
        <tr>
            <td class="cell">
                <div class="top-left">
                    <div>
                        <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="Label32" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L3" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </td>
            <td class="cell">
                <div class="top-left">
                    <div>
                        <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="Label34" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L4" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td class="cell">
                <div class="top-left">
                    <div>
                        <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="Label36" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L5" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </td>
            <td class="cell">
                <div class="top-left">
                    <div>
                        <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="Label38" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L6" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td class="cell">
                <div class="top-left">
                    <div>
                       <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="Label40" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L7" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </td>
            <td class="cell">
                <div class="top-left">
                    <div>
                        <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="top-right">
                    <div>
                        
                    <asp:Label ID="Label29" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="bottom-left">
                    <div class="container">
                        <div class="containerr">
            <asp:Label ID="Label42" runat="server" Text="" CssClass="topLabel"></asp:Label>
            <asp:Label ID="L8" runat="server" Text="" CssClass="bottomLabel"></asp:Label>
        </div>
                    </div>
                </div>
            </td>
        </tr>
    </table>


    <hr />
    <h2>
        
        MOST RECENT POST
    </h2>

    <div class="grid-uc">
        
        <div class="grid-item3">
            
            <asp:ImageMap ID="ImageMap1" style="width: 320px; height: 370px;" runat="server"></asp:ImageMap>
            <div> <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></div>
            <div> <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></div>
        </div>
        <div class="grid-item3">
            <asp:ImageMap ID="ImageMap2" style="width: 320px; height: 370px;" runat="server"></asp:ImageMap>
            <div> <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></div>
            <div> <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></div>
        </div>
        <div class="grid-item3">
            <asp:ImageMap ID="ImageMap3" style="width: 320px; height: 370px;" runat="server"></asp:ImageMap>
            <div> <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></div>
            <div> <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></div>
        </div>

    </div>


    <div class="grid-dort">
        <div class="item-a">
            PORTFOLIOS
        </div>

        <div class="grid-item4">

<div class="ex1">
<asp:ImageMap ID="ImageMap4" style="width:200px;" runat="server"></asp:ImageMap>
    <asp:ImageMap ID="ImageMap5" style="width:200px;" runat="server"></asp:ImageMap>

</div>
        </div>

        <div class="grid-item4">
            <div class="ex1">
<asp:ImageMap ID="ImageMap7" style="width:200px;" runat="server"></asp:ImageMap>
                <asp:ImageMap ID="ImageMap10" style="width:200px;" runat="server"></asp:ImageMap>
            </div>
        </div>
        <div class="grid-item4">
            <div class="ex1">
<asp:ImageMap ID="ImageMap8" style="width:200px;" runat="server"></asp:ImageMap>
                <asp:ImageMap ID="ImageMap11" style="width:200px;" runat="server"></asp:ImageMap>
            </div>
        </div>
        <div class="grid-item4">
            <div class="ex1">
<asp:ImageMap ID="ImageMap9" style="width:200px;" runat="server"></asp:ImageMap>
                    <asp:ImageMap ID="ImageMap6" style="width:200px;" runat="server" OnClick="ImageMap6_Click"></asp:ImageMap>
            </div>
        </div>
        <div class="item-b">
            Click For More
        </div>
    </div>

    <div class="grid-bes">
        <div class="grid-item5">
            <div id="ad" class="bio"><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></div>
            <p></p>
            
            <div class="bio" style="width:80px; height: 60px;">
                
                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            </div>

        </div>
        <div class="grid-item5">
            <div class="bio">
                ARCHİVE NOVEMBER
            </div>
            <p></p>
            <div class="bio">
                TRENDING STORIES
            </div>
            <p></p>
            <div class="bio">
                FEATUREST POST
            </div>
            <p></p>
            <div class="bio">
                POPULARS NEWS
            </div>
            <p></p>
        </div>
        <div class="grid-item5">
            <div class="bio">
                +88 00 3455899
            </div>
            <div class="bio">
                safiyekytn@gmail.com
            </div>
            <p></p>
            <p></p>
            <div class="bio">
                Kocaeli Universitesi, Muhendislik Fakultesi
            </div>
            <div class="bio">
                Izmit / Kocaeli, TURKIYE
            </div>
        </div>
        <div class="grid-item5">
            <div class="iconsAlt">
                <i class="fa fa-facebook"></i>
                ...
                <i class="fa fa-instagram"></i>
                ...
                <i class="fa fa-linkedin"></i>
                ...
                <i class="fa fa-twitter"></i>
                ...
                <i class="fa fa-youtube"></i>
            </div>
        </div>

        <div class="grid-item5" id="aboutme">
            <p></p>
            <div class="bio">
                About Me
            </div>
            <p></p>
            <div class="bio">
                Contact With Me
            </div>
            <p></p>
            <div class="bio">
                Faq
            </div>
        </div>
        <div class="grid-item5" id="copy">
            <hr />
            <dir>
                development by Safiye Kaytan
            </dir>
        </div>
    </div>
    </form>
</body>
</html>
