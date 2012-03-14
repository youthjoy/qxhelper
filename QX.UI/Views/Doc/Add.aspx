<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Doc_Info>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Add
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="DocInfo" method='post' action="/Doc/DocOperation">
    <fieldset class="DocmentsWidth">
        <legend>公文维护</legend>
        <input type="hidden" id="formOper" value="add" name="formOper" />
        <input type="hidden" id="optype" value="nor" name="optype" />
        <%=Html.AutoBindForm<QX.Model.Doc_Info>("CList_DocInfo", "Doc_Info",Model,false,false,false)%>
    </form>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">正文</a></li>
            <li><a href="#tabs-2">附件</a></li>
            <li><a href="#tabs-3">分发</a></li>
            <li><a href="#tabs-4">抄送</a></li>
        </ul>
        <div id="tabs-1">
            <%Html.RenderPartial("FCKEditor", ""); %>
        </div>
        <div id="tabs-2">
            <%if(Html.IsHavePermission("200600")){ %>
               <%Html.RenderPartial("AttachmentsControl", "uploadCallback", new ViewDataDictionary { new KeyValuePair<string, object>("UploadUrl", "/Doc/Upload/"), new KeyValuePair<string, object>("SetParamCallback", "setParameter"), new KeyValuePair<string, object>("FileType", "Doc") }); %>
            <%} %>
            <%=Html.GenToolbarHelper("Doc_AttachmentModule", "Doc_Attachment", "delN:'删除附件',delFunJs:'Del()'")%>
            <%=Html.SysComm_JqGrid("Doc_AttachmentModule", "Doc_Attachment", "/Doc/GetAttachmentList/"+Model.Doc_Code+"-Doc_AttachmentModule", true)%>
        </div>
        <div id="tabs-3">
            <%=Html.GenToolbarHelper("Doc_AllotModule", "Doc_Allot", "addN:'分发',addFunJs:'Allot()',delN:'删除',delFunJs:'Del()'")%>
            <%=Html.SysComm_JqGrid("Doc_AllotModule", "Doc_Allot", "/Doc/GetAllot/"+Model.Doc_Code, true)%>
        </div>
         <div id="tabs-4">
            <%=Html.GenToolbarHelper("Doc_AllotModule", "CCDoc_Allot", "addN:'抄送',addFunJs:'Allot()',delN:'删除',delFunJs:'Del()'")%>
            <%=Html.SysComm_JqGrid("Doc_AllotModule", "CCDoc_Allot", "/Doc/GetCC/"+Model.Doc_Code, true)%>
        </div>
    </div>
    <div class="FormToolBar">
        <input type='button' name='button' value='草稿' onclick='Doc_Operation.SaveDraft()' />
        <input type='button' name='button' value='提交' onclick='Doc_Operation.SaveData()' />
        <input type='button' name='cancle' value='返回' onclick='ComOperation.CancelEdit()' />
    </div>
    <%=Html.AutoBindValidate("CList_DocInfo", "DocInfo")%>
    </fieldset>

<%=Html.ReferControlEx("Bse_GroupRefModule", "Bse_Group", false)%>
  
    <script type="text/javascript">
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


        function setParameter(loader) {
            if ($("#Doc_Cate").val() == undefined) {
                alert("请选择公文类目");
                return false;
            }
            loader.setParams({ DictKey: "DocCate", Cate: $("#Doc_Cate").val() });
            return true;
        }

        function GetbackUrl() {
            var backUrl = '<%=ViewData["backUrl"]%>';
            return backUrl;
        }

        function Doc_AllotAllot() {
           
        }

        function CCDoc_AllotAllot() {

        }

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
                        url: '/Doc/AllotDelete/',
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


        //抄送
        function Doc_AllotDel() {
            var grid = $('#CCDoc_Allotgrid');
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
                        url: '/Doc/AllotDelete/',
                        data: { id: data.DA_Code, oper: 'del' },
                        success: function(result) {
                            if (result.result == 'success') {
                                $('#CCDoc_Allotgrid').trigger('reloadGrid');
                            } else {
                                ShowMsg('删除失败');
                            }
                        }
                    });
                }
            });

        }

        function uploadCallback(id, fpath) {

            $.ajax({
                type: "post",
                url: "/Doc/UploadDoc",
                dataType: "json",
                data: { code: $("#Doc_Code").val(), path: fpath, module: "Doc_AttachmentModule" },
                success: function(re, textStatus) {
                    //                $("#Doc_Attachmentgrid").trigger("reloadGrid");
                    $("#Doc_Attachmentgrid").setGridParam({ url: '/Doc/GetAttachmentList/' + $("#Doc_Code").val() + '-Doc_AttachmentModule' }).trigger("reloadGrid");
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
                }
            });

        }

        $(document).ready(function() {
        //群组人员授权
        $("#Doc_Allot_add").click(function() {
            Bse_GroupRefModuleBse_GroupOpenRefer(function(data) {
                $.ajax({
                    type: "post",
                    url: "/Doc/GroupAllot",
                    dataType: "json",
                    data: { code: $("#Doc_Code").val(), group: data.GP_Code, module: "Bse_GroupModule" },
                    success: function(re, textStatus) {
                        //                $("#Doc_Attachmentgrid").trigger("reloadGrid");
                        $("#Doc_Allotgrid").trigger("reloadGrid");
                    }
                });
            });
        });

            //            $("#example").multiselect({
            //                checkAllText: "全选",
            //                unCheckAllText: "不选",
            //                selectedList: 100 // 0-based index
            //            });

//            Common_EmpTree_DialogDept.Init("Doc_Allot_add", function(code, name) {
//                //人员回写
//                $.ajax({
//                    type: "post",
//                    url: "/Doc/DocAllot",
//                    dataType: "json",
//                    data: { code: code.join(','), name: name.join(','), doc: $("#Doc_Code").val(), module: 'CList_DocInfo' },
//                    success: function(re, textStatus) {
//                        $("#Doc_Allotgrid").trigger("reloadGrid");
//                    }
//                });
//            });


            Common_EmpTree_DialogDept.Init("CCDoc_Allot_add", function(code, name) {
                //人员回写
                $.ajax({
                    type: "post",
                    url: "/Doc/DocCC",
                    dataType: "json",
                    data: { code: code.join(','), name: name.join(','), doc: $("#Doc_Code").val(), module: 'CList_DocInfo' },
                    success: function(re, textStatus) {
                        $("#CCDoc_Allotgrid").trigger("reloadGrid");
                    }
                });
            });
            
            Doc_Operation.Init();
            $("#tabs").tabs();

            //$("#Doc_Allotgrid").setGridParam({ url: '/Doc/GetAllot/' + $("#Doc_Code").val() }).trigger("reloadGrid");

            // Doc_Allot_Doc_AllotModule_GridControl.Init('/Doc/GetAllot/'+$("#Doc_Code").val(),"Doc_Allot");
        });
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
