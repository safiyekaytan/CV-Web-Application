<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa10.aspx.cs" Inherits="aspxliDeneme.Sayfa10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  
  <meta content="width=device-width, initial-scale=1.0" name="viewport">

  <title>Users / Profile - NiceAdmin Bootstrap Template</title>
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
</head>
<body>
    <form id="form1" runat="server">
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
      <h1>Overview</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item">SK</li>
          <li class="breadcrumb-item">Home</li>
          <li class="breadcrumb-item active">Overview</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class="section profile">
      <div class="row">
        <div class="col-xl-4">

          <div class="card">
            <div class="card-body profile-card pt-4 d-flex flex-column align-items-center">
                 
              <asp:Image ID="imageId" alt="Profile" class="rounded-circle" ImageUrl="https://avatars.githubusercontent.com/u/95499415?s=96&v=4" runat="server" />
              <h2>
                  <asp:Label ID="fullNameTitleText" runat="server" Text="Safiye Kaytan"></asp:Label>
              </h2>
           
              <h3>
                  <asp:Label ID="jobTitleText" runat="server" Text=".Net Developer"></asp:Label>
              </h3>
              <div class="social-links mt-2">
                <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/users-profile.html#" class="twitter"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-twitter" viewBox="0 0 16 16">
  <path d="M5.026 15c6.038 0 9.341-5.003 9.341-9.334 0-.14 0-.282-.006-.422A6.685 6.685 0 0 0 16 3.542a6.658 6.658 0 0 1-1.889.518 3.301 3.301 0 0 0 1.447-1.817 6.533 6.533 0 0 1-2.087.793A3.286 3.286 0 0 0 7.875 6.03a9.325 9.325 0 0 1-6.767-3.429 3.289 3.289 0 0 0 1.018 4.382A3.323 3.323 0 0 1 .64 6.575v.045a3.288 3.288 0 0 0 2.632 3.218 3.203 3.203 0 0 1-.865.115 3.23 3.23 0 0 1-.614-.057 3.283 3.283 0 0 0 3.067 2.277A6.588 6.588 0 0 1 .78 13.58a6.32 6.32 0 0 1-.78-.045A9.344 9.344 0 0 0 5.026 15z"/>
</svg></a>
                <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/users-profile.html#" class="facebook"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-facebook" viewBox="0 0 16 16">
  <path d="M16 8.049c0-4.446-3.582-8.05-8-8.05C3.58 0-.002 3.603-.002 8.05c0 4.017 2.926 7.347 6.75 7.951v-5.625h-2.03V8.05H6.75V6.275c0-2.017 1.195-3.131 3.022-3.131.876 0 1.791.157 1.791.157v1.98h-1.009c-.993 0-1.303.621-1.303 1.258v1.51h2.218l-.354 2.326H9.25V16c3.824-.604 6.75-3.934 6.75-7.951z"/>
</svg></a>
                <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/users-profile.html#" class="instagram"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-instagram" viewBox="0 0 16 16">
  <path d="M8 0C5.829 0 5.556.01 4.703.048 3.85.088 3.269.222 2.76.42a3.917 3.917 0 0 0-1.417.923A3.927 3.927 0 0 0 .42 2.76C.222 3.268.087 3.85.048 4.7.01 5.555 0 5.827 0 8.001c0 2.172.01 2.444.048 3.297.04.852.174 1.433.372 1.942.205.526.478.972.923 1.417.444.445.89.719 1.416.923.51.198 1.09.333 1.942.372C5.555 15.99 5.827 16 8 16s2.444-.01 3.298-.048c.851-.04 1.434-.174 1.943-.372a3.916 3.916 0 0 0 1.416-.923c.445-.445.718-.891.923-1.417.197-.509.332-1.09.372-1.942C15.99 10.445 16 10.173 16 8s-.01-2.445-.048-3.299c-.04-.851-.175-1.433-.372-1.941a3.926 3.926 0 0 0-.923-1.417A3.911 3.911 0 0 0 13.24.42c-.51-.198-1.092-.333-1.943-.372C10.443.01 10.172 0 7.998 0h.003zm-.717 1.442h.718c2.136 0 2.389.007 3.232.046.78.035 1.204.166 1.486.275.373.145.64.319.92.599.28.28.453.546.598.92.11.281.24.705.275 1.485.039.843.047 1.096.047 3.231s-.008 2.389-.047 3.232c-.035.78-.166 1.203-.275 1.485a2.47 2.47 0 0 1-.599.919c-.28.28-.546.453-.92.598-.28.11-.704.24-1.485.276-.843.038-1.096.047-3.232.047s-2.39-.009-3.233-.047c-.78-.036-1.203-.166-1.485-.276a2.478 2.478 0 0 1-.92-.598 2.48 2.48 0 0 1-.6-.92c-.109-.281-.24-.705-.275-1.485-.038-.843-.046-1.096-.046-3.233 0-2.136.008-2.388.046-3.231.036-.78.166-1.204.276-1.486.145-.373.319-.64.599-.92.28-.28.546-.453.92-.598.282-.11.705-.24 1.485-.276.738-.034 1.024-.044 2.515-.045v.002zm4.988 1.328a.96.96 0 1 0 0 1.92.96.96 0 0 0 0-1.92zm-4.27 1.122a4.109 4.109 0 1 0 0 8.217 4.109 4.109 0 0 0 0-8.217zm0 1.441a2.667 2.667 0 1 1 0 5.334 2.667 2.667 0 0 1 0-5.334z"/>
