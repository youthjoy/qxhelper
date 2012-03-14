<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<script type="text/javascript">
    $(document).ready(function() {
        $("#PCR_OldName").bind("click", function() {
            Plant_RecordModulePlant_RecordOpenRefer('Plant_RecordModule', 'Plant_Record', function(data) {
                $("#PCR_OldName").val(data.PR_Category);
                $("#PCR_Cost").val(data.PR_Amount);
            });
        });
        $("#PDR_PlantName").bind("click", function() {
            Plant_RecordModulePlant_RecordOpenRefer('Plant_RecordModule', 'Plant_Record', function(data) {
                $("#PDR_PlantName").val(data.PR_Category);
                $("#PDR_Amount").val(data.PR_Amount);
            });
        });
    });
</script>
<%=Html.ReferControl("Plant_RecordModule", "Plant_Record")%>    