<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Bse_Components>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Add
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="CompInfo" method='post' action="/Comp/CompOperation">
    <fieldset class="DocmentsWidth">
        <legend>零件图纸维护</legend>
        <input type="hidden" id="formOper" value="add" name="formOper" />
        <input type="hidden" id="optype" value="nor" name="optype" />
        <%=Html.AutoBindForm<QX.Model.Bse_Components>("Bse_ComponentsModule", "Bse_Components", Model, false, false, false)%>
    </form>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">备注</a></li>
            <li><a href="#tabs-2">附件</a></li>
            <li><a href="#tabs-3">授权</a></li>
            <%--<li><a href="#tabs-4">审核管理</a></li>--%>
        </ul>
        <div id="tabs-1">
            <%Html.RenderPartial("FCKEditor", ""); %>
        </div>
        <div id="tabs-2">
            <%if (Html.IsHavePermission("400600"))
              { %>
            <%Html.RenderPartial("AttachmentsControl", "uploadCallback", new ViewDataDictionary { new KeyValuePair<string, object>("UploadUrl", "/Doc/Upload/"), new KeyValuePair<string, object>("SetParamCallback", "setParameter"), new KeyValuePair<string, object>("CID", "Attach"), new KeyValuePair<string, object>("FileType", "Comp") }); %>
            <%} %>
            <%=Html.GenToolbarHelper("CompDoc_AttachmentModule", "Doc_Attachment", "delN:'删除附件',delFunJs:'Del()'")%>
            <%=Html.SysComm_JqGrid("CompDoc_AttachmentModule", "Doc_Attachment", "/Doc/GetAttachmentList/" + Model.Comp_Code + "-Bse_ComponentsModule", true)%>
        </div>
        <div id="tabs-3">
            <%=Html.GenToolbarHelper("CompDoc_AllotModule", "Doc_Allot", "addN:'查看授权',addFunJs:'Allot()',editN:'下载授权',editFunJs:'DownloadAllot()'")%>
            <%=Html.SysComm_JqGrid("CompDoc_AllotModule", "Doc_Allot", "/Doc/GetAllot/" + Model.Comp_Code, true)%>
        </div>
     <%--   <div id="tabs-4">
            <%Html.RenderPartial("AttachmentsControl", "uploadImgCallback", new ViewDataDictionary { new KeyValuePair<string, object>("UploadUrl", "/Comp/Upload/"), new KeyValuePair<string, object>("CID", "AuditImg"), new KeyValuePair<string, object>("FileType", "Comp") }); %>
            <%=Html.GenToolbarHelper("Bse_CompHistoryModule", "Bse_CompHistory", "addN:'打印',addFunJs:'Print()',delN:'删除附件',delFunJs:'Del()'")%>
            <%=Html.SysComm_JqGrid("Bse_CompHistoryModule", "Bse_CompHistory", "/Comp/GetCompHisList/" + Model.Comp_Code, true)%>
        </div>--%>
    </div>
    <div class="FormToolBar">
        <input type='button' name='button' value='草稿' onclick='Comp_Operation.SaveDraft()' />
        <input type='button' name='button' value='提交' onclick='Comp_Operation.SaveData()' />
        <input type='button' name='cancle' value='返回' onclick='ComOperation.CancelEdit()' />
    </div>
    <%=Html.AutoBindValidate("Bse_ComponentsModule", "CompInfo")%>
    </fieldset>
    <%=Html.ReferControl("Road_ComponentsModule", "Road_Components", false)%>
    <%=Html.ReferControlEx("Bse_GroupRefModule", "Bse_Group", false)%>
    
    <%=Html.ReferControl("CustomerModule", "Customer", false)%>

    <script type="text/javascript">

        function GetbackUrl() {
            var backUrl = '<%=ViewData["backUrl"]%>';
            return backUrl;
        }

        function Bse_GroupGroupEdit() {
            Win.Open('/Permission/Group');
        }
        
        //打印
        function Bse_CompHistoryPrint() {
            var grid = $('#Bse_CompHistorygrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            if (curid == undefined || curid == null) {
                return;
            }
            var data = grid.getRowData(curid);
            var pri = window.open(data.CH_FilePath);
            //var pri = window.open("test.html");
            pri.print();
            pri.close();
        }

        function Doc_AllotAllot() {

        }

        function setParameter(loader) {
            if ($("#Comp_Cate").val() == '' && $("#Comp_Type").val() != "CompType1") {
                alert("请选择工艺节点");
                return false;
            }
            loader.setParams({ typeParam: 'Comp', DictKey: "RoadNode", Cate: $("#Comp_Cate").val() });
            return true;
        }

        function Doc_AllotDownloadAllot() {

        }

        //删除图纸
        function Bse_CompHistoryDel() {
            var grid = $('#Bse_CompHistorygrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid);
            if (data.CH_Code == undefined) {
                ShowMsg("请选中要操作的数据!");
                return;
            }

            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    $.ajax({
                        type: 'post',
                        url: '/Doc/DeleteCompHis/',
                        data: { id: data.CH_Code, oper: 'del' },
                        success: function(result) {
                            if (result.result == 'success') {
                                $('#Bse_CompHistorygrid').trigger('reloadGrid');
                            } else {
                                ShowMsg('删除失败');
                            }
                        }
                    });
                }
            });
        }

        //附件删除
        function Doc_AttachmentDel() {
            var grid = $('#Doc_Attachmentgrid');
            var curid = grid.getGridParam('selrow'); //获取选择行的id
            var data = grid.getRowData(curid);
            if (data.Dat_Code == undefined) {
                ShowMsg("请选中要操作的数据!");
                return;
            }

            ShowMsg('你确定要删除选中的数据吗?', function(yes) {
                if (yes) {
                    $.ajax({
                        type: 'post',
                        url: '/Doc/AttachmentDelete/',
                        data: { id: data.Dat_Code, oper: 'del' },
                        success: function(result) {
                            if (result.result == 'success') {
                                $('#Doc_Attachmentgrid').trigger('reloadGrid');
                            } else {
                                ShowMsg('删除失败');
                            }
                        }
                    });
                }
            });
        }



        //附件上传
        function uploadCallback(id, fpath) {
            $.ajax({
                type: "post",
                url: "/Doc/UploadDocComp",
                dataType: "json",
                data: { code: $("#Comp_Code").val(), path: fpath, module: "Bse_ComponentsModule" },
                success: function(re, textStatus) {
                    //                $("#Doc_Attachmentgrid").trigger("reloadGrid");
                    $("#Doc_Attachmentgrid").setGridParam({ url: '/Doc/GetAttachmentList/' + $("#Comp_Code").val() + '-Bse_ComponentsModule' }).trigger("reloadGrid");
                }
            });
        }

        //审核使用图片上传
        function uploadImgCallback(id, fpath) {
            $.ajax({
                type: "post",
                url: "/Comp/UploadImg",
                dataType: "json",
                data: { code: $("#Comp_Code").val(), path: fpath, module: "Bse_ComponentsModule" },
                success: function(re, textStatus) {
                    if (re.result == 'fail') {
                        ShowMsg(re.Msg);
                    }
                    $("#Bse_CompHistorygrid").trigger("reloadGrid");
                }
            });
        }


        $(document).ready(function() {
            //零件图号参考
            $("#Comp_CCode").click(function() {
                Road_ComponentsModuleRoad_ComponentsOpenRefer(function(data) {
                    $("#Comp_CCode").val(data.Comp_Code);
                    $("#Comp_Name").val(data.Comp_Name);
                });
            });

            $("#Comp_CustomerName").click(function() {
                CustomerModuleCustomerOpenRefer(function(data) {
                    $("#Comp_Customer").val(data.Cust_Code);
                    $("#Comp_CustomerName").val(data.Cust_Name);
                });
            });


            //群组人员授权
            $("#Doc_Allot_add").click(function() {
                Bse_GroupRefModuleBse_GroupOpenRefer(function(data) {
                    $.ajax({
                        type: "post",
                        url: "/Doc/GroupAllot",
                        dataType: "json",
                        data: { code: $("#Comp_Code").val(), group: data.GP_Code, module: "Bse_GroupModule" },
                        success: function(re, textStatus) {
                            //                $("#Doc_Attachmentgrid").trigger("reloadGrid");
                            $("#Doc_Allotgrid").trigger("reloadGrid");
                        }
                    });
                });
            });


            //群组人员授权
            $("#Doc_Allot_edit").click(function() {
                Bse_GroupRefModuleBse_GroupOpenRefer(function(data) {
                    $.ajax({
                        type: "post",
                        url: "/Doc/GroupDownloadAllot",
                        dataType: "json",
                        data: { code: $("#Comp_Code").val(), group: data.GP_Code, module: "Bse_GroupModule" },
                        success: function(re, textStatus) {
                            //                $("#Doc_Attachmentgrid").trigger("reloadGrid");
                            $("#Doc_Allotgrid").trigger("reloadGrid");
                        }
                    });
                });
            });
            //人员分发
            //            Common_EmpTree_DialogDept.Init("Doc_Allot_add", function(code, name) {
            //                //人员回写
            //                $.ajax({
            //                    type: "post",
            //                    url: "/Doc/DocAllot",
            //                    dataType: "json",
            //                    data: { code: code.join(','), name: name.join(','), doc: $("#Comp_Code").val(), module: "Bse_ComponentsModule" },
            //                    success: function(re, textStatus) {
            //                        //                $("#Doc_Attachmentgrid").trigger("reloadGrid");
            //                        $("#Doc_Allotgrid").trigger("reloadGrid");
            //                    }
            //                });
            //            });


            Comp_Operation.Init();
            $("#tabs").tabs();

            //$("#Doc_Allotgrid").setGridParam({ url: '/Doc/GetAllot/' + $("#Doc_Code").val() }).trigger("reloadGrid");

            // Doc_Allot_Doc_AllotModule_GridControl.Init('/Doc/GetAllot/'+$("#Doc_Code").val(),"Doc_Allot");
        });
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    <link href="/Content/css/jquery.multiselect.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/Shared/jquery.multiselect.min.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>
    <script src="/Scripts/Shared/Dict_ERP.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Group.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
