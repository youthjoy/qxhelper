<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Sys_Bug>" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	砼网科技工作管理系统
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%= Html.JqGridListPage("Sys_BugModule", "Sys_Bug", "", "", "")%>
    <div id="tabs" style="width: 100%">
        <ul>
            <li><a href="#tabs-1">操作日志</a></li>
        </ul>
        <div id="tabs-1">
            <%= Html.JqGridListPage("Sys_BugLogModule", "Sys_BugLog", "", "", "")%>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
<script type="text/javascript">
    $(function() {
        $("#tabs").tabs();
    });
</script>
<script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>
<script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
