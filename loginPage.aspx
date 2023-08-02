<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="aspxliDeneme.loginPage" %>

<!doctype html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="ikinciSayfa.css" type="text/css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.min.js" integrity="sha384-fbbOQedDUMZZ5KreZpsbe1LCZPVmfTnH7ois6mU1QK+m14rQ1l2bGBq41eYeM/fS" crossorigin="anonymous"></script>
</head>
<body>
    <form runat="server">
        <asp:ImageMap ID="ImageMap1" ImageUrl="login.png" style="width:400px; margin-left:560px; margin-bottom:25px; margin-top:40px;" runat="server"></asp:ImageMap>

          <div class="card" style="margin-top:0px; border:none; height:400px;">
        <div class="shadow-lg p-3 mb-0 bg-body rounded">
            <div class="card-body" >
                <h4 class="card-title" style="color:#012970;">Login to Your Account</h4>
                <p class="card-text" style="color:#012970;">Enter your username & password to login</p>

                
                    <div class="textboxlar" >

                    <p class="font-weight-normal" style="color:#012970;">Username</p>

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="basic-addon1">@</span>
                        </div>
                         <asp:TextBox ID="textbox1" class="form-control" runat="server" placeholder="Username" aria-describedby="basic-addon1" OnTextChanged="textbox1_TextChanged"></asp:TextBox>

                    </div>
                   
                    <p class="font-weight-normal" style="color:#012970;">Password</p>

                    <div class="input-group mb-3">
                        
                         <asp:TextBox ID="textbox2" class="form-control" runat="server" placeholder="Password" aria-describedby="basic-addon2" OnTextChanged="textbox2_TextChanged"></asp:TextBox>
                        <div class="input-group-append">
                        </div>
                    </div>
                   
                </div>
                
                

                <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                    <label class="form-check-label" for="flexCheckDefault" style="color:#012970;">
                        Remember Me
                    </label>
                </div>
                <p></p>
                <div class="d-grid gap-2 col-12 mx-auto">
            

                        <asp:Button ID="Button1" style="background-color: #012970" runat="server"  Text="LogIn" class="btn btn-primary" OnClick="Button1_Click" />

                    <script>

                        function tikla() {


                            var kullaniciAd = document.getElementById("userNames").value;
                            var sifre = document.getElementById("passwords").value;

                            alert(kullaniciAd);
                            alert(sifre);

                    </script>

                    
                </div>
                <p></p>

                <div class="card-body">
                    <label style="color:#012970;"> Don't have account ? </label>
                    <asp:Button ID="createAccount" class="card-link" runat="server" style="background-color:white; color: #012970; border: none;" Text="Create an account" OnClick="createAccount_Click" />
                </div>
                
            </div>
        </div>

       
    </div>






    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
    </form>
  
    </body>
    </html>