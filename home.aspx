<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultPageMaster.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="de1.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlSidebar" runat="server" CssClass="sidebar">
        <asp:DataList ID="dlCategories" runat="server" BorderStyle="None" DataKeyField="ID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="dlCategories_SelectedIndexChanged">
            <ItemTemplate>
                ID:
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                ImageFilePath:
                <asp:Label ID="ImageFilePathLabel" runat="server" Text='<%# Eval("ImageFilePath") %>' />
                <br />
                Description:
                <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                <br />
                Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                <br />
                NumsLike:
                <asp:Label ID="NumsLikeLabel" runat="server" Text='<%# Eval("NumsLike") %>' />
                <br />
                CatID:
                <asp:Label ID="CatIDLabel" runat="server" Text='<%# Eval("CatID") %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLDoUongConnectionString %>" ProviderName="<%$ ConnectionStrings:QLDoUongConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Beverage]"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>

