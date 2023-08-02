<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa4.aspx.cs" Inherits="aspxliDeneme.Sayfa4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  
  <meta content="width=device-width, initial-scale=1.0" name="viewport">

  <title>Tables / Data - NiceAdmin Bootstrap Template</title>
  <meta content="" name="description">
  <meta content="" name="keywords">

  <!-- Favicons -->
  <link href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/assets/img/favicon.png" rel="icon">
  <link href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/assets/img/apple-touch-icon.png" rel="apple-touch-icon">

  <!-- Google Fonts -->
  <link href="https://fonts.gstatic.com/" rel="preconnect">
  <link href="./sifreler_files/css" rel="stylesheet">

  <!-- Vendor CSS Files -->
  <link href="./sifreler_files/bootstrap.min.css" rel="stylesheet">
  <link href="./sifreler_files/bootstrap-icons.css" rel="stylesheet">
  <link href="./sifreler_files/boxicons.min.css" rel="stylesheet">
  <link href="./sifreler_files/quill.snow.css" rel="stylesheet">
  <link href="./sifreler_files/quill.bubble.css" rel="stylesheet">
  <link href="./sifreler_files/remixicon.css" rel="stylesheet">
  <link href="./sifreler_files/style.css" rel="stylesheet">

  <!-- Template Main CSS File -->
  <link href="./sifreler_files/style(1).css" rel="stylesheet">
    <title></title>
</head>
<body>
    <form runat="server">

        <main id="main" class="main">
            <header id="header" class="header fixed-top d-flex align-items-center" style="height:80px;">
                <asp:ImageMap ID="ImageMap3" runat="server" ImageUrl="safiyekaytan.png" style="width:230px;" ></asp:ImageMap>

                <asp:ImageMap ID="ImageMap4" style="margin-left:920px;" class="rounded-circle" imageurl="https://cdn.evrimagaci.org/YL_ODyDQeJlg-vy36QBAnn8gIXA=/2000x0/filters:format(webp)/evrimagaci.org%2Fpublic%2Fcontent_media%2F81ee7fd9f62f889572904276d5215b22.jpg"
        width="30" 
        height="30" runat="server"></asp:ImageMap>   
                &nbsp
                <p></p>
                <div class="dropdown" style=" border: none;">
            <asp:DropDownList ID="ddlCities" class="btn btn-secondary dropdown-toggle" style="background-color:white; color: #012970; border:none; text-align:start" runat="server" AutoPostBack="True" 
      
                Width="200px" Height="40px" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged" >
                
                <asp:ListItem class="dropdown-item" Text="Safiye Kaytan" Value="baslik" CssClass="deneme"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="My Profile" Value="myprofile"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="Help" style="margin-left: 10px;" Value="5"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="Sign Out" Value="signout"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="Concat Me" Value="contact"></asp:ListItem>
            </asp:DropDownList>
        </div>
              
</header>
            <p>

            </p>
            <p>

            </p>
    <div class="pagetitle">

      <h1>Education</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item">SK</li>
          <li class="breadcrumb-item">Home</li>
          <li class="breadcrumb-item active">Education</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class="section">
      <div class="row">
        <div class="col-lg-12">

          <div class="card">
            <div class="card-body">
              <h5 class="card-title">Datatables</h5>
             

              <!-- Table with stripped rows -->
              <div class="datatable-wrapper datatable-loading no-footer sortable searchable fixed-columns"><div class="datatable-top">
    <div class="datatable-dropdown">

        <div id="yenilenme">
          <asp:Button ID="newRow" CssClass="arti" runat="server" Text="+" OnClick="newRow_Click" />
        </div>
       

        <script>
            document.getElementById('newRow').addEventListener('click', function (event) {
                //   event.preventDefault(); // Sayfanın yenilenmesini engeller

                // AJAX isteği başlatma
                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function () {
                    if (this.readyState == 4 && this.status == 200) {
                        // İstek başarıyla tamamlandı, verileri işleme
                        var data = JSON.parse(this.responseText);
                        document.getElementById('yenilenme').innerHTML = data.message;
                    }
                };
                xhttp.open('GET', 'https://localhost:44302/', true); // Sunucu URL'nizi buraya girin
                xhttp.send();
            });
        </script>
        <style>
            .submit{
                background-color: #012970;
                color: white;
                border-radius: 4px 4px;
                border: none;
                width: 80px;
                height: 35px;
            }
            .arti{
                background-color: #012970;
                color: white;
                border-radius: 4px 4px;
                border: none;
                width: 35px;
                height: 35px;
            }
            .textBox{
                background-color: white;
                         border-radius:5px 5px;
                         border:1px solid grey;
            }
        </style>
            

        </div>
    <div class="datatable-search">
            <input class="datatable-input" placeholder="Search..." type="search" title="Search within table">
        </div>
