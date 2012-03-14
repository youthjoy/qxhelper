<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    共享信息
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {

            $("#tabs").tabs();
        });
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">文档列表</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("Bse_MessageModule","Bse_Message","")%>
            <%=Html.SysComm_JqGrid("Bse_MessageModule","Bse_Message","/Message/GetMessageList",true )%>
        </div>
    </div>

    <script type="text/javascript">
        function Bse_MessageToolBarAdd() {
            window.location = '/Message/Add'+"?backUrl=/Message/Index";
        }

        function Bse_MessageToolBarEdit() {
            var grid = $('#Bse_Messagegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数
            if (data.Msg_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            window.location = "/Message/Edit/" + data.Msg_Code + "?backUrl=/Message/Index"
        }

        function Bse_MessageToolBarView() {
            var grid = $('#Bse_Messagegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.Msg_Code == undefined) {
                alert('请选中编辑行');
                return;
            }
            window.location = "/Message/Show/" + data.Msg_Code + "?backUrl=/Message/Index"
        }

        function Bse_MessageToolBarSearch() {

            Bse_Message_Bse_MessageModule_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
