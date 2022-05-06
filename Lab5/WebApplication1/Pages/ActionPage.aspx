<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActionPage.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div style="margin-bottom: 15px;">
            <asp:Label ID="LName" runat="server" Text="Title*"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="txtTitle" runat="server" Width="117px" Height="16px" OnTextChanged="txtTitle_TextChanged"></asp:TextBox>
        </div>

        <div style="margin-bottom: 15px;">
            <asp:Label ID="LGender" runat="server" Text="Genre*"></asp:Label>
            &nbsp;
            <asp:DropDownList ID="ddGen" runat="server" Width="127px">
                <asp:ListItem>ACTION</asp:ListItem>
                <asp:ListItem>HORROR</asp:ListItem>
                <asp:ListItem>NOVEL</asp:ListItem>
            </asp:DropDownList>
        </div>

    </div>

    <div class="container">
        <div style="margin: 20px 0px 20px 0px;">
            <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addBtn_Click" Height="31px" Width="192px" />
        </div>
        <div style="margin-bottom: 20px;">
            <asp:Button ID="dltBtn" runat="server" Text="Delete" OnClick="dltBtn_Click" Height="29px" Width="190px" />
        </div>
        <div>
            <asp:Button ID="updtBtn" runat="server" Text="Update" OnClick="updtBtn_Click" Height="29px" Width="190px" />
        </div>
    </div>

    <div style="display: grid; margin-top: 20px;">
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BackButtonOnClickEvent" runat="server" Text="Go Back" OnClick="goBack" Height="29px" Width="192px" />
        <br />
        <br />
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label CssClass="alert" ID="err_msg" runat="server" Visible="False" BorderColor="Red"></asp:Label>
        </asp:Content>
