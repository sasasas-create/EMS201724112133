<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EMS201724112133.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>设备保管与查询系统-登录页面</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery-3.5.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
           <div class="container" style="width:80%;margin-top:30px;">
            <div class="row">
               <div class ="col">
                <div class="auto-style1">
                    <div class="card-header bg-warning text-center">系统登录</div>
                    <div class="card-body text-center">
                        <!--定义出表单栏位的群组-->
                        <div class="form-group">
                            <span id="spanuser">编号:</span>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" Height="30px" Width="240px"></asp:TextBox>
                        </div>
                        
                        <div class="form-group">
                            <span id="spanpsd">密码: </span><asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Height="30px" Width="240px" TextMode="Password"></asp:TextBox>
                            <br/>
                        </div>
                        <p>
                            <asp:Button ID="Button1" runat="server" Text="登 录"  Width="86px" OnClick="Button1_Click" />
                            
                        </p>
                    </div>
                </div>
            </div>
           </div>
         </div>
</form>
</body>
</html>

