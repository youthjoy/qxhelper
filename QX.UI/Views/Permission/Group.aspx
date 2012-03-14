<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    分组列表
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        $(document).ready(function() {

            $("#tabs").tabs();
        });
    </script>

    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">授权群组</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarNoPermissionHelper("Bse_GroupModule","Bse_Group","")%>
            <%=Html.SysComm_JqGrid("Bse_GroupModule","Bse_Group","/Permission/GetGroupList",true )%>
        </div>
    </div>
    <div id="GroupEdit">
        <%=Html.GenToolbarHelper("GroupDoc_AllotModule", "Doc_Allot", "addN:'分发',addFunJs:'Allot()',delN:'删除',delFunJs:'Del()'")%>
        <%=Html.SysComm_JqGrid("GroupDoc_AllotModule", "Doc_Allot", "/Doc/GetAllot/", true)%>
    </div>

    <script type="text/javascript">
        $(document).ready(function() {
            $("#GroupEdit").dialog({
                width: 500,
                autoOpen: false
            });

            Common_EmpTree_DialogDept.Init("Doc_Allot_add", function(code, name) {
                var grid = $('#Bse_Groupgrid');
                var curid = grid.getGridParam('selrow'); //获取选择行的id
                var data = grid.getRowData(curid);
                //人员回写
                $.ajax({
                    type: "post",
                    url: "/Doc/DocAllot",
                    dataType: "json",
                    data: { code: code.join(','), name: name.join(','), doc: data.GP_Code, module: 'Bse_Group' },
                    success: function(re, textStatus) {

                        $("#Doc_Allotgrid").trigger("reloadGrid");
                    }
                });
            });
        });


        function Doc_AllotDel() {
            var grid = $('#Doc_Allotgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid);
            if (data.DA_Code == undefined) {
                ShowMsg("请选中要操作的数据!");
                return;
            }

            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    $.ajax({
                        type: 'post',
                        url: '/Doc/AllotGroupDelete/',
                        data: { id: data.DA_Code, oper: 'del' },
                        success: function(result) {
                            if (result.result == 'success') {
                                $('#Doc_Allotgrid').trigger('reloadGrid');
                            } else {
                                ShowMsg('删除失败');
                            }
                        }
                    });
                }
            });

        }

    </script>

    <script type="text/javascript">

        function DocAllotAllot() {

        }

        function Bse_GroupToolBarEdit() {
            var grid = $('#Bse_Groupgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.GP_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            $("#GroupEdit").dialog('open');
            $("#Doc_Allotgrid").setGridParam({ url: '/Doc/GetAllot/' + data.GP_Code }).trigger("reloadGrid");
        }

        function Bse_GroupToolBarSearch() {

            Bse_Group_Bse_GroupModule_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    <link href="/Content/css/jquery.multiselect.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/Shared/jquery.multiselect.min.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
