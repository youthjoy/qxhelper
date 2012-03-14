<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    销售工程管理
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">工程列表</a></li>
            <li><a href="#tabs-2">全部工程</a></li>
        </ul>
        <div id="tabs-1">
            <!--有效地工程信息-->
            <%=Html.Common_ToolBarForListPage("Project", "viewN:'查看',viewFunJs:'View()',searchN:'搜索',searchFunJs:'Search()'")%>
            <%=Html.JqGrid("SD_AllProjectModule", "Valid", "Cust", "Valid")%>
            <%--工程路线--%>
            <%=Html.JqGridListPage("SD_CTransModule","SD_CTrans","","","")%>
        </div>
        <div id="tabs-2">
            <!--全部工程-->
            <%=Html.Common_ToolBarForListPage("ProjectAll", "viewN:'查看',viewFunJs:'View()',searchN:'搜索',searchFunJs:'Search()'")%>
            <%=Html.JqGrid("SD_AllProjectModule", "All", "Cust", "All")%>
        </div>
    </div>

    <script type="text/javascript">
        $(function() {
            $("#tabs").tabs();

            //单击工程列表事件出现路线列表


        });

        //工程 添加：编辑，删除
        function Project_add() {

        }

        function Project_edit() {


        }

        function Project_del() {


        }

        //查看
        function Project_View() {
            var grid = $('#Validgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDI_Code == undefined) {
                ShowMsg('请选中需要查看的数据行');
                return;
            }
            var url = "/Sales/QProjectView/" + data.SDI_Code;
            Win.Open(url, "", "");
        }
        function Project_Search() {
            SysComm_Valid.Search();
        }

        //查看
        function ProjectAll_View() {
            var grid = $('#Allgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.SDI_Code == undefined) {
                ShowMsg('请选中需要查看的数据行');
                return;
            }
            var url = "/Sales/QProjectView/" + data.SDI_Code;
            Win.Open(url, "", "");
        }
        function ProjectAll_Search() {
            SysComm_All.Search();
        }
        
        
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

    <script type="text/javascript" src="/Scripts/Shared/WinOpen.js"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
