<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MarketLocator.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-3">
            <asp:Label CssClass="control-label" runat="server">Age: </asp:Label>
            <asp:DropDownList ID="DropDownListAge" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
            <br />
            <asp:Label CssClass="control-label" runat="server">Gender: </asp:Label>
            <asp:DropDownList ID="DropDownListGenre" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
            <br />
            <asp:Label CssClass="control-label" runat="server">Start date: </asp:Label>
            <asp:textbox id="startDate" runat="server" cssclass="datepicker-field form-control" placeholder="Select date"/>
            <br />
            <asp:Button class="btn btn-primary" runat="server" Text="Filter" OnClick="Filter_Click" />
            <br /> <br /> 
        </div>
        <div class="col-md-9">
            <div id="mapid" style="width: 100px; height: 600px; min-height: 100%; min-width: 100%;"></div>
        </div>
    </div>
    <script src="Scripts/Leaflet/leaflet.js"></script>

</asp:Content>