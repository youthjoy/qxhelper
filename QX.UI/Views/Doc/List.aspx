<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    已处理公文列表
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {

            $("#tabs").tabs();
        });
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">已处理公文列表</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("CList_DocInfo","DoneDoc_Info","viewN:'查看'")%>
            <%=Html.SysComm_JqGrid("CList_DoingDocInfo","DoneDoc_Info","/Doc/GetInDoList",true )%>
        </div>
    </div>

    <script type="text/javascript">
       

        function DoneDoc_InfoToolBarView() {
            var grid = $('#DoneDoc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Doc_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            window.location = "/Doc/Show/" + data.Doc_Code + "?backUrl=/Doc/List";
        }

        function DoneDoc_InfoToolBarSearch() {

            DoneDoc_Info_CList_DoingDocInfo_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
