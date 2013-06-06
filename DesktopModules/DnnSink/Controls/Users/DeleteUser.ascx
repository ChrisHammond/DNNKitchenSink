<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DeleteUser.ascx.cs" Inherits="Christoc.Modules.DnnSink.Controls.Users.DeleteUser" %>

<asp:TextBox id="deleteUser" TextMode="MultiLine" runat="server" CssClass="CodeExample">
var user = UserController.GetUserById(PortalId, userId);
UserController.DeleteUser(ref user, false, false);
UserController.RemoveUser(user);
</asp:TextBox>