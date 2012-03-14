<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BasePage.Master" Inherits="System.Web.Mvc.ViewPage<QX.Model.Doc_Info>" %>

<%@ Import Namespace="QX.HtmlHelperLib" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="DocInfo" method='post' action="/Doc/DocOperation">
    <fieldset class="DocmentsWidth">
        <legend>公文维护</legend>
        <input type="hidden" id="formOper" value="edit" name="formOper" />
        <input type="hidden" id="optype" value="correct" name="optype" />
        <%=Html.AutoBindForm<QX.Model.Doc_Info>("CList_DocInfo", "Doc_Info",Model, false,false,false)%>
    </form>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">正文</a></li>
            <li><a href="#tabs-2">附件</a></li>
            <li><a href="#tabs-3">分发</a></li>
        </ul>
        <div id="tabs-1">
            <%Html.RenderPartial("FCKEditor", Model.Doc_Content); %>
        </div>
        <div id="tabs-2">
            <%if (Html.IsHavePermission("200600"))
              { %>
            <%Html.RenderPartial("AttachmentsControl", "uploadCallback", new ViewDataDictionary { new KeyValuePair<string, object>("UploadUrl", "/Doc/Upload/"), new KeyValuePair<string, object>("FileType", "Doc") }); %>
            <%} %>
            <%=Html.SysComm_JqGrid("Doc_AttachmentModule", "Doc_Attachment", "/Doc/GetAttachmentList/"+Model.Doc_Code+"-Doc_AttachmentModule", true)%>
        </div>
        <div id="tabs-3">
            <%=Html.GenToolbarHelper("Doc_AllotModule", "Doc_Allot", "addN:'分发',addFunJs:'Allot()'")%>
            <%=Html.SysComm_JqGrid("Doc_AllotModule", "Doc_Allot", "/Doc/GetAllot/"+Model.Doc_Code, true)%>
        </div>
    </div>
    <div class="FormToolBar">
        <input type='button' name='button' value='提交' onclick='Doc_Operation.CorrectData()' />
        <input type='button' name='cancle' value='返回' onclick='ComOperation.CancelEdit()' />
    </div>
    <%=Html.AutoBindValidate("CList_DocInfo", "DocInfo")%>
    </fieldset>

    <script type="text/javascript">

        function GetbackUrl() {
            var backUrl = '<%=ViewData["backUrl"]%>';
            return backUrl;
        }

        $(document).ready(function() {
            Doc_Operation.Init();
            $("#tabs").tabs();

            Common_EmpTree_DialogDept.Init("Doc_Allot_add", function(code, name) {
                //人员回写
                $.ajax({
                    type: "post",
                    url: "/Doc/DocAllot",
                    dataType: "json",
                    data: { code: code.join(','), name: name.join(','), doc: $("#Doc_Code").val(), module: 'CList_DocInfo' },
                    success: function(re, textStatus) {
                        //                $("#Doc_Attachmentgrid").trigger("reloadGrid");
                        $("#Doc_Allotgrid").trigger("reloadGrid");
                    }
                });
            });
        });


        function Doc_AllotAllot() {

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
                }
            });

        }

       
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderExtend" runat="server">
    <link href="/Content/css/jquery.multiselect.css" rel="stylesheet" type="text/css" />

    <script src="/Scripts/Shared/jquery.multiselect.min.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dict.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/ComOperation.js" type="text/javascript"></script>

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
