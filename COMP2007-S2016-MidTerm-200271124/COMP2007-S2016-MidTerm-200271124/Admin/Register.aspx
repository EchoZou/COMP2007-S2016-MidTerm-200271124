<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="COMP2007_S2016_MidTerm_200271124.Register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Here is the header and contact for the page. -->
    <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4"> 

     <div class="alert alert-danger" id="AlertFlash" runat="server" visible="false">                 
         <asp:Label runat="server" ID="StatusLabel" />
     </div>
                
    <div class="panel panel-primary">
          <div class="panel-heading">
               <h1 class="panel-title"><i class="fa fa-user-plus fa-lg"></i> Register</h1>
               <h5>All Fields are Required</h5>
          </div>

          <br />
          <div class="panel-body">
                <!-- textboxes -->
                <div class="form-group">
                    <label class="control-label" for="Username">Username</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="UserNameTextBox" placeholder="Username" required="true" TabIndex="0"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Password">Password</label>
                    <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="PasswordTextBox" placeholder="Password" required="true" TabIndex="0"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Email">Email</label>
                    <asp:TextBox runat="server" TextMode="Email" CssClass="form-control" ID="EmailTextBox" placeholder="Email" required="true" TabIndex="0"></asp:TextBox>
                </div>                
              <p>Already have an account? <a href="/Admin/Login.aspx">Login</a> here</p>

              <!-- buttons -->  
              <div class="text-right">
                     <asp:Button Text="Cancel" ID="CancelButton" runat="server" CssClass="btn btn-warning" OnClick="CancelButton_Click" UseSubmitBehavior="false" CausesValidation="false" TabIndex="0" />
                     <asp:Button Text="Submit" ID="SubmitButton" runat="server" CssClass="btn btn-primary" OnClick="SubmitButton_Click" TabIndex="0" />
                </div>
                <br />

            </div>
        </div>
    </div>
 </div>
</div>


</asp:Content>
