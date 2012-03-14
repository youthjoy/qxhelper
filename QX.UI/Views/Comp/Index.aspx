<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    DraftList
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();
        });
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">草稿列表</a></li>
            <li><a href="#tabs-2">已提交图纸</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("Bse_ComponentsModule", "Bse_Components", "")%>
            <%=Html.SysComm_JqGrid("Bse_ComponentsModule", "Bse_Components", "/Comp/GetCompDraftList", true)%>
        </div>
        <div id="tabs-2">
            <%=Html.GenToolbarNoPermissionHelper("Bse_ComponentsModule", "DoneBse_Components", "viewN:'查看',addN:'修订',addFunJs:'Modify()'")%>
            <%=Html.SysComm_JqGrid("Bse_ComponentsModule", "DoneBse_Components", "/Comp/GetMySubmitList", true)%>
        </div>
    </div>


    <script type="text/javascript">
        //历史记录
        function DoneBse_ComponentsModify() {
            var grid = $('#DoneBse_Componentsgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            window.location = "/Comp/Correct/" + data.Comp_Code + "?backUrl=/Comp/Index"
        }
    </script>
<script type="text/javascript">

    function DoneBse_ComponentsToolBarView() {
        var grid = $('#DoneBse_Componentsgrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据            
        if (data.Comp_Code == undefined) {
            ShowMsg('请选中编辑行');
            return;
        }
        window.location = "/Comp/Show/" + data.Comp_Code + "?backUrl=/Comp/Index";
    }

    function DoneBse_ComponentsToolBarSearch() {

        DoneBse_Components_Bse_ComponentsModule_GridControl.Search();
    }   
    </script>

    <script type="text/javascript">
        
        function Bse_ComponentsToolBarAdd() {
            window.location = '/Comp/Add' + "?backUrl=/Comp/Index";
        }

        function Bse_ComponentsToolBarDel() {
            var grid = $('#Bse_Componentsgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {

                    $.ajax({
                        type: 'post',
                        url: '/Comp/Delete/',
                        data: { id: data.Comp_Code, oper: 'del' },
                        success: function(result) {
                            if (result.result == 'success') {
                                $('#Bse_Componentsgrid').trigger('reloadGrid');
                            }
                            else {
                                ShowMsg('删除失败');
                            }
                        }
                    });
                }
            });
        }

        function Bse_ComponentsToolBarEdit() {
            var grid = $('#Bse_Componentsgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            window.location = "/Comp/Edit/" + data.Comp_Code + "?backUrl=/Comp/Index"
        }

        function Bse_ComponentsToolBarView() {
            var grid = $('#Bse_Componentsgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Comp_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            window.location = "/Comp/Show/" + data.Comp_Code + "?backUrl=/Comp/Index"
        }

        function Bse_ComponentsToolBarSearch() {

            Bse_Components_Bse_ComponentsModule_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/jquery.tips.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/ComOperation.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
