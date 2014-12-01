<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="MyRequests.aspx.cs" Inherits="Pages_MyRequests" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <section id="myAccountSection" class="bg-light-gray">
        <div class="container">
            <div class="row">
                <div class="form-horizontal">

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserFirstName" CssClass="col-md-2 control-label">User firstname:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserFirstName" CssClass="form-control" placeholder="Firstname *"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserFirstName"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserLastName" CssClass="col-md-2 control-label">User lastname:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserLastName" CssClass="form-control" placeholder="Lastname *"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserLastName"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" placeholder="Password *"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserEmail" CssClass="col-md-2 control-label">Email:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserEmail" CssClass="form-control" placeholder="Email *"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserEmail"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserPhone" CssClass="col-md-2 control-label">Phone:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserPhone" CssClass="form-control" placeholder="Phone *"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserPhone"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" Text="Modify" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>

                <p>
                    <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Modify</asp:HyperLink>
                    if you don't have an account.
                </p>

            </div>
        </div>
    </section>



</asp:Content>