</svg></a>
                <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/users-profile.html#" class="linkedin"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-linkedin" viewBox="0 0 16 16">
  <path d="M0 1.146C0 .513.526 0 1.175 0h13.65C15.474 0 16 .513 16 1.146v13.708c0 .633-.526 1.146-1.175 1.146H1.175C.526 16 0 15.487 0 14.854V1.146zm4.943 12.248V6.169H2.542v7.225h2.401zm-1.2-8.212c.837 0 1.358-.554 1.358-1.248-.015-.709-.52-1.248-1.342-1.248-.822 0-1.359.54-1.359 1.248 0 .694.521 1.248 1.327 1.248h.016zm4.908 8.212V9.359c0-.216.016-.432.08-.586.173-.431.568-.878 1.232-.878.869 0 1.216.662 1.216 1.634v3.865h2.401V9.25c0-2.22-1.184-3.252-2.764-3.252-1.274 0-1.845.7-2.165 1.193v.025h-.016a5.54 5.54 0 0 1 .016-.025V6.169h-2.4c.03.678 0 7.225 0 7.225h2.4z"/>
</svg></a>
              </div>
            </div>
          </div>

        </div>

        <div class="col-xl-8">

          <div class="card">
            <div class="card-body pt-3">
              <!-- Bordered Tabs -->
              <ul class="nav nav-tabs nav-tabs-bordered" role="tablist">

                <li class="nav-item" role="presentation">
                  <asp:Button ID="Button1" style="background-color: #012970; color: white;"  class="nav-link active" data-bs-toggle="tab" data-bs-target="#profile-overview" aria-selected="true" role="tab" runat="server" Text="Overview" />
                </li>
              
              </ul>
              <div class="tab-content pt-2">

                <div class="tab-pane fade show active profile-overview" id="profile-overview" role="tabpanel">
                  <h5 class="card-title">About</h5>
                  <p class="small fst-italic">
                  <asp:Label ID="aboutText" runat="server" Text="Kocaeli Universitesi Bilgisayar Muhendisligi 3. sinif ogrencisi"></asp:Label>
                  </p>

                  <h5 class="card-title">Profile Details</h5>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label ">Full Name</div>
                    <asp:Label ID="fullNameText" class="col-lg-9 col-md-8" runat="server" Text="Safiye Kaytan"></asp:Label>
                  </div>
            
                     
                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Company</div>
                    <asp:Label ID="companyText" class="col-lg-9 col-md-8" runat="server" Text="Viya LM&BT"></asp:Label>
                  </div>
                    
                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Job</div>
                    <asp:Label ID="jobText" class="col-lg-9 col-md-8" runat="server" Text=".Net Developer"></asp:Label>
                  </div>
                    
                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Country</div>
                   <asp:Label ID="countryText" class="col-lg-9 col-md-8" runat="server" Text="TR"></asp:Label>
                  </div>
                   
                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Address</div>
                     <asp:Label ID="adressText" class="col-lg-9 col-md-8" runat="server" Text="Kocaeli/İzmit, Umuttepe, Kabaoğlu Mahallesi"></asp:Label>
                  </div>
                     
                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Phone</div>
                    <asp:Label ID="phoneText" class="col-lg-9 col-md-8" runat="server" Text="530 215 58 81"></asp:Label>
                  </div>
                    
                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Email</div>
                    <asp:Label ID="emailText" class="col-lg-9 col-md-8" runat="server" Text="safiyekytn@gmail.com"></asp:Label>
                  </div>
                </div>
                   <asp:Button ID="talent" style=" background-color: #012970; margin-top: 20px;" class="btn btn-primary" runat="server" Text="Add Skills" OnClick="talent_Click"/>
                <asp:Button ID="createCV" style="margin-left:800px; background-color: #012970;" class="btn btn-primary" runat="server" Text="Create  CV" OnClick="createCV_Click" />

              </div><!-- End Bordered Tabs -->

            </div>
          </div>

        </div>
      </div>
    </section>

  </main><!-- End #main -->

  <!-- ======= Footer ======= -->
  <footer id="footer" class="footer">
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

  <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/users-profile.html#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

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
