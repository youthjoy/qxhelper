<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {

            $("#tabs").tabs();
        });
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">日志列表</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("Sys_OpLogModule", "Sys_OpLog", "")%>
            <%=Html.SysComm_JqGrid("Sys_OpLogModule", "Sys_OpLog", "/Permission/GetLogList", true)%>
        </div>
    </div>

    <script type="text/javascript">
        function Sys_OpLogToolBarSearch() {

            Sys_OpLog_Sys_OpLogModule_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
