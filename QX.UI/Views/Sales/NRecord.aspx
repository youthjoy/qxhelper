<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	NRecord
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%--<%=Html.JqGrid("PCD_NRecordModule","","","")%>--%>
    <%=Html.JqGridListPage("PCD_NRecordModule","PCD_NRecord","","","")%>
    
    

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>
    
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
