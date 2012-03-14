<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<script type="text/javascript">
    $(document).ready(function() {
    $("#DL_DocumentCode").bind("click", function() {
            Document_ManageModuleDocument_ManageOpenRefer('Document_ManageModule', 'Document_Manage', function(data) {
                $("#DL_DocumentCode").val(data.DM_Code);
                $("#DL_DocumentName").val(data.DM_Name);
            });
        });
    });
</script>
<%=Html.ReferControl("Document_ManageModule", "Document_Manage")%>    