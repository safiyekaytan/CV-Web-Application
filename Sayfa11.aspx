<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sayfa11.aspx.cs" Inherits="aspxliDeneme.Sayfa11" %>

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
          <div class="card" style ="border: none; margin-top: 0px;">
        <div class="shadow-lg p-3 mb-0 bg-body rounded">
            <div class="card-body">
                <h4 class="card-title" style="color:#012970;">Sign Up</h4>
                <p class="card-text" style="color:#012970;">Complete the pre-registration process by specifying a username and password</p>

                    <div class="textboxlar" >

                    <p class="font-weight-normal" style="color:#012970;">Username</p>

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="basic-addon1">@</span>
                        </div>
                         <asp:TextBox ID="userNameText" class="form-control" runat="server" placeholder="Username" aria-describedby="basic-addon1"></asp:TextBox>
                    </div>
                    <p class="font-weight-normal" style="color:#012970;">Password</p>

                    <div class="input-group mb-3">
                        
                         <asp:TextBox ID="passwordText" class="form-control" runat="server" placeholder="Password" aria-describedby="basic-addon2"></asp:TextBox>
                        <div class="input-group-append">
                        </div>
                    </div>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                    <label class="form-check-label" style="color:#012970;" for="flexCheckDefault">
                        Remember Me
                    </label>
                </div>
                <p></p>
                <div class="d-grid gap-2 col-12 mx-auto">
                        <asp:Button ID="signupButton" style="background-color:#012970;" runat="server"  Text="Sign Up" class="btn btn-primary" OnClick="Button1_Click" />
                </div>
                <div style="margin-left:140px; margin-top: 15px;">
                     <asp:LinkButton ID="LinkButton1" stlye="color: #012970;" runat="server" OnClick="LinkButton1_Click"> - Log In  -</asp:LinkButton>
                </div>
               
            </div>
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
    </form>
  
    </body>
    </html>