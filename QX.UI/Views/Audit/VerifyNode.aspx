<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Verify_Nodes>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Templdate
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%=Html.GenToolbarNoPermissionHelper("Verify_NodesConfigModule", "Verify_Nodes", "")%>
    <%=Html.SysComm_JqGrid("Verify_NodesConfigModule", "Verify_Nodes", "/Audit/GetVerifyNodeList", true)%>
    <div id="auditUsers">
        <form id="DocInfo" method='post' action="/Audit/VerifyNodeOperation">
        <input type="hidden" id="formOper" value="add" name="formOper" />
        <%=Html.AutoBindForm<QX.Model.Verify_Nodes>("Verify_NodesConfigModule", "Verify_Nodes",Model,false,false,false)%>
        <div id="tabs">
            <ul>
                <li><a href="#tabs-1">人员列表</a></li>
            </ul>
            <div id="tabs-1">
                <%=Html.GenToolbarNoPermissionHelper("Verify_UsersModule", "Verify_Users", "")%>
                <%=Html.SysComm_JqGrid("Verify_UsersModule", "Verify_Users", "/Audit/GetVerifyUsers", true)%>
            </div>
        </div>
        </form>
    </div>

    <script type="text/javascript">
        //当前选中阶段
        var SelNode = { Code: '', Name: '' };

        $(document).ready(function() {

            $("#tabs").tabs();

            $("#auditUsers").dialog({
                minWidth: 800,
                minHeight: 300,
                autoOpen: false,
                buttons: { "确定": function() {
                    $("#DocInfo").submit();

                }
                }
            });

            var ooptions = {
                success: function(data) {

                    if (data.result = 'success') {
                        $("#auditUsers").dialog('close');
                        $("#Verify_Nodesgrid").trigger("reloadGrid");
                        ShowMsg(data.Msg);
                    }
                    else {
                        ShowMsg(data.Msg);
                    }

                },  // post-submit callback
                width: 800,
                dataType: 'json',
                timeout: 3000
            };

            $("#DocInfo").ajaxForm(ooptions);

            Common_EmpTree_DialogDept.Init("Verify_Users_add", function(code, name) {
                //人员回写
                $.ajax({
                    type: "post",
                    url: "/Audit/AddUser",
                    dataType: "json",
                    data: { code: code.join(','), name: name.join(','), Node: SelNode.Code },
                    success: function(re, textStatus) {
                        $("#Verify_Usersgrid").trigger("reloadGrid");
                    }
                });
            });

        });

        function Verify_UsersToolBarAdd() {
          
        }

        function Verify_UsersToolBarDel() {
            var grid = $("#Verify_Usersgrid");
            var arr = grid.getGridParam('selarrrow');

            if (arr.length == 0) {
                ShowMsg("请选择要删除的数据");
                return;
            }
            
            var selarr = new Array();
            for (var d in arr) {
                var t = grid.getRowData(arr[d]);
                selarr.push(t.VU_User);
            }
            
            
            //人员回写
            $.ajax({
                type: "post",
                url: "/Audit/DelUser",
                dataType: "json",
                data: { code: selarr.join(','), NodeCode: SelNode.Code },
                success: function(re, textStatus) {
                    $("#Verify_Usersgrid").trigger("reloadGrid");
                }
            });
        }

        function Verify_NodesToolBarAdd() {
            $('#DocInfo')[0].reset();
            $("#formOper").val('add');
            $.ajax({
                type: 'post',
                url: '/Sys_Config_ListPage/GetTableKeyCode',
                data: { oper: 'add', n: 'Verify_UsersModule' },
                success: function(result) {
                    SelNode.Code = result;
                    $('#DocInfo').find('#VerifyNode_Code').val(result);
                    $("#Verify_Usersgrid").setGridParam({ url: '/Audit/GetVerifyUsers/' + result }).trigger("reloadGrid");
                }
            });

            $("#auditUsers").dialog('open');
        }

        function Verify_NodesToolBarEdit() {
            $('#DocInfo')[0].reset();
            $("#formOper").val('edit');
            var grid = $("#Verify_Nodesgrid");
            var curid = grid.getGridParam('selrow');
            var data = grid.getRowData(curid);
        

            if (data.VerifyNode_Code != undefined) {
                SelNode.Code = data.VerifyNode_Code;
                for (var d in data) {
                    var $obj = $("#" + d)
                    if ($obj.length != 0) {
                        $obj.val(data[d]);
                    }
                }
                $("#Verify_Usersgrid").setGridParam({ url: '/Audit/GetVerifyUsers/' + data.VerifyNode_Code }).trigger("reloadGrid");
            }
            
            $("#auditUsers").dialog('open');
        }

    
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    <link href="/Content/css/jquery.multiselect.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/Shared/jquery.multiselect.min.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>
