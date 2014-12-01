<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="MyRequests.aspx.cs" Inherits="Pages_MyRequests" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

<div class="container">
    <div class="row">
        <fieldset>
            <legend>Your requests subscription!</legend>
            <asp:Table ID="table" runat="server" />
        </fieldset>
    </div>
</div>

</asp:Content>

