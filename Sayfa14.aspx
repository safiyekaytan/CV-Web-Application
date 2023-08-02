<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa14.aspx.cs" Inherits="aspxliDeneme.Sayfa14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  
  <meta content="width=device-width, initial-scale=1.0" name="viewport">

  <title>Components / Progress - NiceAdmin Bootstrap Template</title>
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
        <style>
.grid-container {
            display: grid;
            grid-template-columns: 510px 20px 50px; /* İlk satır için sütun genişlikleri */
            grid-template-rows: auto; /* İlk satır için otomatik yükseklik */
            gap: 10px; /* Sütunlar arası boşluk */
        }

        .grid-item {
            background-color: white;
            padding: 10px;
            border: none;
        }

        .second-row {
            grid-column: 1 / span 3; /* İkinci satır için genişlik */
        }
        </style>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

         <header id="header" class="header fixed-top d-flex align-items-center" style="height:80px;">
                <asp:ImageMap ID="ImageMap3" runat="server" ImageUrl="safiyekaytan.png" style="width:230px;" ></asp:ImageMap>

                <asp:ImageMap ID="ImageMap4" style="margin-left:920px;" class="rounded-circle" imageurl="https://cdn.evrimagaci.org/YL_ODyDQeJlg-vy36QBAnn8gIXA=/2000x0/filters:format(webp)/evrimagaci.org%2Fpublic%2Fcontent_media%2F81ee7fd9f62f889572904276d5215b22.jpg"
        width="30" 
        height="30" runat="server"></asp:ImageMap>   
                &nbsp
                <p></p>
                <div class="dropdown" style=" border: none;">
            <asp:DropDownList ID="ddlCities" class="btn btn-secondary dropdown-toggle" style="background-color:white; color: #012970; border:none; text-align:start" runat="server" AutoPostBack="True" 
      
                Width="200px" Height="40px" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged">
                
                <asp:ListItem class="dropdown-item" Text="Safiye Kaytan" Value="baslik" CssClass="deneme"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="My Profile" Value="myprofile"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="Help" style="margin-left: 10px;" Value="5"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="Sign Out" Value="signout"></asp:ListItem>
                <asp:ListItem class="dropdown-item" Text="Concat Me" Value="contact"></asp:ListItem>
            </asp:DropDownList>
        </div>
              
</header>

  <main id="main" class="main" style="margin-top: 120px;">

    <div class="pagetitle">
      <h1>Skills</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item">SK</li>
          <li class="breadcrumb-item">Home</li>
          <li class="breadcrumb-item active">Skills</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class="section">
      <div class="row">
    
        

        <div class="col-lg-6">
            <p>

            </p>
            
                <asp:Panel ID="Panel1" class="card" style="width: 650px;" runat="server">
                    <div class="card-body">
              <div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">

                  <asp:TextBox ID="TextBox17" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label9" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox18" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
                </asp:Panel>


            <asp:Panel ID="Panel2" class="card" style="width: 650px;" runat="server">
                <div class="card-body">
              <div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">
                  <asp:TextBox ID="TextBox15" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label8" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox16" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
            </asp:Panel>


<asp:Panel ID="Panel3" class="card" style="width: 650px;" runat="server">
    <div class="card-body">
              <div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">
                  <asp:TextBox ID="TextBox13" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label7" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox14" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
</asp:Panel>


<asp:Panel ID="Panel4" class="card" style="width: 650px;" runat="server">
    <div class="card-body">
              <div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">
                  <asp:TextBox ID="TextBox11" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label6" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox12" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
</asp:Panel>

        </div>
          <div class="col-lg-6">
            <p>

            </p>
            
                <asp:Panel ID="Panel5" class="card" style="width: 650px;" runat="server">
                    <div class="card-body">
              <div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">
                  <asp:TextBox ID="TextBox9" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label5" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox10" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
                </asp:Panel>


            <asp:Panel ID="Panel6" class="card" style="width: 650px;" runat="server">
                <div class="card-body">
              <div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">
                  <asp:TextBox ID="TextBox7" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label4" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox8" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
            </asp:Panel>


<asp:Panel ID="Panel7" class="card" style="width: 650px;" runat="server">
    <div class="card-body">
              <div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">
                  <asp:TextBox ID="TextBox5" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label3" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox6" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
</asp:Panel>
    


<asp:Panel ID="Panel8" class="card" style="width: 650px;" runat="server">
    <div class="card-body">
<div class="grid-container">
        <div class="grid-item">
            <h5 class="card-title">
                  <asp:TextBox ID="TextBox3" style="width:300px; border-radius: 5px 5px; border-color: #f0ecec;" runat="server"></asp:TextBox>
              </h5>
        </div>
        <div class="grid-item">
            <asp:Label ID="Label1" style="text-align: end; color: grey;" runat="server" Text="%"></asp:Label>
        </div>
        <div class="grid-item">
             <asp:TextBox ID="TextBox4" style="width:30px; height: 20px; align-items:start; border-color: #f0ecec; border-radius: 4px 4px;" runat="server"></asp:TextBox>
        </div>
        <div class="grid-item second-row">
            <div class="progress mt-3">
                <div class="progress-bar progress-bar-striped bg-info progress-bar-animated" role="progressbar" style="width: 75%" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100"></div>
              </div>
        </div>
    </div>
            </div>
</asp:Panel>

        </div>

              <asp:Button ID="Button1" class=" btn btn-primary" runat="server" style="width: 200px; background-color: #11cbf0; border:none; margin-left: 590px; margin-top: 50px;" Text="Submit Talented" OnClick="Button1_Click1" />

      </div>
    </section>

  </main><!-- End #main -->



  <a href="file:///C:/Users/safiy/Masa%C3%BCst%C3%BC/NiceAdmin/components-progress.html#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

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

        <script type="text/javascript">
    function performAjaxCall() {
        // AJAX çağrısını yapalım (burada jQuery kullanacağımızı varsayalım)
        $.ajax({
            type: "POST",
            url: "SayfaAdi.aspx/myButton_Click", // ASPX sayfasının adını ve tıklanma olayını belirtin
            data: "{}", // Eğer veri göndermek gerekiyorsa, uygun verileri burada gönderin (JSON formatında)
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                // AJAX çağrısı başarılıysa bu fonksiyon çalışır.
                // Gerekli işlemleri burada yapabilirsiniz.
            },
            error: function (xhr, status, error) {
                // AJAX çağrısı başarısız olursa bu fonksiyon çalışır.
                // Hata durumlarını burada yönetebilirsiniz.
            }
        });
    }
    </script>


<svg id="SvgjsSvg1001" width="2" height="0" xmlns="http://www.w3.org/2000/svg" version="1.1" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:svgjs="http://svgjs.dev" style="overflow: hidden; top: -100%; left: -100%; position: absolute; opacity: 0;"><defs id="SvgjsDefs1002"></defs><polyline id="SvgjsPolyline1003" points="0,0"></polyline><path id="SvgjsPath1004" d="M0 0 "></path></svg>
    </form>
</body>
</html>










