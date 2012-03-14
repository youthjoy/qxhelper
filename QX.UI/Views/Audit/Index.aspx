<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    审核配置页面
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <div class="left_tree" width="200px">
                    <%= Html.TreeView<QX.Model.Audit_Template>(
                        "configlist",
                        ViewData["DictList"] as IEnumerable<QX.Model.Audit_Template>,
                        d => d.ChildrenNode,
                        d => "<a id='"+d.Template_Key+"'>" + d.Template_Name + "</a>")%>
                </div>
            </td>
            <td valign="top" style="width: 80%">
                <%=Html.GenToolbarHelper("Verify_TemplateConfigModule", "Verify_TemplateConfig", "addN:'添加阶段',addFunJs:'Add()',editN:'审核阶段维护',editFunJs:'Edit()',delN:'删除阶段',delFunJs:'Del()'")%>
                <%=Html.SysComm_JqGrid("Verify_TemplateConfigModule", "Verify_TemplateConfig", "/Audit/GetTemplateConfigList", true)%>
            </td>
        </tr>
    </table>
    <div id="NodeSel">
        <%=Html.GenToolbarNoPermissionHelper("Verify_NodesModule", "Verify_Nodes", "addN:'添加阶段',addFunJs:'Confirm()'")%>
        <%=Html.SysComm_JqGrid("Verify_NodesModule", "Verify_Nodes", "/Audit/GetVerifyNodeList", true)%>
    </div>

    <script type="text/javascript">
        var CurSelTreeNode = {
            Code: '',
            Name: ''
        }

        $(document).ready(function() {
            $("#NodeSel").dialog({ minWidth: 500, autoOpen: false });
            //数据控件事件绑定
            $("#configlist").bind('click.jstree', function(event) {
                var eventNodeName = event.target.nodeName;

                if (eventNodeName == 'INS') {
                    return;
                } else if (eventNodeName == 'A') {
                    var $subject = $(event.target);
                    var deptcode = $subject.attr("id");

                    CurSelTreeNode.Code = deptcode;

                    //读取数据的方法
                    $("#Verify_TemplateConfiggrid").setGridParam({ url: '/Audit/GetTemplateConfigList/' + deptcode }).trigger("reloadGrid");
                }
            });
        });

        function Verify_TemplateConfigEdit() {
            window.location = "/Audit/VerifyNode";
        }

        //确定添加阶段
        function Verify_NodesConfirm() {
            var grid = $("#Verify_Nodesgrid");
            var arr = grid.getGridParam('selarrrow');
            var selarr = new Array();
            for (var d in arr) {
                var data = grid.getRowData(arr[d]);
                selarr.push(data.VerifyNode_Code);
            }

            $.ajax({
                type: "post",
                dataType: 'json',
                data: { data: selarr.join(','), module: CurSelTreeNode.Code },
                url: "/Audit/ConfirmSel",
                success: function(re, textStatus) {
                    if (re.result == "success") {
                        $("#NodeSel").dialog('close');
                        $("#Verify_TemplateConfiggrid").setGridParam({ url: '/Audit/GetTemplateConfigList/' + CurSelTreeNode.Code }).trigger("reloadGrid");
                    }
                }
            });

        }


        function Verify_TemplateConfigAdd() {
            if (CurSelTreeNode.Code != '') {
                $("#NodeSel").dialog('open');
            }
            else {
                ShowMsg("请选择您要编辑的审核模板!");
            }
        }

        function Verify_TemplateConfigDel() {
            var grid = $("#Verify_TemplateConfiggrid");
            var arr = grid.getGridParam('selarrrow');
            if (arr.length == 0) {
                ShowMsg("请选中要删除的数据!");
                return;
            }
            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    var selarr = new Array();
                    for (var d in arr) {
                        var data = grid.getRowData(arr[d]);
                        selarr.push(data.VT_Template_Code);
                    }

                    $.ajax({
                        type: "post",
                        dataType: 'json',
                        data: { data: selarr.join(','), module: CurSelTreeNode.Code },
                        url: "/Audit/DelConfig",
                        success: function(re, textStatus) {
                            if (re.result == "success") {
                                $("#Verify_TemplateConfiggrid").setGridParam({ url: '/Audit/GetTemplateConfigList/' + CurSelTreeNode.Code }).trigger("reloadGrid");
                            }
                        }
                    });

                }
            }); //end
        }

        function Verify_TemplateConfigToolBarSearch() {

            Verify_TemplateConfig_Verify_TemplateConfigModule_GridControl.Search();
        }   

        
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
