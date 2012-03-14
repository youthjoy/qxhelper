<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    共享文档
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {

            $("#tabs").tabs();
        });
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">已处理文档列表</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("Bse_FileModule","DoneBse_File","viewN:'查看'")%>
            <%=Html.SysComm_JqGrid("Bse_FileModule","DoneBse_File","/File/GetAllFileList",true )%>
        </div>
    </div>

    <script type="text/javascript">
        

        function DoneBse_FileToolBarView() {
            var grid = $('#DoneBse_Filegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.CF_Code == undefined) {
                alert('请选中编辑行');
                return;
            }
            window.location = "/File/Show/" + data.CF_Code + "?backUrl=/File/List"
        }

        function DoneBse_FileToolBarSearch() {

            DoneBse_File_Bse_FileModule_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
