<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CPlan
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <%= Html.JqGridListPage("PC_CPlanModule", "PC_CPlan", "", "", "")%>
    
    <%--工程--%>
    <%=Html.ReferControl("SD_ProjectModule", "SD_Project",false)%>
    <%--合同--%>
    <%=Html.ReferControl("WH_ContractModule", "WH_Contract", false)%>
    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
