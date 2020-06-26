<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="23.aspx.cs" Inherits="EMS201724112133._23" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>公司人员情况</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery-3.5.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            color: #000000;
        }
        .auto-style6 {
            width: 37%;
            height: 26px;
        }
        .auto-style9 {
            width: 125px;
        }
        .auto-style10 {
            width: 236px;
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
                        <a href="21.aspx"><span class="auto-style1">部门管理</span>&nbsp;</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="22.aspx"><span class="auto-style1">设备管理&nbsp;</span></a>&nbsp;&nbsp;&nbsp;&nbsp; 员工管理</div>
                    <div class="text-center">
                        
                        
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        <asp:LinkButton runat="server"  ID="btnToLog" OnClick="btnToLog_Click">登录</asp:LinkButton>
                        
                        
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="查询" Width="89px" OnClick="Button1_Click" />
                        <br />
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        <br />
                        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="EMS201724112133.Models.EMSdb1Entities" EntityTypeName="" OrderBy="Emp_id" TableName="Emp">
                        </asp:LinqDataSource>
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="2" DataSourceID="LinqDataSource1" ForeColor="Black" GridLines="None" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
                            <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            <Columns>
                                <asp:BoundField DataField="Emp_id" HeaderText="Emp_id" SortExpression="Emp_id" />
                                <asp:BoundField DataField="Emp_pass" HeaderText="Emp_pass" SortExpression="Emp_pass" />
                                <asp:BoundField DataField="Emp_name" HeaderText="Emp_name" SortExpression="Emp_name" />
                                <asp:BoundField DataField="Emp_phone" HeaderText="Emp_phone" SortExpression="Emp_phone" />
                                <asp:CheckBoxField DataField="Emp_manager" HeaderText="Emp_manager" SortExpression="Emp_manager" />
                                <asp:BoundField DataField="Emp_dept" HeaderText="Emp_dept" SortExpression="Emp_dept" />
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
                        <asp:QueryExtender ID="QueryExtender1" runat="server" TargetControlID="LinqDataSource1">
                            <asp:SearchExpression DataFields="Emp_id,Emp_name,,Emp_dept" SearchType="StartsWith">
                                <asp:ControlParameter ControlID="TextBox1" />
                            </asp:SearchExpression>
                        </asp:QueryExtender>
                        
                        
                        <br />
                        <table align="center" class="auto-style6">
                            <tr>
                                <td class="auto-style9">员工编号：</td>
                                <td class="auto-style10">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">员工密码：</td>
                                <td class="auto-style10">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">员工姓名：</td>
                                <td class="auto-style10">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">员工电话：</td>
                                <td class="auto-style10">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">是否为管理员：</td>
                                <td class="auto-style10">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">所属部门：</td>
                                <td class="auto-style10">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="插入" OnClick="Button2_Click" />
&nbsp;
                        <asp:Button ID="Button3" runat="server" Text="修改" OnClick="Button3_Click" />
&nbsp;
                        <asp:Button ID="Button4" runat="server" Text="删除" OnClick="Button4_Click" />
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

