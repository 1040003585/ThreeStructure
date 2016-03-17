<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestOne3.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
        <asp:Label ID="Label1" runat="server" Text="bm(id)"></asp:Label> 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>     
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="mc"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="插入" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="删除" onclick="Button2_Click" />
    
        <asp:Button ID="Button3" runat="server" Text="修改" onclick="Button3_Click" 
            Width="40px" />
    
       
    </div>
    <div> <asp:Button ID="Button4" runat="server" Text="查询所有" onclick="Button4_Click" />
    </div>
    </form>
</body>
</html>
