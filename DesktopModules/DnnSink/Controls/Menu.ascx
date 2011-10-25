<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="DotNetNuke.Modules.DnnSink.Controls.Menu" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>

<ol>
    <li><dnn:label ID="lblPages" runat="server" />
        <ol>
            <li><a href="<%= DotNetNuke.Common.Globals.NavigateURL(TabId, "", "fn=Pages&cn=ListOfPages") %>"><%= Localization.GetString("ListOfPages.Text",LocalResourceFile) %></a>
            </li>
        </ol>
    </li>
    <li>
        <ol><dnn:label ID="lblUsers" runat="server" />
            <li><a href="<%= DotNetNuke.Common.Globals.NavigateURL(TabId, "", "fn=Users&cn=DeleteUser") %>"><%= Localization.GetString("DeleteUser.Text",LocalResourceFile) %></a>
            </li>
        </ol>
    </li>
</ol>