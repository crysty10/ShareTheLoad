<%@ Page Title="Add Request" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="AddRequest.aspx.cs" Inherits="AddRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <section id="registerForm" class="bg-light-gray">
        <div class="container" >
            <h2><%: Title %></h2>
            <p class="text-danger">
                <asp:Literal runat="server" ID="ErrorMessage" />
            </p>

            <div class="form-horizontal" >
                <hr />
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="RequestTitle" CssClass="col-md-2 control-label">Title: </asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="RequestTitle" CssClass="form-control" placeholder="First Name *" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="RequestTitle"
                            CssClass="text-danger" ErrorMessage="The request title is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" CssClass="col-md-2 control-label">Category: </asp:Label>
                    <div class="col-md-10">
                        <select class="form-control" name="Category">
                            <option value="all">All</option>
                            <option value="games">Games</option>
                            <option value="it">IT</option>
                            <option value="misc">Misc</option>
                            <option value="tools">Tools</option>
                        </select>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Price" CssClass="col-md-2 control-label">Estimated price: </asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Price" CssClass="form-control" placeholder="Address *"/>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Price"
                            CssClass="text-danger" ErrorMessage="The estimated price is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="MinFollow" CssClass="col-md-2 control-label">Minimum followers: </asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="MinFollow" CssClass="form-control" placeholder="User Name *"/>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="MinFollow"
                            CssClass="text-danger" ErrorMessage="The minimum followers number is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="MaxFollow" CssClass="col-md-2 control-label">Maximum followers: </asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="MaxFollow" TextMode="Password" CssClass="form-control" placeholder="Password *"/>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="MaxFollow"
                            CssClass="text-danger" ErrorMessage="The maximum followers number is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" CssClass="col-md-2 control-label">Deadline: </asp:Label>
                    <div class="col-md-10">
                        <input data-provide="datepicker-inline" class="datepicker">
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Button runat="server" Text="Add request" CssClass="btn btn-default" OnClick="AddRequest_Click" />
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>

