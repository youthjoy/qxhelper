<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.Permission" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Test
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%=Html.GenNToolbarHelper("Bse_ComponentsModule", "Bse_Components", PermissionHelper.Instance.GetUserPermissionMapByUser("113"))%>
    <%=Html.GenToolbarHelper("Bse_ComponentsModule", "Bse_Components",null)%>
    <%=Html.SysComm_JqGrid("Bse_ComponentsModule", "Bse_Components", "/Comp/GetCompDraftList", true)%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="../../Scripts/Shared/Dict_ERP.js" type="text/javascript"></script>

    <script src="../../Scripts/Shared/Dict.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
