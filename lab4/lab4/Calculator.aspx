<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="lab4.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">  
<head id="Head1" runat="server">  
    <title></title>
    <style>
        .btn:hover {
            background-color: darkslateblue;
        }
    </style>
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Label ID="l" Text=" LAB4 CALCULATOR" runat="server" Style="margin-left: 200px"  
            Font-Bold="False" Font-Italic="False"></asp:Label>  
    </div>
        <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="t" runat="server" Style="margin-left: 100px; margin-top: 24px;"  
            Width="314px" Height="41px" BackColor="Black" BorderColor="#666666" BorderStyle="Groove" BorderWidth="10px" ForeColor="White"></asp:TextBox>  
        </p>
        <p style="margin-left: 160px">
        <asp:Button ID="b1" Text="1" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b1_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" CssClass="btn" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="b2" Text="2" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b2_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="b3" Text="3" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b3_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="mul" Text="*" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="mul_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        </p>
        <p style="margin-left: 160px">
        <asp:Button ID="b4" Text="4" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b4_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="b5" Text="5" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b5_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="b6" Text="6" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b6_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="div" Text="/" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="div_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        </p>
        <p style="margin-left: 160px">
        <asp:Button ID="b7" Text="7" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b7_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="b8" Text="8" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b8_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="b9" Text="9" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b9_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="sub" Text="-" runat="server" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="sub_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        </p>
        <p style="margin-left: 160px">
        <asp:Button ID="clr" runat="server" Text="CLR" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="clr_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="b0" runat="server" Text="0" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="b0_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="eql" runat="server" Text="=" Height="57px" Style="margin-left: 0px"  
            Width="57px" OnClick="eql_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        &nbsp;&nbsp;&nbsp;&nbsp;  
        <asp:Button ID="add" Text="+" runat="server" Height="57px" Style="margin-left: 0px;  
            margin-top: 0px;" Width="57px" OnClick="add_Click" BackColor="#333333" BorderColor="#666666" BorderWidth="5px" ForeColor="White" />  
        </p>
        <p>
            &nbsp;</p>
    </form>  
</body>  
</html>
