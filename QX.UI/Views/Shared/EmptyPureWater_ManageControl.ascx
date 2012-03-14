<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="QX.HtmlHelperLib" %>
<%@ Import Namespace="QX.HtmlHelperLib.Widgets" %>
<script type="text/javascript">
    $(document).ready(function() {
        $("#WR_EmptyPosition").bind("click", function() {
            EmptyPureWater_ManageModuleEmptyPureWater_ManageOpenRefer('EmptyPureWater_ManageModule', 'EmptyPureWater_Manage', function(data) {
                $('#WaterRecipients_Record_Form').find('#WR_EmptyPosition').val(data.EPW_EmptyPosition);
            });
        });
    });
</script>
<%=Html.ReferControl("EmptyPureWater_ManageModule", "EmptyPureWater_Manage")%>  