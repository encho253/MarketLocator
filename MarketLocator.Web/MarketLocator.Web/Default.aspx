<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MarketLocator.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-2">
            <asp:Label CssClass="control-label" runat="server">Age: </asp:Label>
            <asp:DropDownList ID="DropDownListAge" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
            <br />
            <asp:Label CssClass="control-label" runat="server">Gender: </asp:Label>
            <asp:DropDownList ID="DropDownListGenre" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
            <br />

            <asp:Button runat="server" Text="Filter" OnClick="Unnamed_Click" />
        </div>
        <div class="col-md-10">
            <div id="mapid" style="width: 100px; height: 600px; min-height: 100%; min-width: 100%;"></div>
        </div>
    </div>
</asp:Content>