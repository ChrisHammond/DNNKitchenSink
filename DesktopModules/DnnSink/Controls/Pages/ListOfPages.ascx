<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListOfPages.ascx.cs" Inherits="DotNetNuke.Modules.DnnSink.Controls.Pages.ListOfPages" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>


<asp:TextBox ID="txtCode" runat="server" TextMode="MultiLine" CssClass="CodeExample">
var tabs = TabController.GetTabsByParent(-1, PortalId);
foreach (var t in tabs)
{
    if (t.IsVisible)
    {
        txtListOfPages.Text += t.TabName;
        txtListOfPages.Text += "/n";
    }
}
</asp:TextBox>

<asp:TextBox ID="txtListOfPages" runat="server"  TextMode="MultiLine" CssClass="CodeResult" />