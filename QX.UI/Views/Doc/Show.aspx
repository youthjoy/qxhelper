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
        <input type="hidden" id="optype" value="nor" name="optype" />
        <%=Html.AutoBindForm<QX.Model.Doc_Info>("CList_DocInfo", "Doc_Info",Model, false,false,false)%>
    </form>
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">正文</a></li>
            <li><a href="#tabs-2">附件</a></li>
            <li><a href="#tabs-3">分发</a></li>
            <li><a href="#tabs-4">抄送</a></li>
        </ul>
        <div id="tabs-1">
            <%Html.RenderPartial("FCKEditor", Model.Doc_Content); %>
            
        </div>
        <div id="tabs-2">
            
            <%=Html.SysComm_JqGrid("Doc_AttachmentModule", "Doc_Attachment", "/Doc/GetAttachmentList/"+Model.Doc_Code+"-Doc_AttachmentModule", true)%>
        </div>
        <div id="tabs-3">
            <%=Html.GenToolbarHelper("Doc_AllotModule", "Doc_Allot", "addN:''")%>
            <%=Html.SysComm_JqGrid("Doc_AllotModule", "Doc_Allot", "/Doc/GetAllot/"+Model.Doc_Code, true)%>
        </div>
         <div id="tabs-4">
            <%=Html.GenToolbarHelper("Doc_AllotModule", "CCDoc_Allot", "")%>
            <%=Html.SysComm_JqGrid("Doc_AllotModule", "CCDoc_Allot", "/Doc/GetCC/"+Model.Doc_Code, true)%>
        </div>
    </div>
    <div class="FormToolBar">
        
        <input type='button' name='cancle' value='返回' onclick='ComOperation.CancelEdit()' />
    </div>
    
    </fieldset>

    <script type="text/javascript">

        function GetbackUrl() {
            var backUrl = '<%=ViewData["backUrl"]%>';
            return backUrl;
        }
    
        $(document).ready(function() {
            Doc_Operation.Init();
            $("#tabs").tabs();
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
 

    <script src="/Scripts/Shared/Dept.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="TopMenu" runat="server">
</asp:Content>
