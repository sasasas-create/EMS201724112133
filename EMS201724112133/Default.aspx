<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EMS201724112133.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>设备保管与查询系统-首页</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery-3.5.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            position: relative;
            width: 100%;
            flex-basis: 0;
            flex-grow: 1;
            min-width: 0;
            max-width: 100%;
            left: 0px;
            top: 0px;
            padding-left: 15px;
            padding-right: 15px;
        }

        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="width:80%;margin-top:30px;">
            <div class="row">
               <div class ="col">
                <div class="auto-style1">
                    <div class="card-header bg-warning text-center">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="Black" OnClick="LinkButton2_Click">部门管理</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Black" OnClick="LinkButton3_Click" >设备管理</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton4" runat="server" ForeColor="Black" OnClick="LinkButton4_Click" >员工管理</asp:LinkButton>
                    </div>
                    <div class="card-body ">
                        
                        
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        <asp:LinkButton runat="server" ID="btnToLog" OnClick="btnToLog_Click">登录</asp:LinkButton>
                        
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="font-family: 宋体; font-size: 14pt;">本公司由财务部，人事部，生产部，技术部，销售部五个部门组成。本系统记录企业内所有设备的状况及保管人信息以提供企业内部了解设备的保管状况，并可进一步实施设备资源的共享，以避免不必要的重覆购入相同设备。本系统只允许企业内部人员登录。</span></p>
                        <br />
&nbsp;<br />
                    </div>
                    
                </div>
            </div>
        </div>
       </div>
    </form>
</body>
</html>

