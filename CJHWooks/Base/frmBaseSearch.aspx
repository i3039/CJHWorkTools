<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBaseSearch.aspx.cs" Inherits="CJH.CJHWooks.frmBaseSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="txtCode" MaxLength="6" CssClass="textBox60"></asp:TextBox>
        <asp:Button runat="server" ID="btnSearch" Text="查询" />
    </div>
        <div runat="server" id="showResult"></div>
    </form>
</body>
</html>
