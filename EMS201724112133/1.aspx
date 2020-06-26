<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1.aspx.cs" Inherits="EMS201724112133._1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>普通员工页面</title>
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
                    <div class="card-header bg-warning text-center">
                        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Black" OnClick="LinkButton1_Click">部门管理</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="Black" >设备情况</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Black" O OnClick="LinkButton3_Click">员工管理</asp:LinkButton>
                    </div>
                    <div class="text-center">
                        
                        
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        <asp:LinkButton runat="server"  ID="btnToLog" OnClick="btnToLog_Click" >登录</asp:LinkButton>
                        
                        
                        <br />
                        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="EMS201724112133.Models.EMSdb1Entities" EntityTypeName="" OrderBy="Equ_Id" Select="new (Equ_Id, Equ_name, Equ_standards, Equ_price, Equ_date, Equ_location, Equ_resp)" TableName="Equ">
                        </asp:LinqDataSource>
                        
                        
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server"  Text="查询" OnClick="Button1_Click" />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                        
                        
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" AllowPaging="True" CellPadding="2" CssClass="active" ForeColor="Black" GridLines="None" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
                            <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            <Columns>
                                <asp:BoundField DataField="Equ_Id" HeaderText="Equ_Id" SortExpression="Equ_Id" ReadOnly="True" />
                                <asp:BoundField DataField="Equ_name" HeaderText="Equ_name" SortExpression="Equ_name" ReadOnly="True" />
                                <asp:BoundField DataField="Equ_standards" HeaderText="Equ_standards" SortExpression="Equ_standards" ReadOnly="True" />
                                <asp:BoundField DataField="Equ_price" HeaderText="Equ_price" ReadOnly="True" SortExpression="Equ_price" />
                                <asp:BoundField DataField="Equ_date" HeaderText="Equ_date" ReadOnly="True" SortExpression="Equ_date" />
                                <asp:BoundField DataField="Equ_location" HeaderText="Equ_location" ReadOnly="True" SortExpression="Equ_location" />
                                <asp:BoundField DataField="Equ_resp" HeaderText="Equ_resp" ReadOnly="True" SortExpression="Equ_resp" />
                            </Columns>
                            <FooterStyle BackColor="Tan" />
                            <HeaderStyle BackColor="Tan" Font-Bold="True" />
                            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            <SortedAscendingCellStyle BackColor="#FAFAE7" />
                            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                            <SortedDescendingCellStyle BackColor="#E1DB9C" />
                            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                        </asp:GridView>
                        <br />
                        <br />
                        
                        
                        <br />
                        <br />
                        
                        
                    </div>
                    
                </div>
            </div>
        </div>
       </div>
    </form>
</body>
</html>
