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
            <li><a href="#tabs-2">已提交列表</a></li>
        </ul>
        <div id="tabs-1">
            <%=Html.GenToolbarHelper("CList_DocInfo","Doc_Info","")%>
            <%=Html.SysComm_JqGrid("CList_DocInfo","Doc_Info","/Doc/GetDraftList",true )%>
        </div>
        <div id="tabs-2">
            <%=Html.GenToolbarNoPermissionHelper("CList_DocInfo", "DoneDoc_Info", "viewN:'查看',addN:'审核情况',addFunJs:'Audit()'")%>
            <%=Html.SysComm_JqGrid("CList_DocInfo", "DoneDoc_Info", "/Doc/GetMySubmitList", true)%>
        </div>
    </div>
<% Html.RenderPartial("AuditHis");%>
    <script type="text/javascript">
        //历史记录
        function DoneDoc_InfoAudit() {
            var grid = $('#DoneDoc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据

            AuditInstance.Init("DocumentAudit", data.AuditCurAudit, data.Doc_Code, function(data1) {
            });

        }
    </script>

    <script type="text/javascript">

        function DoneDoc_InfoToolBarView() {
            var grid = $('#DoneDoc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Doc_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            window.location = "/Doc/Show/" + data.Doc_Code + "?backUrl=/Comp/Index";
        }

        function DoneDoc_InfoToolBarSearch() {

            DoneDoc_Info_CListDoc_InfoGridControl.Search();
        }   
    </script>

    <script type="text/javascript">
        function Doc_InfoToolBarAdd() {
            window.location = '/Doc/Add' + "?backUrl=/Doc/DraftList";
        }

        function Doc_InfoToolBarEdit() {
            var grid = $('#Doc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Doc_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }

            window.location = "/Doc/Edit/" + data.Doc_Code + "?backUrl=/Doc/DraftList"
        }
        function Doc_InfoToolBarDel() {
            var grid = $('#Doc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据            
            if (data.Doc_Code == undefined) {
                ShowMsg('请选中编辑行');
                return;
            }
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {

                    if (data.AuditStat != undefined) {
                        ShowMsg("当前公文已提交，不能删除！");
                        return;
                    }
                    $.ajax({
                        type: 'post',
                        url: '/Doc/Delete/',
                        data: { id: data.Doc_Code, oper: 'del' },
                        success: function(result) {
                            if (result.result == 'success') {
                                $('#Doc_Infogrid').trigger('reloadGrid');
                            } else {
                                ShowMsg('删除失败');
                            }
                        }
                    });
                }
            });
        }

        //        function Doc_InfoToolBarDel() {
        //            var grid = $('#Doc_Infogrid');
        //            var curid = grid.getGridParam('selrow'); //获取选择行的id
        //            var data = grid.getRowData(curid); //获取行号为curid的数据            
        //            if (data.Doc_Code == undefined) {
        //                ShowMsg('请选中编辑行');
        //                return;
        //            }
        // ShowMsg('你确定要删除选中的数据吗?', function(yes) {
        //                    if (yes) {
        //                       $.ajax({
        //                        type: 'post',
        //                        url: '/Doc/Delete',
        //                        data: { id: {KeyCode},oper:'del'},
        //                        success: function(result) {                     
        //                            if(result=='success'){
        //                                $('#{GridID}').trigger('reloadGrid');
        //                            }else{
        //                                ShowMsg('删除失败');
        //                            }
        //                        }
        //                    });
        //                    }
        //                });
        //        }
        function Doc_InfoToolBarView() {
            var grid = $('#Doc_Infogrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid); //获取行号为curid的数据
            if (data.Doc_Code == undefined) {
                alert('请选中编辑行');
                return;
            }
            window.location = "/Doc/Show/" + data.Doc_Code + "?backUrl=/Doc/DraftList"
        }

        function Doc_InfoToolBarSearch() {

            Doc_Info_CList_DocInfo_GridControl.Search();
        }   
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