</div>
<div class="datatable-container"><table class="table datatable datatable-table"><thead>
    <tr><th data-sortable="true" style="width: 5.635062611806798%;">
        <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/tables-data.html#" class="datatable-sorter">#</a>

        </th><th data-sortable="true" style="width: 27.996422182468695%;">
            <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/tables-data.html#" class="datatable-sorter">Name of School</a>

             </th><th data-sortable="true" style="width: 37.83542039355993%;">
                 <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/tables-data.html#" class="datatable-sorter">Department for University</a>

                  </th><th data-sortable="true" style="width: 9.212880143112702%;">
                      <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/tables-data.html#" class="datatable-sorter">Graduation Date</a>

                       </th><th data-sortable="true" style="width: 19.32021466905188%;">
                           <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/tables-data.html#" class="datatable-sorter">
                               Submit

                           </a>

                            </th>

    </tr>

                                                                                </thead>
    <tbody>
        
                                 <td><asp:Label ID="Label1" runat="server" Text="1"></asp:Label></td>
                                 <td><asp:TextBox ID="name1" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="department1" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="date1" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:Button ID="egitimKayitButon1" CssClass="submit" runat="server" Text="Submit" class="btn btn-primary" OnClick="egitimKayitButon1_Click" /></td>
                                      </tr>
                                      <tr data-index="2">

                                       <td><asp:Label ID="Label2" runat="server" Text="2"></asp:Label></td>
                                 <td><asp:TextBox ID="name2" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="department2" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="date2" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:Button ID="egitimKayitButon2" CssClass="submit" runat="server" Text="Submit" class="btn btn-primary" OnClick="egitimKayitButon2_Click" /></td>

                                           </tr>

                               <tr data-index="3">
                                           <td><asp:Label ID="Label3" runat="server" Text="3"></asp:Label></td>
                                 <td><asp:TextBox ID="name3" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="department3" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="date3" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:Button ID="egitimKayitButon3" CssClass="submit" runat="server" Text="Submit" class="btn btn-primary" OnClick="egitimKayitButon3_Click" /></td>

                                                </tr>
                               <tr data-index="4">
                                                    <td><asp:Label ID="Label4" runat="server" Text="4"></asp:Label></td>
                                 <td><asp:TextBox ID="name4" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="department4" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="date4" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:Button ID="egitimKayitButon4" CssClass="submit" runat="server" Text="Submit" class="btn btn-primary" OnClick="egitimKayitButon4_Click" /></td>

                                                     </tr> 
        </tr>
                               <tr data-index="5">
                                                    <td><asp:Label ID="Label5" runat="server" Text="5"></asp:Label></td>
                                 <td><asp:TextBox ID="name5" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="department5" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="date5" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:Button ID="egitimKayitButon5" CssClass="submit" runat="server" Text="Submit" class="btn btn-primary" OnClick="egitimKayitButon5_Click" /></td>

                                                     </tr> 

                               <tr data-index="6">
                                                    <td><asp:Label ID="Label6" runat="server" Text="6"></asp:Label></td>
                                 <td><asp:TextBox ID="name6" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="department6" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:TextBox ID="date6" CssClass="textBox" runat="server"></asp:TextBox></td>
                                   <td><asp:Button ID="egitimKayitButon6" CssClass="submit" runat="server" Text="Submit" class="btn btn-primary" OnClick="egitimKayitButon6_Click" /></td>

                                                     </tr> 
        




                                                 </tbody></table></div>
<div class="datatable-bottom">
    <div class="datatable-info">Showing 1 to 5 of 5 entries</div>
    <nav class="datatable-pagination"><ul class="datatable-pagination-list"></ul></nav>
</div></div>
              <!-- End Table with stripped rows -->

            </div>
          </div>

        </div>
      </div>
    </section>

  </main><!-- End #main -->

  <!-- ======= Footer ======= -->
  <footer id="footer" class="footer" style="margin-top: 65px;">
    <div class="copyright">
      © Copyright <strong><span>NiceAdmin</span></strong>. All Rights Reserved
    </div>
    <div class="credits">
      <!-- All the links in the footer should remain intact. -->
      <!-- You can delete the links only if you purchased the pro version. -->
      <!-- Licensing information: https://bootstrapmade.com/license/ -->
      <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/nice-admin-bootstrap-admin-html-template/ -->
      development by Safiye Kaytan
    </div>
  </footer><!-- End Footer -->

  <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/tables-data.html#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

  <!-- Vendor JS Files -->
  <script src="./sifreler_files/apexcharts.min.js.indir"></script>
  <script src="./sifreler_files/bootstrap.bundle.min.js.indir"></script>
  <script src="./sifreler_files/chart.umd.js.indir"></script>
  <script src="./sifreler_files/echarts.min.js.indir"></script>
  <script src="./sifreler_files/quill.min.js.indir"></script>
  <script src="./sifreler_files/simple-datatables.js.indir"></script>
  <script src="./sifreler_files/tinymce.min.js.indir"></script>
  <script src="./sifreler_files/validate.js.indir"></script>

  <!-- Template Main JS File -->
  <script src="./sifreler_files/main.js.indir"></script>



<svg id="SvgjsSvg1001" width="2" height="0" xmlns="http://www.w3.org/2000/svg" version="1.1" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:svgjs="http://svgjs.dev" style="overflow: hidden; top: -100%; left: -100%; position: absolute; opacity: 0;"><defs id="SvgjsDefs1002"></defs><polyline id="SvgjsPolyline1003" points="0,0"></polyline><path id="SvgjsPath1004" d="M0 0 "></path></svg>

    </form>
</body>
</html>