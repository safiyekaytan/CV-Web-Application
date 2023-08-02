<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa5.aspx.cs" Inherits="aspxliDeneme.Sayfa5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  
  <meta content="width=device-width, initial-scale=1.0" name="viewport">

  <title>Forms / Elements - NiceAdmin Bootstrap Template</title>
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
      <h1>Experiences</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item">SK</li>
          <li class="breadcrumb-item">Home</li>
          <li class="breadcrumb-item active">Experiences</li>
        </ol>
      </nav>
    </div>

    <section class="section">
      <div class="row">
        <div class="col-lg-6">

          <div class="card" style="width:1000px;">
            <div class="card-body">
              <h5 class="card-title">Experiences</h5>

              <form>
                <div class="row mb-3">
                  <label for="inputText" class="col-sm-2 col-form-label">Position</label>
                  <div class="col-sm-10">
                   <asp:TextBox ID="positionText" class="form-control" runat="server"></asp:TextBox>
                  </div>
                </div>
                <div class="row mb-3">
                  <label for="inputEmail" class="col-sm-2 col-form-label">Department</label>
                  <div class="col-sm-10">
                   <asp:TextBox ID="departmentText" class="form-control" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="row mb-3">
                  <label for="inputPassword" class="col-sm-2 col-form-label">Company Name</label>
                  <div class="col-sm-10">
                   <asp:TextBox ID="companyText" class="form-control" runat="server"></asp:TextBox>
                  </div>
                </div>
            

                <div class="row mb-3">
                  <label for="inputNumber" class="col-sm-2 col-form-label">CV Upload</label>
                  <div class="col-sm-10">
                    <asp:TextBox ID="cvText" class="form-control" type="file" runat="server"></asp:TextBox>
                  </div>
                </div>

                <div class="row mb-3">
                  <label for="inputDate" class="col-sm-2 col-form-label">Start Date</label>
                  <div class="col-sm-10">
                     <asp:TextBox ID="startText" type="date" class="form-control" runat="server"></asp:TextBox>
                  </div>
                </div>
            
            

                  <div class="row mb-3">
                  <label for="inputDate" class="col-sm-2 col-form-label">End Date</label>
                  <div class="col-sm-10">
                    <asp:TextBox ID="endText" type="date" class="form-control" runat="server"></asp:TextBox>
                  </div>
                </div>
                  <div class="form-check">
                      <asp:CheckBox ID="CheckBox1" class="form-check-input" runat="server" />
                      <label class="form-check-label" for="gridCheck2">
                        Still working at this job 
                      </label>
                    </div>

                <div class="row mb-3">
                  <label for="inputPassword" class="col-sm-2 col-form-label">Description</label>
                  <div class="col-sm-10">
                    <asp:TextBox ID="descriptionText" class="form-control"  style="height: 100px" runat="server"></asp:TextBox>
                  </div>
                </div>


      <div class="col-sm-10">
 <asp:Button ID="Button1" type="submit" style="background-color: #012970" class="btn btn-primary" runat="server" Text="Submit" OnClick="Button1_Click" />

              </form><!-- End General Form Elements -->

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

  <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/forms-elements.html#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

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
