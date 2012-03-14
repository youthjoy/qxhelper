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
            <li><a href="#tabs-1">文档草稿列表</a></li>
            <li><a href="#tabs-2">已提交文档列表</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("Bse_FileModule","Bse_File","")%>
            <%=Html.SysComm_JqGrid("Bse_FileModule","Bse_File","/File/GetFileList",true )%>
        </div>
         <div id="tabs-2">
            <%=Html.GenToolbarNoPermissionHelper("Bse_FileModule", "DoneBse_File", "viewN:'查看',addN:'审核情况',addFunJs:'Audit()'")%>
            <%=Html.SysComm_JqGrid("Bse_FileModule", "DoneBse_File", "/File/GetMySubmitList", true)%>
        </div>
    </div>


<% Html.RenderPartial("AuditHis");%>
    <script type="text/javascript">
        //历史记录
        function DoneBse_FileAudit() {
            var grid = $('#DoneBse_Filegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据

            AuditInstance.Init("ComFileAudit", data.AuditCurAudit, data.CF_Code, function(data1) {
            });

        }
    </script>
<script type="text/javascript">

    function DoneBse_FileToolBarView() {
        var grid = $('#DoneBse_Filegrid');
        var curid = grid.getGridParam('selrow'); //获取选择行的id
        var data = grid.getRowData(curid); //获取行号为curid的数据            
        if (data.CF_Code == undefined) {
            ShowMsg('请选中编辑行');
            return;
        }
        window.location = "/File/Show/" + data.CF_Code + "?backUrl=/Comp/Index";
    }

    function DoneBse_FileToolBarSearch() {

        DoneBse_File_Bse_FileModuleGridControl.Search();
    }   
    </script>

    <script type="text/javascript">
        function Bse_FileToolBarAdd() {
            window.location = '/File/Add'+"?backUrl=/File/Index";
        }

        function Bse_FileToolBarEdit() {
            var grid = $('#Bse_Filegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.CF_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            window.location = "/File/Edit/" + data.CF_Code + "?backUrl=/File/Index"
        }

        function Bse_FileToolBarDel() {
            var grid = $('#Bse_Filegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.CF_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {

                    if (data.AuditStat != undefined) {
                        ShowMsg("当前文档已提交，不能删除！");
                        return;
                    }
                    $.ajax({
                        type: 'post',
                        url: '/File/Delete/',
                        data: { id: data.CF_Code, oper: 'del' },
                        success: function(result) {
                            if (result.result == 'success') {
                                $('#Bse_Filegrid').trigger('reloadGrid');
                            } else {
                                ShowMsg('删除失败');
                            }
                        }
                    });
                }
            });
        }

        function Bse_FileToolBarView() {
            var grid = $('#Bse_Filegrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.CF_Code == undefined) {
                alert('请选中编辑行');
                return;
            }
            window.location = "/File/Show/" + data.CF_Code + "?backUrl=/File/Index"
        }

        function Bse_FileToolBarSearch() {

            Bse_File_Bse_FileModule_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
